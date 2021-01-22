using System;

namespace DesignPatterns.Template_Method
{
    public class SandwichCheddar : Sandwich
    {
        public override void AgregarPan() {
            Console.WriteLine("Dos panes blancos.");
        }

        public override void AgregarAderezos()
        {
            Console.WriteLine("Mayonesa común, mostaza y/o ketchup.");
        }

        public override void AgregarCarne()
        {
            Console.WriteLine("Una hamburguesa de carne.");
        }

        public override void AgregarQueso()
        {
            Console.WriteLine("Dos fetas de queso cheddar.");
        }

        public override void AgregarVegetales()
        {
            Console.WriteLine("Tomate y lechuga.");
        }

        public override void AgregarExtras()
        {
            ;
        }

        public override bool LlevaAderezos() { return false; }
    }
}
