namespace ExampleAPI1.EjemploDeHerencia
{
    public class Animal
    {
        public string Nombre { get; set; }
        public string Raza { get; set; }
        public int Edad { get; set; }

        public virtual string Comer()
        {
            return "Está comiendo";
        }
        public  virtual string Jugar()
        {
            return "Está jugando";
        }
    }
}
