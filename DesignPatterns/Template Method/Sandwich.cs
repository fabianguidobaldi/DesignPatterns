namespace DesignPatterns.Template_Method
{
    public abstract class Sandwich
    {
        /* El método Preparar es el "Método plantilla" o Template Method: es el método que define el esqueleto del algoritmo,
         * permitiendo que las clases concretas redefinan la lógica de algunos pasos, pero respetando el esquema general. De
         * esta forma, podemos observar que el método plantilla puede invocar tanto a los métodos que se definen en las clases
         * concretas, como así también métodos de la clase abstracta e incluso métodos "hook", que son aquellos métodos que retornan
         * valores true/false y nos permiten ejecutar o no ciertos métodos según la clase concreta que se haya instanciado. */

        public void Preparar()
        {
            AgregarPan();
            
            if (LlevaAderezos())
            {
                AgregarAderezos();
            }

                AgregarCarne();

            if (LlevaQueso())
            {
                AgregarQueso();
            }

            AgregarVegetales();
            AgregarExtras();

        }

        public abstract void AgregarPan();
        public abstract void AgregarAderezos();
        public abstract void AgregarCarne();
        public abstract void AgregarQueso();
        public abstract void AgregarVegetales();
        public abstract void AgregarExtras();


        public virtual bool LlevaAderezos() { return true; }
        public virtual bool LlevaQueso() { return true; }
    }
}
