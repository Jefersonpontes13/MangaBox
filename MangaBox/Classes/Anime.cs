using System;
using MangaBox.Enum;

namespace MangaBox.Classes
{
    public class Anime : EntidadeBase
    {
        private string Titulo { get; set; }
        private int Ano { get; set; }
        private string Descricao { get; set; }
        private Genero Genero { get; set; }
        private Demografia Demografia { get; set; }
        private bool Excluido { get; set; }

        public Anime(int id, Genero genero, Demografia demografia, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Titulo = titulo;
            this.Ano = ano;
            this.Descricao = descricao;
            this.Genero = genero;
            this.Demografia = demografia;
            this.Excluido = false;
        }

        public string ToStrig()
        {
            // Environment.NewLine https://docs
            string retorno = "";
            retorno += "Título: " + this.Titulo + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Demografia: " + this.Demografia + Environment.NewLine;
            retorno += "Excluído: " + this.Excluido + Environment.NewLine;
            return retorno;

        }

        public string RetornaTitulo()
        {
            return this.Titulo;
        }        
        
        
        public int RetornaId()
        {
            return this.Id;
        }
        
        public bool RetornaExcluido()
        {
            return this.Excluido;
        }

        public void Excluir()
        {
            this.Excluido = true;
        }
    }
}