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

        public int antiguedad(){
            return DateTime.Today.Year - FechaIngreso.Year;  // fecha actual - fecha ingreso
        }
        public int edad(){
            return DateTime.Today.Year - FechaNacimiento.Year; //fecha actual - fecha nacimiento
        }
        public int aniosHastaJubilacion(){
            return 65 - this.edad();
        }
        public float salario(){
            return 1000 + adicional(); // sueldo basico + adicional
        }

        private float adicional(){
            // 1 % del sueldo básico por cada año de antigüedad hasta los 20 años, a partir de este, el porcentaje se fija en 25%
            if(this.antiguedad() > 20){
                // por cada anio despues del 20, sumar 25% del sueldo basico
            } else{
                // por cada anio hasta 20, sumar 1% del sueldo basico
            }

            if(this.Cargo == Cargos.Ingeniero || this.Cargo == Cargos.Especialista){
                // el adicional aumenta un 50%
            }

            if(this.EstadoCivil == 'C'){
                // Si es casado al Adicional se le aumenta $150.000
            }
            return 0;
        }

    }

    public enum Cargos{
        Auxiliar,Administrativo, Ingeniero, Especialista, Investigador
    };
}