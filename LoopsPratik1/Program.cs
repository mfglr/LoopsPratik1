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
