using HtmlAgilityPack;
using System.Xml;

namespace API_Placa.Models
{
    public class Carro
    {
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public string? Importado { get; set; }
        public string? Ano { get; set; }
        public string? AnoModelo { get; set; }
        public string? Cor { get; set; }    
        public string? Cilindrada { get; set; }
        public string? Potencia { get; set; }
        public string? Combustivel { get; set; }
        public string? Chassi { get; set; }
        public string? Motor { get; set; }
        public string? Passageiros { get; set; }
        public string? Uf { get; set; }
        public string? Municipio { get; set; }
        public Carro() { }

        public Carro(List<HtmlNode> model)
        {
            Marca = model[0]?.InnerText;
            Modelo = model[1]?.InnerText;
            Importado = model[2]?.InnerText;
            Ano = model[3]?.InnerText;
            AnoModelo = model[4]?.InnerText;
            Cor = model[5]?.InnerText;
            Cilindrada = model[6]?.InnerText;
            Potencia = model[7]?.InnerText;
            Combustivel = model[8]?.InnerText;
            Chassi = model[9]?.InnerText;
            Motor = model[10]?.InnerText;
            Passageiros = model[11]?.InnerText;
            Uf = model[12]?.InnerText;
            Municipio = model[13]?.InnerText;
        }
        public override string ToString()
        {
            return "Marca: " + Marca + "\nModelo: " + Modelo + "\nImportado: " + Importado + "\nAno: " + Ano + "\nAno Modelo: " + AnoModelo + "\nModelo: " + Cor + "\nCilindrada: " + Cilindrada + "\nCombustivael: " + Combustivel + "\nChassi: " + Chassi + "\nMotor: " + Motor + "\nPassageiros: " + Passageiros + "\nUf: " + Uf + "\nMunicipio: " + Municipio;
        }

    }
}
