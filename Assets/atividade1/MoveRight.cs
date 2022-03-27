using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : MonoBehaviour
{
    void Update()
    {
        Movement();
    }
    
    void Movement()
    {
        transform.Translate(Vector2.right * Time.deltaTime); // move pra direita sem controle do player
    }
}
