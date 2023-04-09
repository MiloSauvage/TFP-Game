using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animController : MonoBehaviour
{
    private Animator mAnimator;
    bool run = false;

    // Start is called before the first frame update
    void Start()
    {
        mAnimator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (mAnimator != null){

            if (Input.GetKeyDown(KeyCode.F1)){
                mAnimator.SetTrigger("trEmote1");
                Debug.Log("play emote 1");
            }
            if (Input.GetKeyDown(KeyCode.F2)){
                mAnimator.SetTrigger("trEmote2");
                Debug.Log("play emote 2");
            }
            // if (Input.GetKeyDown(KeyCode.V)){
            //     mAnimator.SetTrigger("trIdle");
            //     Debug.Log("play emote 2");
            // }

            if (Input.GetKeyDown(KeyCode.LeftShift)){
                mAnimator.SetTrigger("trSlide");
                Debug.Log("play slide");
            }
            
            run = Input.GetButton("Vertical");
            mAnimator.SetBool("run", run);
            Debug.Log("La valeur de run est : " + run);
        }
    }
}
