//Nossa calculadora deve ter a possibilidade de somar dois números
//Nossa calculadora deve ter a possibilidade de subtrair dois números
//Nossa calculadora deve ter a possibilidade de multiplicar dois números
//Nossa calculadora deve ter a possibilidade de dividir dois números
//Nossa calculadora deve permitir que o usuário continue utilizando o sistema até decidir sair



while (true)
{
    Console.Clear();

    Console.WriteLine("-------------------------------");
    Console.WriteLine("Bem-vindo à Calculadora!");
    Console.WriteLine("-------------------------------");
    Console.WriteLine("1 - Somar");
    Console.WriteLine("2 - Subtrair");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.WriteLine("5 - Tabuada");
    Console.WriteLine("S - Sair");
    Console.WriteLine("-------------------------------");
    Console.Write("Escolha a operação desejada: ");
    string operacao = Console.ReadLine();

    if (operacao == "S" || operacao == "s")
    {
        Console.WriteLine("Obrigado por usar a calculadora. Até mais!");
        return;
    }

    if (operacao != "1" && operacao != "2" && operacao != "3" && operacao != "4")
    {
        Console.WriteLine("Operação inválida. saindo do sistema...");
        Console.ReadKey();
        return;
    }

    //um for aqui para o loop da tabuada
     

    Console.Write("Digite o primeiro número: ");
    string primeiroNumero = Console.ReadLine();
    float numero1 = Convert.ToSingle(primeiroNumero);

    Console.Write("Digite o segundo número: ");
    string segundoNumero = Console.ReadLine();
    float numero2 = Convert.ToSingle(segundoNumero);

    float resultado = 0;

    if (operacao == "1")
    {
        resultado = numero1 + numero2;
    } else if (operacao  == "2")
    {
        resultado = numero1 - numero2;
    }else if (operacao == "3")
    {
        resultado = numero1 * numero2;
    } else
    {
        if (numero2 == 0)
        {
            Console.WriteLine("Erro: Divisão por zero não é permitida.");
            return;
        }
        resultado = numero1 / numero2;
    }

    Console.WriteLine("O resultado do calculo é " + resultado);
    Console.WriteLine("Pressione 'S' ou 's' para sair ou a tecla 'ENTER' para continuar...");
    if (Console.ReadKey().Key == ConsoleKey.S)
    {
        Console.WriteLine("\nObrigado por usar a calculadora. Até mais!");
        return;
    }
    Console.ReadKey();

}