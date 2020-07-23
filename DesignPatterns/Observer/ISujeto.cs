namespace DesignPatterns.Observer
{
    public interface ISujeto
    {
        void Suscribir(IObservador observador);
        void Desuscribir(IObservador observador);
        void Notificar();
    }
}
