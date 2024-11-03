namespace ProjetoConsole
{
    public class StringHelper
    {
        public int ContarCaracteres(string texto) => texto.Length;
        public bool ContemTexto(string texto, string termo) => texto.Contains(termo);
        public string InverterTexto(string texto) => new string(texto.Reverse().ToArray());
    }
}