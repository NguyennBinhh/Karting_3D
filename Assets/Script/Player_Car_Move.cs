using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Car_Move : MonoBehaviour
{

    public float Car_Speed;

    private float Check_Move;

    private float Check_Turn;

    public Rigidbody Rb_Car;

    public Transform Wheel_FrontLeft;

    public Transform Wheel_FrontRight;

    public Transform Wheel_BackLeft;

    public Transform Wheel_BackRight;

    private void FixedUpdate()
    {
       Car_Move();
       Car_Turn();
    }

    private void Car_Move()
    {
        Check_Move = Input.GetAxis("Vertical");
        transform.Translate (Vector3.forward * Car_Speed * Check_Move * Time.deltaTime);
        if(Check_Move > 0)
        {
            Wheel_Movement(360f);
        }
        if(Check_Move < 0) 
        {
            Wheel_Movement(-360f);
        }
    } 
    
    private void Car_Turn()
    {
        Check_Turn = Input.GetAxis("Horizontal");
        if (Check_Move > 0)
        {
            transform.Rotate(Vector3.up * Car_Speed * Check_Turn * Time.deltaTime * 10f);
        }
        if(Check_Move < 0)
        {
            transform.Rotate(Vector3.up * Car_Speed * Check_Turn * Time.deltaTime * -10f);
        }
    }    
    
    private void Wheel_Movement(float wm)
    {
        Wheel_FrontLeft.Rotate(wm * Time.deltaTime, 0, 0);
        Wheel_FrontRight.Rotate(wm * Time.deltaTime, 0, 0);
        Wheel_BackRight.Rotate(wm * Time.deltaTime, 0, 0);
        Wheel_BackLeft.Rotate(wm * Time.deltaTime, 0, 0);
    }    
}
