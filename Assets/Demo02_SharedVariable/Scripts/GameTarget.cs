using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTarget : MonoBehaviour
{
    //修改後
    public IntVariable scoreReference;
    public int hitScore = 10;
    public float appearTime = 1;
    private float mTimeElapse = 0;

    void Start()
    {
        mTimeElapse = 0;
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SphereCollider collider = GetComponent<SphereCollider>();
            Vector3 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (IsFallingInCircle(collider, touchPos))
            {
                OnHit(touchPos);
            }
        }

        mTimeElapse += Time.deltaTime;
        if (mTimeElapse > appearTime)
        {
            Destroy(this.gameObject);
        }
    }

    //點擊到時的行為
    void OnHit(Vector3 position)
    {

        //修改前
        Demo02_Logic.score += hitScore;

        //修改後
        //scoreReference.value += hitScore;


        Destroy(this.gameObject);
    }
    //檢查是否點擊到的方法
    bool IsFallingInCircle(SphereCollider collider, Vector3 position)
    {
        position.z = 0;

        Vector3 centerPos = collider.transform.position;
        centerPos.z = 0;

        float scaledRadius = collider.radius * collider.transform.localScale.x;
        float distance = (position - centerPos).magnitude;
        Debug.Log("distance=" + distance + " radius=" + scaledRadius);
        return distance < scaledRadius;
    }

}
