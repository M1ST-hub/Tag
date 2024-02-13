using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class CamMan : MonoBehaviour
{
    public Animator animator;

    public void TurnLeft()
    {
        animator.SetBool("DidLeftClick", true);
    }

    public void TurnRight()
    {
        animator.SetBool("DidRightClick", true);
    }

    public void Clear()
    {
        animator.SetBool("DidRightClick", false);
        animator.SetBool("DidLeftClick", false);
    }


}
