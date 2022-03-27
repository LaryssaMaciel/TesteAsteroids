using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "ast") { DestroyThis(); }
    }

    void OnBecameInvisible() { DestroyThis(); }

    void DestroyThis() { Destroy(this.gameObject); }    
}
