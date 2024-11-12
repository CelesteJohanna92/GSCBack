namespace ExampleAPI1.EjemploDeHerencia
{
    public class Gato:Animal
    {
        public override string Comer()
        {
            return "El gato está comiendo";
        }
        public override string Jugar()
        {
            return "El gato está jugando";
        }
    }
}
