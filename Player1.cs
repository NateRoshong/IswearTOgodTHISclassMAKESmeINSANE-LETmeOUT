using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private GameObject FP;
    private Rigidbody RB;
    public float speed;
    public bool PU;
    private float PS = 15.0f;
    public GameObject PUI;

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody>();
        FP = GameObject.Find("FP");
    }

    // Update is called once per frame
    void Update()
    {
        float FI = Input.GetAxis("Vertical");
        RB.AddForce(FP.transform.forward * speed * FI);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("P"))
        {
            PU = true;
            Destroy(other.gameObject);
            StartCoroutine(PCR());
            PUI.gameObject.SetActive(true);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("E") && PU)
        {
            Rigidbody ER = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 AFP = (collision.gameObject.transform.position - transform.position);

            ER.AddForce(AFP * PS, ForceMode.Impulse);
        }
    }

    IEnumerator PCR()
    {
        yield return new WaitForSeconds(7);
        PU = false;
        PUI.gameObject.SetActive(false);
    }

}