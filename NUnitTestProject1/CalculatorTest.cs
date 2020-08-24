


using NUnit.Framework;
using NUnit.Framework.Internal; 

public class CalculatorTest
{
    [Test]
    public void calcMultNegativeNumber()
    {
        Calculator calc = new Calculator();
        Assert.AreEqual(1.21, calc.Multiplication(-1.1, -1.1), 1.0E-4, "��� ��������� ������������� ����� �������� �������������");
    }
    [Test]
    public void calcMultNegativeNumberToPositive()
    {
        Calculator calc = new Calculator();
        Assert.AreEqual(-1.21, calc.Multiplication(-1.1, 1.1), 1.0E-4, "��� ��������� �������������� ����� �� ������������� �������� �������������");
    }
    [Test]
    public void calcMultPositiveNumber()
    {
        Calculator calc = new Calculator();
        Assert.AreEqual(1.21, calc.Multiplication(1.1, 1.1), 1.0E-4, "��� ��������� ������������� ����� �������� �������������");
    }
    [Test]
    public void calcMultNumberByZero()
    {
        Calculator calc = new Calculator();
        Assert.AreEqual(0, calc.Multiplication(0, 1.1), 1.0E-4, "��� ��������� �� 0 �������� 0");
    }
    [Test]
    public void calcAddNumberByZero()
    {
        Calculator calc = new Calculator();
        Assert.AreEqual(1.1, calc.Addition(0, 1.1), 1.0E-4, "��� �������� ����� � 0 �������� �� �� �����");
    }
    [Test]
    public void calcSubZeroFromNumber()
    {
        Calculator calc = new Calculator();
        Assert.AreEqual(1.1, calc.Subtraction(1.1, 0), 1.0E-4, "��� ��������� ���� �� ����� �������� �� �� �����");
    }
    [Test]
    public void calcSubNumberFromZero()
    {
        Calculator calc = new Calculator();
        Assert.AreEqual(-1.1, calc.Subtraction(0, 1.1), 1.0E-4, "��� ��������� ����� �� ���� �������� �� �� ����� � �������");
    }
    [Test]
    public void calcDivZeroByNumber()
    {
        Calculator calc = new Calculator();
        Assert.AreEqual(0, calc.Division(0, 1.1), 1.0E-4, "��� ������� ����� 0 �� ������ ����� �������� 0");
    }
    [Test]
    public void calcDivNegativeNumber()
    {
        Calculator calc = new Calculator();
        Assert.AreEqual(1, calc.Division(-1.1, -1.1), 1.0E-4, "��� ������� ������������� ����� �������� �������������");
    }
    [Test]
    public void calcDivNegativeNumberToPositive()
    {
        Calculator calc = new Calculator();
        Assert.AreEqual(-1, calc.Division(-1.1, 1.1), 1.0E-4, "��� ������� �������������� ����� �� ������������� �������� �������������");
    }
    [Test]
    public void calcDivPositiveNumber()
    {
        Calculator calc = new Calculator();
        Assert.AreEqual(1, calc.Division(1.1, 1.1), 1.0E-4, "��� ������� ������������� ����� �������� �������������");
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
