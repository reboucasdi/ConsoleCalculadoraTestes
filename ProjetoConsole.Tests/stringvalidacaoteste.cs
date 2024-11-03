using ProjetoConsole;
using Xunit;

public class StringHelperTests
{
    private readonly StringHelper _stringHelper = new StringHelper();

    [Fact]
    public void ContarCaracteres_DeveRetornarQuantidadeCorreta()
    {
        string texto = "hello";
        int resultadoEsperado = 5;
        var resultado = _stringHelper.ContarCaracteres(texto);
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void ContemTexto_DeveRetornarTrueSeTextoContemTermo()
    {
        string texto = "hello world";
        string termo = "world";
        Assert.True(_stringHelper.ContemTexto(texto, termo));
    }

    [Fact]
    public void ContemTexto_DeveRetornarFalseSeTextoNaoContemTermo()
    {
        string texto = "hello world";
        string termo = "planet";
        Assert.False(_stringHelper.ContemTexto(texto, termo));
    }

    [Fact]
    public void InverterTexto_DeveRetornarTextoInvertido()
    {
        string texto = "abcd";
        string resultadoEsperado = "dcba";
        var resultado = _stringHelper.InverterTexto(texto);
        Assert.Equal(resultadoEsperado, resultado);
    }
}
