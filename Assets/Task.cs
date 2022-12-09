using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task : MonoBehaviour
{
    Rigidbody rb;
    float Yvalue;
    float Zvalue;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        StartCoroutine(Moving());
    }

    IEnumerator Moving()
    {
        int i = 0;
        while (i < 75)
        {
            Zvalue = 0;
            Yvalue = Random.Range(-0.3f, 0.3f);

            yield return new WaitForSeconds(1);

            Yvalue = 0;

            yield return new WaitForSeconds(0.2f);

            Yvalue = 0;
            Zvalue = Random.Range(0.5f, 5);

            yield return new WaitForSeconds(1);

            Zvalue = 0;

            yield return new WaitForSeconds(3);

            i++;
        }
        
    }

    void Update()
    {
        rb.transform.Rotate(0, Yvalue, 0);
        rb.AddForce(transform.forward * Zvalue);
    }
}
