/*
бесконечный цикл
    ход компьюетра = "н"
    запросить ход игрока
    ход игрока = считать строку
    если ход игрока = пустая строка
        выйти из цикла
выйти из программы
*/

Console.WriteLine("Камень, ножницы, бумага!");
Console.WriteLine();

while(true)
{
    string computerMove = "н";
    Console.Write("Твой ход (к/н/б): ");
    string playerMove = Console.ReadLine();
    if (playerMove == "")
        break;
}

Console.WriteLine();
Console.Write("Для выхода нажми Enter");
Console.ReadLine();

