namespace DesignPatterns.Factory_Method
{
    public class OrcoFactory : IEnemigoFactory
    {
        public Enemigo CrearEnemigo()
        {
            return new Orco();
        }

        public Enemigo CrearEnemigo(int def, int at, int vel)
        {
            return new Orco(def, at, vel);
        }
    }
}
