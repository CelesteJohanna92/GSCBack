using System.Reflection.Metadata.Ecma335;

namespace ExampleAPI1.EjemploDeInterfaz
{
    public class Perro : IAnimal
    {
        public string Comer()
        {
            return "El perro está comiendo";
        }
        public string Jugar()
        {
            return "El Gato está jugando";
        }
    }

}
