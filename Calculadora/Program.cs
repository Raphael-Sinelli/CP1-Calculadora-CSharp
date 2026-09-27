using System.Globalization;

namespace Calculadora;

internal static class Program
{
    /// <summary>Ponto de entrada da aplicação.</summary>
    [STAThread]
    private static void Main()
    {
        Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
        Application.ThreadException += (_, e) => ExibirErroFatal(e.Exception);
        AppDomain.CurrentDomain.UnhandledException += (_, e) => ExibirErroFatal(e.ExceptionObject as Exception);

        var culturaPtBr = CultureInfo.GetCultureInfo("pt-BR");
        CultureInfo.DefaultThreadCurrentCulture = culturaPtBr;
        CultureInfo.DefaultThreadCurrentUICulture = culturaPtBr;

        ApplicationConfiguration.Initialize();
        Application.Run(new FormCalculadora());
    }

    private static void ExibirErroFatal(Exception? excecao)
    {
        MessageBox.Show(
            $"Ocorreu um erro inesperado e a ação não pôde ser concluída.\n\n{excecao?.Message}",
            "Erro inesperado",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error);
    }
}
