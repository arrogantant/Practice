using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UIElements;

public class Fork : MonoBehaviour
{
    public GameObject fork;
    private Rigidbody forkmove;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("z"))
        {
            transform.DOLocalMoveY(-0.43f, 0.1f).SetLoops(1, LoopType.Restart);
            return;

        }
        



    }
}
