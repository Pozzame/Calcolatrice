using System;

Console.WriteLine("Inserisci il primo numero.");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Inserisci il secondo numero.");
double num2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Inserisci l'operatore tra +-*/^V");
string? operatore = Console.ReadLine();

switch (operatore)
{
    case "+": //Somma 
        Console.WriteLine($"{num1} {operatore} {num2} = {num1 + num2}");
        break;
    case "-": //Sottrazione
        Console.WriteLine($"{num1} {operatore} {num2} = {num1 - num2}");
        break;
    case "*": //Moltiplicazione
        Console.WriteLine($"{num1} {operatore} {num2} = {num1 * num2}");
        break;
    case "/": //Divisione
        try
        {
            if (num2 == 0) throw new DivideByZeroException();
            Console.WriteLine($"{num1} {operatore} {num2} = {num1 / num2}");
        }
        catch (DivideByZeroException)
        {
            try
            {
                if (num1 == 0) throw new Exception();
                Console.WriteLine("Non si può dividere per zero."); //Divisione per zero
            }
            catch
            {
                Console.WriteLine("Indefinito."); //Indefinito 0/0
            }
        }
        break;
    case "^": //Potenza
        Console.WriteLine($"{num1} {operatore} {num2} = {Math.Pow(num1, num2)}");
        break;
    case "V": //Radice n-esima
        Console.WriteLine($"{num1} {operatore} {num2} = {Math.Pow(num2, 1 / num1)}");
        break;
    default: //Operatore errato
        Console.WriteLine($"Spiacente ma '{operatore}' non è un operatore valido");
        break;
}