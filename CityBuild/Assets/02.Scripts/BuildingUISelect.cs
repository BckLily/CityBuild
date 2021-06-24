using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class BuildingUISelect : MonoBehaviour, IPointerClickHandler
{
    GameManager gameManager;


    // BuildingUI
    [SerializeField]
    private Transform buildUITr;
    // BuildingListUI
    [SerializeField]
    private Transform buildingListTr;
    // List(1~10)Canvas
    [SerializeField]
    private List<Transform> listCanvasTr;
    // Parent Canvas Transform of this gameObject
    [SerializeField]
    private Transform parentListCanvasTr;


    //// List(1~)Button(1~) >> this
    //[SerializeField]
    //private Transform buildButtonTr;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameManager.instance;

        // BuildingUI Transform Setting
        buildUITr = GameObject.Find("BuildingUI").GetComponent<Transform>();
        // BuildingLIstUI Transform Setting
        buildingListTr = buildUITr.GetChild(1);
        
        // ListCanvas Transform Setting 
        Transform[] _listCanvasTrArr = new Transform[buildingListTr.childCount];
        for(int i = 0; i < _listCanvasTrArr.Length; i++)
        {
            _listCanvasTrArr[i] = buildingListTr.GetChild(i);
        }
        // _listCanvasTrArr copy to listCanvasTr
        listCanvasTr.AddRange(_listCanvasTrArr);

        // Parent Canvas Transform Setting
        parentListCanvasTr = this.transform.parent.gameObject.GetComponent<Transform>();

        //// This Button Transform Setting
        //buildButtonTr = this.transform;



        


        //buildingListTr.gameObject.SetActive(false);
    }



    // Update is called once per frame
    void Update()
    {
        

    }


    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            Instantiate(gameManager.houseList[0]);
        }



        //throw new System.NotImplementedException();
    }


}
