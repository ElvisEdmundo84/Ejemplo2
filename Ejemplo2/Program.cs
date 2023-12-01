namespace PrimerPrograma 
{
    class Program
    {
        static void Main(string[] args) 
        {   //Aquí estamos sobreescribiendo sobre nuestra plantilla de la clase Auto
            Console.WriteLine("-------------------------");
            Auto nissan = new Auto();
            nissan.color = "rojo";
            nissan.modelo = 1232;
            nissan.marca = "ABC";
            Console.WriteLine("---------MÉTODOS---------");
            nissan.acelera ();
            nissan.enciende ();

        }

    }

    class Auto //Esta es nuestra plantilla para la clase auto
    {
        public string color = " ";
        public int modelo = 0;
        public string marca = " ";

        public void enciende()
        {
            Console.WriteLine("Se enciende el auto");
        }
        public void acelera()
        {
            Console.WriteLine("Se acelera el auto");
        }
    }
}

