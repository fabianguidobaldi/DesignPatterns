namespace DesignPatterns.Factory_Method
{
    public class ArañaFactory : IEnemigoFactory
    {
        public Enemigo CrearEnemigo()
        {
            return new Araña();
        }

        public Enemigo CrearEnemigo(int def, int at, int vel)
        {
            return new Araña(def, at, vel);
        }
    }
}
