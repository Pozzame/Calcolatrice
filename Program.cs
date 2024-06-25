Console.WriteLine("Inserisci il primo numero.");
double num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Inserisci il secondo numero.");
double num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Inserisci l'operatore tra +-*/");
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
        if (num2 == 0) Console.WriteLine("Non si può dividere per zero."); //Divisione per zero
        else Console.WriteLine($"{num1} {operatore} {num2} = {num1 / num2}");
        break;
    default: //Operatore errato
        Console.WriteLine($"Spiacente ma '{operatore}' non è un operatore valido");
        break;
}