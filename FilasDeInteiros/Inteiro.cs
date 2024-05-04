namespace FilasDeInteiros
{
    internal class Numero
    {
        int numero;
        Numero? proximo;

        public Numero(int n)
        {
            this.numero = n;
            this.proximo = null;
        }

        public void SetNext(Numero aux) { this.proximo = aux; }
        public Numero? GetNext() { return this.proximo; }
        public int GetN() { return this.numero; }
        public string PrintN() { return $"Numero: {this.numero}"; }
    }
}
