int counter = 0;
//while (counter < 10)
//{
//    Console.WriteLine(counter);
//    counter++;
//}

//counter = 0;
//while (counter < 10)
//{
//    Console.WriteLine(counter);   
//}

counter = 0;
while (counter < 0)
{
    Console.WriteLine("while");
    Console.WriteLine(counter);
    counter++;
}

counter = 0;
do
{
    Console.WriteLine("do while");
    Console.WriteLine(counter);
    counter++;
}
while (counter < 10);

//ciclo for
for (int i = 5; i <= 100; i = i + 5)
{
    Console.WriteLine(i);
}

for (int i = 5; i <= 100; i = i + 5)
{
    Console.WriteLine(i);
    if (i == 50) break;
}

foreach (var character in "Stranger Things")
{
    Console.WriteLine(character);
    if (character == ' ') break;
}

for (int i = 1; i <= 10; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine("**************");
}

for (int i = 1; i < 10; i++) Console.WriteLine(i);
