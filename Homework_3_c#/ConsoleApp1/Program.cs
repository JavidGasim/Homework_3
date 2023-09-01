using ConsoleApp1;

//Task1

//Pointer pointer = new Pointer(1,4);

//pointer.showData();

//----------------------------------------

//Task2

//Counter counter = new Counter(0, 10, 4);

//counter.increment();
//counter.decrement();

//----------------------------------------

//Task3



while (true)
{
    Console.WriteLine("1)Toplama");
    Console.WriteLine("2)Cixma");
    Console.WriteLine("3)Vurma");
    Console.WriteLine("4)Bolme");

    Console.Write("Seciminizi edin: ");
    string secim_ = Console.ReadLine();

    int secim = Convert.ToInt32(secim_);

    Console.Write("Num1: ");
    string num1_ = Console.ReadLine();

    Console.Write("Num2: ");
    string num2_ = Console.ReadLine();

    double num1 = Convert.ToDouble(num1_);
    double num2 = Convert.ToDouble(num2_);

    if (secim == 1)
    {
        Calc calc = new Calc(num1, num2);
        calc.Toplama();
    }

    else if (secim == 2)
    {
        Calc calc = new Calc(num1, num2);
        calc.Cixma();
    }

    else if (secim == 3)
    {
        Calc calc = new Calc(num1, num2);
        calc.Vurma();
    }

    else if (secim == 4)
    {
        Calc calc = new Calc(num1, num2);
        calc.Bolme();
    }

    else
    {
        Console.WriteLine("Yanlis secim");
    }
}