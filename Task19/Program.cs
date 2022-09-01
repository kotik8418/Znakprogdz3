string number = Console.ReadLine();

void CheckingNumber(string number)
{
    if (number[0] == number[4] || number[1] == number[3])
    Console.WriteLine($"Число {number} - палидром");

    else Console.WriteLine($"Число {number} - не палидром");
}

if (number.Length == 5)
{
CheckingNumber(number);
}
else Console.WriteLine("Не правильно введено число");
