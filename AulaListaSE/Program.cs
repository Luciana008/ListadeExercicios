﻿namespace AulaListaSE{

    class Program{
        static void Main(string[] args){

            Lista lista = new();
            lista.inserirInicio(22);
            lista.inserirInicio(12);
            lista.inserirInicio(7);
            //7 -> 12 -> 22 -> NULL
            lista.percurso();

            lista.inserirFim(25);
            //7 -> 12 -> 22 -> 25-> NULL
            lista.percurso();



            
            No noAtual = null;
            No noAnterior = null;

            Boolean encontrou = lista.consulta(12, ref noAtual, ref noAnterior);
            if(encontrou){
                Console.WriteLine("Encontrou o no de valor: " + noAtual.valor);
            }
            else{
                Console.WriteLine("Não encontrou o no procurado!");
            }
        }
    }
}

