using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActionController : MonoBehaviour
{
    [SerializeField]
    private float range; //습득 사정거리

    private bool pickupActivated = false; //습득 가능할시 true

    private RaycastHit hitInfo; // 충돌체 정보

    [SerializeField]
    private LayerMask layerMask; //아이템에 대한 레이어에 대해 반응하도록 씌운 마스크

    [SerializeField]
    private Text actionText; //UI 필요


    // Update is called once per frame
    void Update()
    {
        CheckItem();
        TryAction();
    }

    private void TryAction()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            CheckItem();
            CanPickUp();
        }
    }

    private void CanPickUp()
    {
        if(pickupActivated) //true이면
        {
            if (hitInfo.transform != null) //정보가 있는 경우
            {
                Debug.Log(hitInfo.transform.GetComponent<ItemPickup>().item.itemName + " 획득했습니다");
                Destroy(hitInfo.transform.gameObject);
                InfoDisappear();

            }
        }
    }

    private void CheckItem()
    {
        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hitInfo, range, layerMask))
        {
            if(hitInfo.transform.tag == "Item")
            {
                ItemInfoAppear(); // 발견하면 텍스트가 나타나는
            }
            else
            {
                InfoDisappear();
            }
        }
    }

    private void ItemInfoAppear()
    {
        pickupActivated = true;
        actionText.gameObject.SetActive(true); // 텍스트 육안으로 확인 가능
        actionText.text = hitInfo.transform.GetComponent<ItemPickup>().item.itemName + " 획득" + "<color=yellow>" + "(E)" + "</color>";
    }

    private void InfoDisappear()
    {
        pickupActivated =false;
        actionText.gameObject.SetActive(false); // 텍스트 육안으로 확인 불가
    }
}
