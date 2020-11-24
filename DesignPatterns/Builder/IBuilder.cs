namespace DesignPatterns.Builder
{
    public interface IBuilder
    {
        void SetArmadura(string armadura);

        void SetArma(string arma);

        void SetCasco(string casco);

        void SetGuantes(string guantes);

        void SetBotas(string botas);

        Personaje ObtenerPersonaje();

        /* Los constructores concretos deben implementar esta interfaz para poder construir los objetos.
         * Cada constructor es el responsable de definir la lógica de creación de cada objeto. Si bien
         * vemos que, en muchos casos, se repite código, es mucho más fácil de leer, sobre todo cuando
         * los objetos que se deben construir son complejos (en este caso, un Personaje, cuyos atributos
         * podrían crecer con el tiempo). */
    }
}
