string separator = "\n***************************************************************\n";

//first step
for (int i = 0; i < 10; i++)
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");

Console.WriteLine(separator);

//second step
for (int i = 1; i <= 20; i++)
    Console.WriteLine(i);

Console.WriteLine(separator);

//third step
for (int i = 1; i <= 20; i++)
    if(i % 2 == 0)
        Console.WriteLine(i);

Console.WriteLine(separator);

//fourth step

int sum = 0;
for (int i = 50; i <= 150; i++)
    sum += i;
Console.WriteLine(sum);

Console.WriteLine(separator);

//fifth step
int sumOfEvenNumbers = 0, sumOfOddNumbers = 0;
for (int i = 1; i <= 120; i++)
    if (i % 2 == 0)
        sumOfEvenNumbers += i;
    else
        sumOfOddNumbers += i;

Console.WriteLine($"Çift sayıların toplamı: {sumOfEvenNumbers}");
Console.WriteLine($"Tek sayıların toplamı: {sumOfOddNumbers}");