using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearManager : MonoBehaviour
{
    public string labelText = "Collect all 3 items and win your freedom!";
    public int maxItems = 3;
    private int _itemCount = 0;

    //public bool showWindow = false;

    public int Item
    {
        get { return _itemCount; }
        set
        {
            _itemCount = value;

            if(_itemCount >= maxItems)
            {
                //showWindow = true;
                labelText = "You've found all the items!"; 
            }

            else
            {
                labelText = "Item found only " + (maxItems - _itemCount) + "more to go!";
            }
        }
    }

    void ONGUI()
    {
        GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height - 50, 300, 50), labelText);

        /*
        if (showWindow)
        {
            if(GUI.Button(new Rect(Screen.width/2 - 100, Screen.height/2-50,200,100), "YOU WON!"))
            {
                SceneManager.LoadScene(0);
            }
        }
        */
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
