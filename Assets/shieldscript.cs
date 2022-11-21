using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shieldscript : MonoBehaviour
{
    public GameObject Player;
    public Text shieldtxt;
    private bool shieldReady = true;
    public bool shield = false;
    private float shieldTime = 3f;
    private float chargetime = 5f;

    // Start is called before the first frame update
    void Start()
    {
        shieldtxt = GameObject.Find("Shieldtxt").GetComponent<Text>();
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        gameObject.GetComponent<CircleCollider2D>().enabled = false;
        shieldtxt.text = "Shield : Ready";
    }

    // Update is called once per frame
    void Update()
    {
        Shield();
    }

    void Shield()
    {
        transform.position = Player.transform.position;
        if (Input.GetButton("Shield") && shieldReady)
        {
            shield = true;
            StartCoroutine(ShieldWearOff(shieldTime));
            shieldtxt.text = "Shield : Not Ready";
            shieldReady = false;
        }
    }

    IEnumerator ShieldWearOff(float shieldTime)
    {
        gameObject.GetComponent<SpriteRenderer>().enabled = true;
        gameObject.GetComponent<CircleCollider2D>().enabled = true;
        yield return new WaitForSeconds(shieldTime);
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        gameObject.GetComponent<CircleCollider2D>().enabled = false;
        shield = false;
        yield return new WaitForSeconds(chargetime);
        shieldReady = true;
        shieldtxt.text = "Shield : Ready";
    }
}
