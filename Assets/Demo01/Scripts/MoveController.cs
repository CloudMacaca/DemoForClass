using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    private Transform transformCache;
	[SerializeField]
    private float moveSpeed = 1;
    // Use this for initialization
    void Start()
    {
        transformCache = transform;
    }

    // Update is called once per frame
    void Update()
    {
        var targetMoveDirection = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        transformCache.Translate(targetMoveDirection * moveSpeed * Time.deltaTime);
    }
}
