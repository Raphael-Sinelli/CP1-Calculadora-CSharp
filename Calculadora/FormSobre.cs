using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Calculadora;

/// <summary>
/// Tela "Sobre", com os dados dos integrantes, um resumo do trabalho
/// e o link do repositório no GitHub.
/// </summary>
public partial class FormSobre : Form
{
    private const string UrlRepositorio = "https://github.com/Raphael-Sinelli/CP1-Calculadora-CSharp";

    [DllImport("dwmapi.dll")]
    private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attribute, ref int valor, int tamanho);

    public FormSobre()
    {
        InitializeComponent();

        Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath) ?? Icon;
        AplicarModoEscuroNaBarraDeTitulo();
    }

    private void AplicarModoEscuroNaBarraDeTitulo()
    {
        try
        {
            int ativado = 1;
            const int DWMWA_USE_IMMERSIVE_DARK_MODE = 20;
            const int DWMWA_USE_IMMERSIVE_DARK_MODE_ANTIGO = 19;

            if (DwmSetWindowAttribute(Handle, DWMWA_USE_IMMERSIVE_DARK_MODE, ref ativado, sizeof(int)) != 0)
            {
                DwmSetWindowAttribute(Handle, DWMWA_USE_IMMERSIVE_DARK_MODE_ANTIGO, ref ativado, sizeof(int));
            }
        }
        catch
        {
            // Versões antigas do Windows não suportam o atributo; a janela continua funcional.
        }
    }

    private void LinkRepositorio_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
    {
        try
        {
            Process.Start(new ProcessStartInfo(UrlRepositorio) { UseShellExecute = true });
        }
        catch
        {
            // Se não houver navegador configurado, a tela continua aberta normalmente.
        }
    }

    private void BtnFechar_Click(object? sender, EventArgs e)
    {
        Close();
    }
}
