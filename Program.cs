/*
ВывестиЗаголовокПрограммы(заголовок)
создать генератор случайных чисел
бесконечный цикл
    ходКомпьютера = ВыполнитьХодКомпьютера
    ходИгрока = ВыполнитьХодИгрока
    если ходИгрока = пустая строка
        выйти из цикла
    победитель = ОпределитьПобедителя(ходИгрока, ходКомпьютера)
    ВывестиПобедителя(ходКомпьютера, ходИгрока, победитель)
ВыйтиИзПрограммы
*/

WriteTitle("Камень, ножницы, бумага!");
Random rand = new Random();

while (true)
{
    string computerMove = GetComputerMove();
    string playerMove = GetPlayerMove();
    playerMove = VerifyPlayerMove(playerMove);
    if (playerMove == "")
        break;

    string winner = GetWinner(playerMove, computerMove);
    WriteWinner(computerMove, playerMove, winner);
}
ExitApp();

void WriteTitle(string title)
{
    Console.WriteLine(title);
    Console.WriteLine(new string('-', title.Length));
    Console.WriteLine();
}

string GetComputerMove()
{
    int computerNumber = rand.Next(1, 4);
    if (computerNumber == 1)
        return "к";
    if (computerNumber == 2)
        return "н";
    if (computerNumber == 3)
        return "б";
    return "";
}

string GetPlayerMove()
{
    Console.Write("Твой ход (к/н/б): ");
    string playerMove = Console.ReadLine();

    return playerMove;
}

string VerifyPlayerMove(string playerMove)
{
    while (playerMove != "к"
        && playerMove != "н"
        && playerMove != "б"
        && playerMove != "")
    {
        Console.WriteLine("Ошибка: неправильный ход!");
        playerMove = GetPlayerMove();
    }
    return playerMove;
}

string GetWinner(string playerMove, string computerMove)
{
    if (playerMove == computerMove)
        return "Ничья";
    else if (playerMove == "к" && computerMove == "н")
        return "Игрок";
    else if (playerMove == "н" && computerMove == "б")
        return "Игрок";
    else if (playerMove == "б" && computerMove == "к")
        return "Игрок";
    else
        return "Компьютер";
}

void WriteWinner(string computerMove, string playerMove, string winner)
{
    Console.WriteLine($"Компьютер: {computerMove}");
    Console.WriteLine($"Игрок: {playerMove}");

    if (winner == "Ничья")
        Console.WriteLine("Ничья!");
    else if (winner == "Игрок")
        Console.WriteLine("Ты выиграл!");
    else
        Console.WriteLine("Ты проиграл!");
    Console.WriteLine();
}

void ExitApp()
{
    Console.WriteLine();
    Console.Write("Для выхода нажми Enter");
    Console.ReadLine();
}