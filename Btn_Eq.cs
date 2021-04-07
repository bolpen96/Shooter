using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Btn_Eq : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = this.GetComponent<Animator>();
    }

    public void EqOnclick()
    {
        bool isOpen = anim.GetBool("IsOpen");
        if(isOpen == false)
        {
            anim.SetBool("IsOpen", true);
        }else
        {
            anim.SetBool("IsOpen", false);
        }
    }

}
