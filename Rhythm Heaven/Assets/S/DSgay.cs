using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DSgay : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.transform.DOJump(new Vector3(5f, 0f, 0f), jumpPower: 3f, numJumps: 2, duration: 4f);
    }

    
    // Update is called once per frame
    void Update()
    {
        
    }
}
