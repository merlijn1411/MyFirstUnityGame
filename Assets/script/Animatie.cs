using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animatie : MonoBehaviour
{
    Animator m_Animator;
    

    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
    }


    void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow))
        {

            m_Animator.ResetTrigger("walking");


            m_Animator.SetTrigger("walking");
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            
            m_Animator.ResetTrigger("catwalk");

            m_Animator.SetTrigger("catwalk");
        }
    }
}
