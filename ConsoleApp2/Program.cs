using System;
public abstract class Fiqur
{
    public abstract void Sahə();
}
public class Düzbucaqlı : Fiqur
{
    public double Uzunluq { get; set; }
    public double En { get; set; }
    public Düzbucaqlı(double uzunluq, double en)
    {
        Uzunluq = uzunluq;
        En = en;
    }
    public override void Sahə()
    {
        double sahə = Uzunluq * En;
        Console.WriteLine("Düzbucaqlının sahəsi: " + sahə);
    }
}
public class Kvadrat : Fiqur
{
    public double TərəfUzunluğu { get; set; }
    public Kvadrat(double tərəfUzunluğu)
    {
        TərəfUzunluğu = tərəfUzunluğu;
    }
    public override void Sahə()
    {
        double sahə = TərəfUzunluğu * TərəfUzunluğu;
        Console.WriteLine("Kvadratın sahəsi: " + sahə);
    }
}
class Program
{
    static void Main()
    {
        Düzbucaqlı düzbucaqlı = new Düzbucaqlı(5, 3);
        Kvadrat kvadrat = new Kvadrat(4);
        düzbucaqlı.Sahə();
        kvadrat.Sahə();
    }
}