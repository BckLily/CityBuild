using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Build : MonoBehaviour
{
    public Camera camera;

    Vector3 mousePos;
    // 건물이 지어졌는가? true예 false아니요
    bool isBuild;

    public Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        camera = GameObject.Find("LevelCamera").GetComponent<Camera>();
        DontDestroyOnLoad(this);

        pos = this.transform.position;

        SceneManager.MoveGameObjectToScene(this.gameObject, SceneManager.GetSceneByName("LevelScene"));

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
            this.enabled = true;
        }
    }

    IEnumerator followMouse()
    {
        yield return new WaitForSeconds(Time.deltaTime * 3f);

        mousePos = Input.mousePosition;
        //Vector3 worldMousePos = Camera.main.ScreenToWorldPoint(mousePos);
        //worldMousePos.z = 0f;
        //transform.position = worldMousePos;
        //Debug.Log("world Mouse: " + worldMousePos);
        
        //transform.position = mousePos;

        //Debug.Log("mousePos: " + mousePos);
        //Debug.Log("cam: " + Camera.main.ScreenToWorldPoint(Input.mousePosition));

        RaycastHit hit;
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);

        //Debug.Log("ray: " + ray.direction);

        //if (Physics.Raycast(ray, out hit, 1 << 6))
        if (Physics.Raycast(ray, out hit))
        {
            Transform objectHit = hit.transform;
            Debug.Log("hit point : " + hit.point + ", distance : " + hit.distance + ", name : " + hit.collider.name);
            Debug.DrawRay(ray.origin, ray.direction * hit.distance, Color.red);
        }

        //Debug.Log("objectHit: " + hit.transform.position);

        this.transform.position = hit.point;
        pos = this.transform.position;


        Debug.Log("isBuild: " + isBuild);


        // 좌클릭을 하면
        if (Input.GetMouseButtonDown(0))
        {
            isBuild = true;
        }

    }
}
