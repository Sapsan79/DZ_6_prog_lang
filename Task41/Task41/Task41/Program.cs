// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2-> 2
//1, -7, 567, 89, 223-> 4



    Console.WriteLine("Введите количество цифр, равное длине массива М: ");
int M = ReadInt();
    Console.WriteLine("Введите значения элементов через Enter: ");

int[] Array = new int[M];
for (int i = 0; i < Array.Length; i++)
Array[i] = int.Parse(Console.ReadLine());

Console.WriteLine($"Ваш массив {GetArrayAsString(Array)}");
Console.WriteLine($"Количество положительных чисел в массиве {summ()}");

int summ()
{
    int summ = 0;
    int i = 0;
    for (i= 0; i < Array.Length; i++)
        if (Array[i] > 0)
        {
        summ++;
        }
   return summ;
    
}

    int ReadInt()//проверка на норм ввод
    {
        string s = Console.ReadLine();

        if (int.TryParse(s, out int i))
            return i;

        return -1;
    }

    string GetArrayAsString(int[] Array)//выводит символы строки через запятую
    {
        string s = string.Empty;

        foreach (var item in Array)
        {
            s += $"{item}, ";
        }

        return s;
    }


