using Calculator;
using Xunit;

namespace Calculator.Tests;

public class MathServiceTests
{
    private readonly MathService _service = new();

    [Fact]
    public void Add_ReturnsCorrectSum()
    {
        var result = _service.Add(2, 3);
        Assert.Equal(5, result);
    }

    [Fact]
    public void Divide_ByZero_ThrowsException()
    {
        Assert.Throws<DivideByZeroException>(() => _service.Divide(10, 0));
    }
}
