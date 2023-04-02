using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Capture input in the vertical axis
        float verticalInput = Input.GetAxis("Vertical");

        //Get the value of the horizontal axis and then using it to move the player.
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.position = new Vector3(horizontalInput, 0 , 0) * Time.deltaTime;

        //Only play rotation animations when player is stopped
        AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);
        if (stateInfo.IsName("Idle"))
        {
            if (horizontalInput < 0)
            {
                animator.SetTrigger("TurnLeft");
            }
            else if (horizontalInput > 0)
            {
                animator.SetTrigger("TurnRight");
            }
        }

        //Set the Speed variable of the animator controller to 1.0
        animator.SetFloat("Speed", 1.0f);
    }
}
