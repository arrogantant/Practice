using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    public AudioClip one;

    Animator anim;
    AudioSource audioSource;
    
    void Start()
    {
        anim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {



        if (Input.GetKeyDown(KeyCode.Z))
        {
            transform.DOLocalMoveY(1f, 0.1f).SetLoops(1, LoopType.Restart);
            anim.SetBool("on", true);
            audioSource.clip = one;
            audioSource.Play();
        }

        if (Input.GetKeyUp(KeyCode.Z))
        {
            transform.DOLocalMoveY(2, 0.1f).SetLoops(1, LoopType.Restart);
            anim.SetBool("on", false);

        }

        
    }
}
