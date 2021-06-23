using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField]
    public List<Object> houseList;

    private void Awake()
    {
        instance = this;

        var build1Array = Resources.LoadAll("Models/House/Prefabs", typeof(GameObject));

        houseList.AddRange(build1Array);

        /*
         * https://docs.unity3d.com/ScriptReference/Resources.LoadAll.html
         */

    }

    // Start is called before the first frame update
    void Start()
    {

        SceneManager.LoadScene("UI", );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
