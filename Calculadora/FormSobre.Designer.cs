#nullable enable

namespace Calculadora;

partial class FormSobre
{
    private System.ComponentModel.IContainer? components = null;

    private Label lblTitulo = null!;
    private Label lblIntegrantes = null!;
    private Label lblTurma = null!;
    private Label lblResumo = null!;
    private LinkLabel linkRepositorio = null!;
    private Button btnFechar = null!;

    private static readonly Color CorFundo = Color.FromArgb(32, 32, 32);
    private static readonly Color CorTexto = Color.White;
    private static readonly Color CorTextoSecundario = Color.FromArgb(190, 190, 190);
    private static readonly Color CorAccent = Color.FromArgb(59, 130, 246);
    private static readonly Color CorBotao = Color.FromArgb(58, 58, 58);
    private static readonly Color CorBotaoHover = Color.FromArgb(78, 78, 78);

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

        ClientSize = new Size(420, 380);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        StartPosition = FormStartPosition.CenterParent;
        Text = "Sobre";
        BackColor = CorFundo;
        Padding = new Padding(24);
        Icon = new Icon("Resources/calculadora.ico");

        lblTitulo = new Label
        {
            Text = "Calculadora Semi-Científica",
            Dock = DockStyle.Top,
            Height = 34,
            Font = new Font("Segoe UI", 16f, FontStyle.Bold),
            ForeColor = CorTexto,
            TextAlign = ContentAlignment.MiddleLeft
        };

        lblTurma = new Label
        {
            Text = "Turma 2TDSPS, curso TDS, Checkpoint 1 de Programação em C# e .NET",
            Dock = DockStyle.Top,
            Height = 40,
            Font = new Font("Segoe UI", 9.5f),
            ForeColor = CorTextoSecundario,
            TextAlign = ContentAlignment.MiddleLeft
        };

        lblIntegrantes = new Label
        {
            Text = "Integrantes:\r\n" +
                   "Raphael Oliveira Sinelli Mendonça, RM568346\r\n" +
                   "Henrique Spoltore Moreno Pavão dos Santos, RM568130",
            Dock = DockStyle.Top,
            Height = 70,
            Font = new Font("Segoe UI", 10f),
            ForeColor = CorTexto,
            TextAlign = ContentAlignment.MiddleLeft
        };

        lblResumo = new Label
        {
            Text = "Calculadora semi-científica desenvolvida em Windows Forms, com operações " +
                   "básicas, potência, raiz quadrada, memória e histórico da conta em andamento. " +
                   "A lógica de cálculo fica separada da interface na classe CalculadoraMotor.",
            Dock = DockStyle.Top,
            Height = 80,
            Font = new Font("Segoe UI", 9.5f),
            ForeColor = CorTextoSecundario,
            TextAlign = ContentAlignment.TopLeft
        };

        linkRepositorio = new LinkLabel
        {
            Text = "https://github.com/Raphael-Sinelli/CP1-Calculadora-CSharp",
            Dock = DockStyle.Top,
            Height = 30,
            Font = new Font("Segoe UI", 9.5f),
            LinkColor = CorAccent,
            ActiveLinkColor = CorAccent,
            VisitedLinkColor = CorAccent,
            BackColor = CorFundo,
            TextAlign = ContentAlignment.MiddleLeft
        };
        linkRepositorio.LinkClicked += LinkRepositorio_LinkClicked;

        btnFechar = new Button
        {
            Text = "Fechar",
            Dock = DockStyle.Bottom,
            Height = 40,
            FlatStyle = FlatStyle.Flat,
            BackColor = CorBotao,
            ForeColor = CorTexto,
            Font = new Font("Segoe UI", 10f),
            Cursor = Cursors.Hand
        };
        btnFechar.FlatAppearance.BorderSize = 0;
        btnFechar.FlatAppearance.MouseOverBackColor = CorBotaoHover;
        btnFechar.Click += BtnFechar_Click;

        Controls.Add(linkRepositorio);
        Controls.Add(lblResumo);
        Controls.Add(lblIntegrantes);
        Controls.Add(lblTurma);
        Controls.Add(lblTitulo);
        Controls.Add(btnFechar);

        AcceptButton = btnFechar;

        ResumeLayout(false);
    }
}
