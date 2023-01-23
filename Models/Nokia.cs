namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            Aplicativos.Add("Play Store");
            Aplicativos.Add("Chrome Browser");
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            if(Aplicativos.Contains(nomeApp)){
                Console.WriteLine($"Aplicativo {nomeApp} já instalado no Nokia");
                return;
            }

            Aplicativos.Add(nomeApp);
            Console.WriteLine($"Instalando aplicativo {nomeApp} no Nokia");
        }

        public override void DesinstalarAplicativo(string nomeApp)
        {
            if(!Aplicativos.Contains(nomeApp)){
                Console.WriteLine($"Aplicativo {nomeApp} não está instalado no Nokia.");
                return;
            }

            Aplicativos.Remove(nomeApp);
            Console.WriteLine($"Aplicativo {nomeApp} desinstalado do Nokia.");
        }

        public override void ListarAplicativos()
        {
            if(Aplicativos == null || !Aplicativos.Any()){
                Console.WriteLine("Não existem aplicativos instalados no Nokia.");
                return;
            }
            Console.WriteLine("Aplicativos instalados no Nokia:");
            for(int i = 0; i < Aplicativos.Count; i++)
            {
                Console.WriteLine($"{i+1} - {Aplicativos[i]}");
            }
        }

        public override void Informacoes()
        {
            Console.WriteLine($"--Informações: \nMarca: Nokia \nModelo: {Modelo} \nImei: {Imei} \nMemória: {Memoria} \nNumero: {Numero}");
        }
    }
}