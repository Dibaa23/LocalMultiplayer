using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TankShooting : MonoBehaviour
{
    public Text ppltxt;
    public GameObject firepoint2;
    public GameObject missilePrefab;
    public GameObject coinPrefab;
    private float missileSpeed = 4f;
    public float missileAmmo = 5f;
    public bool canFire;
    public bool reload;

    // Start is called before the first frame update
    void Start()
    {
        canFire = true;
        reload = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && canFire && !reload && !Input.GetButtonDown("Dash1"))
        {
            GameObject missile = Instantiate(missilePrefab, firepoint2.transform.position, firepoint2.transform.rotation);
            Rigidbody2D rb = missile.GetComponent<Rigidbody2D>();
            rb.AddForce(firepoint2.transform.up * missileSpeed, ForceMode2D.Impulse);
            missileAmmo -= 1f;
        }

        if (missileAmmo == 0f)
        {
            canFire = false;
            StartCoroutine("Reload");
        }

        if (canFire == true)
        {
            reload = false;
        }

        if (reload == true)
        {
            missileAmmo = 5f;
            canFire = true;
        }

        ppltxt.text = "People : " + GameObject.FindGameObjectsWithTag("People").Length;
    }

    IEnumerator Reload()
    {
        yield return new WaitForSeconds(1);
        reload = true;
    }
}
