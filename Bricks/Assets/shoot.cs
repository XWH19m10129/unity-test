using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    // Start is called before the first frame update
    void Start()
    {
        //����Prefab����ʵ��
        //GameObject.Instantiate(bulletPrefab, transform.position,transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))//0���������� 1��������Ҽ�
        {
            GameObject bullet = GameObject.Instantiate(bulletPrefab, transform.position, transform.rotation);
            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            //rb.AddForce(Vector3.forward * 100);
            rb.velocity = Vector3.forward * 30;

        }
    }
}
