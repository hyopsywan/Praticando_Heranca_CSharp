namespace AtividadeHerancaPOO
{
    public class EntregaEconomica : Entrega
    {
        public EntregaEconomica(double distancia) : base(distancia)
        {
            Distancia = distancia;
        }

         public override decimal CalcularFrete()
        {
            return 
        }
    }
}