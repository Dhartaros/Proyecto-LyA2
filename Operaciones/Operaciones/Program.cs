using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    public class StackOp
    {
        private Object[] pila;
        public Object tempData;
        private Object val;
        private int tope = -1;
        private int max = 0;
        
        public StackOp(int max)
        {
            this.max = max;
            pila = new Object[max];
        }

        public void DeleteStack()
        {
            tope = -1;
        }

        private bool IsFull()
        {
            bool res = false;
            if (tope == (max - 1))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }

        private bool IsEmpty()
        {
            bool res = false;
            if (tope == -1)
                res = true;
            return res;
        }

        public bool Push(char dato)
        {
            bool flag = false;
            if (!IsFull())
            {
                tope++;
                pila[tope] = dato;
                flag = true;
            }
            return flag;
        }

        public bool Pop()
        {
            bool flag = false;
            if (!IsEmpty())
            {
                val = pila[tope];
                tope--;
            }
            else
            {
                Console.WriteLine("Pila vacía. No se puede retirar más elementos.");
                res = "ERROR, no se puede retirar";
            }
            return flag;
        }

        public void PrintStack()
        {
            for (int i = tope; i >= 0; i--)
            {
                Console.WriteLine(pila[i]);
            }
        }

    }

    public class Postfija
    {
        public static void EvaluateExpression(String str)
        {
            StackOp pila = new StackOp(30);
            char op;                                            //Operador u operando
            for (int i = 0; i < str.Length; i++)
            {
                op = str.ElementAt(i);
                if (op >= '0' && op <= '9')
                {
                    if (!pila.Push(op))
                    {
                        System.out.println("La expresión posfija no puede evaluarse, PILA LLENA");
                        return;
                    }
                    continue;
                }
                else if (Car == '+' || Car == '-' || Car == '*' || Car == '/')
                {
                    if (!Obj.Retira())
                    {
                        System.out.println("La expresión posfija esta incorrecta");
                        return;
                    }
                    float V2 = Obj.Dr;

                    if (!Obj.Retira())
                    {
                        System.out.println("La expresión posfija esta incorrecta");
                        return;
                    }
                    float V1 = Obj.Dr;
                    float Res = 0.0f;
                    switch (Car)
                    {
                        case '+': Res = V1 + V2; break;
                        case '-': Res = V1 - V2; break;
                        case '*': Res = V1 * V2; break;
                        case '/': Res = V1 / V2; break;
                    }
                    Obj.Inserta(Res);
                }




            }
            if (Obj.Retira())
                System.out.println("Resultado= " + Obj.Dr);
        }
    }

    public class Nodo
    {
        public Nodo Izq, Der;
        public char val;
        public Nodo()
        {
            Izq = null;
            Der = null;
            this.val = '?';
        }
        public Nodo(char val)
        {
            Izq = null;
            Der = null;
            this.val = val;
        }
    }

    public class ArbolBinario
    {
        Nodo raiz = null;
        Nodo actual = null;
        Stack operandos = new Stack();
        Stack operadores = new Stack();
        public Nodo AgregaNodo(char val)
        {
            Nodo nuevo = new Nodo(val);
            //Primera inserción
            if (raiz.val == '?')
            {
                raiz = nuevo;
            }
            //Ya existe una raíz
            else
            {
                actual = raiz;
                while(true)
                {
                    Nodo temp = actual;
                    try
                    {
                        
                    }
                    catch
                    {

                    }
                }
            }
            return nuevo;
        }
        public void Preorden(Nodo raiz)
        {
            Console.Write(raiz.val);
            if (raiz.Izq != null)
                Preorden(raiz.Izq);
            if (raiz.Der != null)
                Preorden(raiz.Der);
        }
        public void Inorden(Nodo raiz)
        {
            if (raiz.Izq != null)
                Inorden(raiz.Izq);
            Console.Write(raiz.val);
            if (raiz.Der != null)
                Inorden(raiz.Der);
        }
        public void Postorden(Nodo raiz)
        {
            if (raiz.Izq != null)
                Postorden(raiz.Izq);
            if (raiz.Der != null)
                Postorden(raiz.Der);
            Console.Write(raiz.val);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
