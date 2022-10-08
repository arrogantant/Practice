using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UIElements;

public class Fork : MonoBehaviour
{
    public GameObject Shadow;
    public GameObject stabfx;
    public GameObject shadow;
    private void Update()
    {
        

            if (Input.GetKeyDown(KeyCode.Z))
            {
                transform.DOLocalMoveY(-0.43f, 0.05f).SetLoops(1, LoopType.Restart);
                Shadow.SetActive(true);
                stabfx.SetActive(true);
                shadow.transform.DOScale(new Vector3(1.6f, 1.6f, 1.6f), 0.1f);
            }
       

            if (Input.GetKeyUp(KeyCode.Z))
            {
                transform.DOLocalMoveY(2, 0.05f).SetLoops(1, LoopType.Restart);
                Shadow.SetActive(false);
                stabfx.SetActive(false);
                shadow.transform.DOScale(new Vector3(1.4f, 1.2f, 1.2f), 0.1f);

        }
        
        
    }


}
