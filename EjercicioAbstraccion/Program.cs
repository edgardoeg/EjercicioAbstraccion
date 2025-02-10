using EjercicioAbstraccion;

    Console.WriteLine("**********MENU************");
    Console.WriteLine("Escoja una opcion:");
    Console.WriteLine("1. Área de un triángulo");
    Console.WriteLine("2. Volumen de un Cubo");
    Console.WriteLine("3. Voltaje con Ley de Ohn");
    
    int opcion = int.Parse(Console.ReadLine());

    FormulaMatematica formula = null;

    switch (opcion)
    {
        case 1:
            Console.Write("Ingrese la base del triángulo: ");
            double BaseTriang = double.Parse(Console.ReadLine());
            
        Console.Write("Ingrese la altura del triángulo: ");
            double AlturaTriang = double.Parse(Console.ReadLine());
        
            formula = new AreaTriangulo(BaseTriang, AlturaTriang);
            break;

        case 2:
            Console.Write("Ingrese un lado del cubo: ");
            double LadoCubo = double.Parse(Console.ReadLine());
            
            formula = new VolumenCubo(LadoCubo);
            break;

        case 3:
            Console.Write("Ingrese la Intensidad: ");
            double intensidad = double.Parse(Console.ReadLine());
            
            Console.Write("Ingrese la Resistencia: ");
            double resistencia = double.Parse(Console.ReadLine());
            
            formula = new Voltaje(intensidad, resistencia);
            break;
        
    }

    formula.Imprimir();
    Console.WriteLine();
