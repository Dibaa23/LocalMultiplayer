using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour
{
    public Rigidbody2D rb;
    private float speed = 5f;
    private float timer; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        rb.AddRelativeForce(Random.onUnitSphere * speed);
        if (timer <= 1f)
        {
            speed = 5f;
        }
        else
        {
            rb.isKinematic = true;
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
        }
    }
}
