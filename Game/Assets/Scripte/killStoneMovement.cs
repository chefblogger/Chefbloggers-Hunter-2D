using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killStoneMovement : MonoBehaviour
{

    [SerializeField]
    Transform[] waypoints;

    [SerializeField]
    float speed = 2f;

    int waypointIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = waypoints [waypointIndex].transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }


   void Move() {
       transform.position = Vector2.MoveTowards (transform.position,
                                                    waypoints[waypointIndex].transform.position,
                                                    speed * Time.deltaTime);
        if (transform.position == waypoints [waypointIndex].transform.position){
            waypointIndex += 1;
        }

        if (waypointIndex == waypoints.Length)
        {
            waypointIndex = 0;
        }
   }
}
 