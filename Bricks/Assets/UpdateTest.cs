using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Time.deltaTime);
        //Debug.Log(1/Time.deltaTime);//FPS frame per second
    }
    private void FixedUpdate()
    {
        //Debug.Log(Time.deltaTime);
        //Debug.Log(1 / Time.deltaTime);//FPS frame per second

    }
}
