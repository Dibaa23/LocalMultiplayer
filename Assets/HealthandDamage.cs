using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthandDamage : MonoBehaviour
{
    public GameObject man;
    public GameObject coinPrefab;
    public Text healthtxt;
    public float health;
    public bool healthDrain = false;
    public Rigidbody2D rob;
    public float Force;

    // Start is called before the first frame update
    void Start()
    {
        healthtxt = GameObject.Find("Health").GetComponent<Text>();
        health = 500f;
    }

    // Update is called once per frame
    void Update()
    {
            Force = 0.5f * rob.mass * rob.velocity.sqrMagnitude;
            healthtxt.text = "Health : " + health.ToString("F0");

            if (health <= 0)
            {
                Destroy(gameObject);
                Debug.Log("You got Destroyed");
            }

            if (healthDrain == true)
            {
                health -= 10f * Time.deltaTime;
            }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player2")
        {
            col.gameObject.GetComponent<healthdamage>().health -= (Force * 5);
        }

        if (col.gameObject.tag == "Player2" && (col.gameObject.GetComponent<healthdamage>().health <= 0))
        {
            Destroy(col.gameObject);
        }

        if (col.gameObject.tag == "bullet")
        {
            health -= col.gameObject.GetComponent<bullet>().Force * man.gameObject.GetComponent<eating>().Buff;
            Instantiate(coinPrefab, transform.position, Quaternion.identity);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Impact")
        {
             health -= 25;
        }

        if (other.CompareTag("Storm"))
        {
             healthDrain = false;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Storm"))
        {
             healthDrain = true;
        }
    }
}
