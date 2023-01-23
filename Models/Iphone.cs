namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            Aplicativos.Add("App Store");
            Aplicativos.Add("Safari Browser");
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            if(Aplicativos.Contains(nomeApp)){
                Console.WriteLine($"Aplicativo {nomeApp} já instalado no iPhone");
                return;
            }

            Aplicativos.Add(nomeApp);
            Console.WriteLine($"Instalando aplicativo {nomeApp} no iPhone");
        }

        public override void DesinstalarAplicativo(string nomeApp)
        {
            if(!Aplicativos.Contains(nomeApp)){
                Console.WriteLine($"Aplicativo {nomeApp} não está instalado no iPhone.");
                return;
            }

            Aplicativos.Remove(nomeApp);
            Console.WriteLine($"Aplicativo {nomeApp} desinstalado do iPhone.");
        }

        public override void ListarAplicativos()
        {
            if(Aplicativos == null || !Aplicativos.Any()){
                Console.WriteLine("Não existem aplicativos instalados no iPhone.");
                return;
            }
            Console.WriteLine("Aplicativos instalados no iPhone:");
            for(int i = 0; i < Aplicativos.Count; i++)
            {
                Console.WriteLine($"{i+1} - {Aplicativos[i]}");
            }
        }
        public override void Informacoes()
        {
            Console.WriteLine($"--Informações: \nMarca: iPhone \nModelo: {Modelo} \nImei: {Imei} \nMemória: {Memoria} \nNumero: {Numero}");
        }
    }
}