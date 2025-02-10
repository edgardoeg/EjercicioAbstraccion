

namespace EjercicioAbstraccion
{
    public class Voltaje : FormulaMatematica
    {
        public double Resistencia;
        public double Intensidad;

        public Voltaje(Double resistencia, double intensidad)
        {
            Resistencia = resistencia;
            Intensidad = intensidad;
        }
        
        public override double calcular()
        {
            return Intensidad * Resistencia;
        }

        public override void Imprimir()
        {
            Console.WriteLine($"El Voltaje es: {calcular()}");
        }
    }
}
