using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Animator myAnimation;
    // Start is called before the first frame update
    void Start()
    {
        myAnimation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Attack();
    }

    void Attack()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            myAnimation.SetBool("Attack", true);
        }
        if(Input.GetKeyUp(KeyCode.Space))
        {
            myAnimation.SetBool("Attack", false);
        }
    }
}
