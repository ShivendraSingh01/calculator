namespace Calculator;

public class MathService
{
    public int Add(int a, int b) => a + b;

    public int Divide(int a, int b)
    {
        if (b == 0)
            throw new DivideByZeroException();

        return a / b;
    }
}
