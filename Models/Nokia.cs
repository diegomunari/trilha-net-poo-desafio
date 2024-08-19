namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        string modeloCel;
        public Nokia(string numero, string modelo, string imei, int memoria) : 
            base(numero, modelo, imei, memoria) {
                modeloCel = modelo;
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando app {nomeApp} no Nokia modelo {modeloCel}.");
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
    }
}