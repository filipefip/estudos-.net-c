using System.Text;
using ByteBankIO;

partial class Program
{
    static void LidandoComFileStreamDiretamente()
    {
        string enderecoDoArquivo = "contas.txt";
        using (FileStream fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            int numeroDeBytesLidos = -1;



            byte[] buffer = new byte[1024]; // 1KB

            while (numeroDeBytesLidos != 0)
            {
                numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                EscreverBuffer(buffer, numeroDeBytesLidos);
            }

            fluxoDoArquivo.Close();
            Console.ReadLine();
        }
    }

    static void EscreverBuffer(byte[] buffer, int bytesLidos)
    {

        UTF8Encoding utf8 = new UTF8Encoding();
        string texto = utf8.GetString(buffer, 0, bytesLidos);
        Console.Write(texto);
    }
}