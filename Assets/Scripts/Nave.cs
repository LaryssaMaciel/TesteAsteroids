using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nave : MonoBehaviour
{
    private Rigidbody2D rb;
    //private Vector2 dir;
    public float turnDir;
    [SerializeField] private GameObject bala;
    private Transform spawnBala;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spawnBala = GameObject.Find("spawn").GetComponent<Transform>();
    }

    void Update()
    {
        // pega inputs
        // float horizontal = Input.GetAxis("Horizontal");
        // float vertical = Input.GetAxis("Vertical");
        // dir = new Vector2(horizontal, vertical);

        if (turnDir != 0) { rb.AddTorque(turnDir); } // gira
    }

    public void Move()
    {
        rb.AddForce(this.transform.up * 100, ForceMode2D.Force); // move nave
    }

    public void Shoot()
    {
        GameObject obj = Instantiate(bala, spawnBala.transform.position, spawnBala.transform.rotation); // spawna
        obj.GetComponent<Rigidbody2D>().AddForce(obj.GetComponent<Rigidbody2D>().transform.up * 100); // move bala
    }
}
