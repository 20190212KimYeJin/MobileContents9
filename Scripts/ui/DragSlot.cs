using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DragSlot : MonoBehaviour
{
    static public DragSlot instance; //자기자신을 인스턴스로 받아옴

    public DragSlot dragSlot;

    [SerializeField]
    private Image imageItem; //아이템 이미지

    void Start()
    {
        instance = this;
    }


    public void DragSetImage(Image _itemImage)
    {
        imageItem.sprite = _itemImage.sprite;
        SetColor(1);
    }

    public void SetColor(float _alpha)
    {
        Color color = imageItem.color;
        color.a = _alpha;
        imageItem.color = color;
    }

}
