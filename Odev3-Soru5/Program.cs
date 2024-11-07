// See https://aka.ms/new-console-template for more information
Random  rnd = new Random();
int number = rnd.Next(1,20);
Console.WriteLine("1 ile 20 arasında tutulan bir sayıyı tahmin edin.");
int tahmin = int.Parse(Console.ReadLine());
if (tahmin == number)
{
    Console.WriteLine("Tebrikler doğru tahmin");
}
else
{
    do
    {
        Console.WriteLine("Yanlış tahmin ettiniz. Tekrar bir sayı giriniz:");
        tahmin = int.Parse(Console.ReadLine());


    } while (tahmin != number);
    Console.WriteLine("Tebrikler doğru tahmin");

}
Console.ReadKey();