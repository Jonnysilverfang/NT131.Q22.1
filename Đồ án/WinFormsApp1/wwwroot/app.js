const $ = (id) => document.getElementById(id);

const infoContent = {
  playfair: {
    title: "Nguyên lý hoạt động PlayFair",
    body: `1. Khóa được chuẩn hóa để tạo ma trận 5x5.

2. Thuật toán chỉ xử lý chữ cái A-Z và gộp J thành I.

3. Văn bản được tách thành từng cặp ký tự. Nếu hai ký tự trong cùng một cặp bị trùng, hệ thống sẽ chèn ký tự đệm.

4. Quy tắc mã hóa:
- Cùng hàng: dịch sang phải.
- Cùng cột: dịch xuống dưới.
- Khác hàng, khác cột: lấy hai góc còn lại của hình chữ nhật.

5. Giải mã là quá trình ngược lại và kết quả trả về là bản rõ đã chuẩn hóa.`
  },
  rsa: {
    title: "Nguyên lý hoạt động RSA",
    body: `1. RSA là hệ mã hóa bất đối xứng, dùng một cặp khóa:
- Khóa công khai để mã hóa.
- Khóa bí mật để giải mã.

2. Ứng dụng hỗ trợ tạo khóa theo nhiều độ dài khác nhau.

3. Luồng mã hóa:
- Nhập bản rõ.
- Dùng khóa công khai PEM.
- Kết quả được xuất ra dạng Base64.

4. Luồng giải mã:
- Nhập chuỗi Base64 đã mã hóa.
- Dùng khóa bí mật PEM tương ứng để giải mã.
- Hệ thống trả về nội dung gốc.

5. Ứng dụng đang sử dụng OAEP SHA-256 để tăng độ an toàn.`
  }
};

async function postJson(url, payload) {
  const response = await fetch(url, {
    method: "POST",
    headers: { "Content-Type": "application/json" },
    body: JSON.stringify(payload)
  });

  const data = await response.json();
  if (!response.ok) {
    throw new Error(data.error || "Có lỗi xảy ra khi xử lý yêu cầu.");
  }

  return data;
}

function setStatus(id, message, isError = false) {
  const element = $(id);
  element.textContent = message;
  element.classList.toggle("error", isError);
  element.classList.toggle("ok", !isError);
}

function clearFields(ids) {
  ids.forEach((id) => {
    const element = $(id);
    if (element) {
      element.value = "";
    }
  });
}

function setActiveTab(target) {
  document.querySelectorAll(".tab").forEach((tab) => {
    tab.classList.toggle("active", tab.dataset.target === target);
  });

  document.querySelectorAll(".lab-link").forEach((link) => {
    link.classList.toggle("active", link.dataset.target === target);
  });

  document.querySelectorAll(".panel").forEach((panel) => {
    panel.classList.toggle("active", panel.id === target);
  });

  const panel = $(target);
  if (panel) {
    panel.scrollIntoView({ behavior: "smooth", block: "start" });
  }
}

document.querySelectorAll(".tab, .lab-link, [data-tab-shortcut]").forEach((button) => {
  button.addEventListener("click", () => setActiveTab(button.dataset.target));
});

document.querySelectorAll("[data-info]").forEach((button) => {
  button.addEventListener("click", () => {
    const content = infoContent[button.dataset.info];
    if (!content) {
      return;
    }

    $("dialogTitle").textContent = content.title;
    $("dialogBody").textContent = content.body;
    $("infoDialog").showModal();
  });
});

$("dialogClose").addEventListener("click", () => $("infoDialog").close());

$("infoDialog").addEventListener("click", (event) => {
  if (event.target === $("infoDialog")) {
    $("infoDialog").close();
  }
});

$("playfairEncrypt").addEventListener("click", async () => {
  try {
    const data = await postJson("/api/playfair/encrypt", {
      text: $("playfairPlain").value,
      key: $("playfairKey").value
    });
    $("playfairCipherOut").value = data.result;
    setStatus("playfairStatus", data.message);
  } catch (error) {
    setStatus("playfairStatus", `Mã hóa PlayFair thất bại. ${error.message}`, true);
  }
});

$("playfairDecrypt").addEventListener("click", async () => {
  try {
    const data = await postJson("/api/playfair/decrypt", {
      text: $("playfairCipherIn").value,
      key: $("playfairKey").value
    });
    $("playfairPlainOut").value = data.result;
    setStatus("playfairStatus", data.message);
  } catch (error) {
    setStatus("playfairStatus", `Giải mã PlayFair thất bại. ${error.message}`, true);
  }
});

$("playfairMove").addEventListener("click", () => {
  $("playfairCipherIn").value = $("playfairCipherOut").value;
  setStatus("playfairStatus", "PlayFair: đã chuyển bản mã sang khu vực giải mã.");
});

$("playfairClear").addEventListener("click", () => {
  clearFields(["playfairKey", "playfairPlain", "playfairCipherOut", "playfairCipherIn", "playfairPlainOut"]);
  setStatus("playfairStatus", "PlayFair: sẵn sàng xử lý.");
});

$("rsaGenerate").addEventListener("click", async () => {
  try {
    const data = await postJson("/api/rsa/generate", {
      keySize: Number.parseInt($("rsaKeySize").value, 10)
    });
    $("rsaPublicKey").value = data.publicKey;
    $("rsaPrivateKey").value = data.privateKey;
    setStatus("rsaStatus", data.message);
  } catch (error) {
    setStatus("rsaStatus", `Không thể tạo khóa RSA. ${error.message}`, true);
  }
});

$("rsaEncrypt").addEventListener("click", async () => {
  try {
    const data = await postJson("/api/rsa/encrypt", {
      text: $("rsaPlain").value,
      publicKey: $("rsaPublicKey").value
    });
    $("rsaCipherOut").value = data.result;
    setStatus("rsaStatus", data.message);
  } catch (error) {
    setStatus("rsaStatus", `Mã hóa RSA thất bại. ${error.message}`, true);
  }
});

$("rsaDecrypt").addEventListener("click", async () => {
  try {
    const data = await postJson("/api/rsa/decrypt", {
      text: $("rsaCipherIn").value,
      privateKey: $("rsaPrivateKey").value
    });
    $("rsaPlainOut").value = data.result;
    setStatus("rsaStatus", data.message);
  } catch (error) {
    setStatus("rsaStatus", `Giải mã RSA thất bại. ${error.message}`, true);
  }
});

$("rsaMove").addEventListener("click", () => {
  $("rsaCipherIn").value = $("rsaCipherOut").value;
  setStatus("rsaStatus", "RSA: đã chuyển bản mã sang khu vực giải mã.");
});

$("rsaClear").addEventListener("click", () => {
  clearFields(["rsaPublicKey", "rsaPrivateKey", "rsaPlain", "rsaCipherOut", "rsaCipherIn", "rsaPlainOut"]);
  setStatus("rsaStatus", "RSA: sẵn sàng tạo khóa và xử lý.");
});
