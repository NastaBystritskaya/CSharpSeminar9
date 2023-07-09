/*
** Задача 65. Задайте числа M, N.
** Выведите все числа от M..N, используя рекурсию
*/

int GetUserInput(string text) {
    System.Console.Write(text);
    int input = int.Parse(System.Console.ReadLine()!);
    return input;
}

void PrintNumbers(int start, int end) {
    if (start <= end) {
        System.Console.Write(start);
        start++;
        PrintNumbers(start, end);
    }
}
 void Main() {
    int start = GetUserInput("Введите первое число: ");
    int end = GetUserInput("Введите второе число: ");
    PrintNumbers(start, end);
 }

 Main();