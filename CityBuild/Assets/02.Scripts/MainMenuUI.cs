using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MainMenuUI : MonoBehaviour,IPointerClickHandler
{
    enum mainUI
    {
        Start=0, Load, Setting, Staff, Exit,
    }

    // MainUI Transform 
    [SerializeField]
    Transform mainUITr;
    // Button UI Transform
    [SerializeField]
    List<Transform> buttonListTr;

    GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameManager.instance;

        mainUITr = GameObject.Find("MainUI").GetComponent<Transform>();
        var buttonArr = new Transform[mainUITr.childCount];

        Debug.Log(mainUITr.childCount);

        for(int i = 0; i < buttonArr.Length; i++)
        {
            buttonArr[i] = mainUITr.GetChild(i);
        }
        buttonListTr.AddRange(buttonArr);


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            if(this.name == "Start")
            {

                SceneManager.LoadScene("LevelScene");
                SceneManager.LoadScene("UIScene", LoadSceneMode.Additive);

            }
        }


    }
}
