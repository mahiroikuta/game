// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class BallManager : MonoBehaviour
// {
//     GameObject ball;
//     private Vector3 origin;

//     [SerializeField]
//     int MaxBall;

//     private List<GameObject> balls = new List<GameObject>();
//     [System.NonSerialized]

//     public bool isShooting;
//     // Start is called before the first frame update
//     void Start()
//     {
//         isShooting = false;
//         BallBorn();
//     }

//     void BallBorn()
//     {
//         while ( MaxBall > balls.Count )
//         {
//             var ob = Instantiate(ball, ballBornPoint.position, Quaternion.identity) as GameObject;
//             balls.Add(ob);
//         }
//     }

//     public void Shooting(Vector3 vec)
//     {
//         isShooting = true;
//         Vector3 pos = vec - ballBornPoint.position;
//         pos.Normalize();
//         StartCoroutine("shoot", pos);
//     }

//     IEnumerator shoot(Vector3 vec)
//     {
//         foreach ( GameObject obj in balls )
//         {
//             Rigidbody rig = obj.GetComponent<Rigidbody>();
//             rig.velocity = vec * speed;
//             yield return new WaitForSeconds(0.2f);
//         }
//     }

//     // Update is called once per frame
//     void Update()
//     {
        
//     }
// }
