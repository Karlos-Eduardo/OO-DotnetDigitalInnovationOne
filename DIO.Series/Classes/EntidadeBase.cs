namespace DIO.Series
{
    public abstract class EntidadeBase
    {
        protected int Id { get; set; }
        //Atributos
        protected Genero Genero { get; set; }
        protected string Titulo { get; set; }
        protected string Descricao { get; set; }
        protected int Ano { get; set; }
        protected bool Excluido {get; set; }
    }
}