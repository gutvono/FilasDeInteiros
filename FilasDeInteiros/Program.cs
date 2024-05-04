using FilasDeInteiros;

internal class Program
{
    private static void Main(string[] args)
    {
        //VARIAVEIS GLOBAIS
        FilaInteiro fila1 = new FilaInteiro();
        FilaInteiro fila2 = new FilaInteiro();

        //FUNCOES
        void AdicionarNumeros()
        {
            Console.WriteLine("Em qual fila deseja adicionar?\n" +
                "1 - Fila 1;\n" +
                "2 - Fila 2;\n" +
                "0 - Voltar.");
            int escolha = int.Parse(Console.ReadLine());
            switch (escolha)
            {
                case 1:
                    PopularFila(fila1);
                    break;
                case 2:
                    PopularFila(fila2);
                    break;
                default:
                    break;
            }
        }

        void PopularFila(FilaInteiro fila)
        {
            int num;
            do
            {
                Console.Write("Informe o numero que deseja adicionar, ou digite 0 para voltar:");
                num = int.Parse(Console.ReadLine());
                if (num != 0) fila.Push(new Numero(num));
            } while (num != 0);
        }

        void TamanhoFila()
        {
            if (fila1.QtdNumeros == fila2.QtdNumeros) Console.WriteLine($"As filas tem o mesmo tamanho: {fila1.QtdNumeros}");
            else
            {
                if (fila1.QtdNumeros > fila2.QtdNumeros)
                    Console.WriteLine($"A fila 1 tem {fila1.QtdNumeros} numeros e a fila 2 tem {fila2.QtdNumeros} numeros.\n" +
                        $"Sendo assim, a fila 1 é MAIOR que a fila 2.");
                else
                    Console.WriteLine($"A fila 1 tem {fila1.QtdNumeros} numeros e a fila 2 tem {fila2.QtdNumeros} numeros.\n" +
                        $"Sendo assim, a fila 1 é MENOR que a fila 2.");
            }

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        void PropsDaFila()
        {
            Console.WriteLine("Qual fila deseja verificar?\n" +
                "1 - Fila 1;\n" +
                "2 - Fila 2;\n" +
                "0 - Voltar.");
            int opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    Console.WriteLine($"O MAIOR numero encontrado na fila 1 é: {fila1.MaiorValor}.\n" +
                        $"O MENOR numero encontrado na fila 1 é: {fila1.MenorValor}\n" +
                        $"A MÉDIA ARITMÉTICA dos elementos da fila 1 é: {fila1.Media}\n" +
                        $"\nPressione qualquer tecla para voltar.");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine($"O MAIOR numero encontrado na fila 2 é: {fila2.MaiorValor}.\n" +
                        $"O MENOR numero encontrado na fila 2 é: {fila2.MenorValor}\n" +
                        $"A MÉDIA ARITMÉTICA dos elementos da fila 2 é: {fila2.Media}" +
                        $"\nPressione qualquer tecla para voltar.");
                    Console.ReadKey();
                    break;
                default:
                    break;
            }
        }

        void CopiarFila()
        {
            FilaInteiro aux = new();
            Console.WriteLine("Qual fila deseja copiar? \n" +
                "1 - Fila 1;\n" +
                "2 - Fila 2;\n" +
                "0 - Voltar.");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    aux = fila1;
                    Console.WriteLine("Fila copiada para uma variável auxiliar com sucesso:");
                    aux.RunOver(true);
                    break;
                case 2:
                    aux = fila2;
                    Console.WriteLine("Fila copiada para uma variável auxiliar com sucesso:");
                    aux.RunOver(true);
                    break;
                default:
                    break;
            }
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        //MENU
        void menu()
        {
            int opcao = 0;
            do
            {
                Console.Clear();
                int fila = 0;
                Console.WriteLine("Bem vindo ao comparador de filas de inteiros!\n" +
                    "Selecione uma opção:\n" +
                    "1 - Adicionar números em uma fila;\n" +
                    "2 - Ver o tamanho das filas;\n" +
                    "3 - Ver o maior, o menor numero e a média aritmética dos elementos de uma fila;\n" +
                    "4 - Copiar uma fila;\n" +
                    "5 - Ver os elementos ímpares de uma fila;\n" +
                    "6 - Ver os elementos pares de uma fila;\n" +
                    "0 - Sair do programa.");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarNumeros();
                        break;
                    case 2:
                        TamanhoFila();
                        break;
                    case 3:
                        PropsDaFila();
                        break;
                    case 4:
                        CopiarFila();
                        break;
                    case 5:
                        Console.WriteLine("De qual fila você deseja ver os elementos IMPARES?\n" +
                            "1 - Fila 1;\n" +
                            "2 - Fila 2;\n" +
                            "0 - Voltar.");
                        fila = int.Parse(Console.ReadLine());
                        if (fila == 1) fila1.GetImPar("Os numeros IMPARES da fila 1 são:", false);
                        if (fila == 2) fila2.GetImPar("Os numeros IMPARES da fila 2 são:", false);
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.WriteLine("De qual fila você deseja ver os elementos PARES?\n" +
                            "1 - Fila 1;\n" +
                            "2 - Fila 2;\n" +
                            "0 - Voltar.");
                        fila = int.Parse(Console.ReadLine());
                        if (fila == 1) fila1.GetImPar("Os numeros PARES da fila 1 são:", true);
                        if (fila == 2) fila2.GetImPar("Os numeros PARES da fila 2 são:", true);
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            } while (opcao != 0);
        }


        //PROGRAMA
        menu();
    }
}