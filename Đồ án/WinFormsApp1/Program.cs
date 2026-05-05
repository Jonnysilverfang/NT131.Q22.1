using System.Security.Cryptography;

using DoAnCryptoWeb;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseUrls("http://0.0.0.0:5000");

WebApplication app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

app.MapGet("/api/health", () => Results.Ok(new { status = "ok", app = "DoAnCryptoWeb" }));

app.MapPost("/api/playfair/encrypt", (PlayfairRequest request) =>
    RunCryptoAction(() => new CryptoResponse(
        CryptoService.PlayfairEncrypt(request.Text, request.Key),
        "PlayFair: đã mã hóa xong. Chỉ xử lý chữ A-Z, bỏ qua số và ký tự đặc biệt.")));

app.MapPost("/api/playfair/decrypt", (PlayfairRequest request) =>
    RunCryptoAction(() => new CryptoResponse(
        CryptoService.PlayfairDecrypt(request.Text, request.Key),
        "PlayFair: đã giải mã xong. Kết quả trả về là bản rõ đã chuẩn hóa theo PlayFair.")));

app.MapPost("/api/rsa/generate", (RsaKeyRequest request) =>
    RunCryptoAction(() =>
    {
        int keySize = request.KeySize is 1024 or 2048 or 3072 or 4096 ? request.KeySize : 2048;
        using RSA rsa = RSA.Create(keySize);

        return new RsaKeyResponse(
            rsa.ExportRSAPublicKeyPem(),
            rsa.ExportRSAPrivateKeyPem(),
            $"RSA: đã tạo cặp khóa {keySize}-bit.");
    }));

app.MapPost("/api/rsa/encrypt", (RsaCryptoRequest request) =>
    RunCryptoAction(() => new CryptoResponse(
        CryptoService.RsaEncrypt(request.Text, request.PublicKey),
        "RSA: đã mã hóa xong bằng khóa công khai.")));

app.MapPost("/api/rsa/decrypt", (RsaCryptoRequest request) =>
    RunCryptoAction(() => new CryptoResponse(
        CryptoService.RsaDecrypt(request.Text, request.PrivateKey),
        "RSA: đã giải mã xong bằng khóa bí mật.")));

app.Run();

static IResult RunCryptoAction<T>(Func<T> action)
{
    try
    {
        return Results.Ok(action());
    }
    catch (Exception ex) when (ex is InvalidOperationException or ArgumentException or FormatException or CryptographicException)
    {
        return Results.BadRequest(new ErrorResponse(ex.Message));
    }
}

internal sealed record PlayfairRequest(string Text, string Key);
internal sealed record RsaKeyRequest(int KeySize = 2048);
internal sealed record RsaCryptoRequest(string Text, string PublicKey = "", string PrivateKey = "");
internal sealed record CryptoResponse(string Result, string Message);
internal sealed record RsaKeyResponse(string PublicKey, string PrivateKey, string Message);
internal sealed record ErrorResponse(string Error);
