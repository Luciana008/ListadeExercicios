<<<<<<< HEAD
using System;

=======
>>>>>>> 8a8988dab21802cb7c190077a7074b185b60be92
public class Lista
{
    public No inicializa;

<<<<<<< HEAD
    public void InserirOrdenado(string nome, int periodo, int cargaHoraria, string professorResponsavel)
    {
        No novoNo = new No
        {
            Nome = nome,
            Periodo = periodo,
            CargaHoraria = cargaHoraria,
            ProfessorResponsavel = professorResponsavel
=======
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
>>>>>>> 8a8988dab21802cb7c190077a7074b185b60be92
        };

        if (inicializa == null)
        {
<<<<<<< HEAD
            novoNo.noProx = inicializa;
            inicializa = novoNo;
        }
=======
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
>>>>>>> 8a8988dab21802cb7c190077a7074b185b60be92
        else
        {
            No atual = inicializa;
            while (atual.noProx != null)
            {
                atual = atual.noProx;
            }
<<<<<<< HEAD
            novoNo.noProx = atual.noProx;
=======
>>>>>>> 8a8988dab21802cb7c190077a7074b185b60be92
            atual.noProx = novoNo;
        }
    }

    public bool Busca(string nome)
    {
        No atual = inicializa;
        while (atual != null)
        {
<<<<<<< HEAD
            if (atual.Nome ==(nome))
=======
            if (atual.nome == (nome))
>>>>>>> 8a8988dab21802cb7c190077a7074b185b60be92
            {
                return true;
            }
            atual = atual.noProx;
        }
        return false;
    }

<<<<<<< HEAD
    public void Remover(string nome)
    {
        if (inicializa == null)
        {
            Console.WriteLine("Lista null - vazia.");
            return;
        }

        if (inicializa.Nome == (nome))
        {
            inicializa = inicializa.noProx;
            Console.WriteLine("Disciplina excluída.");
            return;
        }

        No atual = inicializa;
        while (atual.noProx != null)
        {
            if (atual.noProx.Nome == (nome))
            {
                atual.noProx = atual.noProx.noProx;
                Console.WriteLine("Disciplina Excluída.");
                return;
            }
            atual = atual.noProx;
        }

        Console.WriteLine("Disciplina não foi encontrada.");
    }

    public void Imprimir()
    {
        if (inicializa == null)
        {
            Console.WriteLine("Lista  vazia.");
=======
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
>>>>>>> 8a8988dab21802cb7c190077a7074b185b60be92
        }
        else
        {
            No atual = inicializa;
            while (atual != null)
            {
<<<<<<< HEAD
                Console.WriteLine("Disciplina: " + atual.Nome);
                Console.WriteLine("Período: " + atual.Periodo);
                Console.WriteLine("Carga Horária: " + atual.CargaHoraria);
                Console.WriteLine("Professor Responsável: " + atual.ProfessorResponsavel);
=======
                Console.WriteLine("Nome: " + atual.nome);
                Console.WriteLine("Idade: " + atual.idade);
                Console.WriteLine("Telefone: " + atual.telefone);
                Console.WriteLine("Salário: " + atual.salario);
>>>>>>> 8a8988dab21802cb7c190077a7074b185b60be92
                Console.WriteLine();
                atual = atual.noProx;
            }
        }
    }
<<<<<<< HEAD
=======

    internal void InserirInicio(string? nome, int idade, string? telefone, double salario)
    {
        throw new NotImplementedException();
    }
>>>>>>> 8a8988dab21802cb7c190077a7074b185b60be92
}
