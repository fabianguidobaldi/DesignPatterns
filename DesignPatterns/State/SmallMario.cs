namespace DesignPatterns.State
{
    public class SmallMario : IEstado
    {
        private Mario mario;

        public SmallMario(Mario mario)
        {
            this.mario = mario;
        }

        public void ObtenerFlor()
        {
            mario.SetEstado(new FireMario(mario));
        }

        public void ObtenerHongo()
        {
            mario.SetEstado(new SuperMario(mario));
        }

        public void TocarMonstruo()
        {
            mario.PerderVida();
        }

        public override string ToString()
        {
            return $"Small Mario";
        }
    }
}
