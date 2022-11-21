using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerMovement : MonoBehaviour
{ 
    public Text dashtxt;
    public Rigidbody2D rb;
    private bool dashReady = true;
    public bool dash = false;
    public float acceleration = 600;
    private float dashTime = 1.5f;
    private float dashSpeed = 3f;
    private float chargetime = 5f;

    // Start is called before the first frame update
    void Start()
    {
        dashtxt = GameObject.Find("Dash").GetComponent<Text>();
        dashtxt.text = "Dash : Ready";
    }

    // Update is called once per frame  
    void Update()
    {
            Dash();
            Movement();
    }

    void Movement()
    {
        rb.AddForce(transform.up * acceleration * Time.deltaTime);
        //Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
        //Vector3 dir = Input.mousePosition - pos;
        //float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        //transform.rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);

        if (Input.GetKey("p"))
        {
            acceleration = 0;
        }

        if (Input.GetKey("r"))
        {
            acceleration = 600;
        }

        if (Input.GetButton("Rotation1") && Input.GetAxisRaw("Rotation1") < 0)
        {
            transform.Rotate(0f,0f,0.5f);
        }

        if (Input.GetButton("Rotation1") && Input.GetAxisRaw("Rotation1") > 0)
        {
            transform.Rotate(0f, 0f,-0.5f);
        }
    }

    void Dash()
    {
        if (Input.GetButtonDown("Dash1") && dashReady)
        {
            dash = true;
            gameObject.GetComponent<TankShooting>().canFire = false;
            StartCoroutine(DashWearOff(dashTime));
            dashtxt.text = "Dash : Not Ready";
            dashReady = false;
        }
    }

    IEnumerator DashWearOff(float dashTime)
    {
        gameObject.GetComponent<TankShooting>().canFire = false;
        acceleration *= dashSpeed;
        yield return new WaitForSeconds(dashTime);
        acceleration /= dashSpeed;
        dash = false;
        gameObject.GetComponent<TankShooting>().canFire = true;
        yield return new WaitForSeconds(chargetime);
        dashReady = true;
        dashtxt.text = "Dash : Ready";
    }

}
