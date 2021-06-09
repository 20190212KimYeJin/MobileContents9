using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

[System.Serializable]
public class SaveData
{
    public Vector3 playerPos; //플레이어 위치값 기억할 변수
    public Vector3 playerRot;

    public List<int> invenArrayNumber = new List<int>();
    public List<string> invenItemName = new List<string>();
    public List<int> invenItemNumber = new List<int>();
}
public class SaveNLoad : MonoBehaviour
{
    private SaveData saveData = new SaveData();

    private string SAVE_DATA_DIRECTORY;
    private string SAVE_FILENAME = "/SaveFile.txt";

    private PlayerController thePlayer;
    private Inventory theInven;

    // Start is called before the first frame update
    void Start()
    {
        SAVE_DATA_DIRECTORY = Application.dataPath + "/Saves/"; //게임폴더에 세이브 폴더 값 저장

            if (!Directory.Exists(SAVE_DATA_DIRECTORY)) //경로 안에 세이브 디렉토리가 있다면
                Directory.CreateDirectory(SAVE_DATA_DIRECTORY); //게임시작 폴더 안
            
    }

    public void SaveData()
    {
        thePlayer = FindObjectOfType<PlayerController>();
        theInven = FindObjectOfType<Inventory>();

        Slot[] slots = theInven.GetSlots();

        for (int i = 0; i < slots.Length; i++)
        {
            if(slots[i] != null)//아이템이 있으면
            {
                saveData.invenArrayNumber.Add(i);
                //saveData.invenItemName.Add(slots[i].item.itemName);
                saveData.invenItemNumber.Add(slots[i].itemCount);
            }
        }

        saveData.playerPos = thePlayer.transform.position; //위치 데이터를 기억
        saveData.playerRot = thePlayer.transform.eulerAngles; //위치 데이터를 기억
        string json = JsonUtility.ToJson(saveData); //위치 값을 제이슨화 시켜
        File.WriteAllText(SAVE_DATA_DIRECTORY + SAVE_FILENAME, json); //물리적 파일로 넣음

        Debug.Log("저장완료");
        Debug.Log(json);
    }

    public void LoadData()
    {
        if(File.Exists(SAVE_DATA_DIRECTORY + SAVE_FILENAME)) //세이브 파일이 있으면
        {
            string LoadJson = File.ReadAllText(SAVE_DATA_DIRECTORY + SAVE_FILENAME);
            saveData = JsonUtility.FromJson<SaveData>(LoadJson); //세이브 데이터로 풀어줌

            thePlayer = FindObjectOfType<PlayerController>();
            theInven = FindObjectOfType<Inventory>();

            thePlayer.transform.position = saveData.playerPos; //위치 순간이동
            thePlayer.transform.eulerAngles = saveData.playerRot; //회전값 일치

            for (int i = 0; i < saveData.invenItemName.Count; i++)
            {
                theInven.LoadToInven(saveData.invenArrayNumber[i], saveData.invenItemName[i], saveData.invenItemNumber[i]);
            }            

            Debug.Log("로드 완료");
        }

        else
        {
            Debug.Log("세이브 파일 없음");
        }

    }
}
