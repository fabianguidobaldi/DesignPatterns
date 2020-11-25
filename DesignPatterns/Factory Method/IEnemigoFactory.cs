namespace DesignPatterns.Factory_Method
{
    public interface IEnemigoFactory
    {
        Enemigo CrearEnemigo();
        Enemigo CrearEnemigo(int def, int at, int vel);
    }

    /* Esta interfaz permite definir los métodos comunes a todas las factorías de objetos. Cada clase que implementa esta interfaz,
    * podría generar objetos en base a cierta condición (nivel de dificultad, aleatoriedad, personalización de niveles, etc.), de 
    * forma tal que el cliente no debe conocer los objetos que crea ni la lógica detrás de esta creación. */
}
