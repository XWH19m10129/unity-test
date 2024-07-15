using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    public Rigidbody rb;
    public int score = 0;
    public Text scoreText;
    public GameObject WinText;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("游戏开始了");
        //rb=GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {

        //Debug.Log("游戏正在运行");
        //rb.AddForce(new Vector3(10, 0, 0));
        float h= Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        //Debug.Log(h);
        rb.AddForce(new Vector3(h, 0, 0));
        rb.AddForce(new Vector3(0, 0, v));
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("发生碰撞 enter");
        if (other.tag == "Food" )
        {
            Destroy(other.gameObject);
            score++;
            scoreText.text = "分数：" + score;
            if (score == 10)
            {
                WinText.SetActive(true);
            }

        }
    }

}
