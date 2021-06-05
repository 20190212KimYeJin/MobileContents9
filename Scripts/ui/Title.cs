using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    [SerializeField]
    private GameObject canvas;

    public string sceneName = "SampleScene";

    public static Title instance;
    //private SaveAndLoad theSaveAndLoad;

    private void Awake()
    {
        

        if (instance == null)
        {
            instance = this;
            //DontDestroyOnLoad(gameObject);
        }
        else
            Destroy(this.gameObject);
    }

    public void ClickStart()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void ClickLoad()
    {
        Debug.Log("로드");

        StartCoroutine(LoadCoroutine());

    }

    IEnumerator LoadCoroutine()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneName);
        while(operation.isDone) //로딩이 끝나지 않으면
        {
            yield return null;
        }

        //theSaveAndLoad = FindObjectOfType<SaveAndLoad>(); //다음 씬에 있는 곳에 있는 것을 찾아서
        //theSaveAndLoad.LoadData(); //로드
        Destroy(gameObject);

        //SceneManager.LoadScene(sceneName); //버그 방지
    }
    

    public void ClickExit()
    {
        Debug.Log("종료");
        Application.Quit(); //게임 종료
    }
}
