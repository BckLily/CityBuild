using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class BuildingKindUISelect : MonoBehaviour, IPointerClickHandler
{
    // Building UI Transform 
    Transform buildingUI;
    // Building Kind UI Transform
    [SerializeField]
    Transform buildingKindUITr;

    //// this Game Object Button Transform
    [SerializeField]
    //Transform thisButtonTr;

    //Building Kind UI Button Number
    public int buttonNumber;
    [SerializeField]
    Transform buildingListTr;
    [SerializeField]
    List<Transform> buildingCanvasList;

    // Start is called before the first frame update
    void Start()
    {
        buildingUI = GameObject.Find("BuildingUI").GetComponent<Transform>();

        // Building Kind UI Transform (Parent)
        buildingKindUITr = this.transform.parent.GetComponent<Transform>();

        for(int i = 0; i < buildingKindUITr.childCount; i++)
        {
            if(this.name == buildingKindUITr.GetChild(i).name)
            {
                // This Object Number
                buttonNumber = i;
            }
        }

        for(int i = 0; i < buildingUI.childCount; i++)
        {
            if (buildingKindUITr != buildingUI.GetChild(i))
            {
                buildingListTr = buildingUI.GetChild(i);
            }
        }

        var canvasArray = new Transform[buildingListTr.childCount];
        for (int i = 0; i < canvasArray.Length; i++)
        {
            canvasArray[i] = buildingListTr.GetChild(i);
        }
        buildingCanvasList.AddRange(canvasArray);


    }


    void CanvasInActive()
    {
        foreach(var canvas in buildingCanvasList)
        {
            canvas.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClick()
    {

    }

    public void OnPointerClick(PointerEventData eventData)
    {

        if (eventData.button == PointerEventData.InputButton.Left)
        {
            // buildingList의 현재 Active 상태를 받아온다.
            var buildingListObject = buildingListTr.gameObject;
            Debug.Log(Time.realtimeSinceStartup + ": " + buildingListObject.activeSelf);

            //Debug.Log(buttonNumber);
            if (buildingListObject.activeSelf == false)
            {
                // buildingList가 비활성화 상태이면
                buildingListObject.SetActive(true);
                // 활성화 시킨다.
            }
            CanvasInActive();

            buildingCanvasList[buttonNumber].gameObject.SetActive(true);

        }



        //throw new System.NotImplementedException();
    }
}
