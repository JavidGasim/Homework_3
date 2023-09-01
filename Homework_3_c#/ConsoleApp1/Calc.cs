namespace ConsoleApp1;

internal class Calc
{
    public double num1 { get; set; }
    public double num2 { get; set; }
    public Calc()
    {
        
    }

    public Calc(double num1, double num2)
    {
        this.num1 = num1;
        this.num2 = num2;
    }

    public void Toplama()
    {
        double netice = num1 + num2;

        Console.WriteLine(num1 + "+" + num2 + "=" + netice);
    }

    public void Cixma()
    {
        double netice = num1 - num2;

        Console.WriteLine(num1 + "-" + num2 + "=" + netice);
    }

    public void Vurma()
    {
        double netice = num1 * num2;

        Console.WriteLine(num1 + "*" + num2 + "=" + netice);
    }

    public void Bolme()
    {
        double netice = num1 / num2;

        Console.WriteLine(num1 + "/" + num2 + "=" + netice);
    }
}
