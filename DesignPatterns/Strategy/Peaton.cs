namespace DesignPatterns.Strategy
{
    public class Peaton : IEstrategia
    {
        public double Velocidad { get; private set; }

        public Peaton()
        {
            Velocidad = 5; // Velocidad promedio de un peaton: 5 km/h
        }
        public double CalcularDuracionViaje(double distancia)
        {
            return (distancia / Velocidad);
        }
    }
}
