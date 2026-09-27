namespace Calculadora;

/// <summary>
/// Contém toda a lógica matemática e o estado da conta em andamento
/// (operando anterior e operação pendente). Não faz nenhuma referência
/// a controles de tela.
/// </summary>
public class CalculadoraMotor
{
    private double _operandoAnterior;
    private double _operandoParaRepeticao;
    private Operacao _operacaoPendente = Operacao.Nenhuma;
    private Operacao _operacaoParaRepeticao = Operacao.Nenhuma;

    /// <summary>Indica se existe uma operação aguardando o segundo operando.</summary>
    public bool PossuiOperacaoPendente { get; private set; }

    /// <summary>Operação atualmente pendente, usada para montar o histórico na tela.</summary>
    public Operacao OperacaoPendente => _operacaoPendente;

    /// <summary>Última operação concluída, usada para repetir a conta ao apertar = de novo.</summary>
    public Operacao OperacaoParaRepeticao => _operacaoParaRepeticao;

    /// <summary>Segundo operando da última operação concluída, usado na repetição do =.</summary>
    public double OperandoParaRepeticao => _operandoParaRepeticao;

    public double Somar(double a, double b) => a + b;

    public double Subtrair(double a, double b) => a - b;

    public double Multiplicar(double a, double b) => a * b;

    /// <summary>Divide dois valores. Lança exceção quando o divisor é zero.</summary>
    public double Dividir(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Não é possível dividir por zero");
        }

        return a / b;
    }

    /// <summary>Calcula a raiz quadrada. Lança exceção para valores negativos.</summary>
    public double RaizQuadrada(double a)
    {
        if (a < 0)
        {
            throw new ArgumentException("Entrada inválida");
        }

        return Math.Sqrt(a);
    }

    public double Potencia(double baseValor, double expoente) => Math.Pow(baseValor, expoente);

    public double AoQuadrado(double a) => a * a;

    /// <summary>
    /// Define a operação que ficará pendente aguardando o segundo operando.
    /// Se já houver uma operação pendente, calcula o resultado parcial com o
    /// operando atual antes de trocar de operação (permite contas encadeadas).
    /// </summary>
    public double DefinirOperacaoPendente(double operandoAtual, Operacao operacao)
    {
        double resultado = PossuiOperacaoPendente
            ? Executar(_operandoAnterior, operandoAtual, _operacaoPendente)
            : operandoAtual;

        _operandoAnterior = resultado;
        _operacaoPendente = operacao;
        PossuiOperacaoPendente = true;

        return resultado;
    }

    /// <summary>
    /// Troca apenas a operação pendente, sem recalcular nada. Usado quando o
    /// usuário aperta um novo operador antes de digitar o segundo número.
    /// </summary>
    public void SubstituirOperacaoPendente(Operacao operacao)
    {
        if (PossuiOperacaoPendente)
        {
            _operacaoPendente = operacao;
        }
    }

    /// <summary>
    /// Calcula o resultado final com o segundo operando informado. Se não
    /// houver operação pendente (botão = pressionado repetidamente), repete
    /// a última operação realizada com o mesmo segundo operando de antes.
    /// </summary>
    public double CalcularResultado(double segundoOperando)
    {
        double resultado;

        if (PossuiOperacaoPendente)
        {
            resultado = Executar(_operandoAnterior, segundoOperando, _operacaoPendente);
            _operacaoParaRepeticao = _operacaoPendente;
            _operandoParaRepeticao = segundoOperando;
        }
        else if (_operacaoParaRepeticao != Operacao.Nenhuma)
        {
            resultado = Executar(segundoOperando, _operandoParaRepeticao, _operacaoParaRepeticao);
        }
        else
        {
            resultado = segundoOperando;
        }

        _operandoAnterior = resultado;
        _operacaoPendente = Operacao.Nenhuma;
        PossuiOperacaoPendente = false;

        return resultado;
    }

    /// <summary>Limpa todo o estado da conta em andamento (botão C). A memória não é afetada.</summary>
    public void LimparEstado()
    {
        _operandoAnterior = 0;
        _operandoParaRepeticao = 0;
        _operacaoPendente = Operacao.Nenhuma;
        _operacaoParaRepeticao = Operacao.Nenhuma;
        PossuiOperacaoPendente = false;
    }

    private double Executar(double a, double b, Operacao operacao) => operacao switch
    {
        Operacao.Soma => Somar(a, b),
        Operacao.Subtracao => Subtrair(a, b),
        Operacao.Multiplicacao => Multiplicar(a, b),
        Operacao.Divisao => Dividir(a, b),
        Operacao.Potencia => Potencia(a, b),
        _ => b
    };
}
