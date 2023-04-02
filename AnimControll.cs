using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimControll : MonoBehaviour
{
    Animator animator;

    bool Isemote2;

    // Update is called once per frame
    void Update()
    {
        animator = gameObject.GetComponent<Animator>();
        Isemote2 = false;
    }

    private void OnMouseUp()
    {
        if(!Isemote2){
            animator.SetBool("emote2",true);
            Isemote2 = true;
        }
        else
        {
            animator.SetBool("emote2",false);
            Isemote2 = false;
        }
    }
}
