using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public GameObject player;
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }
    
    void Update()
    {
        Vector3 dir = player.transform.position - this.transform.position; // posicao relativa ao player 
        float angulo = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg; // 
        transform.rotation = Quaternion.AngleAxis(angulo, Vector3.forward); // rotaciona na direcao
    }
}
