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
                    Console.WriteLine("1) Adicionar no inicio");
                    Console.WriteLine("2) Adicionar no fim");
                    Console.WriteLine("3) Verificar nome");
                    Console.WriteLine("4) Excluí no inicio");
                    Console.WriteLine("5) Excluí no fim");
                    Console.WriteLine("6) Exibe as informações");
                    Console.WriteLine("s) Sair");
                    Console.Write("Opção: ");
                    selecao = Console.ReadLine();

                    switch (selecao)
                    {
                        case "1":
                            Console.Write("Digite o nome do funcionário: ");
                            string nome = Console.ReadLine();
                            Console.Write("Digite a idade: ");
                            int idade = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Digite o telefone: ");
                            string telefone = Console.ReadLine();
                            Console.Write("Digite o salário: ");
                            double salario = Convert.ToDouble(Console.ReadLine());
                            lista.InserirInicio(nome, idade, telefone, salario);
                            Console.WriteLine("Funcionário >> início da lista.");
                            break;

                        case "2":
                            Console.Write("Digite o nome do funcionário: ");
                            nome = Console.ReadLine();
                            Console.Write("Digite a idade: ");
                            idade = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Digite o telefone: ");
                            telefone = Console.ReadLine();
                            Console.Write("Digite o salário: ");
                            salario = Convert.ToDouble(Console.ReadLine());
                            lista.InserirFim(nome, idade, telefone, salario);
                            Console.WriteLine("Funcionário >> Fim da lista.");
                            break;

                        case "3":
                            Console.Write("Digite o nome do funcionário a ser buscado: ");
                            nome = Console.ReadLine();
                            if (lista.Busca(nome))
                            {
                                Console.WriteLine("O funcionário consta na lista.");
                            }
                            else
                            {
                                Console.WriteLine("O funcionário não consta na lista.");
                            }
                            break;

                        case "4":
                            lista.RemoverInicio();
                            break;

                        case "5":
                            lista.RemoverFim();
                            break;
                        case "6":
                            lista.impressao();
                            break;

                        case "7":
                            Console.WriteLine("...");
                            break;
                    }
                     Console.WriteLine();
                }
            }
        }
    }
}
