public class Lista{

    public No inicio;
    public No fim;

    public Lista(){
        this.inicio = null;
        this.fim = null;
    }

    public void inserirInicio(int Valor){
        //INSERIR UM ELEMENTO NO INICIO DA LISTA
        No novoNo = new(Valor);

        //INSERINDO EM UMA LISTA VAZIA
        if(this.inicio == null && this.fim == null){
            this.inicio = novoNo;
            this.fim = novoNo;
        }
        else if(this.inicio != null){ //LISTA NÃO VAZIA
            novoNo.noProx = this.inicio;
            this.inicio = novoNo;
        }
    }

    public void inserirFim(int Valor){
        //INSERIR UM ELEMENTO NO FIM DA LISTA
        No novoNo new No(Valor);

        //INSERINDO EM UMA LISTA VAZIA
        if(this.inicio == null && this.fim == null){
            this.inicio = novoNo;
            this.fim = novoNo;
        }

        else if(this.inicio != null){ //LISTA NÃO VAZIA
            novoNo.noProx = this.inicio;
            this.inicio = novoNo;
        }


    }

    public void removerInicio(){
        //REMOVER UM ELEMENTO NO INICIO DA LISTA

        if (this.inicio == null){ //LISTA VAZIA
            Console.WriteLine("Lista null - vazia");
            return; 
        }

        if (this.inicio==this.fim){ //LISTA COM UM 
            
            this.inicio = null;
            this.fim = null;
            
        }
        else{
            this.inicio = this.inicio.noProx;
        }
    }

    public void removerFim(){
         //REMOVER UM ELEMENTO NO FIM DA LISTA

         if (this.inicio == null){
            Console.WriteLine("Lista null - vazia"); //LISTA VAZIA
            return; 
         }

        if (this.inicio==this.fim){ //LISTA COM UM 
            
            this.inicio = null;
            this.fim = null;
            return; 
        }
         
         // ENCONTRO DO NÓ
         No noAnterior = null;
         No noAtual = this.inicio;
         while (noAtual.noProx != null){
            noAnterior = noAtual;
            noAtual = noAtual.noProx;
         }

        //RECALCULANDO O FIM DA LISTA
         noAnterior.noProx = null;
         this.fim = noAnterior;

    }


    public Boolean consulta(int Valor, ref No noAtual, ref No noAnterior){ 
        
        noAtual = this.inicio;
        noAnterior = null;

        while(noAtual != null){

            if(noAtual.valor == Valor){ //SE ENCONTROU O VALOR
                return(true);
            }
            noAnterior = noAtual;
            noAtual = noAtual.noProx;
        }
    
        return(false);
    }

    public void percurso(){
        
        No noAux = this.inicio;

        while(noAux != null){
            Console.Write(noAux.valor + " -> ");
            noAux = noAux.noProx;            
        }
    }
}