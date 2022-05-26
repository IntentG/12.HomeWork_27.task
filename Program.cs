/*Задача 27: Напишите программу, которая принимает на
вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.WriteLine("Введите число, для вычисления суммы всех его цифр: ");

int result = 0;
string number = Console.ReadLine();
char [] array = number.ToCharArray();
int [] arrayResult = new int[number.Length];

for (int i = 0; i < array.Length; i++)
{
    arrayResult[i] = int.Parse(array[i].ToString());
    result += arrayResult[i];
}

var arrayValue = string.Join(" + ", arrayResult);

Console.WriteLine($" Введённое число {number} \n Сумма всех чисел {arrayValue} = {result}");
