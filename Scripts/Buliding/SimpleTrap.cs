using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleTrap : MonoBehaviour
{
    private Rigidbody[] rigid;

    [SerializeField]
    private GameObject go_Meat; //함정이 발동되면 고기가 사라지도록

    [SerializeField]
    private int damage; //피해 데미지

    private bool isActivate = false; //일회성 트랩, false일 때만 가동

    private AudioSource theAudio;

    [SerializeField]
    private AudioClip sound_Activate;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponentsInChildren<Rigidbody>(); //자식개체에 리지드 바디 있으면 알아서 채워줌
        theAudio = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (!isActivate)
        {
            if(other.transform.tag == "Untagged") //자기자신과 지형 제외, 플레이어 동물 등에만 반응함
            {
                isActivate = true; 
                theAudio.clip = sound_Activate;
                theAudio.Play();
                Destroy(go_Meat); //고기 삭제

                for (int i = 0; i < rigid.Length; i++)
                {
                    rigid[i].useGravity = true; //중력 적용하여 떨어짐
                    rigid[i].isKinematic = false; //키네매틱 비활성화

                }

                if(other.transform.name == "Player")
                {
                    other.transform.GetComponent<StatusController>().DecreaseHP(damage);
                }
            }
        }
    }
}
