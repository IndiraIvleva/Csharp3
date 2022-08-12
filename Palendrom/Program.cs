Console.WriteLine("Введите 5-значное число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 10000 || n > 99999)
{
    Console.WriteLine("Число не является пятизначным");
}
else
{
    Console.WriteLine("Найдем обратное число");
    int b = n;
    int c = 0;

    while (b > 0)
    {
        c = c * 10 + (b % 10);
        b = b / 10;
    }
    Console.WriteLine($"Обратное число: {c}");
    string answer = (n == c) ? "Это палендром" : "Это не палендром";
    Console.WriteLine(answer);
}