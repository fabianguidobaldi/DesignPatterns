using System;

namespace DesignPatterns.Template_Method
{
    public class SandwichVegetariano : Sandwich
    {
        public override void AgregarPan() {
            Console.WriteLine("Dos panes integrales.");
        }
        public override void AgregarAderezos()
        {
            Console.WriteLine("Mostaza y/o ketchup.");
        }
        public override void AgregarCarne()
        {
            Console.WriteLine("Una hamburguesa vegetariana.");
        }
        public override void AgregarVegetales()
        {
            Console.WriteLine("Tomate, lechuga y pepinillos.");
        }
        
        public override void AgregarExtras()
        {
            ;
        }

        public override void AgregarQueso()
        {
            ;
        }
        public override bool LlevaQueso() { return false; }
    }
}
