
public class CalculatorOperation
{
    public enum CalcOperation
    {
        Addition, Subtraction, Multiplication, Division, Unknown, EXIT
    }


    public static CalcOperation parse(string s) {
    if (s == null || "".Equals(s)) return CalcOperation.Unknown;
    else if ("+".Equals(s)) return CalcOperation.Addition;
        else if ("-".Equals(s)) return CalcOperation.Subtraction;
        else if ("*".Equals(s)) return CalcOperation.Multiplication;
        else if ("/".Equals(s)) return CalcOperation.Division;
        else if ("e".Equals(s)) return CalcOperation.EXIT;
    else return CalcOperation.Unknown;
}

}