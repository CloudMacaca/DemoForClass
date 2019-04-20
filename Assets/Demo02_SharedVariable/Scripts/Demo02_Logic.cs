using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Demo02_Logic : MonoBehaviour
{
    //修改前
    public static int score;

    //修改後
    //public IntVariable score;
    public GameObject[] targetList;
    public float mCooldown;
    void Start()
    {
        //修改前
        score = 0;

        //修改後
        //score.value = 0;

        mCooldown = 2;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            touchPos.z = 0;
        }
        // Spawning 
        mCooldown -= Time.deltaTime;
        if (mCooldown <= 0)
        {
            SpawnTarget();
            mCooldown = 2;
        }
    }

    void SpawnTarget()
    {
        int index = Random.Range(0, targetList.Length);
        GameObject target = targetList[index];

        float x = Random.Range(-5, 5);
        float y = Random.Range(-2, 3);
        Vector3 pos = new Vector3(x, y, 0);

        GameObject newObject = Object.Instantiate(target) as GameObject;
        newObject.transform.position = pos;
    }
}
