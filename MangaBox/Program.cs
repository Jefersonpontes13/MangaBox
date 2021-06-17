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
                       // AtualizarMangas();
                        break;
                    case "4":
                       // ExcluirMangas();
                        break;
                    case "5":
                       // VisualizarrMangas();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
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
                Console.WriteLine("#ID {0}: - {1}", manga.RetornaId(), manga.RetornaTitulo());
            }
        }

        private static void InserirManga()
        {
            
            Console.WriteLine("-- Inserir novo Mangá --");
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
                id: repositorio.ProximoId(),
                titulo: entradaTitulo,
                ano: entradaAno,
                descricao: entradaDescricao,                
                genero: (Genero)entradaGenero,
                demografia: (Demografia)entradaDemografia
            );
            repositorio.Insere(novoManga);
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine(" --- Mangá Box --- ");
            Console.WriteLine("Informe a opção desejada: ");

            Console.WriteLine("1 - Listar Mangás");
            Console.WriteLine("2 - Inserir Novo Mangá");
            Console.WriteLine("3 - Excluir Mangá");
            Console.WriteLine("4 - Excluir Mangá");
            Console.WriteLine("5 - Visualizar Mangá");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}