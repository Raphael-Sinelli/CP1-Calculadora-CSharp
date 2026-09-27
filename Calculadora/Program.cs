using System.Globalization;

namespace Calculadora;

internal static class Program
{
    /// <summary>Ponto de entrada da aplicação.</summary>
    [STAThread]
    private static void Main()
    {
        var culturaPtBr = CultureInfo.GetCultureInfo("pt-BR");
        CultureInfo.DefaultThreadCurrentCulture = culturaPtBr;
        CultureInfo.DefaultThreadCurrentUICulture = culturaPtBr;

        ApplicationConfiguration.Initialize();
        Application.Run(new FormCalculadora());
    }
}
