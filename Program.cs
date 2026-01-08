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
    пока ход игрока не равен "к", "н", "б" или ""
        вывести сообщение об ошибке
        запросить ход игрока
        ход игрока = считать строку
    если ход игрока = пустая строка
        выйти из цикла
   
    если ход игрока = пустая строка
        выйти из цикла    

    вывести ход компьютера
    вывести ход игрока

    если ход игрока = ход компьютера
        вывести "Ничья!"

	если ход игрока = ход компьютера
        вывести "Ничья!"
    иначе если ход игрока = "к" и ход компьютера = "н"
        вывести "Ты выиграл!"    
    иначе если ход игрока = "н" и ход компьютера = "б"
        вывести "Ты выиграл!"
    иначе если ход игрока = "б" и ход компьютера = "к"
        вывести "Ты выиграл!"
    иначе вывести "Ты проиграл!"

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
    while (playerMove != "к" 
        && playerMove != "н" 
        && playerMove != "б" 
        && playerMove != "")
    {
        Console.WriteLine("Ошибка: неправильный ход!");
        Console.Write("Твой ход (к/н/б): ");
        playerMove = Console.ReadLine();
    }
    if (playerMove == "")
        break;

    Console.WriteLine($"Компьютер: {computerMove}");
    Console.WriteLine($"Игрок: {playerMove}");

    if (playerMove == computerMove)
        Console.WriteLine("Ничья!");
    else if (playerMove == "к" && computerMove == "н")
        Console.WriteLine("Ты выиграл!");
    else if (playerMove == "н" && computerMove == "б")
        Console.WriteLine("Ты выиграл!");
    else if (playerMove == "б" && computerMove == "к")
        Console.WriteLine("Ты выиграл!");
    else
        Console.WriteLine("Ты проиграл!");

    Console.WriteLine();
}

Console.WriteLine();
Console.Write("Для выхода нажми Enter");
Console.ReadLine();

