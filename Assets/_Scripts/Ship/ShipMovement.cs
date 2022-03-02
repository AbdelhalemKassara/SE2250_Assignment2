using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    public float speed = 30;
    public float rollMult = -45;
    public float pitchMult = 30;
    // Start is called before the first frame update

    // Update is called once per frame
    void FixedUpdate()
    {
        //Input.GetAxis() calls the values in unity input manager
        float xAxis = Input.GetAxis("Horizontal");
        float yAxis = Input.GetAxis("Vertical");

        float dist = speed * Time.deltaTime;
        transform.position += new Vector3(xAxis * dist, yAxis * dist, 0);
        
        //when the space ship is changing direction on the y axis rotate around the x axis, when on x rotate around y
        transform.rotation = Quaternion.Euler(yAxis * pitchMult, xAxis * rollMult, 0);
    }
}
