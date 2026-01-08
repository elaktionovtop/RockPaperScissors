/*
вывети заголовок программы
создать генератор случайных чисел

бесконечный цикл
    случайное число от 1 до 3
    если число = 1
        ход компьютера = "к"
    если число = 2
        ход компьютера = "к"
    если число = 3
        ход компьютера = "б"

    запросить ход игрока
    ход игрока = считать строку
    если ход игрока = пустая строка
        выйти из цикла
    
    вывести ход компьютера
    вывести ход игрока

    если ход игрока = ход компьютера
        вывести "Ничья!"

выйти из программы
*/

Console.WriteLine("Камень, ножницы, бумага!");
Console.WriteLine();

Random rand = new Random();

while(true)
{
    string computerMove = "";
    int computerNumber = rand.Next(1, 4);

    if (computerNumber == 1)
        computerMove = "к";
    if(computerNumber == 2)
        computerMove = "н";
    if(computerNumber == 3)
        computerMove = "б";

    Console.Write("Твой ход (к/н/б): ");
    string playerMove = Console.ReadLine();
    if (playerMove == "")
        break;

    Console.WriteLine($"Компьютер: {computerMove}");
    Console.WriteLine($"Игрок: {playerMove}");
    Console.WriteLine();
}

Console.WriteLine();
Console.Write("Для выхода нажми Enter");
Console.ReadLine();

