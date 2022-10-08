using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            transform.DOLocalMoveY(1f, 0.1f).SetLoops(1, LoopType.Restart);
        }

        if (Input.GetKeyUp(KeyCode.Z))
        {
            transform.DOLocalMoveY(2, 0.1f).SetLoops(1, LoopType.Restart);
        }
    }
}
