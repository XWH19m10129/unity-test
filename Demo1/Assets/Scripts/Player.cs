using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("update");
    }

    private void OnCollisionEnter(Collision collision)
    {
        print("collide");
        Debug.Log(collision.collider);
    }

    private void OnTriggerEnter(Collider other)
    {
        print(other.name);
        print("trigger");

    }
}