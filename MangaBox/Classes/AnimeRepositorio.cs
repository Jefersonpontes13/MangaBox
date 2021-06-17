using System.Collections.Generic;
using MangaBox.Interfaces;

namespace MangaBox.Classes
{
    public class AnimeRepositorio : IRepositorio<Anime>
    {
        private List<Anime> listaAnime = new List<Anime>();
        
        public List<Anime> Lista()
        {
            return listaAnime;
        }

        public Anime RetornaPorId(int id)
        {
            return listaAnime[id];
        }

        public void Insere(Anime entidade)
        {
            listaAnime.Add(entidade);
        }

        public void Exclui(int id)
        {
            listaAnime[id].Excluir();
        }

        public void Atualiza(int id, Anime entidade)
        {
            listaAnime[id] = entidade;
        }

        public int ProximoId()
        {
            return listaAnime.Count;
        }
    }
}