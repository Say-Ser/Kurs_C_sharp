


using NUnit.Framework;
using NUnit.Framework.Internal; 

public class CalculatorTest
{
    [Test]
    public void calcMultNegativeNumber()
    {
        Calculator calc = new Calculator();
        Assert.AreEqual(1.21, calc.Multiplication(-1.1, -1.1), 1.0E-4, "При умножении отрицательных чисел получаем положительное");
    }
    [Test]
    public void calcMultNegativeNumberToPositive()
    {
        Calculator calc = new Calculator();
        Assert.AreEqual(-1.21, calc.Multiplication(-1.1, 1.1), 1.0E-4, "При умножении отрицательного числа на положительное получаем отрицательное");
    }
    [Test]
    public void calcMultPositiveNumber()
    {
        Calculator calc = new Calculator();
        Assert.AreEqual(1.21, calc.Multiplication(1.1, 1.1), 1.0E-4, "При умножении положительных чисел получаем положительное");
    }
    [Test]
    public void calcMultNumberByZero()
    {
        Calculator calc = new Calculator();
        Assert.AreEqual(0, calc.Multiplication(0, 1.1), 1.0E-4, "При умножении на 0 получаем 0");
    }
    [Test]
    public void calcAddNumberByZero()
    {
        Calculator calc = new Calculator();
        Assert.AreEqual(1.1, calc.Addition(0, 1.1), 1.0E-4, "При сложении числа с 0 получаем то же число");
    }
    [Test]
    public void calcSubZeroFromNumber()
    {
        Calculator calc = new Calculator();
        Assert.AreEqual(1.1, calc.Subtraction(1.1, 0), 1.0E-4, "При вычитании нуля из числа получаем то же число");
    }
    [Test]
    public void calcSubNumberFromZero()
    {
        Calculator calc = new Calculator();
        Assert.AreEqual(-1.1, calc.Subtraction(0, 1.1), 1.0E-4, "При вычитании числа из нуля получаем то же число с минусом");
    }
    [Test]
    public void calcDivZeroByNumber()
    {
        Calculator calc = new Calculator();
        Assert.AreEqual(0, calc.Division(0, 1.1), 1.0E-4, "При делении числа 0 на другое число получаем 0");
    }
    [Test]
    public void calcDivNegativeNumber()
    {
        Calculator calc = new Calculator();
        Assert.AreEqual(1, calc.Division(-1.1, -1.1), 1.0E-4, "При делении отрицательных чисел получаем положительное");
    }
    [Test]
    public void calcDivNegativeNumberToPositive()
    {
        Calculator calc = new Calculator();
        Assert.AreEqual(-1, calc.Division(-1.1, 1.1), 1.0E-4, "При делении отрицательного числа на положительное получаем отрицательное");
    }
    [Test]
    public void calcDivPositiveNumber()
    {
        Calculator calc = new Calculator();
        Assert.AreEqual(1, calc.Division(1.1, 1.1), 1.0E-4, "При делении положительных чисел получаем положительное");
    }
    [Test]
    public void calcDivPositiveNumberByZero()
    {
        Calculator calc = new Calculator();
        Assert.AreEqual(calc.Division(1.1, 0), double.PositiveInfinity, 1.0E-4);
    }
    [Test]
    public void calcNegativePositiveNumberByZero()
    {
        Calculator calc = new Calculator();
        Assert.AreEqual(calc.Division(-1.1, 0), double.NegativeInfinity, 1.0E-4);
    }

}
