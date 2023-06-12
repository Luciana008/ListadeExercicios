public class Lista
{
    public No inicializa;

    public void inserirInicio(string Nome, int Idade, string Telefone, double Salario)
    {
        //INSERIR UM ELEMENTO NO INICIO DA LISTA

        No novoNo = new No
        {
            //INSERINDO O FUNCIONÁRIO NO INICIO
            nome = Nome,
            idade = Idade,
            telefone = Telefone,
            salario = Salario
        };

        if (inicializa == null)
        {
            inicializa = novoNo;
        }
        else
        {
            novoNo.noProx = inicializa;
            inicializa = novoNo;
        }
    }

    public void InserirFim(string Nome, int Idade, string Telefone, double Salario)
    {
        //INSERIR UM ELEMENTO NO FIM DA LISTA

        No novoNo = new No
        {
            //INSERINDO O FUNCIONÁRIO NO FIM
            nome = Nome,
            idade = Idade,
            telefone = Telefone,
            salario = Salario
        };

        if (inicializa == null)
        {
            inicializa = novoNo;
        }
        else
        {
            No atual = inicializa;
            while (atual.noProx != null)
            {
                atual = atual.noProx;
            }
            atual.noProx = novoNo;
        }
    }

    public bool Busca(string nome)
    {
        No atual = inicializa;
        while (atual != null)
        {
            if (atual.nome == (nome))
            {
                return true;
            }
            atual = atual.noProx;
        }
        return false;
    }

    public void RemoverInicio()
    {
        //REMOVE UM ELEMENTO NO INICIO

        if (inicializa == null)
        {
            Console.WriteLine("Lista null - vazia.");
        }
        else
        {
            inicializa = inicializa.noProx;
            Console.WriteLine("Excluído >> primeiro elemento da lista.");
        }
    }

    public void RemoverFim()
    {
        //REMOVE UM ELEMENTO NO FIM
        if (inicializa == null)
        {
            Console.WriteLine("Lista null - vazia.");
        }
        else if (inicializa.noProx == null)
        {
            inicializa = null;
            Console.WriteLine("Removido >> último elemento");
        }
        else
        {
            No atual = inicializa;
            while (atual.noProx.noProx != null)
            {
                atual = atual.noProx;
            }
            atual.noProx = null;
            Console.WriteLine("Removido >> último elemento");
        }
    }

     public void impressao()
    {
        if (inicializa == null)
        {
            Console.WriteLine("A lista está vazia.");
        }
        else
        {
            No atual = inicializa;
            while (atual != null)
            {
                Console.WriteLine("Nome: " + atual.nome);
                Console.WriteLine("Idade: " + atual.idade);
                Console.WriteLine("Telefone: " + atual.telefone);
                Console.WriteLine("Salário: " + atual.salario);
                Console.WriteLine();
                atual = atual.noProx;
            }
        }
    }

    internal void InserirInicio(string? nome, int idade, string? telefone, double salario)
    {
        throw new NotImplementedException();
    }
}
