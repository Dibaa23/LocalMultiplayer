using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthdamage : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float health;
    public Text healthtxt2;
    public Rigidbody2D rob;
    public bool healthDrain = false;

    // Start is called before the first frame update
    void Start()
    {
        health = 100f;
    }

    // Update is called once per frame
    void Update()
    {
        healthtxt2.text = "Health : " + health.ToString("F0");

        if (healthDrain == true)
        {
            health -= 5f * Time.deltaTime;
        }

        HealthRegen();
        Respawn();
    }

    void Respawn()
    {
        if (health <= 0)
        {
            health = 100f;
            GetComponent<Rigidbody2D>().mass = 1f;
            gameObject.GetComponent<eating>().gemCount = 0;
            gameObject.GetComponent<eating>().Buff = 1;
            gameObject.GetComponent<eating>().Debuff = 3;
            transform.localScale = new Vector3(1f, 1f, 0f);
            bulletPrefab.transform.localScale = new Vector3(0.2f, 0.2f, 0f);
            transform.position = new Vector2(Random.Range(-10, 10), Random.Range(-10, 10));
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemy" && !gameObject.GetComponent<Powerups>().speedActive)
        {
            GetComponent<Collider>().isTrigger = false;
            health -= col.gameObject.GetComponent<BotMovement>().EForce * (gameObject.GetComponent<eating>().Debuff);
        }

        if (col.gameObject.tag == "Enemy" && gameObject.GetComponent<Powerups>().speedActive)
        {
            col.gameObject.GetComponent<BotMovement>().Ehealth -= 100f;
        }

        if (col.gameObject.tag == "missile")
        {
            health -= (col.gameObject.GetComponent<missile>().Force * 2) * gameObject.GetComponent<eating>().Debuff;
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

    void HealthRegen()
    {
        if (health < 100f)
        {
            health += Time.deltaTime;
        }
    }
}
