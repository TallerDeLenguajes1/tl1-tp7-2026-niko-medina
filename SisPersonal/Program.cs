using EspacioEmpleado;

//Cargue los datos para 3 empleados en un arreglo de tipo empleados.
DateTime inicio = new DateTime(1961, 1, 1);
DateTime fin = new DateTime(2008, 1, 1);
int rango = (fin - inicio).Days;

DateTime fechaNacimiento = inicio.AddDays(Random.Shared.Next(rango + 1));
DateTime fechaMinima = fechaNacimiento.AddYears(18);
DateTime fechaMaxima = DateTime.Today;
int rangoIngreso = (fechaMaxima - fechaMinima).Days;
DateTime fechaIngreso = fechaMinima.AddDays(Random.Shared.Next(rangoIngreso + 1));

//Empleado(string nombre, string apellido, DateTime nacimiento, char estCivil, DateTime ingreso, Cargos cargo
Empleado empleado1 = new Empleado("Juan", "Perez", fechaNacimiento, 'C', fechaIngreso, Cargos.Administrativo);

fechaNacimiento = inicio.AddDays(Random.Shared.Next(rango + 1));
fechaMinima = fechaNacimiento.AddYears(18);
rangoIngreso = (fechaMaxima - fechaMinima).Days;
fechaIngreso = fechaMinima.AddDays(Random.Shared.Next(rangoIngreso + 1));
Empleado empleado2 = new Empleado("Juana", "Paz", fechaNacimiento, 'S', fechaIngreso, Cargos.Ingeniero);

fechaNacimiento = inicio.AddDays(Random.Shared.Next(rango + 1));
fechaMinima = fechaNacimiento.AddYears(18);
rangoIngreso = (fechaMaxima - fechaMinima).Days;
fechaIngreso = fechaMinima.AddDays(Random.Shared.Next(rangoIngreso + 1));
Empleado empleado3 = new Empleado("Jose", "Pez", fechaNacimiento, 'D', fechaIngreso, Cargos.Especialista);

Empleado[] empleados = [empleado1, empleado2, empleado3];

/*
foreach(Empleado e in empleados) // mostrar los datos de cada empleado
{
    Console.WriteLine($"------ Empleado: {e.GetApellido()}, {e.GetNombre()} ------");
    Console.WriteLine($"Edad: {e.Edad()} años");
    Console.WriteLine($"Antiguedad: {e.Antiguedad()} años");
    Console.WriteLine($"Salario: {e.Salario().ToString("C")}");    
}
*/

//Obtener el Monto Total de lo que se paga en concepto de Salarios
float Total = 0;
foreach(Empleado e in empleados){ 
    Total += e.Salario();
}
Console.WriteLine($"Monto total Salarios: {Total.ToString("C")}"); 

// Muestre por pantalla los datos del empleado que esté más próximo a jubilarse
int menor = 100;
foreach(Empleado e in empleados){ 
    if (e.AniosHastaJubilacion() < menor){
        menor = e.AniosHastaJubilacion();
    }
}
foreach(Empleado e in empleados){
    if(e.AniosHastaJubilacion() == menor){
        Console.WriteLine($"Empleado mas proximo a jubilacion: {e.GetApellido()}, {e.GetNombre()}");
        Console.WriteLine($"Edad: {e.Edad()} años");
        Console.WriteLine($"Antiguedad: {e.Antiguedad()} años");                 
        Console.WriteLine($"Años hasta jubilacion: {e.AniosHastaJubilacion()}");
    }
}

