using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotTooltip : MonoBehaviour
{

    [SerializeField]
    private GameObject go_Base; //필요할 때만 호출하게 만듦

    [SerializeField]
    private Text Txt_ItemName;

    [SerializeField]
    private Text Txt_ItemDesc;

    [SerializeField]
    private Text Txt_ItemhowToUsed;

    public void ShowTooltip(Item _item, Vector3 _pos) //넘어오는 파라미터로 아이템이 넘어오도록, 툴팁 위치 이동
    {
        go_Base.SetActive(true);
        _pos += new Vector3(go_Base.GetComponent<RectTransform>().rect.width * 0.5f, -go_Base.GetComponent<RectTransform>().rect.height * 0.5f, 0f); //툴팁 위치를 중앙에서 이동
        go_Base.transform.position = _pos;

        Txt_ItemName.text = _item.itemName; //파라미터에 이름 변경
        Txt_ItemDesc.text = _item.ItemDesc; //설명 변경

        if (_item.itemType == Item.ItemType.Equipment) //장비라면
            Txt_ItemhowToUsed.text = "우클릭 - 장착";

        else if (_item.itemType == Item.ItemType.Used) //음식이나 포션이라면
            Txt_ItemhowToUsed.text = "우클릭 - 먹기";

        else //재료라면
            Txt_ItemhowToUsed.text = "";
    }

    public void HideTooltip() //툴팁 사라지도록
    {
        go_Base.SetActive(false);
    }
    
}
