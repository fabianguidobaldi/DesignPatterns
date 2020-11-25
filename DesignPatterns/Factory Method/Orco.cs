namespace DesignPatterns.Factory_Method
{
    public class Orco : Enemigo
    {
        public Orco(int def, int at, int vel)
        {
            this.Defensa = def;
            this.Ataque = at;
            this.Velocidad = vel;
        }

        public Orco()
        {
            this.Defensa = 30;
            this.Ataque = 40;
            this.Velocidad = 10; 
        }

        public override string ToString()
        {
            return $"Este orco tiene {Defensa} puntos de defensa, {Ataque} puntos de ataque y {Velocidad} puntos de velocidad.";
        }
    }
}

