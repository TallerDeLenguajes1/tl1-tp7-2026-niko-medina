namespace EspacioCalculadora {
    class Calculadora{
        private double dato;

        public Calculadora(double numero){
            this.dato = numero;
        }

        public void Sumar(double termino)
        {
            dato += termino;
        }
        public void Restar(double termino)
        {
            dato -= termino;
        }
        public void Multiplicar(double termino)
        {
            dato *= termino;
        }
        public void Dividir(double termino)
        {
            dato /= termino;
        }
        public void Limpiar(double termino)
        {
            dato = 0;
        }

        public double Resultado(){
            return dato;
        }
    }

}