using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Build : MonoBehaviour
{
    Vector3 mousePos;
    // 건물이 지어졌는가? true예 false아니요
    bool isBuild;

    // Start is called before the first frame update
    void Start()
    {
        isBuild = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isBuild)
        {
            StartCoroutine(followMouse());
        }
        else
        {
            StopCoroutine(followMouse());
        }
    }

    IEnumerator followMouse()
    {
        yield return Time.deltaTime * 10;

        mousePos = Input.mousePosition;
        transform.position = mousePos;

        // 좌클릭을 하면
        if (Input.GetMouseButtonDown(0))
        {
            isBuild = true;
        }

    }
}
