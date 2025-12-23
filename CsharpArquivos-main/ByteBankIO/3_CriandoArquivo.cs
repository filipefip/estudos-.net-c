using ByteBankIO;
using System.Text;

partial class Program
{
    static void CriarArquivo()
    {
        string caminhoNovoArquivo = "contasExportadas.csv";
        using (FileStream fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        {
            string contaComoString = "456,7890,1000.50,Pedro Silva";
            Encoding encoding = Encoding.UTF8;
            byte[] bytes = encoding.GetBytes(contaComoString);
            fluxoDeArquivo.Write(bytes, 0, bytes.Length);
        }
    }

    static void CriarArquivoComWriter()
    {
        string caminhoNovoArquivo = "contasExportadas.csv";
        using (FileStream fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        using (var escritor = new StreamWriter(fluxoDeArquivo, Encoding.UTF8))
        {
            escritor.Write("456,7890,1000.50,Pedro Silva");
        }
    }
}