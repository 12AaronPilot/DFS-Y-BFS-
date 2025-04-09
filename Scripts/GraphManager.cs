using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// Clase que construye un grafo de ejemplo y ejecuta BFS y DFS automáticamente al iniciar el juego.
public class GraphManager : MonoBehaviour
{
    private Grafo grafo;
    private Nodo nodoA, nodoB, nodoC, nodoD, nodoE;

    void Start()
    {
        grafo = new Grafo();

        // Crear nodos
        nodoA = new Nodo("A");
        nodoB = new Nodo("B");
        nodoC = new Nodo("C");
        nodoD = new Nodo("D");
        nodoE = new Nodo("E");

        // Establecer conexiones
        nodoA.AgregarVecino(nodoB);
        nodoA.AgregarVecino(nodoC);
        nodoB.AgregarVecino(nodoD);
        nodoC.AgregarVecino(nodoE);
        nodoD.AgregarVecino(nodoE);

        // Agregar nodos al grafo
        grafo.AgregarNodo(nodoA);
        grafo.AgregarNodo(nodoB);
        grafo.AgregarNodo(nodoC);
        grafo.AgregarNodo(nodoD);
        grafo.AgregarNodo(nodoE);

        // Ejecutar BFS
        Debug.Log("=== BFS ===");
        grafo.BFS(nodoA);

        // Ejecutar DFS
        Debug.Log("=== DFS ===");
        grafo.DFS(nodoA);
    }
}