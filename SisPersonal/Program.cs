using EspacioEmpleado;

//Cargue los datos para 3 empleados en un arreglo de tipo empleados.
DateTime inicio = new DateTime(1960, 1, 1);
DateTime fin = DateTime.Today; // MODIFICAR: el rango para las edades deberia ser entre 18 y 65
int rango = (fin - inicio).Days;

DateTime fechaAleatoria = inicio.AddDays(Random.Shared.Next(rango + 1));
int rango2 = (fin - fechaAleatoria).Days;
DateTime fechaAleatoria2 = fechaAleatoria.AddDays(Random.Shared.Next(rango2 + 1));

//Empleado(string nombre, string apellido, DateTime nacimiento, char estCivil, DateTime ingreso, Cargos cargo
Empleado empleado1 = new Empleado("Juan", "Perez", fechaAleatoria, 'C', fechaAleatoria2, Cargos.Administrativo);

DateTime fechaNac = inicio.AddDays(Random.Shared.Next(rango + 1));
DateTime fechaIng = fechaNac.AddDays(Random.Shared.Next(rango + 1)); // habria que cambiar el rango
Empleado empleado2 = new Empleado("Juan", "Perez", fechaNac, 's', fechaIng, Cargos.Auxiliar);

DateTime fechaNac2 = inicio.AddDays(Random.Shared.Next(rango + 1));
DateTime fechaIng2 = fechaNac2.AddDays(Random.Shared.Next(rango + 1));
Empleado empleado3 = new Empleado("Juan", "Perez", fechaNac2, 'C', fechaIng2, Cargos.Especialista);

Empleado[] empleados = {empleado1, empleado2, empleado3};

foreach(Empleado e in empleados) // mostrar los datos de cada empleado
{
    Console.WriteLine($"Antiguedad Empleado: {e.antiguedad()}\n Edad Empleado: {e.edad()}");    
}

//Obtener el Monto Total de lo que se paga en concepto de Salarios
float Total = 0;
foreach(Empleado e in empleados){ 
    Total += e.salario();
}
Console.WriteLine($"Monto total Salarios(deberia ser 3000): {Total}"); 

// Muestre por pantalla los datos del empleado que esté más próximo a jubilarse
int menor = 100;
foreach(Empleado e in empleados){ 
    if (e.aniosHastaJubilacion() < menor){
        menor = e.aniosHastaJubilacion();
        // dar un id a cada empleado?
    }
}
foreach(Empleado e in empleados){
    if(e.aniosHastaJubilacion() == menor){
        Console.WriteLine($"Anios hasta jubilacion: {e.aniosHastaJubilacion()} \nAntiguedad Empleado mas proximo a jubilarse: {e.antiguedad()}\n Edad Empleado: {e.edad()}");  
    }
}

