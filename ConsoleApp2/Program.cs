

while (true)
{
    Console.Clear();
    Console.WriteLine("=== Калькулятор ===");
    Console.WriteLine("1. Сложение");
    Console.WriteLine("2. Вычитание");
    Console.WriteLine("3. Умножение");
    Console.WriteLine("4. Деление");
    Console.WriteLine("5. Возведение в степень");
    Console.WriteLine("6. Корень");
    Console.WriteLine("7. Процент");
    Console.WriteLine("8. log");
    Console.WriteLine("9. sin");
    Console.WriteLine("10. ctg");
    Console.WriteLine("0. Выход");
    Console.Write("Выберите операцию: ");

    string choice = Console.ReadLine();
    if (choice == "0") break;

    Console.Write("Введите первое число: ");
    double a = double.Parse(Console.ReadLine());

    double b = 0;
    if (choice != "6" && choice != "8" && choice != "9" && choice != "10")
    {
        Console.Write("Введите второе число: ");
        b = double.Parse(Console.ReadLine());
    }

    double result = 0;

    switch (choice)
    {
        case "1": result = a + b; break;
        case "2": result = b - a; break;
        case "3": result = a * b; break;
        case "4": result = a / b; break;
        case "5": result = Math.Pow(a, b); break;
        case "6": result = Math.Sqrt(a); break;
        case "7": result = a * b / 100; break;
        case "8": result = Math.Log(a); break;
        case "9": result = Math.Sin(a); break;
        case "10": result = Math.Cos(a) / Math.Sin(a); break;
        default:
            Console.WriteLine("Неизвестная операция");
            continue;
    }

    Console.WriteLine("Результат: " + result);
    Console.WriteLine("Нажмите Enter для продолжения...");
    Console.ReadLine();
}
  
