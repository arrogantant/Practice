using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class thumb : MonoBehaviour
{

    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            transform.DOLocalMoveY(-0.7f, 0.1f).SetLoops(1, LoopType.Restart);
            anim.SetBool("on", true);
        }

        if (Input.GetKeyUp(KeyCode.Z))
        {
            transform.DOLocalMoveY(0.271f, 0.1f).SetLoops(1, LoopType.Restart);
            anim.SetBool("on", false);
        }
    }
}
