using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour
{
    private float speedSphere=10;
    private Vector3 position;
    private Vector3 positionDown;
    private Vector3 positionUp;


    private float height = 1.0f;
    private int direction = 0;

    Vector3 moveDir = Vector3.zero;
    CharacterController controller;
    // Start is called before the first frame update
    void Start()
    {
        positionDown= transform.position;
       // positionDown.y -= height;
        positionUp = transform.position;
        positionUp.y += height;

        controller = GetComponent<CharacterController>();
        position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
      

        if (Input.GetKey(KeyCode.X))
        {
            moveDir = new Vector3(0, 0, 1);

            controller.Move(moveDir * Time.deltaTime * speedSphere);
           
        }else 
        {
            if (transform.position.y > positionUp.y) direction = 1;
            else   if (transform.position.y < positionDown.y) direction = 0;

            switch(direction)
            {
                case 0:
                    moveDir = new Vector3(0, 1, 0);
                   controller.Move(moveDir * Time.deltaTime);
                    Debug.Log(0 + " " +transform.position + " " + positionUp.y);
                     break;
                case 1:
                    moveDir = new Vector3(0, -1, 0);
                    controller.Move(moveDir * Time.deltaTime);
                    Debug.Log(1 + " " + transform.position + " " + positionDown.y);
                    break;
            }
            //if (Vector3.Distance(transform.position, positionDown) >0.1)
            //{
             

            //}
            //else
            //{
              
            //    //Debug.Log(transform.position + " " - positionDown);
            //}
        }
    }

    private void FixedUpdate()
    {
    
    }

}
