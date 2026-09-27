namespace Calculadora;

partial class FormSobre
{
    private System.ComponentModel.IContainer components = null;

    private System.Windows.Forms.Label lblTitulo;
    private System.Windows.Forms.Label lblTurma;
    private System.Windows.Forms.Label lblIntegrantes;
    private System.Windows.Forms.Label lblResumo;
    private System.Windows.Forms.LinkLabel linkRepositorio;
    private System.Windows.Forms.Button btnFechar;

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
        this.lblTitulo = new System.Windows.Forms.Label();
        this.lblTurma = new System.Windows.Forms.Label();
        this.lblIntegrantes = new System.Windows.Forms.Label();
        this.lblResumo = new System.Windows.Forms.Label();
        this.linkRepositorio = new System.Windows.Forms.LinkLabel();
        this.btnFechar = new System.Windows.Forms.Button();
        this.SuspendLayout();
        //
        // lblTitulo
        //
        this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
        this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        this.lblTitulo.ForeColor = System.Drawing.Color.White;
        this.lblTitulo.Location = new System.Drawing.Point(24, 24);
        this.lblTitulo.Name = "lblTitulo";
        this.lblTitulo.Size = new System.Drawing.Size(372, 34);
        this.lblTitulo.TabIndex = 0;
        this.lblTitulo.Text = "Calculadora Semi-Científica";
        this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        //
        // lblTurma
        //
        this.lblTurma.Dock = System.Windows.Forms.DockStyle.Top;
        this.lblTurma.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
        this.lblTurma.ForeColor = System.Drawing.Color.FromArgb(190, 190, 190);
        this.lblTurma.Location = new System.Drawing.Point(24, 58);
        this.lblTurma.Name = "lblTurma";
        this.lblTurma.Size = new System.Drawing.Size(372, 40);
        this.lblTurma.TabIndex = 1;
        this.lblTurma.Text = "Turma 2TDSPS, curso TDS, Checkpoint 1 de Programação em C# e .NET";
        this.lblTurma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        //
        // lblIntegrantes
        //
        this.lblIntegrantes.Dock = System.Windows.Forms.DockStyle.Top;
        this.lblIntegrantes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
        this.lblIntegrantes.ForeColor = System.Drawing.Color.White;
        this.lblIntegrantes.Location = new System.Drawing.Point(24, 98);
        this.lblIntegrantes.Name = "lblIntegrantes";
        this.lblIntegrantes.Size = new System.Drawing.Size(372, 70);
        this.lblIntegrantes.TabIndex = 2;
        this.lblIntegrantes.Text = "Integrantes:\r\nRaphael Oliveira Sinelli Mendonça, RM568346\r\nHenrique Spoltore M" +
    "oreno Pavão dos Santos, RM568130";
        this.lblIntegrantes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        //
        // lblResumo
        //
        this.lblResumo.Dock = System.Windows.Forms.DockStyle.Top;
        this.lblResumo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
        this.lblResumo.ForeColor = System.Drawing.Color.FromArgb(190, 190, 190);
        this.lblResumo.Location = new System.Drawing.Point(24, 168);
        this.lblResumo.Name = "lblResumo";
        this.lblResumo.Size = new System.Drawing.Size(372, 80);
        this.lblResumo.TabIndex = 3;
        this.lblResumo.Text = "Calculadora semi-científica desenvolvida em Windows Forms, com operações básic" +
    "as, potência, raiz quadrada, memória e histórico da conta em andamento. A lóg" +
    "ica de cálculo fica separada da interface na classe CalculadoraMotor.";
        this.lblResumo.TextAlign = System.Drawing.ContentAlignment.TopLeft;
        //
        // linkRepositorio
        //
        this.linkRepositorio.ActiveLinkColor = System.Drawing.Color.FromArgb(59, 130, 246);
        this.linkRepositorio.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
        this.linkRepositorio.Dock = System.Windows.Forms.DockStyle.Top;
        this.linkRepositorio.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
        this.linkRepositorio.LinkColor = System.Drawing.Color.FromArgb(59, 130, 246);
        this.linkRepositorio.Location = new System.Drawing.Point(24, 248);
        this.linkRepositorio.Name = "linkRepositorio";
        this.linkRepositorio.Size = new System.Drawing.Size(372, 30);
        this.linkRepositorio.TabIndex = 4;
        this.linkRepositorio.TabStop = true;
        this.linkRepositorio.Text = "https://github.com/Raphael-Sinelli/CP1-Calculadora-CSharp";
        this.linkRepositorio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.linkRepositorio.VisitedLinkColor = System.Drawing.Color.FromArgb(59, 130, 246);
        this.linkRepositorio.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkRepositorio_LinkClicked);
        //
        // btnFechar
        //
        this.btnFechar.BackColor = System.Drawing.Color.FromArgb(58, 58, 58);
        this.btnFechar.Dock = System.Windows.Forms.DockStyle.Bottom;
        this.btnFechar.FlatAppearance.BorderSize = 0;
        this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(78, 78, 78);
        this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnFechar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
        this.btnFechar.ForeColor = System.Drawing.Color.White;
        this.btnFechar.Location = new System.Drawing.Point(24, 316);
        this.btnFechar.Name = "btnFechar";
        this.btnFechar.Size = new System.Drawing.Size(372, 40);
        this.btnFechar.TabIndex = 5;
        this.btnFechar.Text = "Fechar";
        this.btnFechar.UseVisualStyleBackColor = false;
        this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
        //
        // FormSobre
        //
        this.AcceptButton = this.btnFechar;
        this.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
        this.ClientSize = new System.Drawing.Size(420, 380);
        this.Controls.Add(this.linkRepositorio);
        this.Controls.Add(this.lblResumo);
        this.Controls.Add(this.lblIntegrantes);
        this.Controls.Add(this.lblTurma);
        this.Controls.Add(this.lblTitulo);
        this.Controls.Add(this.btnFechar);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "FormSobre";
        this.Padding = new System.Windows.Forms.Padding(24);
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "Sobre";
        this.ResumeLayout(false);
    }
}
