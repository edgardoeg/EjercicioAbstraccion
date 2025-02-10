
namespace EjercicioAbstraccion
{
    public class AreaTriangulo : FormulaMatematica
    {

        public double Base;
        public double Altura;
        public AreaTriangulo(double baseTriang, double alturaTriang)
        {
            Base= baseTriang;
            Altura= alturaTriang;
        }
        public override double calcular()
        {
            return(Base * Altura)/2;
        }

        public override void Imprimir()
        {
            Console.WriteLine($"El area del triangulo es: {calcular()}");
        }
    }
}
