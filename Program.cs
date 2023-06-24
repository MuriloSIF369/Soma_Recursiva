Function math = new Function();
Console.Write("Número da soma: ");
double number = Convert.ToInt32(Console.ReadLine());

double result = math.Sum(number);

Console.Write($"Número somado: {result}");
public class Function
{
    public double Sum(double number)
    {
        if (number == 1)
            return number;

        return (2 * number - 1) + Sum(number - 1);
    }
}