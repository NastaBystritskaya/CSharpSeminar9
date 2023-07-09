/*
** Задача 69. Напишите программу, которая на вход принимает числа А, В
** и возводит А в степень В с помощью рекурсии
*/

int GetUserInput(string text) {
    System.Console.Write(text);
    int input = int.Parse(System.Console.ReadLine()!);
    return input;
}

void PrintNumbers(int start, int end, int temp ) {
    if (end > 0) {
        temp = start * temp;
        end--;
        PrintNumbers(start, end, temp);
    }
    else {
        System.Console.WriteLine(temp);
    }
}
 void Main() {
    int start = GetUserInput("Введите число: ");
    int end = GetUserInput("Введите степень числа: ");
    PrintNumbers(start, end, 1);
 }

 Main();