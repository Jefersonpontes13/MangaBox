using System;
using MangaBox.Classes;
using MangaBox.Enum;

namespace MangaBox
{
    class Program
    {
        private static MangaRepositorio repositorioManga = new MangaRepositorio();
        private static AnimeRepositorio repositorioAnime = new AnimeRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = "";

            while (opcaoUsuario.ToUpper() != "X")
            {
                opcaoUsuario = ObterOpcaoUsuario();

                switch (opcaoUsuario)
                {
                    case "M":
                        MangaBox();
                        break;
                    case "A":
                        AnimeBox();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    case "X":
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        private static void MangaBox()
        {
                            
            string opcaoUsuario = ObterOpcaoUsuarioManga();
                
            switch (opcaoUsuario)
            {
                case "1":
                    ListarMangas();
                    break;
                case "2":
                    InserirManga();
                    break;
                case "3":
                    AtualizarManga();
                    break;
                case "4":
                    ExcluirManga();
                    break;
                case "5":
                    VisualizarManga();
                    break;
                case "C":
                    Console.Clear();
                    break;
                case "X":
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
       
        private static void AnimeBox()
        {
                            
            string opcaoUsuario = ObterOpcaoUsuarioAnime();
                
            switch (opcaoUsuario)
            {
                case "1":
                    ListarAnimes();
                    break;
                case "2":
                    InserirAnime();
                    break;
                case "3":
                    AtualizarAnime();
                    break;
                case "4":
                    ExcluirAnime();
                    break;
                case "5":
                    VisualizarAnime();
                    break;
                case "C":
                    Console.Clear();
                    break;
                case "X":
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        
        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine(" --- Box --- ");
            Console.WriteLine("Informe a opção desejada: ");

            Console.WriteLine("M - Mangá Box");
            Console.WriteLine("A - Anime Box");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
                
        private static string ObterOpcaoUsuarioManga()
        {
            Console.WriteLine();
            Console.WriteLine(" --- Mangá Box --- ");
            Console.WriteLine("Informe a opção desejada: ");

            Console.WriteLine("1 - Listar Mangás");
            Console.WriteLine("2 - Inserir Novo Mangá");
            Console.WriteLine("3 - Atualizar Mangá");
            Console.WriteLine("4 - Excluir Mangá");
            Console.WriteLine("5 - Visualizar Mangá");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
        
        private static string ObterOpcaoUsuarioAnime()
        {
            Console.WriteLine();
            Console.WriteLine(" --- Anime Box --- ");
            Console.WriteLine("Informe a opção desejada: ");

            Console.WriteLine("1 - Listar Animes");
            Console.WriteLine("2 - Inserir Novo Anime");
            Console.WriteLine("3 - Atualizar Anime");
            Console.WriteLine("4 - Excluir Anime");
            Console.WriteLine("5 - Visualizar Anime");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }

        private static Manga ObterMangaDoUsuario(int id)
        {
            foreach (int genero in System.Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} - {1}", genero, System.Enum.GetName(typeof(Genero), genero));
            }
            
            Console.WriteLine("Digite um Gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());            
                        
            Console.WriteLine();
            foreach (int demografia in System.Enum.GetValues(typeof(Demografia)))
            {
                Console.WriteLine("{0} - {1}", demografia, System.Enum.GetName(typeof(Demografia), demografia));
            }
            
            Console.WriteLine("Digite um Demografia entre as opções acima: ");
            int entradaDemografia = int.Parse(Console.ReadLine());            
            
            Console.WriteLine("Digite o Título do Mangá: ");
            string entradaTitulo = Console.ReadLine();
            
            Console.WriteLine("Digite o Ano do Mangá: ");
            int entradaAno = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite a Descrição do Mangá: ");
            string entradaDescricao = Console.ReadLine();

            Manga novoManga = new Manga(
                id: id,
                titulo: entradaTitulo,
                ano: entradaAno,
                descricao: entradaDescricao,                
                genero: (Genero)entradaGenero,
                demografia: (Demografia)entradaDemografia
            );
            return novoManga;
        }

        private static Anime ObterAnimeDoUsuario(int id)
        {
            foreach (int genero in System.Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} - {1}", genero, System.Enum.GetName(typeof(Genero), genero));
            }
            
            Console.WriteLine("Digite um Gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());            
                        
            Console.WriteLine();
            foreach (int demografia in System.Enum.GetValues(typeof(Demografia)))
            {
                Console.WriteLine("{0} - {1}", demografia, System.Enum.GetName(typeof(Demografia), demografia));
            }
            
            Console.WriteLine("Digite um Demografia entre as opções acima: ");
            int entradaDemografia = int.Parse(Console.ReadLine());            
            
            Console.WriteLine("Digite o Título do Anime: ");
            string entradaTitulo = Console.ReadLine();
            
            Console.WriteLine("Digite o Ano do Anime: ");
            int entradaAno = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite a Descrição do Anime: ");
            string entradaDescricao = Console.ReadLine();

            Anime novoAnime = new Anime(
                id: id,
                titulo: entradaTitulo,
                ano: entradaAno,
                descricao: entradaDescricao,                
                genero: (Genero)entradaGenero,
                demografia: (Demografia)entradaDemografia
            );
            return novoAnime;
        }

        private static void VisualizarManga()
        {
            Console.WriteLine("Digite o Id do Mangá: ");

            var manga = repositorioManga.RetornaPorId(int.Parse(Console.ReadLine()));
            
            Console.WriteLine(manga.ToStrig());
            
        }

        private static void VisualizarAnime()
        {
            Console.WriteLine("Digite o Id do Anime: ");

            var anime = repositorioAnime.RetornaPorId(int.Parse(Console.ReadLine()));
            
            Console.WriteLine(anime.ToStrig());
            
        }

        private static void ExcluirManga()
        {
            Console.Write("Digite o Id do Mangá: ");
            repositorioManga.Exclui(int.Parse(Console.ReadLine()));
        }

        private static void ExcluirAnime()
        {
            Console.Write("Digite o Id do Anime: ");
            repositorioAnime.Exclui(int.Parse(Console.ReadLine()));
        }

        private static void AtualizarManga()
        {
            Console.WriteLine("Digite o Id do Mangá: ");
            int indiceManga = int.Parse(Console.ReadLine());
            
            repositorioManga.Atualiza(indiceManga, ObterMangaDoUsuario(indiceManga));
        }
        
        private static void AtualizarAnime()
        {
            Console.WriteLine("Digite o Id do Anime: ");
            int indiceAnime = int.Parse(Console.ReadLine());
            
            repositorioManga.Atualiza(indiceAnime, ObterMangaDoUsuario(indiceAnime));
        }
        
        private static void ListarMangas()
        {
            Console.WriteLine(" -- Listar Mangás -- ");
            var lista = repositorioManga.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Não há Mangás cadastrados !");
                return;
            }

            foreach (var manga in lista)
            {
                var excluido = manga.RetornaExcluido();

                Console.WriteLine("#ID {0}: - {1} - {2}", 
                    manga.RetornaId(), 
                    manga.RetornaTitulo(), 
                    excluido ? "Excluido" : "");
            }
        }
        
        private static void ListarAnimes()
        {
            Console.WriteLine(" -- Listar Animes -- ");
            var lista = repositorioAnime.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Não há Animes cadastrados !");
                return;
            }

            foreach (var anime in lista)
            {
                var excluido = anime.RetornaExcluido();

                Console.WriteLine("#ID {0}: - {1} - {2}", 
                    anime.RetornaId(), 
                    anime.RetornaTitulo(), 
                    excluido ? "Excluido" : "");
            }
        }

        private static void InserirManga()
        {
            
            Console.WriteLine("-- Inserir novo Mangá --");
            
            repositorioManga.Insere(ObterMangaDoUsuario(repositorioManga.ProximoId()));
        }

        private static void InserirAnime()
        {
            
            Console.WriteLine("-- Inserir novo Anime --");
            
            repositorioAnime.Insere(ObterAnimeDoUsuario(repositorioAnime.ProximoId()));
        }

    }
}