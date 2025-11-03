// See https://aka.ms/new-console-template for more information

using System;

Random random = new Random();
bool playAgain = true;

Console.WriteLine("Я загадал число от 1 до 100. Попробуй угадать!");

do
{
    int secretnumber = random.Next(1, 101);
    int userGuess = 0;
    int attempts = 0;

    Console.WriteLine("Начинаем новую игру!");
    
    while (true)
    {
        Console.Write("Ваша догадка: ");
        string input = Console.ReadLine();
        
        if (!int.TryParse(input, out userGuess))
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
            continue;
        }

        attempts++;
        
        if (userGuess == secretnumber)
        {
            Console.WriteLine($"Поздравляю! Вы угадали число {secretnumber} за {attempts} попыток!");
            break;
        }


        if (attempts >= 7)
        {
            Console.WriteLine("Увы, вы проиграли. Количество ваших попыток превысило 7. Загаданное число - {secretnumber}");
            break;
        }
        
        if (userGuess < secretnumber)
        {
            Console.WriteLine("Загаданное число больше");
        }
        else
        {
            Console.WriteLine("Загаданное число меньше");
        }
    }
    
    Console.WriteLine("Вы хотите продолжить игру? (да/нет/yes/no)");
    string playAgainInput = Console.ReadLine();

    if (playAgainInput != null)
    {
        playAgainInput = playAgainInput.Trim().ToLower();
    }
    playAgain = (playAgainInput == "да" || playAgainInput == "yes");

} while (playAgain);

Console.WriteLine("Спасибо за игру!");
Console.ReadLine();




