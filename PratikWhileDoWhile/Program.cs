//While ile yapılmış hali
Console.WriteLine("Lütfen bir değer giriniz: ");
int limit = Convert.ToInt32(Console.ReadLine());
int sayac = 0;

Console.WriteLine();
Console.WriteLine("While");

while (sayac <= limit - 1)
{
    Console.WriteLine("Ben bir Patika'lıyım");
    sayac++;
}

//Do-While ile yapılmış hali
Console.WriteLine();
Console.WriteLine("Do-While");

sayac = 0;
do
{
    Console.WriteLine("Ben bir Patika'lıyım");
    sayac++;
} while (sayac <= limit - 1);