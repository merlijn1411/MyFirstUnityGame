using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMove : MonoBehaviour
{
    //Maak 2 variabelen beschikbaar in de inspector
    [SerializeField] private float speed = 50f;
    [SerializeField] private float rotSpeed = 50f;
    //Maak een variabele voor je rigidbody
    private Rigidbody rb;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();  
    }

    // Update is called once per frame
    void Update()
    {
        float move = Time.deltaTime * speed * Input.GetAxis("Vertical");
        rb.velocity = rb.transform.forward * move;
        float rot = Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
        rb.transform.Rotate(new Vector3(0, rot, 0));
    }
}
