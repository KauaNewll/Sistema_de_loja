public class Cliente
{
    public string nome;
    public string endereco;
    public double saldo;

    public void Depositar(double valor)
    {
        this.saldo = this.saldo + valor;
    }

    public void Debitar(double valor)
    {
        this.saldo = this.saldo - valor;
    }

    public void MostrarSaldo()
    {
        Console.WriteLine("O seu saldo é de " + this.saldo + "R$");
    }

    public Cliente()
    {
        this.nome = "Kauã";
        this.saldo = 10000;
    }

    
}

