using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Build : MonoBehaviour
{
    Vector3 mousePos;
    // �ǹ��� �������°�? true�� false�ƴϿ�
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

        // ��Ŭ���� �ϸ�
        if (Input.GetMouseButtonDown(0))
        {
            isBuild = true;
        }

    }
}
