// See https://aka.ms/new-console-template for more information

Sum();
Subtraction();
Division();
Multiplication();

static void Sum()
{
    Console.Clear();

    Console.WriteLine("Digite o primeiro valor:");
    float valueOne = float.Parse(Console.ReadLine());

    Console.WriteLine("");
    
    Console.WriteLine("Digite o segundo valor:");
    float valueTwo = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float result = valueOne + valueTwo;
    // Console.WriteLine("O resultado da soma é " + result);
    Console.WriteLine($"O resultado da soma é {result}");
    Console.ReadKey();
}

static void Subtraction()
{
    Console.Clear();

    Console.WriteLine("Digite o primeiro valor:");
    float valueOne = float.Parse(Console.ReadLine());

    Console.WriteLine("");
    
    Console.WriteLine("Digite o segundo valor:");
    float valueTwo = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float result = valueOne - valueTwo;
    // Console.WriteLine("O resultado da soma é " + result);
    Console.WriteLine($"O resultado da subtração é {result}");
    Console.ReadKey();
}

static void Division()
{
    Console.Clear();

    Console.WriteLine("Digite o primeiro valor:");
    float valueOne = float.Parse(Console.ReadLine());

    Console.WriteLine("");
    
    Console.WriteLine("Digite o segundo valor:");
    float valueTwo = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float result = valueOne / valueTwo;
    // Console.WriteLine("O resultado da soma é " + result);
    Console.WriteLine($"O resultado da divisão é {result}");
    Console.ReadKey();
}

static void Multiplication()
{
    Console.Clear();

    Console.WriteLine("Digite o primeiro valor:");
    float valueOne = float.Parse(Console.ReadLine());

    Console.WriteLine("");
    
    Console.WriteLine("Digite o segundo valor:");
    float valueTwo = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float result = valueOne * valueTwo;
    // Console.WriteLine("O resultado da soma é " + result);
    Console.WriteLine($"O resultado da multiplicação é {result}");
    Console.ReadKey();
}