namespace Calculadora;

/// <summary>
/// Memória da calculadora, responsável por guardar um único valor acumulado
/// através dos botões MC, MR, M+ e M-.
/// </summary>
public class Memoria
{
    private double _valor;

    /// <summary>Indica se há algum valor guardado na memória.</summary>
    public bool TemValor { get; private set; }

    /// <summary>Limpa a memória (botão MC).</summary>
    public void Limpar()
    {
        _valor = 0;
        TemValor = false;
    }

    /// <summary>Recupera o valor guardado na memória (botão MR).</summary>
    public double Recuperar()
    {
        return _valor;
    }

    /// <summary>Soma um valor ao conteúdo da memória (botão M+).</summary>
    public void Adicionar(double valor)
    {
        _valor += valor;
        TemValor = true;
    }

    /// <summary>Subtrai um valor do conteúdo da memória (botão M-).</summary>
    public void Subtrair(double valor)
    {
        _valor -= valor;
        TemValor = true;
    }
}
