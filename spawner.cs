using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToddSpawn : MonoBehaviour
{
    public GameObject EP;
    public GameObject PP;
    private float SR = 9;
    public int EC;
    public int WN = 1;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(PP, GSP(), PP.transform.rotation);
        SEW(WN);        
    }

    // Update is called once per frame
    void Update()
    {
        EC = FindObjectsOfType<Todd>().Length;

        if (EC == 0)
        {
            WN++;
            SEW(WN);  
            Instantiate(PP, GSP(), PP.transform.rotation);
        }
    }

    private Vector3 GSP()
    {
        float SPX = Random.Range(-SR, SR);
        float SPZ = Random.Range(-SR, SR);
        Vector3 RP = new Vector3(SPX, 0.75f, SPZ);
        return RP;
    }

    void SEW( int ETS)
    {
        for (int i = 0; i < ETS; i++)
        {
            Instantiate(EP, GSP(), EP.transform.rotation);
        }
    }
}