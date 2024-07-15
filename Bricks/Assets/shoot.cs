using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    // Start is called before the first frame update
    void Start()
    {
        //根据Prefab创建实例
        //GameObject.Instantiate(bulletPrefab, transform.position,transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))//0代表鼠标左键 1代表鼠标右键
        {
            GameObject bullet = GameObject.Instantiate(bulletPrefab, transform.position, transform.rotation);
            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            //rb.AddForce(Vector3.forward * 100);
            rb.velocity = Vector3.forward * 30;

        }
    }
}
