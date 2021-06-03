using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems; //마우스 이벤트 담당

public class Slot : MonoBehaviour, IPointerClickHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IDropHandler
{
    private Vector3 originPos;

    public Item item; //획득
    public int itemCount; //획득 아이템 개수
    public Image itemImage; // ui 추가, 아이템 이미지

    [SerializeField]
    private Text text_Count;

    [SerializeField]
    private GameObject go_CountImage;

    private WeaponManager theWeaponManager; //아이템 장착

    void Start()
    {
        originPos = transform.position;
        theWeaponManager = FindObjectOfType<WeaponManager>();
    }


    private void SetColor(float _alpha) // 이미지 투명도 조절 : 평소에는 alpha 값이 0이 되도록 설정
    {
        Color color = itemImage.color;
        color.a = _alpha; 
        itemImage.color = color; //실제 이미지 컬러 변경
    }

    public void AddItem(Item _item, int _count = 1) //아이템 추가
    {
        item = _item;
        itemCount = _count;
        itemImage.sprite = item.itemImage; // 이미지 형식 변환

        if (item.itemType != Item.ItemType.Equipment) //아이템이 장비가 아닌 경우
        {
            go_CountImage.SetActive(true);
            text_Count.text = itemCount.ToString();
        }

        else
        {
            text_Count.text = "0"; //0으로 초기화
            go_CountImage.SetActive(false);            
        }

        SetColor(1); //이미지 컬러 설정
    }

    public void SetSlotCount(int _count) // 아이템 개수 조정
    {
        itemCount += _count;
        text_Count.text = itemCount.ToString();

        if(itemCount <= 0) //슬롯초기화
        {
            ClearSlot();
        }
    }

    private void ClearSlot()
    {
        item = null;
        itemCount = 0;
        itemImage.sprite = null;
        SetColor(0); //투명화

        go_CountImage.SetActive(false);
        text_Count.text = "0"; //텍스트 초기화
    }


    public void OnPointerClick(PointerEventData eventData)
    {
        if(eventData.button == PointerEventData.InputButton.Right) // 스크립트가 적용된 개체에 마우스를 갖다대고 우클릭 하면
        {
            if(item != null)
            {
                if(item.itemType == Item.ItemType.Equipment) //장비 아이템이라면
                {
                    StartCoroutine(theWeaponManager.ChangeWeaponCoroutine(item.weaponType, item.itemName));
                }

                else
                {
                    Debug.Log(item.itemName + "을 사용했습니다.");
                    SetSlotCount(-1); //아이템 소모                    
                }
            }
        }
    }

    
    public void OnBeginDrag(PointerEventData evenData)
    {
        if(item != null)
        {
            transform.position = evenData.position; //슬롯의 위치를 마우스 위치로
        }
        
    }

    public void OnDrag(PointerEventData evenData)
    {
        if (item != null)
        {
            transform.position = evenData.position; //슬롯이 마우스 위치를 따라다님
        }
    }

    public void OnEndDrag(PointerEventData evenData)
    {
        transform.position = originPos;
    }

    public void OnDrop(PointerEventData evenData)
    {
        
    }



}
