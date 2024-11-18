using Calculadora.Services;

namespace CalculadoraTestes;


public class CalculadoraTestes
{
    private CalculadoraService _calculadora = new();
    
    [Fact]
    public void TesteSomaInteiros()
    {
        // Arrange
        int x = 5; int y = 10;

        // Act
        int resultado = _calculadora.SomarInteiros(x, y);

        // Assert
        Assert.Equal(15, resultado);
    }

    [Fact]
    public void TesteSubtracaoInteiros()
    {
        // Arrange
        int x = 5; int y = 10;

        // Act
        int resultado = _calculadora.SubtrairInteiros(x, y);

        // Assert
        Assert.Equal(-5, resultado);
    }

    [Fact]
    public void TesteMultiplicacaoInteiros()
    {
        // Arrange
        int x = 5; int y = 10;

        // Act
        int resultado = _calculadora.MultiplicarInteiros(x, y);

        // Assert
        Assert.Equal(50, resultado);
    }

    [Fact]
    public void TesteDivisaoInteiros()
    {
        // Arrange
        int x = 5; int y = 9;

        // Act
        int resultado = _calculadora.DividirInteiros(x, y);

        // Assert
        Assert.Equal(1, resultado);
    }
    [Fact]
    public void TesteDivisaoPorZero()
    {
        // Arrange
        int x = 5; int y = 0;

        // Act
        int resultado = _calculadora.DividirInteiros(x, y);

        // Assert
        Assert.Equal(0, resultado);
    }

    [Fact]
    public void TesteHistorico()
    {
        // Arrange
        int x = 5; int y = 0;

        // Act
        _calculadora.SomarInteiros(x, y);
        _calculadora.SomarInteiros(x, y);
        _calculadora.SomarInteiros(x, y);
        _calculadora.SomarInteiros(x, y);

        var historico = _calculadora.Historico();
        int resultado = historico.Count;

        // Assert
        Assert.Equal(3, resultado);
    }
}