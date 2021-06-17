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
            throw new NotImplementedException();
        }

        public Manga RetornaPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Insere(Manga entidade)
        {
            throw new NotImplementedException();
        }

        public void Exclui(int id)
        {
            throw new NotImplementedException();
        }

        public void Atualiza(int id, Manga entidade)
        {
            throw new NotImplementedException();
        }

        public int ProximoId()
        {
            throw new NotImplementedException();
        }
    }
}