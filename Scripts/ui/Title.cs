using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    [SerializeField]
    private GameObject canvas;

    [SerializeField]
    private GameObject go_UI;

    public string sceneName = "SampleScene";

    public static Title instance;
    private SaveNLoad theSaveNLoad; //로드 구현

    private void Awake()
    {      

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
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
        StartCoroutine(LoadCoroutine()); //대기

    }

    IEnumerator LoadCoroutine()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneName); //클래스에서 맵 전환
        while(!operation.isDone) //로딩이 끝날 때까지
        {
            yield return null;
        }

        theSaveNLoad = FindObjectOfType<SaveNLoad>(); //다음 씬에 있는 곳에 있는 것을 찾아서
        theSaveNLoad.LoadData(); //로드

        go_UI.SetActive(false);

        /*
        Destroy(gameObject);
        SceneManager.LoadScene(sceneName); //버그 방지
        */
    }
    

    public void ClickExit()
    {
        Debug.Log("종료");
        Application.Quit(); //게임 종료
    }
}
