using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField]
    int blockLife;

    void OnCollisionEnter(Collision collision)
    {
        if ( collision.gameObject.tag == "Ball" )
        {
            blockLife = blockLife-1;
        }
        else if ( collision.gameObject.tag == "Floor" )
        {
            // gameover
        }
        if ( blockLife == 0 )
        {
            Destroy(gameObject);
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
