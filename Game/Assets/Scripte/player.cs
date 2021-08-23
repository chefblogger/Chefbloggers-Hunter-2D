using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    public ParticleSystem particleExplosion;

    public float speed = 2f;
    public float rotationOffset = 270f;
   
   void Update()
   {
    float horizontalInput = UltimateJoystick.GetHorizontalAxis( "movement" );
    float verticalInput = UltimateJoystick.GetVerticalAxis( "movement" );

    Vector2 movementDirection = new Vector2(horizontalInput, verticalInput);
    float inputMagnitude = Mathf.Clamp01(movementDirection.magnitude);
    movementDirection.Normalize();

    transform.Translate(movementDirection * speed * inputMagnitude * Time.deltaTime, Space.World);


    if (movementDirection != Vector2.zero)
    {
        Quaternion toRotation = Quaternion.LookRotation(Vector3.forward, movementDirection);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationOffset * Time.deltaTime);
    }
   }
    /* 
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
    */







}
