namespace WinFormsApp1;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;
    private Label lblHeader;
    private Label lblSubHeader;
    private TabControl tabMain;
    private TabPage tabPlayfair;
    private TabPage tabRsa;
    private Panel panelPlayfairHero;
    private Label lblPlayfairTitle;
    private Label lblPlayfairDesc;
    private Button btnPlayfairInfo;
    private Label lblPlayfairKey;
    private TextBox txtPlayfairKey;
    private Label lblPlayfairKeyHint;
    private Panel panelPlayfairEncrypt;
    private Label lblPlayfairEncryptTitle;
    private Label lblPlayfairEncryptHint;
    private Label lblPlayfairEncryptInput;
    private TextBox txtPlayfairEncryptInput;
    private Label lblPlayfairEncryptOutput;
    private TextBox txtPlayfairEncryptOutput;
    private Button btnPlayfairEncrypt;
    private Button btnPlayfairMoveToDecrypt;
    private Panel panelPlayfairDecrypt;
    private Label lblPlayfairDecryptTitle;
    private Label lblPlayfairDecryptHint;
    private Label lblPlayfairDecryptInput;
    private TextBox txtPlayfairDecryptInput;
    private Label lblPlayfairDecryptOutput;
    private TextBox txtPlayfairDecryptOutput;
    private Button btnPlayfairDecrypt;
    private Button btnPlayfairClear;
    private Label lblPlayfairStatus;
    private Panel panelRsaHero;
    private Label lblRsaTitle;
    private Label lblRsaDesc;
    private Button btnRsaInfo;
    private Panel panelRsaKeys;
    private Label lblRsaKeyPanelTitle;
    private Label lblRsaKeyPanelHint;
    private Label lblRsaKeySize;
    private ComboBox cboRsaKeySize;
    private Button btnRsaGenerateKeys;
    private Label lblRsaPublicKey;
    private TextBox txtRsaPublicKey;
    private Label lblRsaPrivateKey;
    private TextBox txtRsaPrivateKey;
    private Panel panelRsaEncrypt;
    private Label lblRsaEncryptTitle;
    private Label lblRsaEncryptHint;
    private Label lblRsaEncryptInput;
    private TextBox txtRsaEncryptInput;
    private Label lblRsaEncryptOutput;
    private TextBox txtRsaEncryptOutput;
    private Button btnRsaEncrypt;
    private Button btnRsaMoveToDecrypt;
    private Panel panelRsaDecrypt;
    private Label lblRsaDecryptTitle;
    private Label lblRsaDecryptHint;
    private Label lblRsaDecryptInput;
    private TextBox txtRsaDecryptInput;
    private Label lblRsaDecryptOutput;
    private TextBox txtRsaDecryptOutput;
    private Button btnRsaDecrypt;
    private Button btnRsaClear;
    private Label lblRsaStatus;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblHeader = new Label();
        lblSubHeader = new Label();
        tabMain = new TabControl();
        tabPlayfair = new TabPage();
        lblPlayfairStatus = new Label();
        btnPlayfairClear = new Button();
        panelPlayfairDecrypt = new Panel();
        btnPlayfairDecrypt = new Button();
        txtPlayfairDecryptOutput = new TextBox();
        lblPlayfairDecryptOutput = new Label();
        txtPlayfairDecryptInput = new TextBox();
        lblPlayfairDecryptInput = new Label();
        lblPlayfairDecryptHint = new Label();
        lblPlayfairDecryptTitle = new Label();
        panelPlayfairEncrypt = new Panel();
        btnPlayfairMoveToDecrypt = new Button();
        btnPlayfairEncrypt = new Button();
        txtPlayfairEncryptOutput = new TextBox();
        lblPlayfairEncryptOutput = new Label();
        txtPlayfairEncryptInput = new TextBox();
        lblPlayfairEncryptInput = new Label();
        lblPlayfairEncryptHint = new Label();
        lblPlayfairEncryptTitle = new Label();
        lblPlayfairKeyHint = new Label();
        txtPlayfairKey = new TextBox();
        lblPlayfairKey = new Label();
        panelPlayfairHero = new Panel();
        lblPlayfairDesc = new Label();
        lblPlayfairTitle = new Label();
        btnPlayfairInfo = new Button();
        tabRsa = new TabPage();
        lblRsaStatus = new Label();
        btnRsaClear = new Button();
        panelRsaDecrypt = new Panel();
        btnRsaDecrypt = new Button();
        txtRsaDecryptOutput = new TextBox();
        lblRsaDecryptOutput = new Label();
        txtRsaDecryptInput = new TextBox();
        lblRsaDecryptInput = new Label();
        lblRsaDecryptHint = new Label();
        lblRsaDecryptTitle = new Label();
        panelRsaEncrypt = new Panel();
        btnRsaMoveToDecrypt = new Button();
        btnRsaEncrypt = new Button();
        txtRsaEncryptOutput = new TextBox();
        lblRsaEncryptOutput = new Label();
        txtRsaEncryptInput = new TextBox();
        lblRsaEncryptInput = new Label();
        lblRsaEncryptHint = new Label();
        lblRsaEncryptTitle = new Label();
        panelRsaKeys = new Panel();
        txtRsaPrivateKey = new TextBox();
        lblRsaPrivateKey = new Label();
        txtRsaPublicKey = new TextBox();
        lblRsaPublicKey = new Label();
        btnRsaGenerateKeys = new Button();
        cboRsaKeySize = new ComboBox();
        lblRsaKeySize = new Label();
        lblRsaKeyPanelHint = new Label();
        lblRsaKeyPanelTitle = new Label();
        panelRsaHero = new Panel();
        lblRsaDesc = new Label();
        lblRsaTitle = new Label();
        btnRsaInfo = new Button();
        tabMain.SuspendLayout();
        tabPlayfair.SuspendLayout();
        panelPlayfairDecrypt.SuspendLayout();
        panelPlayfairEncrypt.SuspendLayout();
        panelPlayfairHero.SuspendLayout();
        tabRsa.SuspendLayout();
        panelRsaDecrypt.SuspendLayout();
        panelRsaEncrypt.SuspendLayout();
        panelRsaKeys.SuspendLayout();
        panelRsaHero.SuspendLayout();
        SuspendLayout();
        // 
        // lblHeader
        // 
        lblHeader.AutoSize = true;
        lblHeader.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold);
        lblHeader.ForeColor = Color.FromArgb(29, 37, 68);
        lblHeader.Location = new Point(24, 18);
        lblHeader.Name = "lblHeader";
        lblHeader.Size = new Size(471, 50);
        lblHeader.TabIndex = 0;
        lblHeader.Text = "Ứng dụng Mã hóa WinForms";
        // 
        // lblSubHeader
        // 
        lblSubHeader.AutoSize = true;
        lblSubHeader.Font = new Font("Segoe UI", 10.8F);
        lblSubHeader.ForeColor = Color.FromArgb(96, 105, 132);
        lblSubHeader.Location = new Point(24, 67);
        lblSubHeader.Name = "lblSubHeader";
        lblSubHeader.Size = new Size(754, 25);
        lblSubHeader.TabIndex = 1;
        lblSubHeader.Text = "Tách biệt rõ khóa, dữ liệu đầu vào và kết quả đầu ra để tránh nhầm lẫn giữa mã hóa và giải mã.";
        lblSubHeader.Visible = false;
        // 
        // tabMain
        // 
        tabMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        tabMain.Controls.Add(tabPlayfair);
        tabMain.Controls.Add(tabRsa);
        tabMain.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
        tabMain.ItemSize = new Size(150, 36);
        tabMain.Location = new Point(24, 80);
        tabMain.Name = "tabMain";
        tabMain.Padding = new Point(18, 8);
        tabMain.SelectedIndex = 0;
        tabMain.Size = new Size(1336, 750);
        tabMain.SizeMode = TabSizeMode.Fixed;
        tabMain.TabIndex = 2;
        // 
        // tabPlayfair
        // 
        tabPlayfair.AutoScroll = true;
        tabPlayfair.BackColor = Color.FromArgb(246, 248, 252);
        tabPlayfair.Controls.Add(lblPlayfairStatus);
        tabPlayfair.Controls.Add(btnPlayfairClear);
        tabPlayfair.Controls.Add(panelPlayfairDecrypt);
        tabPlayfair.Controls.Add(panelPlayfairEncrypt);
        tabPlayfair.Controls.Add(lblPlayfairKeyHint);
        tabPlayfair.Controls.Add(txtPlayfairKey);
        tabPlayfair.Controls.Add(lblPlayfairKey);
        tabPlayfair.Controls.Add(panelPlayfairHero);
        tabPlayfair.Location = new Point(4, 40);
        tabPlayfair.Name = "tabPlayfair";
        tabPlayfair.Padding = new Padding(16);
        tabPlayfair.Size = new Size(1328, 676);
        tabPlayfair.TabIndex = 0;
        tabPlayfair.Text = "PlayFair";
        // 
        // lblPlayfairStatus
        // 
        lblPlayfairStatus.AutoSize = true;
        lblPlayfairStatus.Font = new Font("Segoe UI", 10.2F);
        lblPlayfairStatus.ForeColor = Color.FromArgb(82, 90, 114);
        lblPlayfairStatus.Location = new Point(36, 608);
        lblPlayfairStatus.Name = "lblPlayfairStatus";
        lblPlayfairStatus.Size = new Size(163, 23);
        lblPlayfairStatus.TabIndex = 7;
        lblPlayfairStatus.Text = "PlayFair: sẵn sàng xử lý.";
        // 
        // btnPlayfairClear
        // 
        btnPlayfairClear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnPlayfairClear.BackColor = Color.White;
        btnPlayfairClear.FlatAppearance.BorderColor = Color.FromArgb(209, 215, 228);
        btnPlayfairClear.FlatStyle = FlatStyle.Flat;
        btnPlayfairClear.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        btnPlayfairClear.Location = new Point(1140, 597);
        btnPlayfairClear.Name = "btnPlayfairClear";
        btnPlayfairClear.Size = new Size(152, 38);
        btnPlayfairClear.TabIndex = 6;
        btnPlayfairClear.Text = "Xóa toàn bộ";
        btnPlayfairClear.UseVisualStyleBackColor = false;
        btnPlayfairClear.Click += btnPlayfairClear_Click;
        // 
        // panelPlayfairDecrypt
        // 
        panelPlayfairDecrypt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        panelPlayfairDecrypt.BackColor = Color.White;
        panelPlayfairDecrypt.BorderStyle = BorderStyle.FixedSingle;
        panelPlayfairDecrypt.Controls.Add(btnPlayfairDecrypt);
        panelPlayfairDecrypt.Controls.Add(txtPlayfairDecryptOutput);
        panelPlayfairDecrypt.Controls.Add(lblPlayfairDecryptOutput);
        panelPlayfairDecrypt.Controls.Add(txtPlayfairDecryptInput);
        panelPlayfairDecrypt.Controls.Add(lblPlayfairDecryptInput);
        panelPlayfairDecrypt.Controls.Add(lblPlayfairDecryptHint);
        panelPlayfairDecrypt.Controls.Add(lblPlayfairDecryptTitle);
        panelPlayfairDecrypt.Location = new Point(664, 202);
        panelPlayfairDecrypt.Name = "panelPlayfairDecrypt";
        panelPlayfairDecrypt.Size = new Size(628, 330);
        panelPlayfairDecrypt.TabIndex = 5;
        // 
        // btnPlayfairDecrypt
        // 
        btnPlayfairDecrypt.BackColor = Color.FromArgb(18, 103, 96);
        btnPlayfairDecrypt.FlatAppearance.BorderSize = 0;
        btnPlayfairDecrypt.FlatStyle = FlatStyle.Flat;
        btnPlayfairDecrypt.ForeColor = Color.White;
        btnPlayfairDecrypt.Location = new Point(28, 271);
        btnPlayfairDecrypt.Name = "btnPlayfairDecrypt";
        btnPlayfairDecrypt.Size = new Size(190, 38);
        btnPlayfairDecrypt.TabIndex = 6;
        btnPlayfairDecrypt.Text = "Giải mã PlayFair";
        btnPlayfairDecrypt.UseVisualStyleBackColor = false;
        btnPlayfairDecrypt.Click += btnPlayfairDecrypt_Click;
        // 
        // txtPlayfairDecryptOutput
        // 
        txtPlayfairDecryptOutput.BorderStyle = BorderStyle.FixedSingle;
        txtPlayfairDecryptOutput.Font = new Font("Consolas", 10.5F);
        txtPlayfairDecryptOutput.Location = new Point(28, 188);
        txtPlayfairDecryptOutput.Multiline = true;
        txtPlayfairDecryptOutput.Name = "txtPlayfairDecryptOutput";
        txtPlayfairDecryptOutput.ReadOnly = true;
        txtPlayfairDecryptOutput.ScrollBars = ScrollBars.Vertical;
        txtPlayfairDecryptOutput.Size = new Size(570, 74);
        txtPlayfairDecryptOutput.TabIndex = 5;
        // 
        // lblPlayfairDecryptOutput
        // 
        lblPlayfairDecryptOutput.AutoSize = true;
        lblPlayfairDecryptOutput.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        lblPlayfairDecryptOutput.Location = new Point(28, 160);
        lblPlayfairDecryptOutput.Name = "lblPlayfairDecryptOutput";
        lblPlayfairDecryptOutput.Size = new Size(119, 23);
        lblPlayfairDecryptOutput.TabIndex = 4;
        lblPlayfairDecryptOutput.Text = "Bản rõ giải mã";
        // 
        // txtPlayfairDecryptInput
        // 
        txtPlayfairDecryptInput.BorderStyle = BorderStyle.FixedSingle;
        txtPlayfairDecryptInput.Font = new Font("Consolas", 10.5F);
        txtPlayfairDecryptInput.Location = new Point(28, 84);
        txtPlayfairDecryptInput.Multiline = true;
        txtPlayfairDecryptInput.Name = "txtPlayfairDecryptInput";
        txtPlayfairDecryptInput.ScrollBars = ScrollBars.Vertical;
        txtPlayfairDecryptInput.Size = new Size(570, 74);
        txtPlayfairDecryptInput.TabIndex = 3;
        // 
        // lblPlayfairDecryptInput
        // 
        lblPlayfairDecryptInput.AutoSize = true;
        lblPlayfairDecryptInput.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        lblPlayfairDecryptInput.Location = new Point(28, 56);
        lblPlayfairDecryptInput.Name = "lblPlayfairDecryptInput";
        lblPlayfairDecryptInput.Size = new Size(136, 23);
        lblPlayfairDecryptInput.TabIndex = 2;
        lblPlayfairDecryptInput.Text = "Bản mã đầu vào";
        // 
        // lblPlayfairDecryptHint
        // 
        lblPlayfairDecryptHint.AutoSize = false;
        lblPlayfairDecryptHint.BackColor = Color.FromArgb(243, 248, 233);
        lblPlayfairDecryptHint.BorderStyle = BorderStyle.FixedSingle;
        lblPlayfairDecryptHint.Font = new Font("Segoe UI", 9.2F);
        lblPlayfairDecryptHint.ForeColor = Color.FromArgb(78, 90, 66);
        lblPlayfairDecryptHint.Location = new Point(28, 42);
        lblPlayfairDecryptHint.Name = "lblPlayfairDecryptHint";
        lblPlayfairDecryptHint.Padding = new Padding(10, 8, 10, 8);
        lblPlayfairDecryptHint.Size = new Size(570, 46);
        lblPlayfairDecryptHint.TabIndex = 1;
        lblPlayfairDecryptHint.Text = "Ghi chú: Giải mã PlayFair đảo quy tắc dịch chuyển trên ma trận 5x5." + "\r\n" + "Kết quả sẽ được lọc bớt ký tự đệm do quá trình mã hóa tạo ra.";
        lblPlayfairDecryptHint.Visible = false;
        // 
        // lblPlayfairDecryptTitle
        // 
        lblPlayfairDecryptTitle.AutoSize = true;
        lblPlayfairDecryptTitle.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
        lblPlayfairDecryptTitle.ForeColor = Color.FromArgb(25, 80, 73);
        lblPlayfairDecryptTitle.Location = new Point(23, 10);
        lblPlayfairDecryptTitle.Name = "lblPlayfairDecryptTitle";
        lblPlayfairDecryptTitle.Size = new Size(97, 30);
        lblPlayfairDecryptTitle.TabIndex = 0;
        lblPlayfairDecryptTitle.Text = "Giải mã";
        // 
        // panelPlayfairEncrypt
        // 
        panelPlayfairEncrypt.BackColor = Color.White;
        panelPlayfairEncrypt.BorderStyle = BorderStyle.FixedSingle;
        panelPlayfairEncrypt.Controls.Add(btnPlayfairMoveToDecrypt);
        panelPlayfairEncrypt.Controls.Add(btnPlayfairEncrypt);
        panelPlayfairEncrypt.Controls.Add(txtPlayfairEncryptOutput);
        panelPlayfairEncrypt.Controls.Add(lblPlayfairEncryptOutput);
        panelPlayfairEncrypt.Controls.Add(txtPlayfairEncryptInput);
        panelPlayfairEncrypt.Controls.Add(lblPlayfairEncryptInput);
        panelPlayfairEncrypt.Controls.Add(lblPlayfairEncryptHint);
        panelPlayfairEncrypt.Controls.Add(lblPlayfairEncryptTitle);
        panelPlayfairEncrypt.Location = new Point(36, 202);
        panelPlayfairEncrypt.Name = "panelPlayfairEncrypt";
        panelPlayfairEncrypt.Size = new Size(600, 330);
        panelPlayfairEncrypt.TabIndex = 4;
        // 
        // btnPlayfairMoveToDecrypt
        // 
        btnPlayfairMoveToDecrypt.BackColor = Color.FromArgb(232, 245, 241);
        btnPlayfairMoveToDecrypt.FlatAppearance.BorderColor = Color.FromArgb(188, 217, 209);
        btnPlayfairMoveToDecrypt.FlatStyle = FlatStyle.Flat;
        btnPlayfairMoveToDecrypt.Location = new Point(222, 271);
        btnPlayfairMoveToDecrypt.Name = "btnPlayfairMoveToDecrypt";
        btnPlayfairMoveToDecrypt.Size = new Size(190, 38);
        btnPlayfairMoveToDecrypt.TabIndex = 7;
        btnPlayfairMoveToDecrypt.Text = "Chuyển sang giải mã";
        btnPlayfairMoveToDecrypt.UseVisualStyleBackColor = false;
        btnPlayfairMoveToDecrypt.Click += btnPlayfairMoveToDecrypt_Click;
        // 
        // btnPlayfairEncrypt
        // 
        btnPlayfairEncrypt.BackColor = Color.FromArgb(25, 125, 109);
        btnPlayfairEncrypt.FlatAppearance.BorderSize = 0;
        btnPlayfairEncrypt.FlatStyle = FlatStyle.Flat;
        btnPlayfairEncrypt.ForeColor = Color.White;
        btnPlayfairEncrypt.Location = new Point(28, 271);
        btnPlayfairEncrypt.Name = "btnPlayfairEncrypt";
        btnPlayfairEncrypt.Size = new Size(180, 38);
        btnPlayfairEncrypt.TabIndex = 6;
        btnPlayfairEncrypt.Text = "Mã hóa PlayFair";
        btnPlayfairEncrypt.UseVisualStyleBackColor = false;
        btnPlayfairEncrypt.Click += btnPlayfairEncrypt_Click;
        // 
        // txtPlayfairEncryptOutput
        // 
        txtPlayfairEncryptOutput.BorderStyle = BorderStyle.FixedSingle;
        txtPlayfairEncryptOutput.Font = new Font("Consolas", 10.5F);
        txtPlayfairEncryptOutput.Location = new Point(28, 188);
        txtPlayfairEncryptOutput.Multiline = true;
        txtPlayfairEncryptOutput.Name = "txtPlayfairEncryptOutput";
        txtPlayfairEncryptOutput.ReadOnly = true;
        txtPlayfairEncryptOutput.ScrollBars = ScrollBars.Vertical;
        txtPlayfairEncryptOutput.Size = new Size(542, 74);
        txtPlayfairEncryptOutput.TabIndex = 5;
        // 
        // lblPlayfairEncryptOutput
        // 
        lblPlayfairEncryptOutput.AutoSize = true;
        lblPlayfairEncryptOutput.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        lblPlayfairEncryptOutput.Location = new Point(28, 160);
        lblPlayfairEncryptOutput.Name = "lblPlayfairEncryptOutput";
        lblPlayfairEncryptOutput.Size = new Size(127, 23);
        lblPlayfairEncryptOutput.TabIndex = 4;
        lblPlayfairEncryptOutput.Text = "Bản mã kết quả";
        // 
        // txtPlayfairEncryptInput
        // 
        txtPlayfairEncryptInput.BorderStyle = BorderStyle.FixedSingle;
        txtPlayfairEncryptInput.Font = new Font("Consolas", 10.5F);
        txtPlayfairEncryptInput.Location = new Point(28, 84);
        txtPlayfairEncryptInput.Multiline = true;
        txtPlayfairEncryptInput.Name = "txtPlayfairEncryptInput";
        txtPlayfairEncryptInput.ScrollBars = ScrollBars.Vertical;
        txtPlayfairEncryptInput.Size = new Size(542, 74);
        txtPlayfairEncryptInput.TabIndex = 3;
        // 
        // lblPlayfairEncryptInput
        // 
        lblPlayfairEncryptInput.AutoSize = true;
        lblPlayfairEncryptInput.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        lblPlayfairEncryptInput.Location = new Point(28, 56);
        lblPlayfairEncryptInput.Name = "lblPlayfairEncryptInput";
        lblPlayfairEncryptInput.Size = new Size(124, 23);
        lblPlayfairEncryptInput.TabIndex = 2;
        lblPlayfairEncryptInput.Text = "Bản rõ đầu vào";
        // 
        // lblPlayfairEncryptHint
        // 
        lblPlayfairEncryptHint.AutoSize = false;
        lblPlayfairEncryptHint.BackColor = Color.FromArgb(243, 248, 233);
        lblPlayfairEncryptHint.BorderStyle = BorderStyle.FixedSingle;
        lblPlayfairEncryptHint.Font = new Font("Segoe UI", 9.2F);
        lblPlayfairEncryptHint.ForeColor = Color.FromArgb(78, 90, 66);
        lblPlayfairEncryptHint.Location = new Point(28, 42);
        lblPlayfairEncryptHint.Name = "lblPlayfairEncryptHint";
        lblPlayfairEncryptHint.Padding = new Padding(10, 8, 10, 8);
        lblPlayfairEncryptHint.Size = new Size(542, 46);
        lblPlayfairEncryptHint.TabIndex = 1;
        lblPlayfairEncryptHint.Text = "Ghi chú: PlayFair mã hóa theo từng cặp ký tự trên ma trận 5x5." + "\r\n" + "Khi hai chữ trùng nhau hoặc thiếu cặp, hệ thống sẽ chèn ký tự đệm.";
        lblPlayfairEncryptHint.Visible = false;
        // 
        // lblPlayfairEncryptTitle
        // 
        lblPlayfairEncryptTitle.AutoSize = true;
        lblPlayfairEncryptTitle.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
        lblPlayfairEncryptTitle.ForeColor = Color.FromArgb(25, 80, 73);
        lblPlayfairEncryptTitle.Location = new Point(23, 10);
        lblPlayfairEncryptTitle.Name = "lblPlayfairEncryptTitle";
        lblPlayfairEncryptTitle.Size = new Size(96, 30);
        lblPlayfairEncryptTitle.TabIndex = 0;
        lblPlayfairEncryptTitle.Text = "Mã hóa";
        // 
        // lblPlayfairKeyHint
        // 
        lblPlayfairKeyHint.AutoSize = false;
        lblPlayfairKeyHint.BackColor = Color.FromArgb(255, 249, 230);
        lblPlayfairKeyHint.BorderStyle = BorderStyle.FixedSingle;
        lblPlayfairKeyHint.Font = new Font("Segoe UI", 9.2F);
        lblPlayfairKeyHint.ForeColor = Color.FromArgb(110, 92, 40);
        lblPlayfairKeyHint.Location = new Point(36, 178);
        lblPlayfairKeyHint.Name = "lblPlayfairKeyHint";
        lblPlayfairKeyHint.Padding = new Padding(10, 8, 10, 8);
        lblPlayfairKeyHint.Size = new Size(1256, 62);
        lblPlayfairKeyHint.TabIndex = 3;
        lblPlayfairKeyHint.Text = "Ghi chú khóa: Khóa được dùng để tạo ma trận 5x5 chung cho cả mã hóa và giải mã." + "\r\n" + "Thuật toán chỉ giữ chữ cái A-Z, gộp J vào I và loại bỏ số hoặc ký tự đặc biệt.";
        lblPlayfairKeyHint.Visible = false;
        // 
        // txtPlayfairKey
        // 
        txtPlayfairKey.BorderStyle = BorderStyle.FixedSingle;
        txtPlayfairKey.Font = new Font("Consolas", 11F);
        txtPlayfairKey.Location = new Point(36, 143);
        txtPlayfairKey.Name = "txtPlayfairKey";
        txtPlayfairKey.Size = new Size(1256, 29);
        txtPlayfairKey.TabIndex = 2;
        // 
        // lblPlayfairKey
        // 
        lblPlayfairKey.AutoSize = true;
        lblPlayfairKey.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
        lblPlayfairKey.Location = new Point(36, 115);
        lblPlayfairKey.Name = "lblPlayfairKey";
        lblPlayfairKey.Size = new Size(181, 23);
        lblPlayfairKey.TabIndex = 1;
        lblPlayfairKey.Text = "Khóa dùng cho 2 luồng";
        // 
        // panelPlayfairHero
        // 
        panelPlayfairHero.BackColor = Color.FromArgb(230, 241, 237);
        panelPlayfairHero.Controls.Add(btnPlayfairInfo);
        panelPlayfairHero.Controls.Add(lblPlayfairDesc);
        panelPlayfairHero.Controls.Add(lblPlayfairTitle);
        panelPlayfairHero.Location = new Point(36, 24);
        panelPlayfairHero.Name = "panelPlayfairHero";
        panelPlayfairHero.Size = new Size(1256, 54);
        panelPlayfairHero.TabIndex = 0;
        // 
        // lblPlayfairDesc
        // 
        lblPlayfairDesc.Visible = false;
        // 
        // lblPlayfairTitle
        // 
        lblPlayfairTitle.AutoSize = true;
        lblPlayfairTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
        lblPlayfairTitle.ForeColor = Color.FromArgb(22, 83, 75);
        lblPlayfairTitle.Location = new Point(18, 8);
        lblPlayfairTitle.Name = "lblPlayfairTitle";
        lblPlayfairTitle.Size = new Size(270, 32);
        lblPlayfairTitle.TabIndex = 0;
        lblPlayfairTitle.Text = "Mã hóa PlayFair cổ điển";
        // 
        // btnPlayfairInfo
        // 
        btnPlayfairInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnPlayfairInfo.BackColor = Color.White;
        btnPlayfairInfo.FlatAppearance.BorderColor = Color.FromArgb(167, 201, 192);
        btnPlayfairInfo.FlatStyle = FlatStyle.Flat;
        btnPlayfairInfo.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
        btnPlayfairInfo.Location = new Point(1080, 10);
        btnPlayfairInfo.Name = "btnPlayfairInfo";
        btnPlayfairInfo.Size = new Size(156, 32);
        btnPlayfairInfo.TabIndex = 2;
        btnPlayfairInfo.Text = "Nguyên lý hoạt động";
        btnPlayfairInfo.UseVisualStyleBackColor = false;
        btnPlayfairInfo.Click += btnPlayfairInfo_Click;
        // 
        // tabRsa
        // 
        tabRsa.AutoScroll = true;
        tabRsa.BackColor = Color.FromArgb(246, 248, 252);
        tabRsa.Controls.Add(lblRsaStatus);
        tabRsa.Controls.Add(btnRsaClear);
        tabRsa.Controls.Add(panelRsaDecrypt);
        tabRsa.Controls.Add(panelRsaEncrypt);
        tabRsa.Controls.Add(panelRsaKeys);
        tabRsa.Controls.Add(panelRsaHero);
        tabRsa.Location = new Point(4, 40);
        tabRsa.Name = "tabRsa";
        tabRsa.Padding = new Padding(16);
        tabRsa.Size = new Size(1328, 676);
        tabRsa.TabIndex = 1;
        tabRsa.Text = "RSA";
        // 
        // lblRsaStatus
        // 
        lblRsaStatus.AutoSize = true;
        lblRsaStatus.Font = new Font("Segoe UI", 10.2F);
        lblRsaStatus.ForeColor = Color.FromArgb(82, 90, 114);
        lblRsaStatus.Location = new Point(36, 645);
        lblRsaStatus.Name = "lblRsaStatus";
        lblRsaStatus.Size = new Size(180, 23);
        lblRsaStatus.TabIndex = 5;
        lblRsaStatus.Text = "RSA: sẵn sàng tạo khóa.";
        // 
        // btnRsaClear
        // 
        btnRsaClear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnRsaClear.BackColor = Color.White;
        btnRsaClear.FlatAppearance.BorderColor = Color.FromArgb(209, 215, 228);
        btnRsaClear.FlatStyle = FlatStyle.Flat;
        btnRsaClear.Location = new Point(1140, 634);
        btnRsaClear.Name = "btnRsaClear";
        btnRsaClear.Size = new Size(152, 38);
        btnRsaClear.TabIndex = 4;
        btnRsaClear.Text = "Xóa toàn bộ";
        btnRsaClear.UseVisualStyleBackColor = false;
        btnRsaClear.Click += btnRsaClear_Click;
        // 
        // panelRsaDecrypt
        // 
        panelRsaDecrypt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        panelRsaDecrypt.BackColor = Color.White;
        panelRsaDecrypt.BorderStyle = BorderStyle.FixedSingle;
        panelRsaDecrypt.Controls.Add(btnRsaDecrypt);
        panelRsaDecrypt.Controls.Add(txtRsaDecryptOutput);
        panelRsaDecrypt.Controls.Add(lblRsaDecryptOutput);
        panelRsaDecrypt.Controls.Add(txtRsaDecryptInput);
        panelRsaDecrypt.Controls.Add(lblRsaDecryptInput);
        panelRsaDecrypt.Controls.Add(lblRsaDecryptHint);
        panelRsaDecrypt.Controls.Add(lblRsaDecryptTitle);
        panelRsaDecrypt.Location = new Point(664, 355);
        panelRsaDecrypt.Name = "panelRsaDecrypt";
        panelRsaDecrypt.Size = new Size(628, 248);
        panelRsaDecrypt.TabIndex = 3;
        // 
        // btnRsaDecrypt
        // 
        btnRsaDecrypt.BackColor = Color.FromArgb(88, 58, 146);
        btnRsaDecrypt.FlatAppearance.BorderSize = 0;
        btnRsaDecrypt.FlatStyle = FlatStyle.Flat;
        btnRsaDecrypt.ForeColor = Color.White;
        btnRsaDecrypt.Location = new Point(28, 191);
        btnRsaDecrypt.Name = "btnRsaDecrypt";
        btnRsaDecrypt.Size = new Size(180, 34);
        btnRsaDecrypt.TabIndex = 6;
        btnRsaDecrypt.Text = "Giải mã RSA";
        btnRsaDecrypt.UseVisualStyleBackColor = false;
        btnRsaDecrypt.Click += btnRsaDecrypt_Click;
        // 
        // txtRsaDecryptOutput
        // 
        txtRsaDecryptOutput.BorderStyle = BorderStyle.FixedSingle;
        txtRsaDecryptOutput.Font = new Font("Consolas", 10F);
        txtRsaDecryptOutput.Location = new Point(320, 82);
        txtRsaDecryptOutput.Multiline = true;
        txtRsaDecryptOutput.Name = "txtRsaDecryptOutput";
        txtRsaDecryptOutput.ReadOnly = true;
        txtRsaDecryptOutput.ScrollBars = ScrollBars.Vertical;
        txtRsaDecryptOutput.Size = new Size(278, 103);
        txtRsaDecryptOutput.TabIndex = 5;
        // 
        // lblRsaDecryptOutput
        // 
        lblRsaDecryptOutput.AutoSize = true;
        lblRsaDecryptOutput.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        lblRsaDecryptOutput.Location = new Point(320, 54);
        lblRsaDecryptOutput.Name = "lblRsaDecryptOutput";
        lblRsaDecryptOutput.Size = new Size(119, 23);
        lblRsaDecryptOutput.TabIndex = 4;
        lblRsaDecryptOutput.Text = "Bản rõ kết quả";
        // 
        // txtRsaDecryptInput
        // 
        txtRsaDecryptInput.BorderStyle = BorderStyle.FixedSingle;
        txtRsaDecryptInput.Font = new Font("Consolas", 10F);
        txtRsaDecryptInput.Location = new Point(28, 82);
        txtRsaDecryptInput.Multiline = true;
        txtRsaDecryptInput.Name = "txtRsaDecryptInput";
        txtRsaDecryptInput.ScrollBars = ScrollBars.Vertical;
        txtRsaDecryptInput.Size = new Size(278, 103);
        txtRsaDecryptInput.TabIndex = 3;
        // 
        // lblRsaDecryptInput
        // 
        lblRsaDecryptInput.AutoSize = true;
        lblRsaDecryptInput.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        lblRsaDecryptInput.Location = new Point(28, 54);
        lblRsaDecryptInput.Name = "lblRsaDecryptInput";
        lblRsaDecryptInput.Size = new Size(139, 23);
        lblRsaDecryptInput.TabIndex = 2;
        lblRsaDecryptInput.Text = "Cipher Base64 vào";
        // 
        // lblRsaDecryptHint
        // 
        lblRsaDecryptHint.AutoSize = false;
        lblRsaDecryptHint.BackColor = Color.FromArgb(238, 240, 251);
        lblRsaDecryptHint.BorderStyle = BorderStyle.FixedSingle;
        lblRsaDecryptHint.Font = new Font("Segoe UI", 9.2F);
        lblRsaDecryptHint.ForeColor = Color.FromArgb(75, 78, 122);
        lblRsaDecryptHint.Location = new Point(28, 42);
        lblRsaDecryptHint.Name = "lblRsaDecryptHint";
        lblRsaDecryptHint.Padding = new Padding(10, 8, 10, 8);
        lblRsaDecryptHint.Size = new Size(570, 58);
        lblRsaDecryptHint.TabIndex = 1;
        lblRsaDecryptHint.Text = "Ghi chú: RSA giải mã bằng khóa bí mật tương ứng với khóa công khai đã dùng lúc mã hóa." + "\r\n" + "Dữ liệu đầu vào phải là chuỗi Base64 hợp lệ.";
        lblRsaDecryptHint.Visible = false;
        // 
        // lblRsaDecryptTitle
        // 
        lblRsaDecryptTitle.AutoSize = true;
        lblRsaDecryptTitle.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
        lblRsaDecryptTitle.ForeColor = Color.FromArgb(71, 54, 134);
        lblRsaDecryptTitle.Location = new Point(23, 8);
        lblRsaDecryptTitle.Name = "lblRsaDecryptTitle";
        lblRsaDecryptTitle.Size = new Size(97, 30);
        lblRsaDecryptTitle.TabIndex = 0;
        lblRsaDecryptTitle.Text = "Giải mã";
        // 
        // panelRsaEncrypt
        // 
        panelRsaEncrypt.BackColor = Color.White;
        panelRsaEncrypt.BorderStyle = BorderStyle.FixedSingle;
        panelRsaEncrypt.Controls.Add(btnRsaMoveToDecrypt);
        panelRsaEncrypt.Controls.Add(btnRsaEncrypt);
        panelRsaEncrypt.Controls.Add(txtRsaEncryptOutput);
        panelRsaEncrypt.Controls.Add(lblRsaEncryptOutput);
        panelRsaEncrypt.Controls.Add(txtRsaEncryptInput);
        panelRsaEncrypt.Controls.Add(lblRsaEncryptInput);
        panelRsaEncrypt.Controls.Add(lblRsaEncryptHint);
        panelRsaEncrypt.Controls.Add(lblRsaEncryptTitle);
        panelRsaEncrypt.Location = new Point(36, 355);
        panelRsaEncrypt.Name = "panelRsaEncrypt";
        panelRsaEncrypt.Size = new Size(600, 248);
        panelRsaEncrypt.TabIndex = 2;
        // 
        // btnRsaMoveToDecrypt
        // 
        btnRsaMoveToDecrypt.BackColor = Color.FromArgb(236, 239, 255);
        btnRsaMoveToDecrypt.FlatAppearance.BorderColor = Color.FromArgb(200, 209, 244);
        btnRsaMoveToDecrypt.FlatStyle = FlatStyle.Flat;
        btnRsaMoveToDecrypt.Location = new Point(220, 191);
        btnRsaMoveToDecrypt.Name = "btnRsaMoveToDecrypt";
        btnRsaMoveToDecrypt.Size = new Size(190, 34);
        btnRsaMoveToDecrypt.TabIndex = 7;
        btnRsaMoveToDecrypt.Text = "Chuyển sang giải mã";
        btnRsaMoveToDecrypt.UseVisualStyleBackColor = false;
        btnRsaMoveToDecrypt.Click += btnRsaMoveToDecrypt_Click;
        // 
        // btnRsaEncrypt
        // 
        btnRsaEncrypt.BackColor = Color.FromArgb(58, 73, 164);
        btnRsaEncrypt.FlatAppearance.BorderSize = 0;
        btnRsaEncrypt.FlatStyle = FlatStyle.Flat;
        btnRsaEncrypt.ForeColor = Color.White;
        btnRsaEncrypt.Location = new Point(28, 191);
        btnRsaEncrypt.Name = "btnRsaEncrypt";
        btnRsaEncrypt.Size = new Size(180, 34);
        btnRsaEncrypt.TabIndex = 6;
        btnRsaEncrypt.Text = "Mã hóa RSA";
        btnRsaEncrypt.UseVisualStyleBackColor = false;
        btnRsaEncrypt.Click += btnRsaEncrypt_Click;
        // 
        // txtRsaEncryptOutput
        // 
        txtRsaEncryptOutput.BorderStyle = BorderStyle.FixedSingle;
        txtRsaEncryptOutput.Font = new Font("Consolas", 10F);
        txtRsaEncryptOutput.Location = new Point(320, 82);
        txtRsaEncryptOutput.Multiline = true;
        txtRsaEncryptOutput.Name = "txtRsaEncryptOutput";
        txtRsaEncryptOutput.ReadOnly = true;
        txtRsaEncryptOutput.ScrollBars = ScrollBars.Vertical;
        txtRsaEncryptOutput.Size = new Size(250, 103);
        txtRsaEncryptOutput.TabIndex = 5;
        // 
        // lblRsaEncryptOutput
        // 
        lblRsaEncryptOutput.AutoSize = true;
        lblRsaEncryptOutput.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        lblRsaEncryptOutput.Location = new Point(320, 54);
        lblRsaEncryptOutput.Name = "lblRsaEncryptOutput";
        lblRsaEncryptOutput.Size = new Size(135, 23);
        lblRsaEncryptOutput.TabIndex = 4;
        lblRsaEncryptOutput.Text = "Cipher Base64 ra";
        // 
        // txtRsaEncryptInput
        // 
        txtRsaEncryptInput.BorderStyle = BorderStyle.FixedSingle;
        txtRsaEncryptInput.Font = new Font("Consolas", 10F);
        txtRsaEncryptInput.Location = new Point(28, 82);
        txtRsaEncryptInput.Multiline = true;
        txtRsaEncryptInput.Name = "txtRsaEncryptInput";
        txtRsaEncryptInput.ScrollBars = ScrollBars.Vertical;
        txtRsaEncryptInput.Size = new Size(278, 103);
        txtRsaEncryptInput.TabIndex = 3;
        // 
        // lblRsaEncryptInput
        // 
        lblRsaEncryptInput.AutoSize = true;
        lblRsaEncryptInput.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        lblRsaEncryptInput.Location = new Point(28, 54);
        lblRsaEncryptInput.Name = "lblRsaEncryptInput";
        lblRsaEncryptInput.Size = new Size(124, 23);
        lblRsaEncryptInput.TabIndex = 2;
        lblRsaEncryptInput.Text = "Bản rõ đầu vào";
        // 
        // lblRsaEncryptHint
        // 
        lblRsaEncryptHint.AutoSize = false;
        lblRsaEncryptHint.BackColor = Color.FromArgb(238, 240, 251);
        lblRsaEncryptHint.BorderStyle = BorderStyle.FixedSingle;
        lblRsaEncryptHint.Font = new Font("Segoe UI", 9.2F);
        lblRsaEncryptHint.ForeColor = Color.FromArgb(75, 78, 122);
        lblRsaEncryptHint.Location = new Point(28, 42);
        lblRsaEncryptHint.Name = "lblRsaEncryptHint";
        lblRsaEncryptHint.Padding = new Padding(10, 8, 10, 8);
        lblRsaEncryptHint.Size = new Size(542, 58);
        lblRsaEncryptHint.TabIndex = 1;
        lblRsaEncryptHint.Text = "Ghi chú: RSA mã hóa bằng khóa công khai, còn người nhận dùng khóa bí mật để mở." + "\r\n" + "Kết quả được trả về dưới dạng Base64 để dễ sao chép.";
        lblRsaEncryptHint.Visible = false;
        // 
        // lblRsaEncryptTitle
        // 
        lblRsaEncryptTitle.AutoSize = true;
        lblRsaEncryptTitle.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
        lblRsaEncryptTitle.ForeColor = Color.FromArgb(55, 68, 153);
        lblRsaEncryptTitle.Location = new Point(23, 8);
        lblRsaEncryptTitle.Name = "lblRsaEncryptTitle";
        lblRsaEncryptTitle.Size = new Size(96, 30);
        lblRsaEncryptTitle.TabIndex = 0;
        lblRsaEncryptTitle.Text = "Mã hóa";
        // 
        // panelRsaKeys
        // 
        panelRsaKeys.BackColor = Color.White;
        panelRsaKeys.BorderStyle = BorderStyle.FixedSingle;
        panelRsaKeys.Controls.Add(txtRsaPrivateKey);
        panelRsaKeys.Controls.Add(lblRsaPrivateKey);
        panelRsaKeys.Controls.Add(txtRsaPublicKey);
        panelRsaKeys.Controls.Add(lblRsaPublicKey);
        panelRsaKeys.Controls.Add(btnRsaGenerateKeys);
        panelRsaKeys.Controls.Add(cboRsaKeySize);
        panelRsaKeys.Controls.Add(lblRsaKeySize);
        panelRsaKeys.Controls.Add(lblRsaKeyPanelHint);
        panelRsaKeys.Controls.Add(lblRsaKeyPanelTitle);
        panelRsaKeys.Location = new Point(36, 113);
        panelRsaKeys.Name = "panelRsaKeys";
        panelRsaKeys.Size = new Size(1256, 220);
        panelRsaKeys.TabIndex = 1;
        // 
        // txtRsaPrivateKey
        // 
        txtRsaPrivateKey.BorderStyle = BorderStyle.FixedSingle;
        txtRsaPrivateKey.Font = new Font("Consolas", 9.5F);
        txtRsaPrivateKey.Location = new Point(648, 82);
        txtRsaPrivateKey.Multiline = true;
        txtRsaPrivateKey.Name = "txtRsaPrivateKey";
        txtRsaPrivateKey.ScrollBars = ScrollBars.Vertical;
        txtRsaPrivateKey.Size = new Size(576, 121);
        txtRsaPrivateKey.TabIndex = 8;
        // 
        // lblRsaPrivateKey
        // 
        lblRsaPrivateKey.AutoSize = true;
        lblRsaPrivateKey.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        lblRsaPrivateKey.Location = new Point(648, 54);
        lblRsaPrivateKey.Name = "lblRsaPrivateKey";
        lblRsaPrivateKey.Size = new Size(136, 23);
        lblRsaPrivateKey.TabIndex = 7;
        lblRsaPrivateKey.Text = "Khóa bí mật PEM";
        // 
        // txtRsaPublicKey
        // 
        txtRsaPublicKey.BorderStyle = BorderStyle.FixedSingle;
        txtRsaPublicKey.Font = new Font("Consolas", 9.5F);
        txtRsaPublicKey.Location = new Point(28, 82);
        txtRsaPublicKey.Multiline = true;
        txtRsaPublicKey.Name = "txtRsaPublicKey";
        txtRsaPublicKey.ScrollBars = ScrollBars.Vertical;
        txtRsaPublicKey.Size = new Size(592, 121);
        txtRsaPublicKey.TabIndex = 6;
        // 
        // lblRsaPublicKey
        // 
        lblRsaPublicKey.AutoSize = true;
        lblRsaPublicKey.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        lblRsaPublicKey.Location = new Point(28, 54);
        lblRsaPublicKey.Name = "lblRsaPublicKey";
        lblRsaPublicKey.Size = new Size(155, 23);
        lblRsaPublicKey.TabIndex = 5;
        lblRsaPublicKey.Text = "Khóa công khai PEM";
        // 
        // btnRsaGenerateKeys
        // 
        btnRsaGenerateKeys.BackColor = Color.FromArgb(231, 235, 255);
        btnRsaGenerateKeys.FlatAppearance.BorderSize = 0;
        btnRsaGenerateKeys.FlatStyle = FlatStyle.Flat;
        btnRsaGenerateKeys.Location = new Point(1041, 22);
        btnRsaGenerateKeys.Name = "btnRsaGenerateKeys";
        btnRsaGenerateKeys.Size = new Size(183, 34);
        btnRsaGenerateKeys.TabIndex = 4;
        btnRsaGenerateKeys.Text = "Tạo khóa tự động";
        btnRsaGenerateKeys.UseVisualStyleBackColor = false;
        btnRsaGenerateKeys.Click += btnRsaGenerateKeys_Click;
        // 
        // cboRsaKeySize
        // 
        cboRsaKeySize.DropDownStyle = ComboBoxStyle.DropDownList;
        cboRsaKeySize.FormattingEnabled = true;
        cboRsaKeySize.Items.AddRange(new object[] { "1024", "2048", "3072", "4096" });
        cboRsaKeySize.Location = new Point(494, 24);
        cboRsaKeySize.Name = "cboRsaKeySize";
        cboRsaKeySize.Size = new Size(126, 31);
        cboRsaKeySize.TabIndex = 3;
        // 
        // lblRsaKeySize
        // 
        lblRsaKeySize.AutoSize = true;
        lblRsaKeySize.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
        lblRsaKeySize.Location = new Point(390, 28);
        lblRsaKeySize.Name = "lblRsaKeySize";
        lblRsaKeySize.Size = new Size(98, 23);
        lblRsaKeySize.TabIndex = 2;
        lblRsaKeySize.Text = "Độ dài khóa";
        // 
        // lblRsaKeyPanelHint
        // 
        lblRsaKeyPanelHint.AutoSize = false;
        lblRsaKeyPanelHint.BackColor = Color.FromArgb(238, 240, 251);
        lblRsaKeyPanelHint.BorderStyle = BorderStyle.FixedSingle;
        lblRsaKeyPanelHint.Font = new Font("Segoe UI", 9.2F);
        lblRsaKeyPanelHint.ForeColor = Color.FromArgb(75, 78, 122);
        lblRsaKeyPanelHint.Location = new Point(28, 40);
        lblRsaKeyPanelHint.Name = "lblRsaKeyPanelHint";
        lblRsaKeyPanelHint.Padding = new Padding(10, 8, 10, 8);
        lblRsaKeyPanelHint.Size = new Size(334, 58);
        lblRsaKeyPanelHint.TabIndex = 1;
        lblRsaKeyPanelHint.Text = "Ghi chú: RSA dùng một cặp khóa gồm khóa công khai và khóa bí mật." + "\r\n" + "Khóa công khai để mã hóa, khóa bí mật để giải mã.";
        lblRsaKeyPanelHint.Visible = false;
        // 
        // lblRsaKeyPanelTitle
        // 
        lblRsaKeyPanelTitle.AutoSize = true;
        lblRsaKeyPanelTitle.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
        lblRsaKeyPanelTitle.ForeColor = Color.FromArgb(55, 68, 153);
        lblRsaKeyPanelTitle.Location = new Point(23, 6);
        lblRsaKeyPanelTitle.Name = "lblRsaKeyPanelTitle";
        lblRsaKeyPanelTitle.Size = new Size(142, 30);
        lblRsaKeyPanelTitle.TabIndex = 0;
        lblRsaKeyPanelTitle.Text = "Quản lý khóa";
        // 
        // panelRsaHero
        // 
        panelRsaHero.BackColor = Color.FromArgb(234, 237, 255);
        panelRsaHero.Controls.Add(btnRsaInfo);
        panelRsaHero.Controls.Add(lblRsaDesc);
        panelRsaHero.Controls.Add(lblRsaTitle);
        panelRsaHero.Location = new Point(36, 24);
        panelRsaHero.Name = "panelRsaHero";
        panelRsaHero.Size = new Size(1256, 54);
        panelRsaHero.TabIndex = 0;
        // 
        // lblRsaDesc
        // 
        lblRsaDesc.Visible = false;
        // 
        // lblRsaTitle
        // 
        lblRsaTitle.AutoSize = true;
        lblRsaTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
        lblRsaTitle.ForeColor = Color.FromArgb(55, 68, 153);
        lblRsaTitle.Location = new Point(18, 8);
        lblRsaTitle.Name = "lblRsaTitle";
        lblRsaTitle.Size = new Size(209, 32);
        lblRsaTitle.TabIndex = 0;
        lblRsaTitle.Text = "Mã hóa RSA hiện đại";
        // 
        // btnRsaInfo
        // 
        btnRsaInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnRsaInfo.BackColor = Color.White;
        btnRsaInfo.FlatAppearance.BorderColor = Color.FromArgb(185, 193, 233);
        btnRsaInfo.FlatStyle = FlatStyle.Flat;
        btnRsaInfo.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
        btnRsaInfo.Location = new Point(1080, 10);
        btnRsaInfo.Name = "btnRsaInfo";
        btnRsaInfo.Size = new Size(156, 32);
        btnRsaInfo.TabIndex = 2;
        btnRsaInfo.Text = "Nguyên lý hoạt động";
        btnRsaInfo.UseVisualStyleBackColor = false;
        btnRsaInfo.Click += btnRsaInfo_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(240, 243, 250);
        ClientSize = new Size(1384, 852);
        Controls.Add(tabMain);
        Controls.Add(lblSubHeader);
        Controls.Add(lblHeader);
        MinimumSize = new Size(1400, 880);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Ứng dụng mã hóa PlayFair và RSA";
        tabMain.ResumeLayout(false);
        tabPlayfair.ResumeLayout(false);
        tabPlayfair.PerformLayout();
        panelPlayfairDecrypt.ResumeLayout(false);
        panelPlayfairDecrypt.PerformLayout();
        panelPlayfairEncrypt.ResumeLayout(false);
        panelPlayfairEncrypt.PerformLayout();
        panelPlayfairHero.ResumeLayout(false);
        panelPlayfairHero.PerformLayout();
        tabRsa.ResumeLayout(false);
        tabRsa.PerformLayout();
        panelRsaDecrypt.ResumeLayout(false);
        panelRsaDecrypt.PerformLayout();
        panelRsaEncrypt.ResumeLayout(false);
        panelRsaEncrypt.PerformLayout();
        panelRsaKeys.ResumeLayout(false);
        panelRsaKeys.PerformLayout();
        panelRsaHero.ResumeLayout(false);
        panelRsaHero.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }
}
