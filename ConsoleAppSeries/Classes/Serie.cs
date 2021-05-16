using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSeries
{
    public class Serie : EntidadeBase 
    {
        private Genero Genero { get; set; }       
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            return Id + "|" +
                   Genero + "|" +
                   Titulo + "|" +
                   Descricao + "|" + 
                   Ano;
        }

        public int retornaId()
        {
            return this.Id;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public void Excluir()
        {
            this.Excluido = true;
        }

        public bool retornarExcluido()
        {
            return this.Excluido;
        }
    }
}
