using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorIDs : MonoBehaviour
{
    public int idleState;
    public int locomotionState;
    public int speedParam;

    void Awake()
    {
        idleState = Animator.StringToHash("Idle");
        locomotionState = Animator.StringToHash("Locomotion");
        speedParam = Animator.StringToHash("Speed");

    }
}
