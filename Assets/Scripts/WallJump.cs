using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallJump : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 moveVector;


    public float jumpForce = 20;
    public float gravityModifier = 1;
    public bool jump = false;
    // Start is called before the first frame update
    void Start()
    {
       
        gameObject.tag = "Player";
       
    }

    // Update is called once per frame
    void Update()
    {
        if (jump)
        {
            
            
            jump = false;
        }
    }

    private void OnControllerColliderHit (ControllerColliderHit other)
    {
        if (other.gameObject.CompareTag("Wall Jump"))
        {
            jump = true;

        }


    }
}
