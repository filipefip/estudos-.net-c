using System.Text;
using ByteBankIO;

class Program
{
    static void Main(string[] args)
    {
        string enderecoDoArquivo = "contas.txt";
        int numeroDeBytesLidos = -1;
        
        FileStream fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open);

        byte[] buffer = new byte[1024]; // 1KB

        while(numeroDeBytesLidos != 0)
        {
            numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
            EscreverBuffer(buffer);
        }

        Console.ReadLine();
    }

    static void EscreverBuffer(byte[] buffer)
    {

        UTF8Encoding utf8 = new UTF8Encoding();
        string texto = utf8.GetString(buffer);
        Console.Write(texto);
        //foreach (byte meuByte in buffer)
        //{
        //    Console.Write(meuByte + " ");
        //}
    }
}