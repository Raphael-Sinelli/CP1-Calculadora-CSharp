using System.Globalization;

namespace Calculadora;

/// <summary>
/// Tela principal da calculadora. Cuida apenas da interface e dos eventos
/// dos botões e do teclado, delegando toda a lógica matemática ao
/// <see cref="CalculadoraMotor"/> e o estado da memória à <see cref="Memoria"/>.
/// </summary>
public partial class FormCalculadora : Form
{
    private static readonly CultureInfo CulturaPtBr = CultureInfo.GetCultureInfo("pt-BR");
    private static readonly string SeparadorDecimal = CulturaPtBr.NumberFormat.NumberDecimalSeparator;

    private readonly CalculadoraMotor _motor = new();
    private readonly Memoria _memoria = new();

    private string _entradaAtual = "0";
    private string _historicoTexto = string.Empty;
    private bool _iniciarNovoNumero = true;
    private bool _erroAtivo;

    private readonly Font _fonteVisorNumero;
    private readonly Font _fonteVisorErro;

    public FormCalculadora()
    {
        InitializeComponent();
        _fonteVisorNumero = lblVisor.Font;
        _fonteVisorErro = new Font(_fonteVisorNumero.FontFamily, 15f, FontStyle.Regular);
        KeyDown += FormCalculadora_KeyDown;
        KeyPress += FormCalculadora_KeyPress;
    }

    protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
    {
        switch (keyData)
        {
            case Keys.Enter:
                ProcessarIgual();
                return true;
            case Keys.Escape:
                ProcessarLimpar();
                return true;
            case Keys.Back:
                ProcessarBackspace();
                return true;
            default:
                return base.ProcessCmdKey(ref msg, keyData);
        }
    }

    private void MenuItemSobre_Click(object? sender, EventArgs e)
    {
        using var formSobre = new FormSobre();
        formSobre.ShowDialog(this);
    }

    private void BotaoDigito_Click(object? sender, EventArgs e)
    {
        var botao = (Button)sender!;
        ProcessarDigito(botao.Text);
    }

    private void BotaoOperador_Click(object? sender, EventArgs e)
    {
        var botao = (Button)sender!;
        var operacao = (Operacao)botao.Tag!;
        ProcessarOperador(operacao);
    }

    private void BotaoIgual_Click(object? sender, EventArgs e) => ProcessarIgual();

    private void BotaoLimpar_Click(object? sender, EventArgs e) => ProcessarLimpar();

    private void BotaoBackspace_Click(object? sender, EventArgs e) => ProcessarBackspace();

    private void BotaoPontoDecimal_Click(object? sender, EventArgs e) => ProcessarPontoDecimal();

    private void BotaoInverterSinal_Click(object? sender, EventArgs e) => ProcessarInverterSinal();

    private void BotaoRaiz_Click(object? sender, EventArgs e) => ProcessarRaizQuadrada();

    private void BotaoPotencia_Click(object? sender, EventArgs e) => ProcessarOperador(Operacao.Potencia);

    private void BotaoQuadrado_Click(object? sender, EventArgs e) => ProcessarAoQuadrado();

    private void BotaoMC_Click(object? sender, EventArgs e)
    {
        _memoria.Limpar();
        AtualizarIndicadorMemoria();
    }

    private void BotaoMR_Click(object? sender, EventArgs e)
    {
        ReiniciarSeEmErro();
        _entradaAtual = FormatarNumero(_memoria.Recuperar());
        _iniciarNovoNumero = true;
        AtualizarVisor();
    }

    private void BotaoMMais_Click(object? sender, EventArgs e)
    {
        _memoria.Adicionar(ObterValorAtual());
        _iniciarNovoNumero = true;
        AtualizarIndicadorMemoria();
    }

    private void BotaoMMenos_Click(object? sender, EventArgs e)
    {
        _memoria.Subtrair(ObterValorAtual());
        _iniciarNovoNumero = true;
        AtualizarIndicadorMemoria();
    }

