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

//Даны цифры двух двузначных чисел, записываемых в виде a2a1 и b2b1 , где a1 и b1 — число единиц, a2 и b2 — число десятков. 
//    Получить цифры числа, равного разности заданных чисел (известно, что это число двузначное). Число-уменьшаемое, число-вычитаемое и число-разность не определять.

Console.WriteLine("Enter the digits of a two-digit number1(a2a1)");
string num1 = Console.ReadLine();
int a2 = Convert.ToInt32(num1[0].ToString());
int a1 = Convert.ToInt32(num1[1].ToString());

Console.WriteLine("Enter the digits of a two-digit number1(a2a1)");
string num2 = Console.ReadLine();
int b2 = Convert.ToInt32(num2[0].ToString());
int b1 = Convert.ToInt32(num2[1].ToString());

int difference = ((a2 * 10 + a1) - (b2 * 10 + b1));
Console.Write($"Difference: {num1} - {num2} = {difference}\n");
int Difference_a2 = difference / 10;
int Difference_a1 = difference % 10;
Console.WriteLine($"a2 = {Difference_a2}");
Console.WriteLine($"a1 = {Difference_a1}");


