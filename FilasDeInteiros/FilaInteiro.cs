namespace FilasDeInteiros
{
    internal class FilaInteiro
    {
        Numero? head;
        Numero? tail;
        int qtdNumeros;
        int maiorValor;
        int menorValor;
        int media;

        internal int QtdNumeros { get => qtdNumeros; set => qtdNumeros = value; }
        internal int MaiorValor { get => maiorValor; set => maiorValor = value; }
        internal int MenorValor { get => menorValor; set => menorValor = value; }
        public int Media { get => media; set => media = value; }

        public FilaInteiro()
        {
            this.head = null;
            this.QtdNumeros = 0;
        }

        public void Push(Numero aux)
        {
            if (IsEmpty()) this.head = this.tail = aux;
            else this.tail.SetNext(aux);
            this.tail = aux;
            this.QtdNumeros++;

            this.RunOver(false);
        }

        public void Pop()
        {
            if (!IsEmpty())
            {
                Console.WriteLine($"O número {this.head.GetN()} foi retirado da fila.");
                this.QtdNumeros--;
                this.head = this.head.GetNext();
                this.RunOver(false);
            }
            else
            {
                Console.WriteLine($"Fila vazia! Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }

        }

        bool IsEmpty() { return this.head == null && this.tail == null; }

        public void RunOver(bool print)
        {
            Numero? aux = this.head;
            int index = 0;

            if (IsEmpty())
            {
                Console.WriteLine("Fila vazia! Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            else
            {
                int soma = 0;
                do
                {
                    if (this.QtdNumeros == 1)
                    {
                        this.MaiorValor = aux.GetN();
                        this.MenorValor = aux.GetN();
                    }
                    else
                    {
                        if (aux.GetN() > this.MaiorValor) this.MaiorValor = aux.GetN();
                        if (aux.GetN() < this.MenorValor) this.MenorValor = aux.GetN();
                    }

                    soma += aux.GetN();

                    if (print) Console.WriteLine($"Posição: {index + 1} - Numero: {aux.GetN()}");

                    aux = aux.GetNext();
                    index++;
                } while (aux != null);
                this.Media = soma / this.QtdNumeros;
            }
        }

        public void GetImPar(string mensagem, bool par)
        {
            Numero? aux = this.head;
            int contador = 0;
            Console.WriteLine(mensagem);
            if (IsEmpty())
            {
                Console.WriteLine("Fila vazia. Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            else
            {
                do
                {
                    if (aux.GetN() % 2 != 0 && !par)
                    {
                        contador++;
                        Console.WriteLine($"Elemento: {contador} - Numero: {aux.GetN()} ");
                    }

                    if (aux.GetN() % 2 == 0 && par)
                    {
                        contador++;
                        Console.WriteLine($"Elemento: {contador} - Numero: {aux.GetN()}");
                    }
                    aux = aux.GetNext();
                } while (aux != null);
            }
        }
    }
}

