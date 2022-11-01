using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallShooter : MonoBehaviour
{
    public GameObject ball;
    float speed;
    bool click = false;
    int count = 0;
    Vector3 mouseWorldPos,shotForward;
    private GameObject[] BlockObjects;
    private GameObject[] BallObjects;

    // Start is called before the first frame update
    void Start()
    {
        speed = 10.0f;
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        BlockObjects = GameObject.FindGameObjectWithTag("Block");
        BallObjects = GameObject.FindGameObjectWithTag("Ball");
        if ( click )
        {
            count += 1;
        }
        if ( Input.GetMouseButtonDown(0) )
        {
            click = true;
            mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            shotForward = Vector3.Scale((mouseWorldPos - transform.position), new Vector3(1, 1, 0)).normalized;
        }
        if ( count%50 == 1 && count < 1000 )
        {
            GameObject clone = Instantiate(ball, transform.position, Quaternion.identity);
            clone.GetComponent<Rigidbody>().velocity = shotForward * speed;
        }
        if ( BlockObjects.Length == 0 )
        {
            // game clear
        }
        if ( BallObjects.Length == 0 )
        {
            click = false;
        }
    }
}
