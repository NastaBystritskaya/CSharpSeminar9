/*
** Задача 63. Задайте число N.
** Выведите все числа от 1..N, используя рекурсию
*/

int GetUserInput() {
    System.Console.Write("Введите число: ");
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
    int input = GetUserInput();
    PrintNumbers(1, input);
 }

 Main();