using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peoplehealth : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "missile")
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "bullet")
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Impact")
        {
            Destroy(gameObject);
        }
    }

    
}
