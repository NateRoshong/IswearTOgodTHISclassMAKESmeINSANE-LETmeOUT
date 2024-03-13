using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cama : MonoBehaviour
{
    public float RS;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float HI = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, HI * RS * Time.deltaTime);
    }
}