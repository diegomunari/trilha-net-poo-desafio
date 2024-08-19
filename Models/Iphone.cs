namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        string modeloCel;
        public Iphone(string numero, string modelo, string imei, int memoria) : 
            base(numero, modelo, imei, memoria) {
                modeloCel = modelo;
        }
        
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando app {nomeApp} no iPhone modelo {modeloCel}.");
        }
           // TODO: Sobrescrever o método "InstalarAplicativo"
    }
}