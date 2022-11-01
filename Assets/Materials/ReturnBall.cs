using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnBall : MonoBehaviour
{
    bool firstBall = true;
    Vector3 startPosition;
    void OnCollisionEnter(Collision collision)
    {
        if ( collision.gameObject.tag == "Ball" )
        {
            if ( firstBall ) {
                firstBall = false;
                // 座標記録
                foreach (ContactPoint point in collision.contacts)
                {
                    startPosition = point.point;
                }
            }
        Destroy(collision.gameObject);
        } else {
            
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
