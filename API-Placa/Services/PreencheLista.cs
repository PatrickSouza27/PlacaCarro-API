using API_Placa.Models;
using HtmlAgilityPack;
using System.Numerics;

namespace API_Placa.Services
{
    //https://www.keplaca.com/placa/MMI4350
    //https://placaipva.com.br/placa/IZO1880
    //https://placafipe.com/placa/IZO1880  
    public static class PreencheLista
    {
        public static Carro Site(string placa)
        {
            HtmlWeb web = new();
            List<HtmlNode> info = Lista(web.Load($"https://placaipva.com.br/placa/{placa}"));
            if (VerificaListaNull.Verifica(info))
                return new Carro(info);
            else
            {
                info = new List<HtmlNode>(Lista(web.Load($"https://www.keplaca.com/placa/{placa}")));
                if (VerificaListaNull.Verifica(info))
                    return new Carro(info);
                else
                {
                    info = new List<HtmlNode>(Lista(web.Load($"https://placafipe.com/{placa}")));
                    if (VerificaListaNull.Verifica(info))
                    {
                        return new Carro(info);
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }
        public static List<HtmlNode> Lista(HtmlDocument site)
        {
            List<HtmlNode> info = new();
            for (int i = 2; i <= 28; i += 2)
                info.Add(site.DocumentNode.SelectSingleNode($"(//td)[{i}]"));
            return info;
        }
    }
}
