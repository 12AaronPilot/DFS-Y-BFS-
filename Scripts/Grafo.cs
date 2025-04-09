using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Representa un grafo compuesto por nodos y aristas. Contiene algoritmos de búsqueda (BFS y DFS).
public class Grafo
{
    public List<Nodo> nodos = new List<Nodo>(); // Lista de nodos del grafo

    // Algoritmo BFS (Breadth-First Search). Recorre el grafo por niveles.
    public void BFS(Nodo inicio)
    {
        Queue<Nodo> cola = new Queue<Nodo>();          // Cola para BFS
        HashSet<Nodo> visitados = new HashSet<Nodo>(); // Conjunto de nodos ya visitados

        cola.Enqueue(inicio);
        visitados.Add(inicio);

        while (cola.Count > 0)
        {
            Nodo actual = cola.Dequeue();
            Debug.Log("Visitando nodo: " + actual.Nombre);

            foreach (Edge arista in actual.Vecinos)
            {
                if (!visitados.Contains(arista.Destino))
                {
                    cola.Enqueue(arista.Destino);
                    visitados.Add(arista.Destino);
                }
            }
        }
    }
    /// Algoritmo DFS (Depth-First Search). Recorre el grafo en profundidad.
    public void DFS(Nodo inicio)
    {
        HashSet<Nodo> visitados = new HashSet<Nodo>();
        DFSRecursivo(inicio, visitados);
    }

    private void DFSRecursivo(Nodo nodo, HashSet<Nodo> visitados)
    {
        if (visitados.Contains(nodo)) return;

        visitados.Add(nodo);
        Debug.Log("Visitando nodo: " + nodo.Nombre);

        foreach (Edge arista in nodo.Vecinos)
        {
            DFSRecursivo(arista.Destino, visitados);
        }
    }

    /// Agrega un nodo al grafo.
    public void AgregarNodo(Nodo nodo)
    {
        nodos.Add(nodo);
    }
}