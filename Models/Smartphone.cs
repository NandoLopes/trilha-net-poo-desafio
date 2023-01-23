namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get => _modelo; private set{}}
        public string Imei { get => _imei; private set{}}
        public int Memoria { get => _memoria; private set{}}
        protected List<string> Aplicativos = new List<string>();
        
        private readonly string _modelo;
        private readonly string _imei;
        private readonly int _memoria;

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            _modelo = modelo;
            _imei = imei;
            _memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
        public abstract void DesinstalarAplicativo(string nomeApp);
        public abstract void ListarAplicativos();
        public abstract void Informacoes();
    }
}