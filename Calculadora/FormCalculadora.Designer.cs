namespace Calculadora;

partial class FormCalculadora
{
    private System.ComponentModel.IContainer components = null;

    private System.Windows.Forms.MenuStrip menuPrincipal;
    private System.Windows.Forms.ToolStripMenuItem menuItemSobre;
    private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
    private System.Windows.Forms.Panel pnlVisor;
    private System.Windows.Forms.Label lblVisor;
    private System.Windows.Forms.Panel pnlHistorico;
    private System.Windows.Forms.Label lblHistorico;
    private System.Windows.Forms.Label lblMemoriaIndicador;
    private System.Windows.Forms.TableLayoutPanel tlpBotoes;
    private System.Windows.Forms.Button btnMC;
    private System.Windows.Forms.Button btnMR;
    private System.Windows.Forms.Button btnMMais;
    private System.Windows.Forms.Button btnMMenos;
    private System.Windows.Forms.Button btnLimpar;
    private System.Windows.Forms.Button btnRaiz;
    private System.Windows.Forms.Button btnPotencia;
    private System.Windows.Forms.Button btnQuadrado;
    private System.Windows.Forms.Button btn7;
    private System.Windows.Forms.Button btn8;
    private System.Windows.Forms.Button btn9;
    private System.Windows.Forms.Button btnBackspace;
    private System.Windows.Forms.Button btn4;
    private System.Windows.Forms.Button btn5;
    private System.Windows.Forms.Button btn6;
    private System.Windows.Forms.Button btnDivisao;
    private System.Windows.Forms.Button btn1;
    private System.Windows.Forms.Button btn2;
    private System.Windows.Forms.Button btn3;
    private System.Windows.Forms.Button btnMultiplicacao;
    private System.Windows.Forms.Button btnInverterSinal;
    private System.Windows.Forms.Button btn0;
    private System.Windows.Forms.Button btnPontoDecimal;
    private System.Windows.Forms.Button btnSubtracao;
    private System.Windows.Forms.Button btnIgual;
    private System.Windows.Forms.Button btnSoma;

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
        this.menuPrincipal = new System.Windows.Forms.MenuStrip();
        this.menuItemSobre = new System.Windows.Forms.ToolStripMenuItem();
        this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
        this.pnlVisor = new System.Windows.Forms.Panel();
        this.lblVisor = new System.Windows.Forms.Label();
        this.pnlHistorico = new System.Windows.Forms.Panel();
        this.lblHistorico = new System.Windows.Forms.Label();
        this.lblMemoriaIndicador = new System.Windows.Forms.Label();
        this.tlpBotoes = new System.Windows.Forms.TableLayoutPanel();
        this.btnMC = new System.Windows.Forms.Button();
        this.btnMR = new System.Windows.Forms.Button();
        this.btnMMais = new System.Windows.Forms.Button();
        this.btnMMenos = new System.Windows.Forms.Button();
        this.btnLimpar = new System.Windows.Forms.Button();
        this.btnRaiz = new System.Windows.Forms.Button();
        this.btnPotencia = new System.Windows.Forms.Button();
        this.btnQuadrado = new System.Windows.Forms.Button();
        this.btn7 = new System.Windows.Forms.Button();
        this.btn8 = new System.Windows.Forms.Button();
        this.btn9 = new System.Windows.Forms.Button();
        this.btnBackspace = new System.Windows.Forms.Button();
        this.btn4 = new System.Windows.Forms.Button();
        this.btn5 = new System.Windows.Forms.Button();
        this.btn6 = new System.Windows.Forms.Button();
        this.btnDivisao = new System.Windows.Forms.Button();
        this.btn1 = new System.Windows.Forms.Button();
        this.btn2 = new System.Windows.Forms.Button();
        this.btn3 = new System.Windows.Forms.Button();
        this.btnMultiplicacao = new System.Windows.Forms.Button();
        this.btnInverterSinal = new System.Windows.Forms.Button();
        this.btn0 = new System.Windows.Forms.Button();
        this.btnPontoDecimal = new System.Windows.Forms.Button();
        this.btnSubtracao = new System.Windows.Forms.Button();
        this.btnIgual = new System.Windows.Forms.Button();
        this.btnSoma = new System.Windows.Forms.Button();
        this.menuPrincipal.SuspendLayout();
        this.tlpPrincipal.SuspendLayout();
        this.pnlVisor.SuspendLayout();
        this.pnlHistorico.SuspendLayout();
        this.tlpBotoes.SuspendLayout();
        this.SuspendLayout();
        //
        // menuPrincipal
        //
        this.menuPrincipal.BackColor = System.Drawing.Color.FromArgb(58, 58, 58);
        this.menuPrincipal.ForeColor = System.Drawing.Color.White;
        this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemSobre});
        this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
        this.menuPrincipal.Name = "menuPrincipal";
        this.menuPrincipal.Size = new System.Drawing.Size(360, 24);
        this.menuPrincipal.TabIndex = 0;
        this.menuPrincipal.Text = "menuPrincipal";
        //
        // menuItemSobre
        //
        this.menuItemSobre.Name = "menuItemSobre";
        this.menuItemSobre.Size = new System.Drawing.Size(53, 20);
        this.menuItemSobre.Text = "Sobre";
        this.menuItemSobre.Click += new System.EventHandler(this.MenuItemSobre_Click);
        //
        // tlpPrincipal
        //
        this.tlpPrincipal.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
        this.tlpPrincipal.ColumnCount = 1;
        this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        this.tlpPrincipal.Controls.Add(this.pnlVisor, 0, 0);
        this.tlpPrincipal.Controls.Add(this.tlpBotoes, 0, 1);
        this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tlpPrincipal.Location = new System.Drawing.Point(0, 24);
        this.tlpPrincipal.Name = "tlpPrincipal";
        this.tlpPrincipal.RowCount = 2;
        this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
        this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        this.tlpPrincipal.Size = new System.Drawing.Size(360, 536);
        this.tlpPrincipal.TabIndex = 1;
        //
        // pnlVisor
        //
        this.pnlVisor.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
        this.pnlVisor.Controls.Add(this.lblVisor);
        this.pnlVisor.Controls.Add(this.pnlHistorico);
        this.pnlVisor.Dock = System.Windows.Forms.DockStyle.Fill;
        this.pnlVisor.Location = new System.Drawing.Point(3, 3);
        this.pnlVisor.Name = "pnlVisor";
        this.pnlVisor.Padding = new System.Windows.Forms.Padding(16, 8, 16, 8);
        this.pnlVisor.Size = new System.Drawing.Size(354, 134);
        this.pnlVisor.TabIndex = 0;
        //
        // lblVisor
        //
        this.lblVisor.AutoEllipsis = true;
        this.lblVisor.Dock = System.Windows.Forms.DockStyle.Fill;
        this.lblVisor.Font = new System.Drawing.Font("Segoe UI", 34F, System.Drawing.FontStyle.Regular);
        this.lblVisor.ForeColor = System.Drawing.Color.White;
        this.lblVisor.Location = new System.Drawing.Point(16, 42);
        this.lblVisor.Name = "lblVisor";
        this.lblVisor.Size = new System.Drawing.Size(322, 84);
        this.lblVisor.TabIndex = 1;
        this.lblVisor.Text = "0";
        this.lblVisor.TextAlign = System.Drawing.ContentAlignment.BottomRight;
        //
        // pnlHistorico
        //
        this.pnlHistorico.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
        this.pnlHistorico.Controls.Add(this.lblHistorico);
        this.pnlHistorico.Controls.Add(this.lblMemoriaIndicador);
        this.pnlHistorico.Dock = System.Windows.Forms.DockStyle.Top;
        this.pnlHistorico.Location = new System.Drawing.Point(16, 8);
        this.pnlHistorico.Name = "pnlHistorico";
        this.pnlHistorico.Size = new System.Drawing.Size(322, 34);
        this.pnlHistorico.TabIndex = 0;
        //
        // lblHistorico
        //
        this.lblHistorico.Dock = System.Windows.Forms.DockStyle.Fill;
        this.lblHistorico.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular);
        this.lblHistorico.ForeColor = System.Drawing.Color.FromArgb(155, 155, 155);
        this.lblHistorico.Location = new System.Drawing.Point(24, 0);
        this.lblHistorico.Name = "lblHistorico";
        this.lblHistorico.Size = new System.Drawing.Size(298, 34);
        this.lblHistorico.TabIndex = 1;
        this.lblHistorico.Text = "";
        this.lblHistorico.TextAlign = System.Drawing.ContentAlignment.TopRight;
        //
        // lblMemoriaIndicador
        //
        this.lblMemoriaIndicador.Dock = System.Windows.Forms.DockStyle.Left;
        this.lblMemoriaIndicador.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.lblMemoriaIndicador.ForeColor = System.Drawing.Color.FromArgb(59, 130, 246);
        this.lblMemoriaIndicador.Location = new System.Drawing.Point(0, 0);
        this.lblMemoriaIndicador.Name = "lblMemoriaIndicador";
        this.lblMemoriaIndicador.Size = new System.Drawing.Size(24, 34);
        this.lblMemoriaIndicador.TabIndex = 0;
        this.lblMemoriaIndicador.Text = "M";
        this.lblMemoriaIndicador.TextAlign = System.Drawing.ContentAlignment.TopLeft;
        this.lblMemoriaIndicador.Visible = false;
        //
        // tlpBotoes
        //
        this.tlpBotoes.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
        this.tlpBotoes.ColumnCount = 4;
        this.tlpBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        this.tlpBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        this.tlpBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        this.tlpBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        this.tlpBotoes.Controls.Add(this.btnMC, 0, 0);
        this.tlpBotoes.Controls.Add(this.btnMR, 1, 0);
        this.tlpBotoes.Controls.Add(this.btnMMais, 2, 0);
        this.tlpBotoes.Controls.Add(this.btnMMenos, 3, 0);
        this.tlpBotoes.Controls.Add(this.btnLimpar, 0, 1);
        this.tlpBotoes.Controls.Add(this.btnRaiz, 1, 1);
        this.tlpBotoes.Controls.Add(this.btnPotencia, 2, 1);
        this.tlpBotoes.Controls.Add(this.btnQuadrado, 3, 1);
        this.tlpBotoes.Controls.Add(this.btn7, 0, 2);
        this.tlpBotoes.Controls.Add(this.btn8, 1, 2);
        this.tlpBotoes.Controls.Add(this.btn9, 2, 2);
        this.tlpBotoes.Controls.Add(this.btnBackspace, 3, 2);
        this.tlpBotoes.Controls.Add(this.btn4, 0, 3);
        this.tlpBotoes.Controls.Add(this.btn5, 1, 3);
        this.tlpBotoes.Controls.Add(this.btn6, 2, 3);
        this.tlpBotoes.Controls.Add(this.btnDivisao, 3, 3);
        this.tlpBotoes.Controls.Add(this.btn1, 0, 4);
        this.tlpBotoes.Controls.Add(this.btn2, 1, 4);
        this.tlpBotoes.Controls.Add(this.btn3, 2, 4);
        this.tlpBotoes.Controls.Add(this.btnMultiplicacao, 3, 4);
        this.tlpBotoes.Controls.Add(this.btnInverterSinal, 0, 5);
        this.tlpBotoes.Controls.Add(this.btn0, 1, 5);
        this.tlpBotoes.Controls.Add(this.btnPontoDecimal, 2, 5);
        this.tlpBotoes.Controls.Add(this.btnSubtracao, 3, 5);
        this.tlpBotoes.Controls.Add(this.btnIgual, 0, 6);
        this.tlpBotoes.Controls.Add(this.btnSoma, 3, 6);
        this.tlpBotoes.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tlpBotoes.Location = new System.Drawing.Point(3, 143);
        this.tlpBotoes.Name = "tlpBotoes";
        this.tlpBotoes.Padding = new System.Windows.Forms.Padding(8);
        this.tlpBotoes.RowCount = 7;
        this.tlpBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.2857F));
        this.tlpBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.2857F));
        this.tlpBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.2857F));
        this.tlpBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.2857F));
        this.tlpBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.2857F));
        this.tlpBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.2857F));
        this.tlpBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.2857F));
        this.tlpBotoes.Size = new System.Drawing.Size(354, 390);
        this.tlpBotoes.TabIndex = 1;
        //
        // btnMC
        //
        this.btnMC.BackColor = System.Drawing.Color.FromArgb(58, 58, 58);
        this.btnMC.Dock = System.Windows.Forms.DockStyle.Fill;
        this.btnMC.FlatAppearance.BorderSize = 0;
        this.btnMC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(78, 78, 78);
        this.btnMC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnMC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular);
        this.btnMC.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
        this.btnMC.Location = new System.Drawing.Point(11, 11);
        this.btnMC.Margin = new System.Windows.Forms.Padding(4);
        this.btnMC.Name = "btnMC";
        this.btnMC.Size = new System.Drawing.Size(75, 23);
        this.btnMC.TabIndex = 0;
        this.btnMC.Text = "MC";
        this.btnMC.UseVisualStyleBackColor = false;
        this.btnMC.Click += new System.EventHandler(this.BotaoMC_Click);
        //
        // btnMR
        //
        this.btnMR.BackColor = System.Drawing.Color.FromArgb(58, 58, 58);
        this.btnMR.Dock = System.Windows.Forms.DockStyle.Fill;
        this.btnMR.FlatAppearance.BorderSize = 0;
        this.btnMR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(78, 78, 78);
        this.btnMR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnMR.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular);
        this.btnMR.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
        this.btnMR.Location = new System.Drawing.Point(92, 11);
        this.btnMR.Margin = new System.Windows.Forms.Padding(4);
        this.btnMR.Name = "btnMR";
        this.btnMR.Size = new System.Drawing.Size(75, 23);
        this.btnMR.TabIndex = 1;
        this.btnMR.Text = "MR";
        this.btnMR.UseVisualStyleBackColor = false;
        this.btnMR.Click += new System.EventHandler(this.BotaoMR_Click);
        //
        // btnMMais
        //
        this.btnMMais.BackColor = System.Drawing.Color.FromArgb(58, 58, 58);
        this.btnMMais.Dock = System.Windows.Forms.DockStyle.Fill;
        this.btnMMais.FlatAppearance.BorderSize = 0;
        this.btnMMais.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(78, 78, 78);
        this.btnMMais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnMMais.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular);
        this.btnMMais.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
        this.btnMMais.Location = new System.Drawing.Point(173, 11);
        this.btnMMais.Margin = new System.Windows.Forms.Padding(4);
        this.btnMMais.Name = "btnMMais";
        this.btnMMais.Size = new System.Drawing.Size(75, 23);
        this.btnMMais.TabIndex = 2;
        this.btnMMais.Text = "M+";
        this.btnMMais.UseVisualStyleBackColor = false;
        this.btnMMais.Click += new System.EventHandler(this.BotaoMMais_Click);
        //
        // btnMMenos
        //
        this.btnMMenos.BackColor = System.Drawing.Color.FromArgb(58, 58, 58);
        this.btnMMenos.Dock = System.Windows.Forms.DockStyle.Fill;
        this.btnMMenos.FlatAppearance.BorderSize = 0;
        this.btnMMenos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(78, 78, 78);
        this.btnMMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnMMenos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular);
        this.btnMMenos.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
        this.btnMMenos.Location = new System.Drawing.Point(254, 11);
        this.btnMMenos.Margin = new System.Windows.Forms.Padding(4);
        this.btnMMenos.Name = "btnMMenos";
        this.btnMMenos.Size = new System.Drawing.Size(75, 23);
        this.btnMMenos.TabIndex = 3;
        this.btnMMenos.Text = "M-";
        this.btnMMenos.UseVisualStyleBackColor = false;
        this.btnMMenos.Click += new System.EventHandler(this.BotaoMMenos_Click);
        //
        // btnLimpar
        //
        this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(58, 58, 58);
        this.btnLimpar.Dock = System.Windows.Forms.DockStyle.Fill;
        this.btnLimpar.FlatAppearance.BorderSize = 0;
        this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(78, 78, 78);
        this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular);
        this.btnLimpar.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
        this.btnLimpar.Location = new System.Drawing.Point(11, 63);
        this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
        this.btnLimpar.Name = "btnLimpar";
        this.btnLimpar.Size = new System.Drawing.Size(75, 23);
        this.btnLimpar.TabIndex = 4;
        this.btnLimpar.Text = "C";
        this.btnLimpar.UseVisualStyleBackColor = false;
        this.btnLimpar.Click += new System.EventHandler(this.BotaoLimpar_Click);
        //
        // btnRaiz
        //
        this.btnRaiz.BackColor = System.Drawing.Color.FromArgb(58, 58, 58);
        this.btnRaiz.Dock = System.Windows.Forms.DockStyle.Fill;
        this.btnRaiz.FlatAppearance.BorderSize = 0;
        this.btnRaiz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(78, 78, 78);
        this.btnRaiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnRaiz.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular);
        this.btnRaiz.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
        this.btnRaiz.Location = new System.Drawing.Point(92, 63);
        this.btnRaiz.Margin = new System.Windows.Forms.Padding(4);
        this.btnRaiz.Name = "btnRaiz";
        this.btnRaiz.Size = new System.Drawing.Size(75, 23);
        this.btnRaiz.TabIndex = 5;
        this.btnRaiz.Text = "√y";
        this.btnRaiz.UseVisualStyleBackColor = false;
        this.btnRaiz.Click += new System.EventHandler(this.BotaoRaiz_Click);
        //
        // btnPotencia
        //
        this.btnPotencia.BackColor = System.Drawing.Color.FromArgb(58, 58, 58);
        this.btnPotencia.Dock = System.Windows.Forms.DockStyle.Fill;
        this.btnPotencia.FlatAppearance.BorderSize = 0;
        this.btnPotencia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(78, 78, 78);
        this.btnPotencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnPotencia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular);
        this.btnPotencia.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
        this.btnPotencia.Location = new System.Drawing.Point(173, 63);
        this.btnPotencia.Margin = new System.Windows.Forms.Padding(4);
        this.btnPotencia.Name = "btnPotencia";
        this.btnPotencia.Size = new System.Drawing.Size(75, 23);
        this.btnPotencia.TabIndex = 6;
        this.btnPotencia.Text = "x^y";
        this.btnPotencia.UseVisualStyleBackColor = false;
        this.btnPotencia.Click += new System.EventHandler(this.BotaoPotencia_Click);
        //
        // btnQuadrado
        //
        this.btnQuadrado.BackColor = System.Drawing.Color.FromArgb(58, 58, 58);
        this.btnQuadrado.Dock = System.Windows.Forms.DockStyle.Fill;
        this.btnQuadrado.FlatAppearance.BorderSize = 0;
        this.btnQuadrado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(78, 78, 78);
        this.btnQuadrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnQuadrado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular);
        this.btnQuadrado.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
        this.btnQuadrado.Location = new System.Drawing.Point(254, 63);
        this.btnQuadrado.Margin = new System.Windows.Forms.Padding(4);
        this.btnQuadrado.Name = "btnQuadrado";
        this.btnQuadrado.Size = new System.Drawing.Size(75, 23);
        this.btnQuadrado.TabIndex = 7;
        this.btnQuadrado.Text = "x²";
        this.btnQuadrado.UseVisualStyleBackColor = false;
        this.btnQuadrado.Click += new System.EventHandler(this.BotaoQuadrado_Click);
        //
        // btn7
        //
        this.btn7.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
        this.btn7.Dock = System.Windows.Forms.DockStyle.Fill;
        this.btn7.FlatAppearance.BorderSize = 0;
        this.btn7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
        this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btn7.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular);
        this.btn7.ForeColor = System.Drawing.Color.White;
        this.btn7.Location = new System.Drawing.Point(11, 115);
        this.btn7.Margin = new System.Windows.Forms.Padding(4);
        this.btn7.Name = "btn7";
        this.btn7.Size = new System.Drawing.Size(75, 23);
        this.btn7.TabIndex = 8;
        this.btn7.Text = "7";
        this.btn7.UseVisualStyleBackColor = false;
        this.btn7.Click += new System.EventHandler(this.BotaoDigito_Click);
        //
        // btn8
        //
        this.btn8.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
        this.btn8.Dock = System.Windows.Forms.DockStyle.Fill;
        this.btn8.FlatAppearance.BorderSize = 0;
        this.btn8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
        this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btn8.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular);
        this.btn8.ForeColor = System.Drawing.Color.White;
        this.btn8.Location = new System.Drawing.Point(92, 115);
        this.btn8.Margin = new System.Windows.Forms.Padding(4);
        this.btn8.Name = "btn8";
        this.btn8.Size = new System.Drawing.Size(75, 23);
        this.btn8.TabIndex = 9;
        this.btn8.Text = "8";
        this.btn8.UseVisualStyleBackColor = false;
        this.btn8.Click += new System.EventHandler(this.BotaoDigito_Click);
        //
        // btn9
        //
        this.btn9.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
        this.btn9.Dock = System.Windows.Forms.DockStyle.Fill;
        this.btn9.FlatAppearance.BorderSize = 0;
        this.btn9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
        this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btn9.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular);
        this.btn9.ForeColor = System.Drawing.Color.White;
        this.btn9.Location = new System.Drawing.Point(173, 115);
        this.btn9.Margin = new System.Windows.Forms.Padding(4);
        this.btn9.Name = "btn9";
        this.btn9.Size = new System.Drawing.Size(75, 23);
        this.btn9.TabIndex = 10;
        this.btn9.Text = "9";
        this.btn9.UseVisualStyleBackColor = false;
        this.btn9.Click += new System.EventHandler(this.BotaoDigito_Click);
        //
        // btnBackspace
        //
        this.btnBackspace.BackColor = System.Drawing.Color.FromArgb(58, 58, 58);
        this.btnBackspace.Dock = System.Windows.Forms.DockStyle.Fill;
        this.btnBackspace.FlatAppearance.BorderSize = 0;
        this.btnBackspace.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(78, 78, 78);
        this.btnBackspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnBackspace.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular);
        this.btnBackspace.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
        this.btnBackspace.Location = new System.Drawing.Point(254, 115);
        this.btnBackspace.Margin = new System.Windows.Forms.Padding(4);
        this.btnBackspace.Name = "btnBackspace";
        this.btnBackspace.Size = new System.Drawing.Size(75, 23);
        this.btnBackspace.TabIndex = 11;
        this.btnBackspace.Text = "⌫";
        this.btnBackspace.UseVisualStyleBackColor = false;
        this.btnBackspace.Click += new System.EventHandler(this.BotaoBackspace_Click);
        //
        // btn4
        //
        this.btn4.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
        this.btn4.Dock = System.Windows.Forms.DockStyle.Fill;
        this.btn4.FlatAppearance.BorderSize = 0;
        this.btn4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
        this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btn4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular);
        this.btn4.ForeColor = System.Drawing.Color.White;
        this.btn4.Location = new System.Drawing.Point(11, 167);
        this.btn4.Margin = new System.Windows.Forms.Padding(4);
        this.btn4.Name = "btn4";
        this.btn4.Size = new System.Drawing.Size(75, 23);
        this.btn4.TabIndex = 12;
        this.btn4.Text = "4";
        this.btn4.UseVisualStyleBackColor = false;
        this.btn4.Click += new System.EventHandler(this.BotaoDigito_Click);
        //
        // btn5
        //
        this.btn5.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
        this.btn5.Dock = System.Windows.Forms.DockStyle.Fill;
        this.btn5.FlatAppearance.BorderSize = 0;
        this.btn5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
        this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btn5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular);
        this.btn5.ForeColor = System.Drawing.Color.White;
        this.btn5.Location = new System.Drawing.Point(92, 167);
        this.btn5.Margin = new System.Windows.Forms.Padding(4);
        this.btn5.Name = "btn5";
        this.btn5.Size = new System.Drawing.Size(75, 23);
        this.btn5.TabIndex = 13;
        this.btn5.Text = "5";
        this.btn5.UseVisualStyleBackColor = false;
        this.btn5.Click += new System.EventHandler(this.BotaoDigito_Click);
        //
        // btn6
        //
        this.btn6.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
        this.btn6.Dock = System.Windows.Forms.DockStyle.Fill;
        this.btn6.FlatAppearance.BorderSize = 0;
        this.btn6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
        this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btn6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular);
        this.btn6.ForeColor = System.Drawing.Color.White;
        this.btn6.Location = new System.Drawing.Point(173, 167);
        this.btn6.Margin = new System.Windows.Forms.Padding(4);
        this.btn6.Name = "btn6";
        this.btn6.Size = new System.Drawing.Size(75, 23);
        this.btn6.TabIndex = 14;
        this.btn6.Text = "6";
        this.btn6.UseVisualStyleBackColor = false;
        this.btn6.Click += new System.EventHandler(this.BotaoDigito_Click);
        //
        // btnDivisao
        //
        this.btnDivisao.BackColor = System.Drawing.Color.FromArgb(68, 68, 68);
        this.btnDivisao.Dock = System.Windows.Forms.DockStyle.Fill;
        this.btnDivisao.FlatAppearance.BorderSize = 0;
        this.btnDivisao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(90, 90, 90);
        this.btnDivisao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnDivisao.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular);
        this.btnDivisao.ForeColor = System.Drawing.Color.White;
        this.btnDivisao.Location = new System.Drawing.Point(254, 167);
        this.btnDivisao.Margin = new System.Windows.Forms.Padding(4);
        this.btnDivisao.Name = "btnDivisao";
        this.btnDivisao.Size = new System.Drawing.Size(75, 23);
        this.btnDivisao.TabIndex = 15;
        this.btnDivisao.Tag = Calculadora.Operacao.Divisao;
        this.btnDivisao.Text = "/";
        this.btnDivisao.UseVisualStyleBackColor = false;
        this.btnDivisao.Click += new System.EventHandler(this.BotaoOperador_Click);
        //
        // btn1
        //
        this.btn1.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
        this.btn1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.btn1.FlatAppearance.BorderSize = 0;
        this.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
        this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btn1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular);
        this.btn1.ForeColor = System.Drawing.Color.White;
        this.btn1.Location = new System.Drawing.Point(11, 219);
        this.btn1.Margin = new System.Windows.Forms.Padding(4);
        this.btn1.Name = "btn1";
        this.btn1.Size = new System.Drawing.Size(75, 23);
        this.btn1.TabIndex = 16;
        this.btn1.Text = "1";
        this.btn1.UseVisualStyleBackColor = false;
        this.btn1.Click += new System.EventHandler(this.BotaoDigito_Click);
        //
        // btn2
        //
        this.btn2.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
        this.btn2.Dock = System.Windows.Forms.DockStyle.Fill;
        this.btn2.FlatAppearance.BorderSize = 0;
        this.btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
        this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btn2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular);
        this.btn2.ForeColor = System.Drawing.Color.White;
        this.btn2.Location = new System.Drawing.Point(92, 219);
        this.btn2.Margin = new System.Windows.Forms.Padding(4);
        this.btn2.Name = "btn2";
        this.btn2.Size = new System.Drawing.Size(75, 23);
        this.btn2.TabIndex = 17;
        this.btn2.Text = "2";
        this.btn2.UseVisualStyleBackColor = false;
        this.btn2.Click += new System.EventHandler(this.BotaoDigito_Click);
        //
        // btn3
        //
        this.btn3.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
        this.btn3.Dock = System.Windows.Forms.DockStyle.Fill;
        this.btn3.FlatAppearance.BorderSize = 0;
        this.btn3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
        this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btn3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular);
        this.btn3.ForeColor = System.Drawing.Color.White;
        this.btn3.Location = new System.Drawing.Point(173, 219);
        this.btn3.Margin = new System.Windows.Forms.Padding(4);
        this.btn3.Name = "btn3";
        this.btn3.Size = new System.Drawing.Size(75, 23);
        this.btn3.TabIndex = 18;
        this.btn3.Text = "3";
        this.btn3.UseVisualStyleBackColor = false;
        this.btn3.Click += new System.EventHandler(this.BotaoDigito_Click);
        //
        // btnMultiplicacao
        //
        this.btnMultiplicacao.BackColor = System.Drawing.Color.FromArgb(68, 68, 68);
        this.btnMultiplicacao.Dock = System.Windows.Forms.DockStyle.Fill;
        this.btnMultiplicacao.FlatAppearance.BorderSize = 0;
        this.btnMultiplicacao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(90, 90, 90);
        this.btnMultiplicacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnMultiplicacao.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular);
        this.btnMultiplicacao.ForeColor = System.Drawing.Color.White;
        this.btnMultiplicacao.Location = new System.Drawing.Point(254, 219);
        this.btnMultiplicacao.Margin = new System.Windows.Forms.Padding(4);
        this.btnMultiplicacao.Name = "btnMultiplicacao";
        this.btnMultiplicacao.Size = new System.Drawing.Size(75, 23);
        this.btnMultiplicacao.TabIndex = 19;
        this.btnMultiplicacao.Tag = Calculadora.Operacao.Multiplicacao;
        this.btnMultiplicacao.Text = "x";
        this.btnMultiplicacao.UseVisualStyleBackColor = false;
        this.btnMultiplicacao.Click += new System.EventHandler(this.BotaoOperador_Click);
        //
        // btnInverterSinal
        //
        this.btnInverterSinal.BackColor = System.Drawing.Color.FromArgb(58, 58, 58);
        this.btnInverterSinal.Dock = System.Windows.Forms.DockStyle.Fill;
        this.btnInverterSinal.FlatAppearance.BorderSize = 0;
        this.btnInverterSinal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(78, 78, 78);
        this.btnInverterSinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnInverterSinal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular);
        this.btnInverterSinal.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
        this.btnInverterSinal.Location = new System.Drawing.Point(11, 271);
        this.btnInverterSinal.Margin = new System.Windows.Forms.Padding(4);
        this.btnInverterSinal.Name = "btnInverterSinal";
        this.btnInverterSinal.Size = new System.Drawing.Size(75, 23);
        this.btnInverterSinal.TabIndex = 20;
        this.btnInverterSinal.Text = "±";
        this.btnInverterSinal.UseVisualStyleBackColor = false;
        this.btnInverterSinal.Click += new System.EventHandler(this.BotaoInverterSinal_Click);
        //
        // btn0
        //
        this.btn0.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
        this.btn0.Dock = System.Windows.Forms.DockStyle.Fill;
        this.btn0.FlatAppearance.BorderSize = 0;
        this.btn0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
        this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btn0.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular);
        this.btn0.ForeColor = System.Drawing.Color.White;
        this.btn0.Location = new System.Drawing.Point(92, 271);
        this.btn0.Margin = new System.Windows.Forms.Padding(4);
        this.btn0.Name = "btn0";
        this.btn0.Size = new System.Drawing.Size(75, 23);
        this.btn0.TabIndex = 21;
        this.btn0.Text = "0";
        this.btn0.UseVisualStyleBackColor = false;
        this.btn0.Click += new System.EventHandler(this.BotaoDigito_Click);
        //
        // btnPontoDecimal
        //
        this.btnPontoDecimal.BackColor = System.Drawing.Color.FromArgb(58, 58, 58);
        this.btnPontoDecimal.Dock = System.Windows.Forms.DockStyle.Fill;
        this.btnPontoDecimal.FlatAppearance.BorderSize = 0;
        this.btnPontoDecimal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(78, 78, 78);
        this.btnPontoDecimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnPontoDecimal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular);
        this.btnPontoDecimal.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
        this.btnPontoDecimal.Location = new System.Drawing.Point(173, 271);
        this.btnPontoDecimal.Margin = new System.Windows.Forms.Padding(4);
        this.btnPontoDecimal.Name = "btnPontoDecimal";
        this.btnPontoDecimal.Size = new System.Drawing.Size(75, 23);
        this.btnPontoDecimal.TabIndex = 22;
        this.btnPontoDecimal.Text = ",";
        this.btnPontoDecimal.UseVisualStyleBackColor = false;
        this.btnPontoDecimal.Click += new System.EventHandler(this.BotaoPontoDecimal_Click);
        //
        // btnSubtracao
        //
        this.btnSubtracao.BackColor = System.Drawing.Color.FromArgb(68, 68, 68);
        this.btnSubtracao.Dock = System.Windows.Forms.DockStyle.Fill;
        this.btnSubtracao.FlatAppearance.BorderSize = 0;
        this.btnSubtracao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(90, 90, 90);
        this.btnSubtracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnSubtracao.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular);
        this.btnSubtracao.ForeColor = System.Drawing.Color.White;
        this.btnSubtracao.Location = new System.Drawing.Point(254, 271);
        this.btnSubtracao.Margin = new System.Windows.Forms.Padding(4);
        this.btnSubtracao.Name = "btnSubtracao";
        this.btnSubtracao.Size = new System.Drawing.Size(75, 23);
        this.btnSubtracao.TabIndex = 23;
        this.btnSubtracao.Tag = Calculadora.Operacao.Subtracao;
        this.btnSubtracao.Text = "-";
        this.btnSubtracao.UseVisualStyleBackColor = false;
        this.btnSubtracao.Click += new System.EventHandler(this.BotaoOperador_Click);
        //
        // btnIgual
        //
        this.btnIgual.BackColor = System.Drawing.Color.FromArgb(59, 130, 246);
        this.btnIgual.Dock = System.Windows.Forms.DockStyle.Fill;
        this.btnIgual.FlatAppearance.BorderSize = 0;
        this.btnIgual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(92, 155, 255);
        this.btnIgual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnIgual.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        this.btnIgual.ForeColor = System.Drawing.Color.White;
        this.btnIgual.Location = new System.Drawing.Point(11, 323);
        this.btnIgual.Margin = new System.Windows.Forms.Padding(4);
        this.btnIgual.Name = "btnIgual";
        this.btnIgual.Size = new System.Drawing.Size(237, 23);
        this.btnIgual.TabIndex = 24;
        this.btnIgual.Text = "=";
        this.btnIgual.UseVisualStyleBackColor = false;
        this.btnIgual.Click += new System.EventHandler(this.BotaoIgual_Click);
        //
        // btnSoma
        //
        this.btnSoma.BackColor = System.Drawing.Color.FromArgb(68, 68, 68);
        this.btnSoma.Dock = System.Windows.Forms.DockStyle.Fill;
        this.btnSoma.FlatAppearance.BorderSize = 0;
        this.btnSoma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(90, 90, 90);
        this.btnSoma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnSoma.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular);
        this.btnSoma.ForeColor = System.Drawing.Color.White;
        this.btnSoma.Location = new System.Drawing.Point(254, 323);
        this.btnSoma.Margin = new System.Windows.Forms.Padding(4);
        this.btnSoma.Name = "btnSoma";
        this.btnSoma.Size = new System.Drawing.Size(75, 23);
        this.btnSoma.TabIndex = 25;
        this.btnSoma.Tag = Calculadora.Operacao.Soma;
        this.btnSoma.Text = "+";
        this.btnSoma.UseVisualStyleBackColor = false;
        this.btnSoma.Click += new System.EventHandler(this.BotaoOperador_Click);
        //
        // FormCalculadora
        //
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
        this.ClientSize = new System.Drawing.Size(360, 560);
        this.Controls.Add(this.tlpPrincipal);
        this.Controls.Add(this.menuPrincipal);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.KeyPreview = true;
        this.MainMenuStrip = this.menuPrincipal;
        this.MaximizeBox = false;
        this.Name = "FormCalculadora";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Calculadora";
        this.menuPrincipal.ResumeLayout(false);
        this.menuPrincipal.PerformLayout();
        this.tlpPrincipal.ResumeLayout(false);
        this.pnlVisor.ResumeLayout(false);
        this.pnlHistorico.ResumeLayout(false);
        this.tlpBotoes.ResumeLayout(false);
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}
