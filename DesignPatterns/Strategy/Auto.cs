namespace DesignPatterns.Strategy
{
    public class Auto : IEstrategia
    {
        public double Velocidad { get; private set; }

        public Auto()
        {
            Velocidad = 120; // Velocidad promedio de un auto: 120 km/h
        }
        public double CalcularDuracionViaje(double distancia)
        {
            var demoraTrafico = 0.20; // El porcentaje de demora extra producido por el tráfico.
            return (distancia / Velocidad) * (1 + demoraTrafico);
        }
    }
}