    private void FormCalculadora_KeyDown(object? sender, KeyEventArgs e)
    {
        if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
        {
            ProcessarDigito(((int)e.KeyCode - (int)Keys.D0).ToString(CulturaPtBr));
            e.SuppressKeyPress = true;
            return;
        }

        if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
        {
            ProcessarDigito(((int)e.KeyCode - (int)Keys.NumPad0).ToString(CulturaPtBr));
            e.SuppressKeyPress = true;
            return;
        }

        switch (e.KeyCode)
        {
            case Keys.Add:
                ProcessarOperador(Operacao.Soma);
                break;
            case Keys.Subtract:
                ProcessarOperador(Operacao.Subtracao);
                break;
            case Keys.Multiply:
                ProcessarOperador(Operacao.Multiplicacao);
                break;
            case Keys.Divide:
                ProcessarOperador(Operacao.Divisao);
                break;
            case Keys.Decimal:
                ProcessarPontoDecimal();
                break;
            default:
                return;
        }

        e.SuppressKeyPress = true;
    }

    private void FormCalculadora_KeyPress(object? sender, KeyPressEventArgs e)
    {
        switch (e.KeyChar)
        {
            case '+':
                ProcessarOperador(Operacao.Soma);
                break;
            case '-':
                ProcessarOperador(Operacao.Subtracao);
                break;
            case '*':
            case 'x':
            case 'X':
                ProcessarOperador(Operacao.Multiplicacao);
                break;
            case '/':
                ProcessarOperador(Operacao.Divisao);
                break;
            case '=':
                ProcessarIgual();
                break;
            case ',':
            case '.':
                ProcessarPontoDecimal();
                break;
            default:
                return;
        }

        e.Handled = true;
    }

    private void ProcessarDigito(string digito)
    {
        ReiniciarSeEmErro();

        if (_iniciarNovoNumero || _entradaAtual == "0")
        {
            _entradaAtual = digito;
            _iniciarNovoNumero = false;
        }
        else
        {
            _entradaAtual += digito;
        }

        AtualizarVisor();
    }

    private void ProcessarPontoDecimal()
    {
        ReiniciarSeEmErro();

        if (_iniciarNovoNumero)
        {
            _entradaAtual = "0" + SeparadorDecimal;
            _iniciarNovoNumero = false;
        }
        else if (!_entradaAtual.Contains(SeparadorDecimal))
        {
            _entradaAtual += SeparadorDecimal;
        }

        AtualizarVisor();
    }

    private void ProcessarOperador(Operacao operacao)
    {
        ReiniciarSeEmErro();

        double atual = ObterValorAtual();

        if (_iniciarNovoNumero && _motor.PossuiOperacaoPendente)
        {
            _motor.SubstituirOperacaoPendente(operacao);
        }
        else
        {
            double resultado = _motor.DefinirOperacaoPendente(atual, operacao);
            _entradaAtual = FormatarNumero(resultado);
            _historicoTexto = $"{_entradaAtual} {SimboloDe(operacao)}";
        }

        _iniciarNovoNumero = true;
        AtualizarVisor();
        AtualizarHistorico();
    }

    private void ProcessarIgual()
    {
        if (_erroAtivo)
        {
            ReiniciarSeEmErro();
            AtualizarVisor();
            return;
        }

        double atual = ObterValorAtual();
        bool tinhaPendente = _motor.PossuiOperacaoPendente;
        Operacao operacaoUsada = tinhaPendente ? _motor.OperacaoPendente : _motor.OperacaoParaRepeticao;
        double operandoRepeticaoAnterior = _motor.OperandoParaRepeticao;

        try
        {
            double resultado = _motor.CalcularResultado(atual);

            if (tinhaPendente)
            {
                _historicoTexto = $"{_historicoTexto} {FormatarNumero(atual)} =";
            }
            else if (operacaoUsada != Operacao.Nenhuma)
            {
                _historicoTexto =
                    $"{FormatarNumero(atual)} {SimboloDe(operacaoUsada)} {FormatarNumero(operandoRepeticaoAnterior)} =";
            }

            _entradaAtual = FormatarNumero(resultado);
            _iniciarNovoNumero = true;
            AtualizarVisor();
            AtualizarHistorico();
        }
        catch (Exception ex) when (ex is DivideByZeroException or ArgumentException)
        {
            MostrarErro(ex.Message);
        }
    }

