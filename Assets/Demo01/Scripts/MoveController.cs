using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    private Transform transformCache;

    //修改前
    [SerializeField]
    private float moveSpeed = 1;

    //修改後
    // [SerializeField]
    // private PlayerSetting playerSetting ;

    void Start()
    {
        transformCache = transform;
    }

    void Update()
    {
        //修改前
        var targetMoveDirection = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        transformCache.Translate(targetMoveDirection * moveSpeed * Time.deltaTime);

        //修改後
        // var targetMoveDirection = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        // transformCache.Translate(targetMoveDirection * playerSetting.moveSpeed * Time.deltaTime);
    }
}
