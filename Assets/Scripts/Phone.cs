using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phone : MonoBehaviour
{
    public Animator animator;
    public TextBox text;

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("isPhoneChecked", text.isPhoneChecked);
    }
}
