using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    private Nave nave;

    void Start() => nave = GameObject.Find("Player").GetComponent<Nave>();

    public void Rotate()
    {
        // rotação
        if (this.gameObject.name == "right") { nave.turnDir = 1; } // direita
        else if (this.gameObject.name == "left") { nave.turnDir = -1; } // esquerda
        else { nave.turnDir = 0; }
    }

    public void NotRotating() { nave.turnDir = 0; }
}