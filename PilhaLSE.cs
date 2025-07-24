using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
    {
        class Program
        {
            static void Main(string[] args)
            {
                Pilha pilha = new Pilha();
                Lista lista = new Lista();
                int sair = 0;
                while (sair == 0)
                {
                    imprimeOpcoes();
                    int opcao = int.Parse(Console.ReadLine());
                    switch (opcao)
                    {
                        case 1:
                            Console.Write("\nDigite um número para inserir na pilha: ");
                            int a = int.Parse(Console.ReadLine());
                            pilha.Push(a);
                            lista.SetElemento(a);
                            break;

                        case 2:
                            pilha.Pop();
                            break;

                        case 3:
                            pilha.ImprimirPilha();
                            break;

                        case 4:
                            sair = 1;
                            break;
                    }
                }
            }
            static public void imprimeOpcoes()
            {
                Console.WriteLine("\nEscolha uma opção:\n");
                Console.WriteLine("1 - Inserir na pilha");
                Console.WriteLine("2 - Tirar da pilha");
                Console.WriteLine("3 - Imprimir pilha");
                Console.WriteLine("4 - Sair\n");
            }
        }
        class Lista
        {
            private int elemento;
            private Lista proximo;
            public void SetElemento(int elemento)
            {
                this.elemento = elemento;
            }
            public int GetElemento()
            {
                return elemento;
            }
            public void SetProximo(Lista proximo)
            {
                this.proximo = proximo;
            }
            public Lista GetProximo()
            {
                return proximo;
            }
        }
        class Pilha
        {
            private int tamanho;
            private Lista topo;
            public Pilha() /* Método construtor */
            {
                topo = null;
                tamanho = 0;
            }
            public int GetTamanho()
            {
                return tamanho;
            }
            public void Push(int valor)   /* Método para empilhar */
            {
                Lista lista = new Lista();
                lista.SetElemento(valor);
                lista.SetProximo(topo);
                tamanho++;
                topo = lista;
            }
            public int Pop() /* Método para desempilhar */
            {
                if (GetTamanho() == 0) Console.WriteLine("Pilha Vazia!");
                int element = topo.GetElemento();
                if (GetTamanho() == 1)
                {
                    topo = null;
                }
                topo = topo.GetProximo();
                tamanho--;
                return element;
            }
            public bool IsEmpty()
            {
                return (topo == null);
            }
            public void ImprimirPilha()    /* Método para imprimir a pilha */
            {
                if (topo == null)
                {
                    Console.WriteLine("Pilha Vazia!\n");
                }
                else
                {
                    Console.WriteLine($"O tamanho da pilha é: {GetTamanho()}\n");
                    Lista lista = topo;
                    while (lista != null)
                    {
                        Console.Write($"{lista.GetElemento()} ");
                        Console.WriteLine("\n");
                        lista = lista.GetProximo();
                    }
                }
            }
        }
    }
