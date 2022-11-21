using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class peopleMove : MonoBehaviour
{
    public GameObject Center;
    public GameObject Tank;
    public GameObject Shield;
    public Text attacktxt;
    private bool boundrybreach;
    public Rigidbody2D rb;
    public Sprite[] skins;
    private float speed;
    private float rotateRate1;
    private float rotateRate2;
    private bool runAway;
    public bool attack;
    private float chargetime;
    private bool attackReady;

    // Start is called before the first frame update
    void Start()
    {
        Tank = GameObject.Find("Player");
        runAway = false;

        attacktxt = GameObject.Find("Attack").GetComponent<Text>();
        attack = false;
        attackReady = true;
        chargetime = 5f;
        attacktxt.text = "Attack : Ready";

        Shield = GameObject.Find("Shield");

        Center = GameObject.Find("Center");
        boundrybreach = false;

        rb.mass = Random.Range(1.0f, 2.0f);
        transform.localScale = new Vector3(rb.mass, rb.mass, 0f);
        speed = Random.Range(1.0f, 4.0f);
        rotateRate1 = Random.Range(0.15f, 0.30f);
        rotateRate2 = Random.Range(3.0f, 6.0f);

        int i = Random.Range(0, skins.Length);
        gameObject.GetComponent<SpriteRenderer>().sprite = skins[i];

        InvokeRepeating("RotateSmall", 1f, rotateRate1);
        InvokeRepeating("RotateBig", 1f, rotateRate2);

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * speed);
        Flee();
        Breach();
        Attack();

        if (Input.GetKeyDown("n") && attackReady)
        {
            attack = true;
            StartCoroutine(Normalize2(5));
        }
    }

    void RotateSmall()
    {
        transform.Rotate(0f, 0f, Random.Range(-45, 45));
    }

    void RotateBig()
    {
        if (!runAway)
        {
            transform.Rotate(0f, 0f, Random.Range(0, 180));
        }
    }

    public void Flee()
    {
        if (Vector2.Distance(Tank.transform.position, transform.position) <= 5f && (!attack))
        {
            runAway = true;
            transform.rotation = Tank.transform.rotation * Quaternion.Euler(0, 0, 90f);
            transform.position = Vector2.MoveTowards(transform.position, Tank.transform.position, -2 * speed * Time.deltaTime);
        }

        else
        {
            runAway = false;
        }
    }

    public void Breach()
    {
        if (boundrybreach)
        {
            transform.position = Vector2.MoveTowards(transform.position, Center.transform.position, Time.deltaTime * (speed * 2));
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Storm"))
        {
            boundrybreach = true;
            StartCoroutine(Normalize(3));

        }

        if (other.CompareTag("Map"))
        {
            boundrybreach = true;
            StartCoroutine(Normalize(3));
        }
    }

    IEnumerator Normalize(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        boundrybreach = false;
    }

    IEnumerator Normalize2(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        attack = false;
        attacktxt.text = "Attack : Not Ready";
        yield return new WaitForSeconds(chargetime);
        attackReady = true;
        attacktxt.text = "Attack : Ready";
    }

    public void Attack()
    {
        if (Vector2.Distance(Tank.transform.position, transform.position) <= 10f && attack)
        {
            attacktxt.text = "Attack : In Progress";
            transform.position = Vector2.MoveTowards(transform.position, Tank.transform.position, (2 * speed) * Time.deltaTime);
            Vector2 direction = (Vector2)Tank.transform.position - (Vector2)transform.position;
            direction.Normalize();
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(Vector3.forward * (angle));
            attackReady = false;

            if (Vector2.Distance(Shield.transform.position, transform.position) <= 3f && Shield.GetComponent<shieldscript>().shield)
            {
                attacktxt.text = "Attack : Blocked";
                transform.position = (transform.position - Tank.transform.position).normalized * 3 + Tank.transform.position;
            }
        }
    }

}
