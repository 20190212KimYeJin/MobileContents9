using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject go_BaseUI;

    //[SerializeField]
    //private SaveAndLoad theSaveAndLoad;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (!GameManager.isPause)
                CallMenu();
            else
                CloseMenu();
        }
    }

    private void CallMenu()
    {
        GameManager.isPause = true;
        go_BaseUI.SetActive(true);
        Time.timeScale = 0f; //시간 흐름 조절 가능
    }

    private void CloseMenu()
    {
        GameManager.isPause = false;
        go_BaseUI.SetActive(false);
        Time.timeScale = 1f; //시간 흐름 조절 가능
    }

    public void ClickSave()
    {
        Debug.Log("Save");
        //theSaveAndLoad.SaveData();
    }

    public void ClickLoad()
    {
        Debug.Log("로드");
        //theSaveAndLoad.LoadData();
    }

    public void ClickExit()
    {
        Debug.Log("종료");
        Application.Quit(); //게임 종료
    }
}
