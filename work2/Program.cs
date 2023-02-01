//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3;

Console.Write("Введите числа через запятую: ");
int[] numbers = GetString(Console.ReadLine());
PrintArray(numbers);
Console.WriteLine();

int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine($"количество значений больше 0 = {sum}");


int[] GetString(string input)
{
    int result = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
        {
            result++;
        }
    }

    int[] numbers = new int [result];
    int index = 0;

    for (int i = 0; i < input.Length; i++)
    {
        string temp = "";

        while (input [i] != ',')
        {
        if(i != input.Length - 1)
        {
            temp += input [i].ToString();
            i++;
        }
        else
        {
            temp += input [i].ToString();
            break;
        }
        }
        numbers[index] = Convert.ToInt32(temp);
        index++;
    }
    return numbers;
}


void PrintArray(int[] array)
{
    Console.Write(" ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write(" ");
}