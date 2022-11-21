using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CallMinions : MonoBehaviour
{
    public Text miniontxt;
    public GameObject botPrefab;
    private Vector3 offset = new Vector3(2, 2, 0);
    private float RandomBig;
    private bool minionReady = true;
    private float chargetime = 10f;

    // Start is called before the first frame update
    void Start()
    {
        miniontxt.text = "Minions : Ready";
    }

    // Update is called once per frame
    void Update()
    {
        SpawnMinions();
    }

    public void SpawnMinions()
    {
        if (Input.GetButtonDown("Minion") && minionReady)
        {
            Debug.Log("Minion Spawning");
            StartCoroutine(MinionChargeUp(chargetime));
            miniontxt.text = "Minions : Not Ready";
            minionReady = false;
        }
    }

    IEnumerator MinionChargeUp(float chargetime)
    {
        RandomBig = Random.Range(1f, 2f);
        botPrefab.GetComponent<Rigidbody2D>().mass = RandomBig;
        botPrefab.transform.localScale = new Vector3(RandomBig / 2, RandomBig / 2, 0f);
        Instantiate(botPrefab, transform.position + offset, transform.rotation);
        yield return new WaitForSeconds(chargetime);
        minionReady = true;
        miniontxt.text = "Minions : Ready";
    }
}
