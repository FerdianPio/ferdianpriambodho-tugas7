using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushroom : MonoBehaviour
{
    public float upForce = 1f;
    public float sideForce = .1f;
    public float lifeCycle = 3f;
    void Start()
    {
        float xForce = Random.Range(-sideForce, sideForce);
        float yForce = Random.Range(upForce/2f, upForce);
        float zForce = Random.Range(-sideForce, sideForce);

        Vector3 force = new Vector3 (xForce, yForce, zForce);

        GetComponent<Rigidbody>().velocity = force;
    }
    void Update()
    {
        if (lifeCycle >= 0 && gameObject.activeInHierarchy)
        {
            lifeCycle -= Time.deltaTime;
        }
        else
        {
            gameObject.SetActive(false);
            lifeCycle = 3f;
        }
    }
}
