// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да


Console.Clear();
Console.WriteLine("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 10000 || num > 100000)
{
    Console.WriteLine("Error");
    return;
}
else
{
    string number = num.ToString();
    int[] array = new int[number.Length];

    for (int i = 0; i < number.Length; i++)
    {
        array[i] = int.Parse(number[i].ToString());
    }
    if (array[0] == array[4] && array[1] == array[3])
    {
        Console.Write("Yes");
    }
    else
    {
        Console.Write("No");
    }
}

