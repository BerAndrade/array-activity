class Program

{

    static void vetor(double[] num)
    {
        for (int i = 0; i <= 9; i++)
        {
            Console.Write("digite um numero real :");
            num[i] = double.Parse(Console.ReadLine());
        }
    }

    static void numero(double[] num)
    {
        for (int i = 0; i <= 9; i++)
        {
            if (num[i] % 2 == 0)
            {
                double par = num[i] * 2;
                Console.WriteLine($"numero {num[i]} par = {par}");
            }
            else
            {
                double impar = num[i] + 2;
                Console.WriteLine($"numero {num[i]} impar = {impar}");
            }
        }
           
    }
    static void Main(string[] args)
    {
        double[] num = new double[10];
        Console.WriteLine("Atividade 1 - Questão 2");
        vetor(num);
        numero(num);
    }
} 

