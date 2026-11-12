namespace AtividadeHerancaPOO
{
    public abstract class Entrega
    {
        public double Distancia { set; get;}

        public Entrega()
        {
            
        }

        public Entrega(double distancia)
        {
            Distancia = distancia;
        }

        public abstract decimal CalcularFrete();

    }
}