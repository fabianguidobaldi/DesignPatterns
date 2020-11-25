namespace DesignPatterns.Factory_Method
{
    public class DragonFactory : IEnemigoFactory
    {
        public Enemigo CrearEnemigo()
        {
            return new Dragon();
        }

        public Enemigo CrearEnemigo(int def, int at, int vel)
        {
            return new Dragon(def, at, vel);
        }
    }
}
