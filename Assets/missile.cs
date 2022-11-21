using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missile : MonoBehaviour
{
    public Rigidbody2D rob;
    public float Force;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Force = 0.5f * rob.mass * rob.velocity.sqrMagnitude;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player2")
        {
            Destroy(gameObject);
        }
    }
}
