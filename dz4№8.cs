Console.Clear();
Console.WriteLine("Введите число");
int numberN = int.Parse (Console.ReadLine());
int numberX = 1;
while (numberX <= numberN)
{
    if (numberX%2 == 0) 
    {
        Console.WriteLine(numberX);
    }
    numberX = numberX + 1;
}