    private void ProcessarRaizQuadrada()
    {
        ReiniciarSeEmErro();
        double atual = ObterValorAtual();

        try
        {
            double resultado = _motor.RaizQuadrada(atual);
            _historicoTexto = $"√({FormatarNumero(atual)}) =";
            _entradaAtual = FormatarNumero(resultado);
            _iniciarNovoNumero = true;
            AtualizarVisor();
            AtualizarHistorico();
        }
        catch (ArgumentException ex)
        {
            MostrarErro(ex.Message);
        }
    }

    private void ProcessarAoQuadrado()
    {
        ReiniciarSeEmErro();
        double atual = ObterValorAtual();
        double resultado = _motor.AoQuadrado(atual);

        _historicoTexto = $"({FormatarNumero(atual)})² =";
        _entradaAtual = FormatarNumero(resultado);
        _iniciarNovoNumero = true;
        AtualizarVisor();
        AtualizarHistorico();
    }

    private void ProcessarInverterSinal()
    {
        ReiniciarSeEmErro();

        if (_entradaAtual.StartsWith('-'))
        {
            _entradaAtual = _entradaAtual[1..];
        }
        else if (_entradaAtual != "0")
        {
            _entradaAtual = "-" + _entradaAtual;
        }

        AtualizarVisor();
    }

    private void ProcessarBackspace()
    {
        if (_erroAtivo)
        {
            ReiniciarSeEmErro();
            AtualizarVisor();
            return;
        }

        if (_iniciarNovoNumero)
        {
            return;
        }

        if (_entradaAtual.Length <= 1 || (_entradaAtual.Length == 2 && _entradaAtual[0] == '-'))
        {
            _entradaAtual = "0";
        }
        else
        {
            _entradaAtual = _entradaAtual[..^1];
        }

        AtualizarVisor();
    }

    private void ProcessarLimpar()
    {
        _erroAtivo = false;
        _entradaAtual = "0";
        _historicoTexto = string.Empty;
        _iniciarNovoNumero = true;
        _motor.LimparEstado();
        AtualizarVisor();
        AtualizarHistorico();
    }

    private void MostrarErro(string mensagem)
    {
        _entradaAtual = mensagem;
        _erroAtivo = true;
        _iniciarNovoNumero = true;
        _historicoTexto = string.Empty;
        _motor.LimparEstado();
        AtualizarVisor();
        AtualizarHistorico();
    }

    private void ReiniciarSeEmErro()
    {
        if (!_erroAtivo)
        {
            return;
        }

        _erroAtivo = false;
        _entradaAtual = "0";
        _historicoTexto = string.Empty;
        _iniciarNovoNumero = true;
    }

    private double ObterValorAtual()
    {
        string texto = _entradaAtual.TrimEnd(SeparadorDecimal[0]);

        if (texto.Length == 0 || texto == "-")
        {
            texto = "0";
        }

        return double.Parse(texto, NumberStyles.Float | NumberStyles.AllowLeadingSign, CulturaPtBr);
    }

    private static string FormatarNumero(double valor)
    {
        if (double.IsNaN(valor) || double.IsInfinity(valor))
        {
            return "Entrada inválida";
        }

        double arredondado = Math.Round(valor, 10, MidpointRounding.AwayFromZero);

        if (arredondado == 0)
        {
            arredondado = 0;
        }

        return arredondado.ToString("G15", CulturaPtBr);
    }

    private static string SimboloDe(Operacao operacao) => operacao switch
    {
        Operacao.Soma => "+",
        Operacao.Subtracao => "-",
        Operacao.Multiplicacao => "x",
        Operacao.Divisao => "/",
        Operacao.Potencia => "^",
        _ => string.Empty
    };

    private void AtualizarVisor()
    {
        lblVisor.Text = _entradaAtual;
        lblVisor.Font = _erroAtivo ? _fonteVisorErro : _fonteVisorNumero;
    }

    private void AtualizarHistorico()
    {
        lblHistorico.Text = _historicoTexto;
    }

    private void AtualizarIndicadorMemoria()
    {
        lblMemoriaIndicador.Visible = _memoria.TemValor;
    }
}
