using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    bool firstBall = true;
    Vector3 startPosition;
    void OnCollisionEnter(Collision collision)
    {
        if ( collision.gameObject.tag == "Ball" )
        {
            if ( firstBall )
            {
                firstBall = false;
                // 座標記録
                foreach (ContactPoint point in collision.contacts)
                {
                    startPosition = point.point;
                    Debug.Log(startPosition);
                }
                GameObject shooter = transform.GetChild(0).gameObject;
                Transform shooterTransform = shooter.transform;
                Vector3 pos = shooterTransform.position;
                pos = startPosition;
            }
            Destroy(collision.gameObject);
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
