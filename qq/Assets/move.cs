using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    private float speed;
    private Vector3 vec;
    private Renderer ren;

    // Start is called before the first frame update
    void Start()
    {
        float a = Random.Range(2f, 5f);
        transform.localScale = new Vector3(a, a, a); 
        ren = gameObject.GetComponent<Renderer>();
        ren.material.color = new Color(Random.Range(0,255)/255f, Random.Range(0, 255)/255f, Random.Range(0, 255)/255f);
        speed = Random.Range(1, 10);
        vec = new Vector3(Random.Range(-2f,2f), Random.Range(-2f,2f), 0);
    }
    // Update is called once per frame
    void Update()
    {
        //StartCoroutine(a());
        transform.Rotate(vec * Time.deltaTime, speed);
    }
    /*IEnumerator a()
    {
        yield return new WaitForSeconds(10f);
        Destroy(gameObject);
    }*/
}
