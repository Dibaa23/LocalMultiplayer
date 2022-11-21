using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class eating : MonoBehaviour
{
    public GameObject gemsPrefab;
    public GameObject bulletPrefab;
    public Text masstxt;
    public int gemCount;
    private float size = 0.02f;
    private float massScale = 0.01f;
    private float cameraScale = 0.06f;
    public Camera myCamera;
    public float Buff = 1f;
    public float Debuff = 3f;

    void Start()
    {
        masstxt = GameObject.Find("Mass").GetComponent<Text>();
        myCamera = GameObject.Find("MainCamera").GetComponent<Camera>();
    }

    void Update()
    {
        masstxt.text = "Mass : " + gemCount;

        if(gemCount == 0)
        {
            bulletPrefab.transform.localScale = new Vector3(0.2f, 0.2f, 1f);
        }

        if (Debuff <= 0)
        {
            Debuff = 0.05f;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Gems"))
        {
                transform.localScale += new Vector3(size, size, 0f);
                bulletPrefab.transform.localScale += new Vector3(size/2, size/2, 0f);
                GetComponent<Rigidbody2D>().mass += massScale;
                myCamera.orthographicSize += cameraScale;
                gemCount += 1;
                Buff += 0.035f;
                Debuff -= 0.035f;
                Destroy(other.gameObject);
        }
    }

}
