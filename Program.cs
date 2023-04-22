// See https://aka.ms/new-console-template for more information

Menu();

static void Menu()
{
    Console.Clear();
    Console.WriteLine("O que deseja fazer?");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Divisão");
    Console.WriteLine("4 - Multiplicação");
    Console.WriteLine("5 - Sair");
    Console.WriteLine("-------------------");
    Console.WriteLine("Selecione uma opção:");
    short res = short.Parse(Console.ReadLine());

    switch(res) {
        case 1: Sum(); break;
        case 2: Subtraction(); break;
        case 3: Division(); break;
        case 4: Multiplication(); break;
        case 5: System.Environment.Exit(0); break;
        default: Menu(); break;
    }
}

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
    Menu();
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
    Menu();
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
    Menu();
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
    Menu();
}