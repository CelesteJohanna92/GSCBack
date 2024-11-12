namespace ExampleAPI1.EjemploDeHerencia
{
    public class Perro:Animal
    {
        public override string Comer()
        {
            return "El perro está comiendo";
        }
        public override string Jugar()
        {
            return "El perro está jugando";
        }
    }
}
