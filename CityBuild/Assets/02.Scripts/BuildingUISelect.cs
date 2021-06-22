using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildingUISelect : MonoBehaviour
{
    // BuildingUI
    private Transform buildUITr;
    // BuildingListUI
    private Transform buildingListTr;
    // List(1~10)Canvas
    private Transform[] ListCanvasTr;
    // List(1~)Button(1~) this
    private Transform buildButtonTr;

    // Start is called before the first frame update
    void Start()
    {

        buildUITr = GameObject.Find("BuildingUI").GetComponent<Transform>();
        buildingListTr = GameObject.Find("BuildingListUI").GetComponent<Transform>();

        

        








    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
