using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{



    public Animator animSide;

    public void ButtonSidebar()
    {
        
        if (animSide.GetBool("IsMove") == false)
        {
            animSide.SetBool("IsMove", true);

        }
        else
        {
            animSide.SetBool("IsMove", false);
        }
    }
}
