namespace Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();
            string selecao = "";

            while (selecao != "s")
            {
                {
                    Console.WriteLine("Escolha uma opção:");
                    Console.WriteLine("1) Inserção ordenada");
                    Console.WriteLine("2) Consulta");
                    Console.WriteLine("3) Remoção de um elemento por nome");
                    Console.WriteLine("4) Impressão");
                    Console.WriteLine("s) Impressão");
                    Console.WriteLine("Opção: ");
                    selecao = Console.ReadLine();

                    switch (selecao)
                    {
                        case "1":
                            Console.WriteLine("Digite a disciplina: ");
                            string nome = Console.ReadLine();
                            Console.WriteLine("Digite o período: ");
                            int periodo = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Digite a carga horária: ");
                            int cargaHoraria = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Digite o nome do professor: ");
                            string professorResponsavel = Console.ReadLine();
                            lista.InserirOrdenado(
                                nome,
                                periodo,
                                cargaHoraria,
                                professorResponsavel
                            );
                            Console.WriteLine("Disciplina cadastrada.");
                            break;

                        case "2":
                            Console.Write("Digite o nome da disciplina: ");
                            nome = Console.ReadLine();
                            if (lista.Busca(nome))
                            {
                                Console.WriteLine("Disciplina na lista ");
                            }
                            else
                            {
                                Console.WriteLine("Disciplina não esta apresentada na lista");
                            }
                            break;

                        case "3":
                            Console.Write("Digite o nome da disciplina para ser excluída: ");
                            nome = Console.ReadLine();
                            lista.Remover(nome);
                            break;
                        case "4":
                            lista.Imprimir();
                            break;
                        
                        case "s":
                             Console.WriteLine("...");
                            break;
                            
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
