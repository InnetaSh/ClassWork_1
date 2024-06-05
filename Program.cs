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
    while (!Int32.TryParse(Console.ReadLine(), out mas[i]))
    {
        Console.WriteLine("Введено не число. Введите число:");
    }
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
Console.WriteLine();

//Даны цифры двух двузначных чисел, записываемых в виде a2a1 и b2b1 , где a1 и b1 — число единиц, a2 и b2 — число десятков. 
//    Получить цифры числа, равного разности заданных чисел (известно, что это число двузначное). Число-уменьшаемое, число-вычитаемое и число-разность не определять.

Console.WriteLine("Введите двузначное число 1 (a2a1)");
string num1 = Console.ReadLine(); 
while (num1.Length != 2)
{
    Console.WriteLine("Введено не двухзначное число. Введите двузначное число 1(a2a1)");
    num1 = Console.ReadLine();
}
int a2 = Convert.ToInt32(num1[0].ToString());
int a1 = Convert.ToInt32(num1[1].ToString());

Console.WriteLine("Введите двузначное число 2 (b2b1)");
string num2 = Console.ReadLine();
while (num2.Length !=2)
{
    Console.WriteLine("Введено не двухзначное число. Введите двузначное 2 число (b2b1)");
    num2 = Console.ReadLine();
}
int b2 = Convert.ToInt32(num2[0].ToString());
int b1 = Convert.ToInt32(num2[1].ToString());

int difference = ((a2 * 10 + a1) - (b2 * 10 + b1));
Console.Write($"Разность: {num1} - {num2} = {difference}\n");
int Difference_a2 = difference / 10;
int Difference_a1 = difference % 10;
Console.WriteLine($"число десятков = {Difference_a2}");
Console.WriteLine($"число единиц = {Difference_a1}");


//Даны цифры двух десятичных целых чисел: трехзначного a3a2a1 и двузначного b2b1, где a1 и b1 — число единиц, a2 и b2 — число десятков,
//    a3 — число сотен. Получить цифры, составляющие разность этих чисел (известно, что это число трехзначное). Число-уменьшаемое,
//    число-вычитаемое и число-разность не определять.


Console.WriteLine("Введите трехзначное число 1 (a3a2a1)");
int num2_1;
while(!Int32.TryParse(Console.ReadLine(), out num2_1) || (num2_1 < 99 || num2_1 > 999))
{
    Console.WriteLine("Введено не трехзначное число. Введите трехзначное число 1 (a3a2a1)");
}

Console.WriteLine("Введите двузначное число 2 (b2b1)");
int num2_2;
while (!Int32.TryParse(Console.ReadLine(), out num2_2) || (num2_2 < 9 || num2_2 > 99))
{
    Console.WriteLine("Введено не двухзначное число. Введите двузначное число 2 (b2b1)");
}
int difference2 = (num2_1 - num2_2);
Console.Write($"Разность2: {num2_1} - {num2_2} = {difference2}\n");
int Difference2_a3 = difference2 / 100;
int Difference2_a2 = difference2 / 10 % 10;
int Difference2_a1 = difference2 % 10;
Console.WriteLine($"число сотен = {Difference2_a3}");
Console.WriteLine($"число десятков = {Difference2_a2}");
Console.WriteLine($"число единиц = {Difference2_a1}");



//Поле шахматной доски определяется парой натуральных чисел, каждое из которых не превосходит 8: первое число — номер вертикали (при счете слева направо),
//    второе — номер горизонтали (при счете снизу вверх). Даны натуральные числа a, b, c, d, каждое из которых не превосходит 8.

Console.WriteLine("Введите координаты (a, b):");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
while (a > 8 || a < 1)
{
    Console.WriteLine("Вышли за границы диапазона. Введите координаты (a):");
    a = Convert.ToInt32(Console.ReadLine());
}
while (b > 8 || b < 1)
{
    Console.WriteLine("Вышли за границы диапазона. Введите координаты (b):");
    b = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Введите координаты (c, d):");
int c = Convert.ToInt32(Console.ReadLine());
int d = Convert.ToInt32(Console.ReadLine());
while (c > 8 || c < 1)
{
    Console.WriteLine("Вышли за границы диапазона. Введите координаты (c):");
    c = Convert.ToInt32(Console.ReadLine());
}
while (d > 8 || d < 1)
{
    Console.WriteLine("Вышли за границы диапазона. Введите координаты (d):");
    d = Convert.ToInt32(Console.ReadLine());
}


//а) на поле (a, b) расположена ладья. Определить, угрожает ли она полю (c, d);

if ((a == c) || (b == d))
{
    Console.WriteLine("Ладья угрожает полю.\n");
}
else
{
    Console.WriteLine("Ладья не угрожает полю.\n");
}


//б) на поле (a, b) расположен слон. Определить, угрожает ли он полю (c, d);

if (Math.Abs(a - c) == Math.Abs(b - d))
{
    Console.WriteLine("Слон угрожает полю.\n");
}
else
{
    Console.WriteLine("Слон не угрожает полю.\n");
}


//в) на поле (a, b) расположен король. Определить, может ли он одним ходом попасть на поле (c, d);
if (((Math.Abs(a - c) <= 1) && (Math.Abs(b - d)) <= 1))
{
    Console.WriteLine("Король угрожает полю.\n");
}
else
{
    Console.WriteLine("Король не угрожает полю.\n");
}


//г) на поле (a, b) расположен ферзь. Определить, угрожает ли он полю (c, d);
if ((Math.Abs(a - c) == Math.Abs(b - d)) || ((a == c) || (b == d)))
{
    Console.WriteLine("Ферзь угрожает полю.\n");
}
else
{
    Console.WriteLine("Ферзь не угрожает полю.\n");
}


//д) на поле (a, b) расположена белая пешка. Определить, может ли она одним ходом попасть на поле (c, d):
//— при обычном ходе;
if (((d - b) == 1) && (a == c))
{
    Console.WriteLine("Белая пешка может одним ходом попасть на поле. \n");
}
else
{
    Console.WriteLine("Белая пешка не может одним ходом попасть на поле. \n");
}

//— когда она «бьет» фигуру или пешку соперника;
if ((d - b) == 1 && Math.Abs(c - a) == 1)
{
    Console.WriteLine("Белая пешка угрожает сопернику.\n");
}
else
{
    Console.WriteLine("Белая пешка не угрожает сопернику.\n");
}


//е) на поле (a, b) расположена черная пешка. Определить, может ли она одним ходом попасть на поле (c, d):
//— при обычном ходе;
if (((b - d) == 1) && (a == c))
{
    Console.WriteLine("Черная пешка может одним ходом попасть на поле. \n");
}
else
{
    Console.WriteLine("Черная пешка не может одним ходом попасть на поле. \n");
}

//— когда она «бьет» фигуру или пешку соперника;
if ((b - d) == 1 && Math.Abs(a - c) == 1)
{
    Console.WriteLine("Черная пешка угрожает сопернику.\n");
}
else
{
    Console.WriteLine("Черная пешка не угрожает сопернику.\n");
}

//ж) на поле (a, b) расположен конь. Определить, угрожает ли он полю (c, d).
if ((Math.Abs(a - c) == 1 && Math.Abs(b - d) == 2) || (Math.Abs(a - c) == 2 && Math.Abs(b - d) == 1))
{
    Console.WriteLine("Конь угрожает полю.\n");
}
else
{
    Console.WriteLine("Конь не угрожает полю.\n");
}
//Во всех задачах ответ проверить на шахматной доске




