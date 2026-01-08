/*
ВывестиЗаголовокПрограммы(заголовок)
создать генератор случайных чисел
числоПобедИгрока, числоПобедКомпьютера, числоНичьих = 0

бесконечный цикл
    ходКомпьютера = ВыполнитьХодКомпьютера
    ходИгрока = ВыполнитьХодИгрока
    если ходИгрока = пустая строка
        выйти из цикла
    победитель = ОпределитьПобедителя(ходИгрока, ходКомпьютера)
    ВывестиПобедителя(ходКомпьютера, ходИгрока, победитель)

ВывестиРезультаты
ВыйтиИзПрограммы
*/

WriteTitle("Камень, ножницы, бумага!");

Random rand = new Random();

int playerWins = 0;
int computerWins = 0;
int Draws = 0;

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

WriteResults();
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
    if(playerMove == computerMove)
    {
        Draws++;
        return "Ничья";
    }
    else if(playerMove == "к" && computerMove == "н"
        || playerMove == "н" && computerMove == "б"
        || playerMove == "б" && computerMove == "к")
    {
        playerWins++;
        return "Игрок";
    }
    else
    {
        computerWins++;
        return "Компьютер";
    }
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

void WriteResults()
{
    Console.WriteLine(new string('-', 20));
    Console.WriteLine("Результаты игры:");
    Console.WriteLine($"Побед игрока: {playerWins}");
    Console.WriteLine($"Побед компьютера: {computerWins}");
    Console.WriteLine($"Ничьих: {Draws}");
}

void ExitApp()
{
    Console.WriteLine();
    Console.Write("Для выхода нажми Enter");
    Console.ReadLine();
}