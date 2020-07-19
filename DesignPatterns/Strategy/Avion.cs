namespace DesignPatterns.Strategy
{
    public class Avion : IEstrategia
    {
        public double Velocidad { get; private set; }
        
        public Avion()
        {
            Velocidad = 550; // Velocidad promedio de un avión: 550 km/h
        }
        public double CalcularDuracionViaje(double distancia)
        {
            var tiempoCheckIn = 1; // Tiempo estimado de Check In.
            var demoraAduana = 1; // Tiempo estimado de demora en la Aduana al aterrizar.
            return tiempoCheckIn + (distancia / Velocidad) + demoraAduana;
        }
    }
}
