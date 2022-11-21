using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manShooting : MonoBehaviour
{
    public GameObject firepoint;
    public GameObject bulletPrefab;
    public GameObject coinPrefab;
    private float bulletSpeed = 1f;
    public float bulletAmmo = 10f;
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
        if (Input.GetButtonDown("Fire2") && canFire && !reload && !Input.GetButtonDown("Dash2"))
        {
            GameObject bullet = Instantiate(bulletPrefab, firepoint.transform.position, firepoint.transform.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(firepoint.transform.up * bulletSpeed, ForceMode2D.Impulse);
            bulletAmmo -= 1f;
        }

        if (bulletAmmo == 0f)
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
            bulletAmmo = 10f;
            canFire = true;
        }
    }

    IEnumerator Reload()
    {
        yield return new WaitForSeconds(1);
        reload = true;
    }
}
