using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static bool inventoryActivated = false; //인벤토리가 열리면 인벤토리창만 이용하도록

    [SerializeField]
    private GameObject go_InventoryBase;

    [SerializeField]
    private GameObject go_SlotParent;//슬롯의 부모개체

    private Slot[] slots;

    // Start is called before the first frame update
    void Start()
    {
        slots = go_SlotParent.GetComponentsInChildren<Slot>();
    }

    // Update is called once per frame
    void Update()
    {
        ToOpenInventory();
    }

    private void ToOpenInventory()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            inventoryActivated = !inventoryActivated;

            if (inventoryActivated)
                OpenInventory();

            else
                CloseInventory();

        }
    }

    private void OpenInventory()
    {
        GameManager.isOpenInventory = true;
        go_InventoryBase.SetActive(true);
    }

    private void CloseInventory()
    {
        GameManager.isOpenInventory = false;
        go_InventoryBase.SetActive(false);
    }

    public void AcquireItem(Item _item, int _count = 1) //아이템을 얻음
    {

        if(Item.ItemType.Equipment != _item.itemType) // 아이템 타입이 장비인지 확인
        {
            for (int i = 0; i < slots.Length; i++) //슬롯의 개수만큼 반복
            {
                if (slots[i].item != null)
                {
                    if (slots[i].item.itemName == _item.itemName) //아이템 이름이 일치하면(슬롯 안에 있으면)
                    {
                        slots[i].SetSlotCount(_count); //슬롯의 개수를 증가시킨다
                        return;
                    }
                }
            }
        }

        for (int i = 0; i < slots.Length; i++)
        {
            if (slots[i].item == null) //슬롯에 빈자리가 있으면
            {
                slots[i].AddItem(_item, _count); // 슬롯에 아이템을 추가한다
                return;
            }
        }        
    }
}
