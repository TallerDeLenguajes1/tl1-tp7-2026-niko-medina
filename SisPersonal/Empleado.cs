namespace EspacioEmpleado{
    class Empleado{
        private string Nombre;
        private string Apellido;
        private DateTime FechaNacimiento;
        private char EstadoCivil;
        private DateTime FechaIngreso;
        private Cargos Cargo;

        public Empleado(string nombre, string apellido, DateTime nacimiento, char estCivil, DateTime ingreso, Cargos cargo){
            this.Nombre = nombre;
            this.Apellido = apellido;
            FechaNacimiento = nacimiento;
            EstadoCivil = estCivil;
            FechaIngreso = ingreso;
            Cargo = cargo;
        }
        public string GetNombre(){
            return this.Nombre;
        }
        public string GetApellido(){
            return this.Apellido;
        }

        public int Antiguedad(){
            return DateTime.Today.Year - FechaIngreso.Year;  // fecha actual - fecha ingreso
        }
        public int Edad(){
            return DateTime.Today.Year - FechaNacimiento.Year; //fecha actual - fecha nacimiento
        }
        public int AniosHastaJubilacion(){
            return 65 - Edad();
        }
        public float Salario(){
            float basico = 1000000;
            return basico + Adicional(basico); // sueldo basico + adicional
        }

        private float Adicional(float basico){
            // 1 % del sueldo básico por cada año de antigüedad hasta los 20 años, a partir de este, el porcentaje se fija en 25%
            float adicional = 0;
            if(Antiguedad() > 20){          
                // por cada anio hasta 20, sumar 1% del sueldo basico
                adicional += (float)(20 *basico*0.01);
                // por cada anio despues del 20, sumar 25% del sueldo basico
                adicional += (float)((Antiguedad() - 20)*basico*0.25);
            }
            else
            {
                // por cada anio hasta 20, sumar 1% del sueldo basico
                adicional += (float)(Antiguedad()*basico*0.01);
            }

            if(Cargo == Cargos.Ingeniero || Cargo == Cargos.Especialista){
                // el adicional aumenta un 50%
                adicional += (float)(0.5 * adicional);
            }

            if(EstadoCivil == 'C'){
                // Si es casado al Adicional se le aumenta $150.000
                adicional += 150000;
            }
            return adicional;
        }

    }

    public enum Cargos{
        Auxiliar,Administrativo, Ingeniero, Especialista, Investigador
    };
}