using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ClearDirector : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
                Debug.Log("종료");
                Application.Quit(); //게임 종료
        }
    }
}
