#include <iostream>
using namespace std;

#define QTD_NUMEROS 30

#pragma region Funcoes Pilha
struct No {
	int dado;
	No *prox;
};

struct Pilha
{
	No *topo;
};

Pilha* init() {
	Pilha *pilha = new Pilha;
	pilha->topo = NULL;
	return pilha;
}

void push(Pilha *pilha, int valor) {
	No *no = new No;
	no->dado = valor;
	no->prox = pilha->topo;
	pilha->topo = no;
}

int pop(Pilha *pilha) {
	int ret;
	int podeDesempilhar = (pilha->topo != NULL);
	if (podeDesempilhar) {
		No *no = pilha->topo;
		ret = no->dado;
		pilha->topo = pilha->topo->prox;
		free(no);
	}
	else
	{
		ret = NULL;
	}
	return ret;
}

int isEmpty(Pilha *pilha) {
	return (pilha->topo == NULL);
}

int count(Pilha *pilha) {
	int i=0;
	No *no;
	no = pilha->topo;
	while (no != NULL) {
		i++;
		no = no->prox;
	}
	return i;
}

void print(Pilha *pilha) {
	No *no;
	no = pilha->topo;
	cout << "------" << endl;
    cout << "Qtde: " << count(pilha) << endl << endl;
	while (no != NULL) {
		cout << no->dado << endl;
		no = no->prox;
	}
	cout << "------" << endl;
}

void freePilha(Pilha *pilha) {
	No *no = pilha->topo;
	while (no != NULL) {
		No *aux = no->prox;
		free(no);
		no = aux;
	}
	
}
#pragma endregion


void digitarNumeros(Pilha *pilhaImpares, Pilha *pilhaPares)
{
    int num, maiorNumero = NULL;
    for(int i = 0; i < QTD_NUMEROS; i ++)
    {
		do
    	{
			cout << "Digite o " << i + 1 << "� numero: ";
			cin >> num;
			
			if(i == 0){
				maiorNumero = num;
			}
			
			if(num <= maiorNumero && i != 0)
	        {
	        	cout << "Numero invalido, digite um numero maior que anterior" << endl;	
			}
	     	
	    }while(num <= maiorNumero && i != 0);
	    
	    maiorNumero = num;
	    
        if(num % 2 == 0){
            push(pilhaPares, num);
        }else{
            push(pilhaImpares, num);
        }
    }
}


int main(int argc, char** argv)
{
    setlocale(LC_ALL, "");

	Pilha *pilhaImpares;
    Pilha *pilhaPares;

	pilhaImpares = init();
    pilhaPares = init();

	digitarNumeros(pilhaImpares, pilhaPares);
	
    cout << endl << "Pilha de impares: " << endl;
    print(pilhaImpares);

    cout << endl << "Pilha de pares: " << endl;
    print(pilhaPares);
		
	return 0;
}