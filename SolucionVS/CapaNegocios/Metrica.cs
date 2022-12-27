namespace CapaNegocios
{
    internal class Metrica
    {
        private int idMetrica;
        private string nombreMetrica;
        private string simbolo;

        public Metrica()
        {
        }

        public int IdMetrica { get => idMetrica; set => idMetrica = value; }
        public string NombreMetrica { get => nombreMetrica; set => nombreMetrica = value; }
        public string Simbolo { get => simbolo; set => simbolo = value; }
    }
}