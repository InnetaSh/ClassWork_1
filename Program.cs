using System.Data;
using System.Drawing;
using System.Net.Mail;
using System.Threading.Channels;
using System.Xml.Linq;

////Бульбашкова сортировка

//int[] mas = { 2, 5, 100, -100, 0, 81 };

const int m = 8;
int[] mas = new int[m];
int l = mas.GetUpperBound(0);

for (int i = 0; i <= l; i++)
{
    Console.Write($"Mas{i}=");
    mas[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i <= l; i++)
{
    Console.Write(mas[i]);
    Console.Write("\t");
}
Console.WriteLine();

for (int i = 0; i <= l; i++)
{
    for (int j = l; j > i; j--)
    {
        if (mas[j] < mas[j - 1])
        {
            int tmp = mas[j];
            mas[j] = mas[j - 1];
            mas[j - 1] = tmp;
        }

    }
    Console.Write(mas[i]);
    Console.Write("\t");
}