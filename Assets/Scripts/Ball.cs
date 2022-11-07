using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    float speed = 5f;

    [SerializeField]
    Rigidbody myRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        // Transform myTransform = this.transform;

        // Vector3 pos = myTransform.position;

        // pos.x = 0f;
        // pos.y = -9.4f;
        // pos.z = -1f;
        // myTransform.position = pos;
        myRigidbody = GetComponent<Rigidbody>();
        // クリック地点と出発座標の差を取る
        myRigidbody.velocity = new Vector3(speed,speed,0f);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
