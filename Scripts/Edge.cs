using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Representa una arista (conexión) entre dos nodos en el grafo.
public class Edge
{
    public Nodo Origen;     // Nodo de origen
    public Nodo Destino;    // Nodo destino
    public int Costo;       // Costo del camino (por defecto 1)

    public Edge(Nodo origen, Nodo destino, int costo = 1)
    {
        Origen = origen;
        Destino = destino;
        Costo = costo;
    }
}

