using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatController : MonoBehaviour
{
    public float StartY;
    public float forwardThrust;
    public float turnThrust;
    public Rigidbody player;  
    void Start()
    {
        StartY = this.transform.position.y;
    }
    public void forwardUp()
    {
        forwardThrust = 0;
    }
    public void forwardDown()
    {
        forwardThrust = 3;
    }
    public void backward()
    {
        forwardThrust = -3;
    }
    public void backwardUp()
    {
        forwardThrust = 0;
    }
   void FixedUpdate()
    {

        player.AddForce(transform.forward * forwardThrust);
        player.AddRelativeTorque(transform.up * turnThrust);
    }
     
   
        void Update()
    {

        //  obj.MoveRotation(Quaternion.Euler(startRot + new Vector3(0, 0, -dist)));
        player.velocity = Vector3.ClampMagnitude(player.velocity, 5);

        Vector3 newPosition = this.transform.position;

        newPosition.y = StartY + Mathf.Sin(Time.timeSinceLevelLoad*2)/8;
        this.transform.position = newPosition;
    }
  
    public void leftwardDown()
    {
        turnThrust = -3;
    }
    public void leftwardUp()
    {
        turnThrust = 0;
    }
    public void rightwardDown()
    {
        turnThrust = 3;
    }
    public void rightwardUp()
    {
        turnThrust = 0;
    }

}
