using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if ( collision.gameObject.tag == "Ball" )
        {
            Destroy(gameObject);
        }
        else if ( collision.gameObject.tag == "Floor" )
        {
            // gameover
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
