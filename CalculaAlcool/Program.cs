internal class Program
{
    private static void Main(string[] args)
    {
        float pAlcool, pGasolina;

        Console.WriteLine("Digite o preço do álcool: ");
        pAlcool = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite o preço da gasolina: ");
        pGasolina = float.Parse(Console.ReadLine());

        if ((pAlcool/pGasolina) < 0.72) 
        {
            Console.WriteLine("O álcool esta mais em conta");
        } else { 
            Console.WriteLine("A gasolina está mais em conta"); 
        }
    }
}