
namespace EjercicioAbstraccion
{
    public class VolumenCubo : FormulaMatematica
    {
        public double lado;
        

        public VolumenCubo(double LadoCubo)
        {
            lado = LadoCubo;
        }
        public override double calcular()
        {
            return Math.Pow(lado, 3);
        }

        public override void Imprimir()
        {
            Console.WriteLine($"El Columen de un cubo es: {calcular()}");
        }
    }
}
