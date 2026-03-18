//Nossa calculadora deve ter a possibilidade de somar dois números
//Nossa calculadora deve ter a possibilidade de subtrair dois números
//Nossa calculadora deve ter a possibilidade de multiplicar dois números
//Nossa calculadora deve ter a possibilidade de dividir dois números
//Nossa calculadora deve permitir que o usuário continue utilizando o sistema até decidir sair

//Nossa calculadora deve produzir a tabuada de um número informado
//Nossa calculadora deve armazenar historico de operações

string[] historicOperacoes =  new string[100];
int contadorOperacoes = 0;


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
    Console.WriteLine("6 - Histórico da operação");
    Console.WriteLine("S - Sair");
    Console.WriteLine("-------------------------------");
    Console.Write("Escolha a operação desejada: ");
    string operacao = Console.ReadLine();

    if (operacao == "S" || operacao == "s")
    {
        Console.WriteLine("Obrigado por usar a calculadora. Até mais!");
        return;
    }

    if (operacao != "1" && operacao != "2" && operacao != "3" && operacao != "4" && operacao != "5" && operacao != "6")
    {
        Console.WriteLine("Operação inválida. saindo do sistema...");
        Console.ReadKey();
        return;
    }

    if (operacao == "5")
    {
        Console.Clear();
        Console.WriteLine("-------------------------------");
        Console.WriteLine("Bem-vindo à Tabuada!");
        Console.WriteLine("-------------------------------");
        Console.Write("Digite um número inteiro: ");
        string numTabuadaSt = Console.ReadLine();
        float numTabuada = Convert.ToSingle(numTabuadaSt);

        Console.WriteLine("1 - Multiplicar");
        Console.WriteLine("2 - Subtrair");
        Console.WriteLine("3 - Somar");
        Console.WriteLine("Digite agora a operação da tabuada: ");
        string operTabuada = Console.ReadLine();

        if (operTabuada != "1" && operTabuada != "2" && operTabuada != "3")
        {
            Console.WriteLine("Operação inválida. Clique ENTER para sair da tabuada...");
            Console.ReadKey();
            continue;
        }

        Console.WriteLine("A tabuada do número " + numTabuada + " é: ");

        for (int contador = 1; contador <= 10; contador++)
        {
            //float resultTabuada = numTabuada + contador;
            //Console.WriteLine(numTabuada + " + " + contador + " = " + resultTabuada);
            int opr = Convert.ToInt32(operTabuada);
            switch (opr) {
                case 1:
                    float resultTabuada = numTabuada * contador;
                    Console.WriteLine(numTabuada + " x " + contador + " = " + resultTabuada);
                    break;
                case 2:
                    resultTabuada = numTabuada - contador;
                    Console.WriteLine(numTabuada + " + " + contador + " = " + resultTabuada);
                    break;
                default:
                    resultTabuada = numTabuada + contador;
                    Console.WriteLine(numTabuada + " + " + contador + " = " + resultTabuada);
                    break;

            }
        }


        Console.WriteLine("Clique ENTER para continuar...");
        Console.ReadLine();
        continue;
    }

    if (operacao == "6")
    {
        Console.WriteLine("-------------------------------");
        Console.WriteLine("Histórico de Operações");
        Console.WriteLine("-------------------------------");

        for (int contador = 0; contador < historicOperacoes.Length; contador++)
        {
            if (historicOperacoes[contador] != null)
            {
            Console.WriteLine(historicOperacoes[contador]);
                
            }
        }

        Console.WriteLine("Clique ENTER para continuar...");
        Console.ReadLine();
        continue;
    }
     

    Console.Write("Digite o primeiro número: ");
    string primeiroNumero = Console.ReadLine();
    float numero1 = Convert.ToSingle(primeiroNumero);

    Console.Write("Digite o segundo número: ");
    string segundoNumero = Console.ReadLine();
    float numero2 = Convert.ToSingle(segundoNumero);

    float resultado = 0;
    string textOperacao;

    if (operacao == "1")
    {
        resultado = numero1 + numero2;
        textOperacao = $"{numero1} + {numero2} = {resultado}";
    } else if (operacao  == "2")
    {
        resultado = numero1 - numero2;
        textOperacao = $"{numero1} - {numero2} = {resultado}";
    }else if (operacao == "3")
    {
        resultado = numero1 * numero2;
        textOperacao = $"{numero1} x {numero2} = {resultado}";
    } else
    {
        if (numero2 == 0)
        {
            Console.WriteLine("Erro: Divisão por zero não é permitida.");
            return;
        }
        resultado = numero1 / numero2;
        textOperacao = $"{numero1} / {numero2} = {resultado}";
    }

    if (contadorOperacoes < historicOperacoes.Length)
    {    
        historicOperacoes[contadorOperacoes] = textOperacao;
        contadorOperacoes++;
    } else
    {
        Console.WriteLine("Não há espaços disponíveis em memória");
        Console.WriteLine("Por favor, fechando o programa... Clique ENTER");
        Console.ReadLine();
        return;
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