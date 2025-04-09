using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrafoVisual : MonoBehaviour
{
    private Dictionary<string, NodoVisual> nodos = new Dictionary<string, NodoVisual>();

    private void Start()
    {
        // Buscar todos los nodos visuales en la escena
        NodoVisual[] todosLosNodos = FindObjectsOfType<NodoVisual>();

        // Guardar nodos por nombre
        foreach (var nodo in todosLosNodos)
        {
            nodos[nodo.nombreNodo] = nodo;
            Debug.Log("Nodo encontrado: " + nodo.nombreNodo);
        }

       
        StartCoroutine(BFSVisual("Nodo_A"));
        // StartCoroutine(DFSVisual("Nodo_A"));
    }

    private IEnumerator BFSVisual(string inicio)
    {
        Queue<NodoVisual> cola = new Queue<NodoVisual>();
        HashSet<NodoVisual> visitados = new HashSet<NodoVisual>();

        NodoVisual nodoInicio = nodos[inicio];
        cola.Enqueue(nodoInicio);
        visitados.Add(nodoInicio);

        while (cola.Count > 0)
        {
            NodoVisual actual = cola.Dequeue();
            actual.Pintar(Color.yellow); // Pintar nodo visitado
            Debug.Log("Visitando: " + actual.nombreNodo);
            yield return new WaitForSeconds(0.5f); // Espera visual

            foreach (var vecino in actual.vecinos)
            {
                if (!visitados.Contains(vecino))
                {
                    cola.Enqueue(vecino);
                    visitados.Add(vecino);
                }
            }
        }
    }

    private IEnumerator DFSVisual(string inicio)
    {
        HashSet<NodoVisual> visitados = new HashSet<NodoVisual>();
        yield return DFSRecursivo(nodos[inicio], visitados);
    }

    private IEnumerator DFSRecursivo(NodoVisual nodo, HashSet<NodoVisual> visitados)
    {
        if (visitados.Contains(nodo)) yield break;

        visitados.Add(nodo);
        nodo.Pintar(Color.cyan);
        Debug.Log("Visitando: " + nodo.nombreNodo);
        yield return new WaitForSeconds(0.5f);

        foreach (var vecino in nodo.vecinos)
        {
            yield return DFSRecursivo(vecino, visitados);
        }
    }
}