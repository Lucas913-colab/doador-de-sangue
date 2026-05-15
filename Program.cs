﻿int Idade;

Console.Write("quantos anos você tem: ");
Idade = Convert.ToInt32(Console.ReadLine());

if (Idade >= 18 && Idade <= 67)
{
    Console.WriteLine("você pode doar sangue, caso tenha tatuagem você não poderá.");
}

else

{
    Console.WriteLine("Você não poderá doar sangue.");
}
Console.WriteLine("agradecemos sua vinda!");