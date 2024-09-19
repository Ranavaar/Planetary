using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mercury : MonoBehaviour
{
    // Public Attributes
    public float speed;
    public float speedRotation;
    public Transform sun;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(transform.up, speedRotation * Time.deltaTime);
        transform.RotateAround(sun.position, transform.up, speed * Time.deltaTime);
        Debug.DrawRay(transform.position, transform.forward * 2, Color.blue);

    }
}
