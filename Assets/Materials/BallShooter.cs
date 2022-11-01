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
    // Start is called before the first frame update
    void Start()
    {
        speed = 10.0f;
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {

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
        if ( count%10 == 1 && count < 100 )
        {
            GameObject clone = Instantiate(ball, transform.position, Quaternion.identity);
            clone.GetComponent<Rigidbody>().velocity = shotForward * speed;
        }
    }
}
