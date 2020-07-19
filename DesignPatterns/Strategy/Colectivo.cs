namespace DesignPatterns.Strategy
{
    public class Colectivo : IEstrategia
    {
        public double Velocidad { get; private set; }

        public Colectivo()
        {
            Velocidad = 70; // Velocidad promedio de un colectivo: 70 km/h
        }
        public double CalcularDuracionViaje(double distancia)
        {
            var frecuencia = 0.5; // Frecuencia (en horas) del recorrido: es decir, la espera máxima.
            var demoraTrafico = 0.20; // El porcentaje de demora extra producido por el tráfico.
            return frecuencia + (distancia / Velocidad) * (1 + demoraTrafico);
        }
    }
}
