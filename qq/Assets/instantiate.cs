using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiate : MonoBehaviour
{
    public GameObject a;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            c();
        }
        
    }
    void c()
    {
        Vector3 vec = new Vector3(Random.Range(-25f, 25f), Random.Range(2f, 5f), Random.Range(-25f, 25f));
        Instantiate(a, vec, gameObject.transform.rotation);
        
    }
}
