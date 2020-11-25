namespace DesignPatterns.Factory_Method
{
    public class Dragon : Enemigo
    {
        public Dragon(int def, int at, int vel)
        {
            this.Defensa = def;
            this.Ataque = at;
            this.Velocidad = vel;
        }

        public Dragon()
        {
            this.Defensa = 80;
            this.Ataque = 100;
            this.Velocidad = 60; 
        }

        public override string ToString()
        {
            return $"Este dragón tiene {Defensa} puntos de defensa, {Ataque} puntos de ataque y {Velocidad} puntos de velocidad.";
        }
    }
}
