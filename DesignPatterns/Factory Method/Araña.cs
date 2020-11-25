namespace DesignPatterns.Factory_Method
{
    public class Araña : Enemigo
    {
        public Araña(int def, int at, int vel)
        {
            this.Defensa = def;
            this.Ataque = at;
            this.Velocidad = vel;
        }

        public Araña()
        {
            this.Defensa = 20;
            this.Ataque = 60;
            this.Velocidad = 50; 
        }

        public override string ToString()
        {
            return $"Esta araña tiene {Defensa} puntos de defensa, {Ataque} puntos de ataque y {Velocidad} puntos de velocidad.";
        }
    }
}

