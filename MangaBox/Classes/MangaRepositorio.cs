using System;
using System.Collections.Generic;
using MangaBox.Interfaces;

namespace MangaBox.Classes
{
    public class MangaRepositorio : IRepositorio<Manga>
    {

        private List<Manga> listaManga = new List<Manga>();
        
        public List<Manga> Lista()
        {
            return listaManga;
        }

        public Manga RetornaPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Insere(Manga entidade)
        {
            listaManga.Add(entidade);
        }

        public void Exclui(int id)
        {
            listaManga[id].Excluir();
        }

        public void Atualiza(int id, Manga entidade)
        {
            listaManga[id] = entidade;
        }

        public int ProximoId()
        {
            return listaManga.Count;
        }
    }
}