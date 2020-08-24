
using System;

public class CalculatorInterface : CalculatorOperation {
    private Calculator calculator;

    public CalculatorInterface() {
        calculator = new Calculator();
    }

    public void make() {
        CalcOperation currentOperation;
            while (true) {
                Console.Out.WriteLine("Введите тип операции (+,-,/,*) для вычисления. Для выхода нажмите 'e':");
                string operation = Console.In.ReadLine();
                currentOperation = parse(operation);

                if (currentOperation == CalcOperation.Unknown)
                {
                    Console.Out.WriteLine("Операция введена некорректно!");
                } else if (currentOperation == CalcOperation.EXIT) {
                    break;
                }
                else
                {
                    bool inputCorrect;
                    double a = 0;
                    double b = 0;
                    inputCorrect = false;
                    while (!inputCorrect) {
                        Console.Out.WriteLine("Введите первое число:");
                        string inputA = Console.In.ReadLine();
                        try {
                            a = Double.Parse(inputA);
                            inputCorrect = true;
                        } catch (Exception) {
                            Console.Out.WriteLine("Можно вводить только числа!");
                        }
                    }
                    inputCorrect = false;
                    while (!inputCorrect) {
                        Console.Out.WriteLine("Введите второе число:");
                        string inputB = Console.In.ReadLine();
                        try {
                            b = Double.Parse(inputB);//Double.TryParse(inputB, out b)
                        } catch (Exception) {
                            Console.Out.WriteLine("Можно вводить только числа!");
                            continue;
                        }
                        inputCorrect = true;
                    }
                    string result;
                    switch (currentOperation) {
                        case CalcOperation.Addition:
                            result = string.Format("{0:f4}", calculator.Addition(a, b));
                            Console.Out.Write(a + " " + "+" + " " + b + " = " + result + "\n");
                            break;
                        case CalcOperation.Subtraction:
                            result = string.Format("{0:f4}", calculator.Subtraction(a, b));
                            Console.Out.Write(a + " " + "-" + " " + b + " = " + result + "\n");
                            break;
                        case CalcOperation.Multiplication:
                            result = string.Format("{0:f4}", calculator.Multiplication(a, b));
                            Console.Out.Write(a + " " + "*" + " " + b + "= " + result + "\n");
                            break;
                        case CalcOperation.Division:
                            result = string.Format("{0:f4}", calculator.Division(a, b));
                            Console.Out.Write(a + " " + "/" + " " + b + "= " + result + "\n");
                            break;
                    }
                }
            }
    }
}