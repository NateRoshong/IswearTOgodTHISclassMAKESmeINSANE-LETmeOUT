using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Todd : MonoBehaviour
{
    public float ES;
    private Rigidbody ERB;
    private GameObject P;

    // Start is called before the first frame update
    void Start()
    {
        ERB = GetComponent<Rigidbody>();
        P = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 LD = (P.transform.position - transform.position).normalized;

        ERB.AddForce(LD * ES);

        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
}