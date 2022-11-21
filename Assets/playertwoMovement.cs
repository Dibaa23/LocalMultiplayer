using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playertwoMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 5f;
    public float Rspeed = 3f;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Movement2();
    }

    void Movement2()
    {
        transform.Translate(Vector2.right * Time.deltaTime * speed);

        if (Input.GetKey("l"))
        {
            speed = 0;
        }

        if (Input.GetKey("k"))
        {
            speed = 5;
        }

        if (Input.GetButton("Rotation2") && Input.GetAxisRaw("Rotation2") < 0)
        {
            transform.Rotate(0f, 0f, Rspeed);
        }

        if (Input.GetButton("Rotation2") && Input.GetAxisRaw("Rotation2") > 0)
        {
            transform.Rotate(0f, 0f, -Rspeed);
        }
    }
}
