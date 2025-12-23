using System.Globalization;
using System.Text;
using ByteBankIO;

partial class Program
{
    static void UsandoStreamReader()
    {
        string enderecoDoArquivo = "contas.txt";
        using (FileStream fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            StreamReader leitor = new StreamReader(fluxoDoArquivo);

            // string linha = leitor.ReadLine(); // Lê uma linha do arquivo
            // string texto = leitor.ReadToEnd(); // Lê todo o conteúdo do arquivo
            // int numero = leitor.Read(); // Lê o próximo caractere do arquivo

            while (!leitor.EndOfStream)
            {
                string linha = leitor.ReadLine();
                ContaCorrente contaCorrente = ConverterStringParaContaCorrente(linha);
                string msg = $"{contaCorrente.Titular.Nome} : Conta número {contaCorrente.Numero}, ag {contaCorrente.Agencia}, Saldo {contaCorrente.Saldo.ToString("F2")}";
                Console.WriteLine(msg);
            }
        }
        Console.ReadLine();
    }

    static ContaCorrente ConverterStringParaContaCorrente(string linha)
    {
        string separadorDecimal = Thread
            .CurrentThread
            .CurrentCulture
            .NumberFormat
            .NumberDecimalSeparator;

        var campos = linha.Split(',');

        var agencia = campos[0];
        var numero = campos[1];
        var saldo = separadorDecimal == "," ? campos[2].Replace(".", ",") : campos[2];
        var nomeTitular = campos[3];

        var agenciaComInt = int.Parse(agencia);
        var numeroComInt = int.Parse(numero);
        var saldoComDouble = double.Parse(saldo);

        var titular = new Cliente();
        titular.Nome = nomeTitular;

        ContaCorrente resultado = new ContaCorrente(agenciaComInt, numeroComInt);
        resultado.Depositar(saldoComDouble);
        resultado.Titular = titular;

        return resultado;
    }
}