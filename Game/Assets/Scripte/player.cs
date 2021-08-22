using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    public ParticleSystem particleExplosion;

    public float speed = 2f;
    public float rotationOffset = 270f;
   

    void Update(){

        //fingertouch einschalten 
        //if(Input.touchCount > 0) {
        //Touch touch = Input.GetTouch(0);
        //Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);

        //mouse und finger touch
        Vector3 touchPosition = Input.mousePosition;
        touchPosition = Camera.main.ScreenToWorldPoint(touchPosition);
        
        touchPosition.z = 0f;

        //drehen
        Vector2 direction = new Vector2(
            touchPosition.x - transform.position.x,
            touchPosition.y - transform.position.y
        );
        transform.up = direction;

        //bewegt sich hierhin
        transform.position = Vector3.MoveTowards(transform.position, touchPosition, speed * Time.deltaTime);
       
       //fingertouch einschalten 
       //}


    }







}
