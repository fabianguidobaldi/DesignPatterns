namespace DesignPatterns.Builder
{
    public abstract class Personaje
    {
        public string Armadura;
        public string Arma;
        public string Casco;
        public string Guantes;
        public string Botas;

        public int Fuerza;
        public int Inteligencia;
        public int Vitalidad;
        public int Destreza;

        public override string ToString()
        {
            return $@"
            ARMADURA: {Armadura}
            ARMA: {Arma}
            CASCO: {Casco}
            GUANTES: {Guantes}
            BOTAS: {Botas}";
        }
    }
}
