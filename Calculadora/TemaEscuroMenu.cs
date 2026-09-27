namespace Calculadora;

/// <summary>
/// Paleta de cores escura usada pelo MenuStrip, para manter o mesmo
/// visual escuro do restante da calculadora.
/// </summary>
public class TemaEscuroMenu : ProfessionalColorTable
{
    private static readonly Color CorFundo = Color.FromArgb(58, 58, 58);
    private static readonly Color CorSelecionado = Color.FromArgb(59, 130, 246);

    public override Color MenuItemSelected => CorSelecionado;
    public override Color MenuItemSelectedGradientBegin => CorSelecionado;
    public override Color MenuItemSelectedGradientEnd => CorSelecionado;
    public override Color MenuItemBorder => CorSelecionado;
    public override Color MenuBorder => CorFundo;
    public override Color ToolStripDropDownBackground => CorFundo;
    public override Color ImageMarginGradientBegin => CorFundo;
    public override Color ImageMarginGradientMiddle => CorFundo;
    public override Color ImageMarginGradientEnd => CorFundo;
    public override Color MenuStripGradientBegin => CorFundo;
    public override Color MenuStripGradientEnd => CorFundo;
}
