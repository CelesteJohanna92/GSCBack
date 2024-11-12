namespace ExampleAPI1.EjemploDeInterfaz
{
    public class Base
    {
        public string Jugar(IAnimal animal)
        {
            return animal.Jugar();
        }
    }
}
