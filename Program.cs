int num1, num2, num3;

Console.WriteLine ("Maior número");

Console.Write("Insira o primeiro número: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Insira o segundo número: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Insira o terceiro número: ");
num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2 && num1 > num3)
{
    Console.WriteLine("O primeiro número é o maior!");
}
else if (num2 > num1 && num2 > num3)
{
    Console.WriteLine("O segundo número é o maior!");
}
else if (num3 > num1 && num3 > num2)
{
    Console.WriteLine("O terceiro número é o maior!");
}
else
{
    Console.WriteLine("Existem números iguais que são os maiores.");
}
