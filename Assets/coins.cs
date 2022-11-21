using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coins : MonoBehaviour
{
    public Text cointxt;
    public float coinNum;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        cointxt.text = "Coins : " + coinNum;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coins"))
        {
            coinNum += 1;
            Destroy(other.gameObject);
        }
    }
}
