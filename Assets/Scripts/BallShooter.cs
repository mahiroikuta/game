using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallShooter : MonoBehaviour
{
    public GameObject ball;

    [SerializeField]
    float speed;

    [SerializeField]
    int maxNum;

    bool isShooting = false;
    int count = 0;
    Vector3 mouseWorldPos,shotForward;
    GameObject[] BlockObjects;
    GameObject[] BallObjects;

    // Start is called before the first frame update
    void Start()
    {
        speed = 10.0f;
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        BlockObjects = GameObject.FindGameObjectsWithTag("Block");
        BallObjects = GameObject.FindGameObjectsWithTag("Ball");
        if ( !isShooting && Input.GetMouseButtonDown(0) )
        {
            isShooting = true;
            count = 0;
            mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            shotForward = Vector3.Scale((mouseWorldPos - transform.position), new Vector3(1, 1, 0)).normalized;
        }
        if ( isShooting )
        {
            count += 1;
        }
        if ( isShooting && count%50 == 1 && count < 50*maxNum )
        {
            GameObject clone = Instantiate(ball, transform.position, Quaternion.identity);
            clone.GetComponent<Rigidbody>().velocity = shotForward * speed;
        }
        if ( isShooting && count > 1 && BallObjects.Length == 0 )
        {
            isShooting = false;
            Debug.Log("stop");
            if ( BlockObjects.Length == 0 )
            {
                // game clear
            }
        }
    }
}
