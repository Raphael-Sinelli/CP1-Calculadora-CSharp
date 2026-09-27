#nullable enable

namespace Calculadora;

partial class FormCalculadora
{
    private System.ComponentModel.IContainer? components = null;

    private MenuStrip menuPrincipal = null!;
    private ToolStripMenuItem menuItemSobre = null!;
    private TableLayoutPanel tlpPrincipal = null!;
    private Panel pnlVisor = null!;
    private Label lblMemoriaIndicador = null!;
    private Label lblHistorico = null!;
    private Label lblVisor = null!;
    private TableLayoutPanel tlpBotoes = null!;

    private static readonly Color CorFundo = Color.FromArgb(32, 32, 32);
    private static readonly Color CorTextoHistorico = Color.FromArgb(155, 155, 155);
    private static readonly Color CorBotaoNumero = Color.FromArgb(45, 45, 45);
    private static readonly Color CorBotaoNumeroHover = Color.FromArgb(64, 64, 64);
    private static readonly Color CorBotaoFuncao = Color.FromArgb(58, 58, 58);
    private static readonly Color CorBotaoFuncaoHover = Color.FromArgb(78, 78, 78);
    private static readonly Color CorBotaoOperador = Color.FromArgb(68, 68, 68);
    private static readonly Color CorBotaoOperadorHover = Color.FromArgb(90, 90, 90);
    private static readonly Color CorAccent = Color.FromArgb(59, 130, 246);
    private static readonly Color CorAccentHover = Color.FromArgb(92, 155, 255);

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null)
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        SuspendLayout();

        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(360, 560);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Calculadora";
        BackColor = CorFundo;
        KeyPreview = true;
        Icon = new Icon("Resources/calculadora.ico");

        ConfigurarMenu();

        tlpPrincipal = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            ColumnCount = 1,
            RowCount = 2,
            BackColor = CorFundo
        };
        tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Absolute, 140f));
        tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));

        ConfigurarVisor();
        ConfigurarGradeDeBotoes();

        tlpPrincipal.Controls.Add(pnlVisor, 0, 0);
        tlpPrincipal.Controls.Add(tlpBotoes, 0, 1);

        Controls.Add(tlpPrincipal);
        Controls.Add(menuPrincipal);
        MainMenuStrip = menuPrincipal;

        ResumeLayout(false);
        PerformLayout();
    }

    private void ConfigurarMenu()
    {
        menuItemSobre = new ToolStripMenuItem("Sobre");
        menuItemSobre.Click += MenuItemSobre_Click;

        menuPrincipal = new MenuStrip
        {
            BackColor = CorBotaoFuncao,
            ForeColor = Color.White,
            Renderer = new ToolStripProfessionalRenderer(new TemaEscuroMenu())
        };
        menuPrincipal.Items.Add(menuItemSobre);
    }

    private void ConfigurarVisor()
    {
        pnlVisor = new Panel
        {
            Dock = DockStyle.Fill,
            BackColor = CorFundo,
            Padding = new Padding(16, 8, 16, 8)
        };

        lblMemoriaIndicador = new Label
        {
            Text = "M",
            AutoSize = false,
            Dock = DockStyle.Left,
            Width = 24,
            TextAlign = ContentAlignment.TopLeft,
            ForeColor = CorAccent,
            Font = new Font("Segoe UI", 10f, FontStyle.Bold),
            Visible = false
        };

        lblHistorico = new Label
        {
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.TopRight,
            ForeColor = CorTextoHistorico,
            Font = new Font("Segoe UI", 11f),
            Text = string.Empty
        };

        var pnlHistorico = new Panel
        {
            Dock = DockStyle.Top,
            Height = 34,
            BackColor = CorFundo
        };
        pnlHistorico.Controls.Add(lblHistorico);
        pnlHistorico.Controls.Add(lblMemoriaIndicador);

        lblVisor = new Label
        {
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.BottomRight,
            ForeColor = Color.White,
            Font = new Font("Segoe UI", 34f, FontStyle.Regular),
            Text = "0",
            AutoEllipsis = true
        };

        pnlVisor.Controls.Add(lblVisor);
        pnlVisor.Controls.Add(pnlHistorico);
    }

    private void ConfigurarGradeDeBotoes()
    {
        tlpBotoes = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            ColumnCount = 4,
            RowCount = 7,
            BackColor = CorFundo,
            Padding = new Padding(8)
        };

        for (int coluna = 0; coluna < 4; coluna++)
        {
            tlpBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25f));
        }

        for (int linha = 0; linha < 7; linha++)
        {
            tlpBotoes.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / 7));
        }

        AdicionarBotao(CriarBotaoFuncao("MC", BotaoMC_Click), 0, 0);
        AdicionarBotao(CriarBotaoFuncao("MR", BotaoMR_Click), 1, 0);
        AdicionarBotao(CriarBotaoFuncao("M+", BotaoMMais_Click), 2, 0);
        AdicionarBotao(CriarBotaoFuncao("M-", BotaoMMenos_Click), 3, 0);

        AdicionarBotao(CriarBotaoFuncao("C", BotaoLimpar_Click), 0, 1);
        AdicionarBotao(CriarBotaoFuncao("√y", BotaoRaiz_Click), 1, 1);
        AdicionarBotao(CriarBotaoFuncao("x^y", BotaoPotencia_Click), 2, 1);
        AdicionarBotao(CriarBotaoFuncao("x²", BotaoQuadrado_Click), 3, 1);

        AdicionarBotao(CriarBotaoNumero("7"), 0, 2);
        AdicionarBotao(CriarBotaoNumero("8"), 1, 2);
        AdicionarBotao(CriarBotaoNumero("9"), 2, 2);
        AdicionarBotao(CriarBotaoFuncao("⌫", BotaoBackspace_Click), 3, 2);

        AdicionarBotao(CriarBotaoNumero("4"), 0, 3);
        AdicionarBotao(CriarBotaoNumero("5"), 1, 3);
        AdicionarBotao(CriarBotaoNumero("6"), 2, 3);
        AdicionarBotao(CriarBotaoOperador("/", Operacao.Divisao), 3, 3);

        AdicionarBotao(CriarBotaoNumero("1"), 0, 4);
        AdicionarBotao(CriarBotaoNumero("2"), 1, 4);
        AdicionarBotao(CriarBotaoNumero("3"), 2, 4);
        AdicionarBotao(CriarBotaoOperador("x", Operacao.Multiplicacao), 3, 4);

        AdicionarBotao(CriarBotaoFuncao("±", BotaoInverterSinal_Click), 0, 5);
        AdicionarBotao(CriarBotaoNumero("0"), 1, 5);
        AdicionarBotao(CriarBotaoFuncao(",", BotaoPontoDecimal_Click), 2, 5);
        AdicionarBotao(CriarBotaoOperador("-", Operacao.Subtracao), 3, 5);

        var botaoIgual = CriarBotaoAccent("=", BotaoIgual_Click);
        tlpBotoes.Controls.Add(botaoIgual, 0, 6);
        tlpBotoes.SetColumnSpan(botaoIgual, 3);

        AdicionarBotao(CriarBotaoOperador("+", Operacao.Soma), 3, 6);
    }

    private void AdicionarBotao(Button botao, int coluna, int linha)
    {
        tlpBotoes.Controls.Add(botao, coluna, linha);
    }

    private Button CriarBotaoBase(string texto)
    {
        return new Button
        {
            Text = texto,
            Dock = DockStyle.Fill,
            Margin = new Padding(4),
            FlatStyle = FlatStyle.Flat,
            Font = new Font("Segoe UI", 14f),
            ForeColor = Color.White,
            Cursor = Cursors.Hand
        };
    }

    private Button CriarBotaoNumero(string digito)
    {
        var botao = CriarBotaoBase(digito);
        botao.BackColor = CorBotaoNumero;
        botao.FlatAppearance.BorderSize = 0;
        botao.FlatAppearance.MouseOverBackColor = CorBotaoNumeroHover;
        botao.Font = new Font("Segoe UI", 16f);
        botao.Click += BotaoDigito_Click;
        return botao;
    }

    private Button CriarBotaoFuncao(string texto, EventHandler aoClicar)
    {
        var botao = CriarBotaoBase(texto);
        botao.BackColor = CorBotaoFuncao;
        botao.FlatAppearance.BorderSize = 0;
        botao.FlatAppearance.MouseOverBackColor = CorBotaoFuncaoHover;
        botao.Font = new Font("Segoe UI", 12f);
        botao.ForeColor = Color.FromArgb(220, 220, 220);
        botao.Click += aoClicar;
        return botao;
    }

    private Button CriarBotaoOperador(string texto, Operacao operacao)
    {
        var botao = CriarBotaoBase(texto);
        botao.BackColor = CorBotaoOperador;
        botao.FlatAppearance.BorderSize = 0;
        botao.FlatAppearance.MouseOverBackColor = CorBotaoOperadorHover;
        botao.Tag = operacao;
        botao.Click += BotaoOperador_Click;
        return botao;
    }

    private Button CriarBotaoAccent(string texto, EventHandler aoClicar)
    {
        var botao = CriarBotaoBase(texto);
        botao.BackColor = CorAccent;
        botao.FlatAppearance.BorderSize = 0;
        botao.FlatAppearance.MouseOverBackColor = CorAccentHover;
        botao.Font = new Font("Segoe UI", 16f, FontStyle.Bold);
        botao.Click += aoClicar;
        return botao;
    }
}
