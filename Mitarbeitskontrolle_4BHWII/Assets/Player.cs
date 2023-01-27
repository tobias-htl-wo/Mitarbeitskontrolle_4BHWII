using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float movement_speed = 5f;
    private Vector3 movement;

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * movement_speed * Time.deltaTime * 2;
        }
        else
        {
            movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * movement_speed * Time.deltaTime;
        }
        if (movement != Vector3.zero)
        {
            transform.position += movement;
        }
    }
}
