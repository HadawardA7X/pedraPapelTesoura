Random random = new Random();
bool jogarDenovo = true;
String jogador;
String computador;
String res;

while (jogarDenovo)
{
    jogador = "";
    computador = "";
    res = "";
    while (jogador != "PEDRA" && jogador != "PAPEL" && jogador != "TESOURA")
    {
        Console.Write("Digite PEDRA, PAPEL ou TESOURA: ");
        jogador = Console.ReadLine();
        jogador = jogador.ToUpper();

    }
    switch (random.Next(1, 4))
    {
        case 1:
            computador = "PEDRA";
            break;
        case 2:
            computador = "PAPEL";
            break;
        case 3:
            computador = "TESOURA";
            break;              
    }
    Console.WriteLine("Jogador:" + jogador);
    Console.WriteLine("Computador:" + computador);

    switch (jogador)
    {
        case "PEDRA":
            if (computador == "PEDRA")
            {
                Console.WriteLine("Empate!");
            }
            else if (computador == "PAPEL")
            {
                Console.WriteLine("Você perdeu!");
            }
            else
            {
                Console.WriteLine("Você ganhou!");
            }
            break;
        case "PAPEL":
            if (computador == "PEDRA")
            {
                Console.WriteLine("Você ganhou!");
            }
            else if (computador == "PAPEL")
            {
                Console.WriteLine("Empate!");
            }
            else
            {
                Console.WriteLine("Você perdeu!");
            }
            break;
        case "TESOURA":
            if (computador == "PEDRA")
            {
                Console.WriteLine("Você perdeu!");
            }
            else if (computador == "PAPEL")
            {
                Console.WriteLine("Você ganhou!");
            }
            else
            {
                Console.WriteLine("Empate!");
            }
            break;
    }
    Console.WriteLine("Gostaria de jogar novamente? (Y/N)");
    res = Console.ReadLine();
    res = res.ToUpper();

    if (res == "Y")
    {
        jogarDenovo = true;
    }
    else
    {
        jogarDenovo = false;
        
    }

}
Console.WriteLine("Obrigado por jogar!");



Console.ReadKey();