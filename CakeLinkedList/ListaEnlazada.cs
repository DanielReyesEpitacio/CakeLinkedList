using System.Collections;
using System.Collections.Generic;

namespace CakeLinkedList
{
    //Implementa la interfaz 'Enumerable' para que sea considerado una estructura
    //de datos por el compilador y no solo emule una estructura de datos.
    public class ListaEnlazada<T> : IEnumerable<T>
    {
        private Nodo<T> head;
        private Nodo<T> foot;

        //Agrega un elemento al final de la lista.
        public void add(T item)
        {
            Nodo<T> newNode = new Nodo<T>(item);
            if (head == null)
            {
                head = newNode;
                foot = newNode;
            }
            else
            {
                foot.nextNode = newNode;
                newNode.previousNode = foot;
                foot = newNode;

            }
        }

        //Agrega un elemento al inicio de la lista.
        public void addHead(T item)
        {
            Nodo<T> newNode = new Nodo<T>(item);
            if (head == null)
            {
                head = newNode;
                foot = newNode;
            }
            else
            {
                newNode.nextNode = head;
                head.previousNode = newNode;
                head = newNode;
            }

        }

        public IEnumerator<T> GetEnumerator()
        {
            return new ListaEnlazadaEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        
        private class Nodo<T>
        {
            public T item { get; set; }
            public Nodo<T> nextNode { get; set; }
            public Nodo<T> previousNode { get; set; }

            public Nodo(T item)
            {
                this.item = item;
            }
        }

        private class ListaEnlazadaEnumerator : IEnumerator<T>
        {
            private Nodo<T> current;
            private ListaEnlazada<T> list;

            public ListaEnlazadaEnumerator(ListaEnlazada<T> list)
            {
                this.list = list;
                current = null;
            }

            public T Current
            {
                get { return current.item; }
            }

            object IEnumerator.Current
            {
                get { return Current; }
            }

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                if (current == null)
                {
                    current = list.head;
                }
                else
                {
                    current = current.nextNode;
                }

                return current != null;
            }

            public void Reset()
            {
                current = null;
            }
        }
    }
}
