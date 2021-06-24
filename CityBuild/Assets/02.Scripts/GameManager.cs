using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Scene scene;

    [SerializeField]
    public List<Object> houseList;

    public GameObject building;

    private void Awake()
    {
        instance = this;

        var build1Array = Resources.LoadAll("Models/House/Prefabs", typeof(GameObject));

        houseList.AddRange(build1Array);

        DontDestroyOnLoad(this);

        /*
         * https://docs.unity3d.com/ScriptReference/Resources.LoadAll.html
         */

    }

    // Start is called before the first frame update
    void Start()
    {
        //SceneManager.LoadScene("UI");
        //SceneManager.LoadScene("LevelScene", LoadSceneMode.Additive);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
