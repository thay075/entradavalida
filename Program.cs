Console.Clear();

Console.WriteLine("--- ENTRADA VÁLIDA ---");

int resposta;
do 
{

    Console.Write("\nDigite um número: ");
    resposta = Convert.ToInt32(Console.ReadLine())!;

}
while(resposta < 0 || resposta >= 10);

if (resposta == 0)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("\nOperação cancelada");
    Console.ResetColor();
}

else
{
    Console.WriteLine($"\nNúmero selecionado = {resposta}");
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("\nVolte sempre!");
    Console.ResetColor();
}