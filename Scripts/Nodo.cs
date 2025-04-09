using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Representa un nodo del grafo. Cada nodo puede tener múltiples vecinos conectados mediante aristas.

public class Nodo
{
    public string Nombre;                 // Identificador del nodo (por ejemplo, "A", "B", etc.)
    public List<Edge> Vecinos;           // Lista de conexiones (aristas) hacia otros nodos

    public Nodo(string nombre)
    {
        Nombre = nombre;
        Vecinos = new List<Edge>();      // Inicializa la lista de vecinos
    }

    /// Conecta este nodo a otro nodo mediante una arista.
    // <param name="destino">Nodo destino</param>
    // <param name="costo">Costo de la conexión (por defecto 1)</param>
    public void AgregarVecino(Nodo destino, int costo = 1)
    {
        Vecinos.Add(new Edge(this, destino, costo));
    }
}