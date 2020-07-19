namespace DesignPatterns.Strategy
{
    public class Bici : IEstrategia
    {
        public double Velocidad { get; private set; }

        public Bici()
        {
            Velocidad = 20; // Velocidad promedio de un ciclista: 20 km/h
        }
        public double CalcularDuracionViaje(double distancia)
        {
            var demoraTrafico = 0.10; // El porcentaje de demora extra producido por el tráfico.
            return (distancia / Velocidad) * (1 + demoraTrafico);
        }
    }
}
