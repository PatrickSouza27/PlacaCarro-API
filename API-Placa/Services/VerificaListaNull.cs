using HtmlAgilityPack;

namespace API_Placa.Services
{
    public static class VerificaListaNull
    {
        public static bool Verifica(List<HtmlNode> lista)
            => lista[0] is not null;
    }
}
