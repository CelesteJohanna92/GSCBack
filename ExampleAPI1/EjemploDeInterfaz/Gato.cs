namespace ExampleAPI1.EjemploDeInterfaz
{
    public class Gato: IAnimal
    {
        public string Comer()
        {
            return "El Gato está comiendo";
        }
        public string Jugar()
        {
            return "El Gato está jugando";
        }
    }
}
