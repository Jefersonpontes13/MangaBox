using System;
using MangaBox.Classes;
using MangaBox.Enum;

namespace MangaBox
{
    class Program
    {
        private static MangaRepositorio repositorio = new MangaRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = "";

            while (opcaoUsuario.ToUpper() != "X")
            {
                opcaoUsuario = ObterOpcaoUsuario();
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarMangas();
                        break;
                    case "2":
                        InserirManga();
                        break;
                    case "3":
                        AtualizarMangas();
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
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }
        
        private static string ObterOpcaoUsuario()
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

        private static void VisualizarManga()
        {
            Console.WriteLine("Digite o Id do Mangá: ");

            var manga = repositorio.RetornaPorId(int.Parse(Console.ReadLine()));
            
            Console.WriteLine(manga.ToStrig());
            
        }

        private static void ExcluirManga()
        {
            Console.Write("Digite o Id do Mangá: ");
            repositorio.Exclui(int.Parse(Console.ReadLine()));
        }

        private static void AtualizarMangas()
        {
            Console.WriteLine("Digite o Id do Mangá: ");
            int indiceManga = int.Parse(Console.ReadLine());
            
            repositorio.Atualiza(indiceManga, ObterMangaDoUsuario(indiceManga));
        }
        
        private static void ListarMangas()
        {
            Console.WriteLine(" -- Listar Mangás -- ");
            var lista = repositorio.Lista();

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

        private static void InserirManga()
        {
            
            Console.WriteLine("-- Inserir novo Mangá --");
            
            repositorio.Insere(ObterMangaDoUsuario(repositorio.ProximoId()));
        }

    }
}