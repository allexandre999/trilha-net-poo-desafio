namespace DesafioPOO.Models
{
    // Implementado!!
    public class Iphone : Smartphone
    {
        // Implementado!!
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero,modelo,imei,memoria){} 
        public override void InstalarAplicativo(string nomeApp)
        {
           System.Console.WriteLine($"Instalando o aplicativo \"{nomeApp}\" no iPhone");
        }
    }
}