using System;

namespace DIO.Series
{
    public class Filme : Serie
    {
        public Filme(int id, Genero genero, string titulo, string descricao, int ano) : base(id, genero, titulo, descricao, ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }
    }
}