using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodoVisual : MonoBehaviour
{
    public string nombreNodo;
    public NodoVisual[] vecinos;

    private SpriteRenderer render;

    private void Awake()
    {
        render = GetComponent<SpriteRenderer>();
        nombreNodo = gameObject.name;
    }

    public void Pintar(Color color)
    {
        if (render != null)
        {
            render.color = color;
        }
        else
        {
            Debug.LogWarning("SpriteRenderer no encontrado en " + nombreNodo);
        }
    }
}