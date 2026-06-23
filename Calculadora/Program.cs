using EspacioCalculadora;

// Realice una interfaz de usuario para operar la calculadora que permita continuar
//solicitando operaciones hasta que el usuario ingrese un comando de escape
bool continuar = true;
Calculadora calc = new Calculadora(0); // inicializo la calculadora en cero.
do
{   
    Console.WriteLine($"Resultado: x = {calc.Resultado()}");
  
    bool validoY;
    double y;
    do
    {
        Console.WriteLine("Ingrese un numero y (Ej: 123,45)");
        validoY = double.TryParse(Console.ReadLine(), out y);
        if (!validoY)
        {
            Console.WriteLine("No es un numero valido");
        }
    } while (!validoY); 

    Console.WriteLine("Seleccione una operacion:");
    Console.WriteLine("1. Sumar (x+y)");
    Console.WriteLine("2. Restar (x-y)");
    Console.WriteLine("3. Multiplicar (x*y)");
    Console.WriteLine("4. Dividir (x/y)");
    Console.WriteLine("5. Reiniciar (x=0)");
    Console.WriteLine("0. Salir");

    if(int.TryParse(Console.ReadLine(), out int opcion))
    {
        switch (opcion)
        {
            case 1:
                calc.Sumar(y);
            break;
            case 2:
                calc.Restar(y);
            break;
            case 3:
                calc.Multiplicar(y);
            break;
            case 4:
                if(y != 0)
                {
                    calc.Dividir(y);
                } else
                {
                    Console.WriteLine("Division en cero");
                }
            break;
            case 5:
                calc.Limpiar();
            break;
            case 0:
                continuar = false;
            break;
            default:
                Console.WriteLine("Opcion invalida");
            break;
        }
    } else
    {
        Console.WriteLine("Opcion invalida.");
    }
}while(continuar);
