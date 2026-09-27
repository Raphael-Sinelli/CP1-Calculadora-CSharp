using System.Diagnostics;

namespace Calculadora;

/// <summary>
/// Tela "Sobre", com os dados dos integrantes, um resumo do trabalho
/// e o link do repositório no GitHub.
/// </summary>
public partial class FormSobre : Form
{
    private const string UrlRepositorio = "https://github.com/Raphael-Sinelli/CP1-Calculadora-CSharp";

    public FormSobre()
    {
        InitializeComponent();
    }

    private void LinkRepositorio_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
    {
        Process.Start(new ProcessStartInfo(UrlRepositorio) { UseShellExecute = true });
    }

    private void BtnFechar_Click(object? sender, EventArgs e)
    {
        Close();
    }
}
