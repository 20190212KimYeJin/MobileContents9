using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guide : MonoBehaviour
{
    [SerializeField]
    private GameObject go_BaseUI;

    private bool isActivated = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            CallMenu();
        }
    }

    private void CallMenu()
    {
        if (!isActivated) // isActivated가 false일 경우 윈도우를 오픈.
            OpenWindow();

        else
            CloseWindow();
    }

    private void OpenWindow()
    {
        isActivated = true;
        go_BaseUI.SetActive(true);
    }

    private void CloseWindow()
    {
            isActivated = false;
            go_BaseUI.SetActive(false);
    }
}
