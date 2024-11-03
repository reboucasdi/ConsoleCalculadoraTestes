using ProjetoConsole;
using Xunit;

public class CalculadoraTests
{
    private readonly Calculadora _calculadora = new Calculadora();

    [Fact]
    public void Somar_DeveRetornarSomaDosNumeros()
    {
        // Arrange
        int a = 3, b = 2, resultadoEsperado = 5;

        // Act
        var resultado = _calculadora.Somar(a, b);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void Subtrair_DeveRetornarSubtracaoDosNumeros()
    {
        int a = 3, b = 2, resultadoEsperado = 1;
        var resultado = _calculadora.Subtrair(a, b);
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void Multiplicar_DeveRetornarMultiplicacaoDosNumeros()
    {
        int a = 3, b = 2, resultadoEsperado = 6;
        var resultado = _calculadora.Multiplicar(a, b);
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void Dividir_DeveRetornarDivisaoDosNumeros()
    {
        int a = 4, b = 2;
        double resultadoEsperado = 2;
        var resultado = _calculadora.Dividir(a, b);
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void Dividir_DeveLancarExcecaoQuandoDivisorForZero()
    {
        Assert.Throws<DivideByZeroException>(() => _calculadora.Dividir(4, 0));
    }
}