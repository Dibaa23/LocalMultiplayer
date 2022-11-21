using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Powerups : MonoBehaviour
{
    public GameObject tank;
    public GameObject minion;
    public Text pwptxt;
    public Transform food;
    public SpriteRenderer sr;
    public BoxCollider2D col;
    private bool magnetActive = false;
    private bool ghostActive = false;
    private bool freezeActive = false;
    public bool speedActive = false;
    public bool cloneActive = false;
    public bool timeActive = false;
    private float powerupTime = 5f;
    private string frozen;
    private Vector3 offset = new Vector3(0.5f, 0.5f, 0);

    // Start is called before the first frame update
    void Start()
    {
        pwptxt = GameObject.Find("Powerup").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
            food = GameObject.Find("Food(Clone)").transform;
            GemMagnet();
            Speed();
            Freeze();
            Ghost();
            Clone();
            STime();
    }

    void GemMagnet()
    {
        if (Vector2.Distance(food.position, transform.position) <= 100f && magnetActive)
        {
            pwptxt.text = "Active Powerup : Gem Magnet";
            food.position = Vector2.MoveTowards(food.position, transform.position, Time.deltaTime * 10);
            food.position = Vector2.MoveTowards(food.position, transform.position, Time.deltaTime * 10);
            food.position = Vector2.MoveTowards(food.position, transform.position, Time.deltaTime * 10);
            food.position = Vector2.MoveTowards(food.position, transform.position, Time.deltaTime * 10);
            food.position = Vector2.MoveTowards(food.position, transform.position, Time.deltaTime * 10);
        }
    }

    void Ghost()
    {
        if (ghostActive) 
        {
            pwptxt.text = "Active Powerup : Ghost";
            sr.material.color = new Color(1.0f, 1.0f, 1.0f, 0.1f);
            col.isTrigger = true;
        }
    }

    void Freeze()
    {
        if (freezeActive)
        {
            pwptxt.text = "Active Powerup : Freeze";
            sr.material.color = new Color(1f, 1.0f, 250f, 1f);
        }
    }

    void Speed()
    {
        if (speedActive)
        {
            pwptxt.text = "Active Powerup : Speed";
            gameObject.GetComponent<playertwoMovement>().speed = 10f;
            gameObject.GetComponent<playertwoMovement>().Rspeed = 5f;
        }
    }
    
    void Clone()
    {
        if (cloneActive)
        {
            pwptxt.text = "Active Powerup : Clone";
        }
    }

    void STime()
    {
        if (timeActive)
        {
            pwptxt.text = "Active Powerup : Slow Time";
            Time.timeScale = .25f;
            gameObject.GetComponent<playertwoMovement>().speed = 20f;
            gameObject.GetComponent<playertwoMovement>().Rspeed = 6f;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Magnet"))
        {
            timeActive = false;
            cloneActive = false;
            magnetActive = true;
            speedActive = false;
            ghostActive = false;
            freezeActive = false;
            Destroy(other.gameObject);
            StartCoroutine(MagnetWearOff(powerupTime));
        }

        if (other.CompareTag("Ghost"))
        {
            timeActive = false;
            cloneActive = false;
            ghostActive = true;
            speedActive = false;
            magnetActive = false;
            freezeActive = false;
            Destroy(other.gameObject);
            StartCoroutine(GhostWearOff(powerupTime));
        }

        if (other.CompareTag("Freeze"))
        {
            timeActive = false;
            cloneActive = false;
            freezeActive = true;
            speedActive = false;
            magnetActive = false;
            ghostActive = false;
            Destroy(other.gameObject);
            StartCoroutine(FreezeWearOff(powerupTime));
        }

        if (other.CompareTag("Speed"))
        {
            timeActive = false;
            cloneActive = false;
            speedActive = true;
            freezeActive = false;
            magnetActive = false;
            ghostActive = false;
            Destroy(other.gameObject);
            StartCoroutine(SpeedWearOff(powerupTime));
        }

        if (other.CompareTag("Clone"))
        {
            timeActive = false;
            cloneActive = true;
            speedActive = false;
            freezeActive = false;
            magnetActive = false;
            ghostActive = false;
            Destroy(other.gameObject);
            StartCoroutine(CloneWearOff(powerupTime));
        }

        if (other.CompareTag("Time"))
        {
            timeActive = true;
            cloneActive = false;
            speedActive = false;
            freezeActive = false;
            magnetActive = false;
            ghostActive = false;
            Destroy(other.gameObject);
            StartCoroutine(TimeWearOff(powerupTime/2));
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player" && freezeActive)
        {
            col.gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
            col.gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
            col.gameObject.GetComponent<SpriteRenderer>().material.color = new Color(1f, 1.0f, 250f, 1f);
            StartCoroutine(Thaw(5f));
        }

        if (col.gameObject.tag == "Enemy" && freezeActive)
        {
            minion = col.gameObject;
            col.gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
            col.gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
            col.gameObject.GetComponent<SpriteRenderer>().material.color = new Color(1f, 1.0f, 250f, 1f);
            frozen = "Minion";
            StartCoroutine(Thaw(5f));
        }
    }

    IEnumerator MagnetWearOff(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        sr.material.color = new Color(1.0f, 1.0f, 1.0f, 1f);
        pwptxt.text = "Active Powerup : None";
        magnetActive = false;
    }

    IEnumerator GhostWearOff(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        sr.material.color = new Color(1.0f, 1.0f, 1.0f, 1f);
        col.isTrigger = false;
        pwptxt.text = "Active Powerup : None";
        ghostActive = false;
    }

    IEnumerator FreezeWearOff(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        sr.material.color = new Color(1.0f, 1.0f, 1.0f, 1f);
        col.isTrigger = false;
        pwptxt.text = "Active Powerup : None";
        freezeActive = false;
    }

    IEnumerator SpeedWearOff(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        gameObject.GetComponent<playertwoMovement>().speed = 5f;
        gameObject.GetComponent<playertwoMovement>().Rspeed = 3f;
        pwptxt.text = "Active Powerup : None";
        speedActive = false;
    }

    IEnumerator CloneWearOff(float waitTime)
    {
        GameObject clone = Instantiate(gameObject, transform.position + offset, Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        Destroy(clone);
        pwptxt.text = "Active Powerup : None";
        cloneActive = false;
    }

    IEnumerator TimeWearOff(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        Time.timeScale = 1f;
        gameObject.GetComponent<playertwoMovement>().speed = 5f;
        gameObject.GetComponent<playertwoMovement>().Rspeed = 3f;
        pwptxt.text = "Active Powerup : None";
        timeActive = false;
    }

    IEnumerator Thaw(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        tank.GetComponent<Rigidbody2D>().isKinematic = false;
        tank.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
        tank.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
        if (frozen == "Minion")
        {
            minion.GetComponent<Rigidbody2D>().isKinematic = false;
            minion.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
            minion.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
        }

    }
}
