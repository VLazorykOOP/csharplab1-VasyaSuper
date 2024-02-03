// See https://aka.ms/new-console-template for more information

 static void task1()
{
    Console.WriteLine("Написати програму, яка обчислює: периметр трикутника, заданого координатами вершин x1, y1, x2, y2, x3, y3 ");
    Console.WriteLine("Задайте координати А(x1, y1), B(x2, y2), C(x3, y3) : ");
    //-3 -3 3 -3 3 5

    // Зчитування координат від користувача
    double[] arr = new double[6];
    for (int i = 0; i < arr.Length; ++i)
    {
        arr[i] = Convert.ToDouble(Console.ReadLine());
    }

    // Обчислення відстаней між вершинами
    double AB = Math.Sqrt(Math.Pow(arr[2] - arr[0], 2) + Math.Pow(arr[3] - arr[1], 2));
    double BC = Math.Sqrt(Math.Pow(arr[4] - arr[2], 2) + Math.Pow(arr[5] - arr[3], 2));
    double AC = Math.Sqrt(Math.Pow(arr[4] - arr[0], 2) + Math.Pow(arr[5] - arr[1], 2));

    if (AB + BC > AC && AB + AC > BC && AC + BC > AB)
    {
        // Обчислення периметра
        double perimeter = AB + BC + AC;

        // Виведення результату
        Console.WriteLine("Perimeter = " + perimeter);
    }
    else
    {
        Console.WriteLine("Введені точки не утворюють трикутника.");
    }
}
static void task2()
{
    Console.WriteLine("Написати програму, яка визначає: чи кратна трьом сума цифр двозначного числа ");
    Console.WriteLine("Введіть двозначне число:");
    string input = Console.ReadLine();

    if (int.TryParse(input, out int number))
    {
        // Перевірка, чи число є двозначним
        if (number >= 10 && number <= 99)
        {
            // Отримуємо цифри числа
            int digit_1 = number / 10;
            int digit_2 = number % 10;

            // Обчислюємо суму цифр
            int sum = digit_1 + digit_2;

            // Перевіряємо, чи сума кратна трьом
            if (sum % 3 == 0)
            {
                Console.WriteLine($"Сума цифр числа {number} кратна трьом.");
            }
            else
            {
                Console.WriteLine($"Сума цифр числа {number} не кратна трьом.");
            }
        }
        else
        {
            Console.WriteLine("Число не є двозначним ");
        }
    }
    else
    {
        Console.WriteLine("Введено невірне знaчення ");
    }
}
static void task3()
{
    Console.WriteLine("Написати програму, яка визначає: чи входить наша точка в заштриховану область, чи нi, чи на межi знаходиться ");

    double x, y;
    char key;

    do
    {
        Console.WriteLine("Введiть значення x : ");
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введiть значення y: ");
        y = Convert.ToDouble(Console.ReadLine());

        if (x >= -50.0 && x <= 50.0 && y >= -25.0 && y <= 25.0)
        {
            if ((y >= -25.0 && y <= 25.0 && (x == 50.0 || x == -50.0)) || (x >= -50.0 && x <= 50.0 && (y == 25.0 || y == -25.0)))
            {
                Console.WriteLine("На межi");
            }
            else
            {
                Console.WriteLine("Так");
            }
        }
        else
        {
            Console.WriteLine("Нi");
        }

        Console.WriteLine("Натиснiть 'q', щоб вийти, або будь-яку iншу клавiшу, щоб продовжити:");
        key = Console.ReadKey().KeyChar;
    }      
    while (key != 'q');
}
static void task4()
{
    Console.WriteLine("написати програму: дано цiлi числа n > 0 та m > 0. З 1 сiчня 1990 року по деякий день пройшло m мiсяцiв i n днiв, визначити назву поточного мiсяця ");

    Console.WriteLine("Введiть значення m (кiлькiсть мiсяцiв): ");
    string m = Console.ReadLine();
    Console.WriteLine("Введiть значення n (кiлькiсть днiв): ");
    string n = Console.ReadLine();

    int number1, number2;

    if (int.TryParse(m, out number1) && int.TryParse(n, out number2))
    {
        DateTime startDate = new DateTime(1990, 1, 1);

        DateTime currentDate = startDate.AddMonths(number1).AddDays(number2);

        Console.WriteLine($"Поточний мiсяць: {currentDate.ToString("MMMM")}");
    }
    else
    {
        Console.WriteLine("Введенi значення не є цiлими числами.");
    }
}
static int theSquareOfTheProductOfTwoIntegers(int n, int m)
{
    return (int)Math.Pow(n * m, 2);
}
static void task5()
{
    Console.WriteLine("Реалізувати функцію піднесення у квадрат добутку двох цілих чисел ");

    Console.WriteLine("Введiть значення n: ");
    string n = Console.ReadLine();
    Console.WriteLine("Введiть значення m: ");
    string m = Console.ReadLine();

    int number1, number2;

    // Перевірка, чи можна перетворити введені значення на цілі числа
    if (int.TryParse(n, out number1) && int.TryParse(m, out number2))
    {
        int result = theSquareOfTheProductOfTwoIntegers(number1, number2);
        Console.WriteLine($"Квадрат добутку чисел {number1} та {number2} дорiвнює {result}");
    }
    else
    {
        Console.WriteLine("Введенi значення не є цiлими числами.");
    }
}
static void task6()
{
    Console.WriteLine("Написати програму, яка визначає: за введеними з клавіатури значеннями обчислити та вивести на екран значення виразу ");

    double res;

    Console.WriteLine("Введiть значення x: ");
    string x = Console.ReadLine();
    Console.WriteLine("Введiть значення y: ");
    string y = Console.ReadLine();

    float number1, number2;

    // Перевірка, чи можна перетворити введені значення на цілі числа
    if (float.TryParse(x, out number1) && float.TryParse(y, out number2))
    {
        res = ((number1 * Math.Pow(number2, 2) + Math.Pow(number1, 2) * number2) / (number1 * number2 + 1)) * (number1 - number2);

        Console.WriteLine($"Отже, наше значення виразу = {res}");
    }
    else
    {
        Console.WriteLine("Введенi значення не є цiлими числами.");
    }
}
Console.WriteLine("Lab 1!");
Console.WriteLine("Оберiть завдання від 1 до 6:");
int taskNumber = int.Parse(Console.ReadLine());

switch (taskNumber)
{
    case 1:
        task1();
        break;
    case 2:
        task2();
        break;
    case 3:
        task3();
        break;
    case 4:
        task4();
        break;
    case 5:
        task5();
        break;
    case 6:
        task6();
        break;
    default:
        Console.WriteLine("Такого значення немає ");
        break;
}
