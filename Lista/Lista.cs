using System;

public class Lista
{
    public No inicializa;

    public void InserirOrdenado(string nome, int periodo, int cargaHoraria, string professorResponsavel)
    {
        No novoNo = new No
        {
            Nome = nome,
            Periodo = periodo,
            CargaHoraria = cargaHoraria,
            ProfessorResponsavel = professorResponsavel
        };

        if (inicializa == null)
        {
            novoNo.noProx = inicializa;
            inicializa = novoNo;
        }
        else
        {
            No atual = inicializa;
            while (atual.noProx != null)
            {
                atual = atual.noProx;
            }
            novoNo.noProx = atual.noProx;
            atual.noProx = novoNo;
        }
    }

    public bool Busca(string nome)
    {
        No atual = inicializa;
        while (atual != null)
        {
            if (atual.Nome ==(nome))
            {
                return true;
            }
            atual = atual.noProx;
        }
        return false;
    }

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
        }
        else
        {
            No atual = inicializa;
            while (atual != null)
            {
                Console.WriteLine("Disciplina: " + atual.Nome);
                Console.WriteLine("Período: " + atual.Periodo);
                Console.WriteLine("Carga Horária: " + atual.CargaHoraria);
                Console.WriteLine("Professor Responsável: " + atual.ProfessorResponsavel);
                Console.WriteLine();
                atual = atual.noProx;
            }
        }
    }
}
