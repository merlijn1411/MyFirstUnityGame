using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idlewalk : MonoBehaviour
{
    Animator m_Animator;


    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
    }


    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {

            m_Animator.ResetTrigger("walk");


            m_Animator.SetTrigger("walk");
        }
    
    }
}
