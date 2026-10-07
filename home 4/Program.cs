Random randomer = new Random();
string restartGame = "";

do
{
    int hiddenNumber = randomer.Next(1, 101);
    bool checkWin = false;

    Console.WriteLine("Я загадал число от 1 до 100. У вас 7 попыток.");

    for (int step = 1; step <= 7; step++)
    {
        Console.WriteLine("Попытка №" + step + ". Ваша догадка:");

        string userText = Console.ReadLine();
        int myNum = Convert.ToInt32(userText);

        if (myNum == hiddenNumber)
        {
            Console.WriteLine("Поздравляю! Вы угадали число " + hiddenNumber + " за " + step + " попыток!");
            checkWin = true;
            break;
        }

        // проверка больше или меньше
        if (myNum > hiddenNumber) Console.WriteLine("Загаданное число меньше.");
        if (myNum < hiddenNumber) Console.WriteLine("Загаданное число больше.");
    }

    if (checkWin == false)
    {
        Console.WriteLine("Вы проиграли! Закончились попытки. Было загадано число: " + hiddenNumber);
    }

    Console.WriteLine("Хотите сыграть еще раз? да/нет");
    restartGame = Console.ReadLine();

} while (restartGame == "да" || restartGame == "yes");

Console.ReadLine();
