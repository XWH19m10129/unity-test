using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public int speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        //transform.Translate(Vector3.left);
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(h,0,0)*Time.deltaTime*speed);
        transform.Translate(new Vector3(0, v, 0) * Time.deltaTime * speed);


    }

    private void FixedUpdate()
    {
        
    }
}
