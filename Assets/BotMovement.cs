using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotMovement : MonoBehaviour
{
    public GameObject coinPrefab;
    public SpriteRenderer sr;
    public GameObject player2;
    public float Ehealth;
    public Rigidbody2D robby;
    public float EForce;
    public float accel;

    // Start is called before the first frame update
    void Start()
    {
        Ehealth = 100f;
        player2 = GameObject.FindGameObjectWithTag("Player2");

    }

    // Update is called once per frame
    void Update()
    {
        accel = 900f;
        EForce = 0.5f * robby.mass * robby.velocity.sqrMagnitude;
            SmashPlayer();
            transform.localScale = new Vector3(0.5f,0.5f,1f);
            

        if (Ehealth <= 0)
        {
            Instantiate(coinPrefab, transform.position, Quaternion.identity);
            Instantiate(coinPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
            Debug.Log("Bot Destroyed");
        }
    }

    void SmashPlayer()
    {
        robby.AddForce(transform.up * accel * Time.deltaTime);
        float distance = Vector2.Distance(player2.transform.position, transform.position);
        if (distance < 100)
        {
            Vector2 dir = player2.transform.position - transform.position;
            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            Quaternion qto = Quaternion.AngleAxis(angle, Vector3.forward);
            Quaternion qto2 = Quaternion.Euler(qto.eulerAngles.x, qto.eulerAngles.y, qto.eulerAngles.z - 90);
            transform.rotation = Quaternion.Slerp(transform.rotation, qto2, 10f * Time.deltaTime);
        }
    }


    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "bullet")
        {
            Destroy(col.gameObject);
            sr.material.color = new Color(250f, 1.0f, 1.0f, 1.0f);
            Ehealth -= (col.gameObject.GetComponent<bullet>().Force * 3);
            StartCoroutine(Hurt(0.5f));
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Map"))
        {
                Destroy(gameObject);
                Debug.Log("Bot Yeeted.");
        }
    }

    IEnumerator Hurt(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        sr.material.color = new Color(1.0f, 1.0f, 1.0f, 1f);
    }
}
