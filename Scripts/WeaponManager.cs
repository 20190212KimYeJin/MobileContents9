using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    public static bool isChangeWeapon = false;
    //static : 공유 자원
    //중복 교체 방지

    public static Transform currentWeapon; //현재 무기
    public static Animator currentWeaponAnim; //현재 무기 애니메이션

    [SerializeField]
    private string currentWeaponType; //현재 무기 타입

    [SerializeField] //무기 교체 딜레이
    private float changeWeaponDelayTime;

    [SerializeField]
    private float changeWeaponEndDelayTime;

    [SerializeField] //총
    private Gun[] guns;

    [SerializeField] //맨손
    private Hand[] hands;

    [SerializeField] //도끼
    private Hand[] axes;

    [SerializeField] //곡괭이
    private Hand[] pickaxes;

    //무기 접근 관리
    private Dictionary<string, Gun> gunDictionary = new Dictionary<string, Gun>();
    private Dictionary<string, Hand> handDictionary = new Dictionary<string, Hand>();
    private Dictionary<string, Hand> axeDictionary = new Dictionary<string, Hand>();
    private Dictionary<string, Hand> pickaxeDictionary = new Dictionary<string, Hand>();

    [SerializeField] //필요 컴포넌트
    private GunController theGunController;

    [SerializeField] // "
    private HandController theHandController;

    [SerializeField] 
    private AxeController theAxeController;

    [SerializeField]
    private PickaxeController thePickaxeController;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < guns.Length; i++)
        {
            gunDictionary.Add(guns[i].gunName, guns[i]);
        }

        for (int i = 0; i < hands.Length; i++)
        {
            handDictionary.Add(hands[i].handName, hands[i]);
        }

        for (int i = 0; i < axes.Length; i++)
        {
            axeDictionary.Add(axes[i].handName, axes[i]);
        }

        for (int i = 0; i < pickaxes.Length; i++)
        {
            pickaxeDictionary.Add(pickaxes[i].handName, pickaxes[i]);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (!isChangeWeapon)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1)) //숫자1, 무기 교체 실행
                StartCoroutine(ChangeWeaponCoroutine("HAND", "맨손"));

            else if (Input.GetKeyDown(KeyCode.Alpha2)) //맨손 교체
                StartCoroutine(ChangeWeaponCoroutine("GUN", "SubMachineGun01"));

            else if (Input.GetKeyDown(KeyCode.Alpha3)) //도끼 교체
                StartCoroutine(ChangeWeaponCoroutine("AXE", "Axe"));

            else if (Input.GetKeyDown(KeyCode.Alpha4)) //곡괭이 교체
                StartCoroutine(ChangeWeaponCoroutine("PICKAXE", "Pickaxe"));
        }
    }

    public IEnumerator ChangeWeaponCoroutine(string _type, string _name)
    {
        isChangeWeapon = true;
        currentWeaponAnim.SetTrigger("WeaponOut");
        yield return new WaitForSeconds(changeWeaponDelayTime);

        CanclePreWeaponAction();
        WeaponChange(_type, _name); //원하는 무기 꺼냄

        yield return new WaitForSeconds(changeWeaponEndDelayTime);

        currentWeaponType = _type; // 총 타입으로 바꿈
        isChangeWeapon = false; //무기 교체가 가능하게 만듦
    }

    private void CanclePreWeaponAction() //무기 취소 함수
    {
        switch (currentWeaponType)
        {
            case "GUN":
                theGunController.CancleFineSight(); //정조준 상태 해제(재장전 하다가 무기 교체시 취소(건컨트롤러))
                theGunController.CancleReload();
                GunController.isActivate = false;
                break;

            case "HAND":
                HandController.isActivate = false;
                break;

            case "AXE":
                AxeController.isActivate = false;
                break;

            case "PICKAXE":
                PickaxeController.isActivate = false;
                break;
        }
    }

    private void WeaponChange(string _type, string _name)
    {
        if(_type == "GUN")
        {
            theGunController.GunChange(gunDictionary[_name]);
        }

        if (_type == "HAND")
        {
            theHandController.HandChange(handDictionary[_name]);
        }

        if (_type == "AXE")
        {
            theAxeController.HandChange(axeDictionary[_name]);
        }

        if (_type == "PICKAXE")
        {
            thePickaxeController.HandChange(pickaxeDictionary[_name]);
        }
    }

    public IEnumerator WeaponInCoroutine()
    {
        isChangeWeapon = true;
        currentWeaponAnim.SetTrigger("Weapon_Out");

        yield return new WaitForSeconds(changeWeaponDelayTime);

        currentWeapon.gameObject.SetActive(false);
    }

    public void WeaponOut()
    {
        isChangeWeapon = true;

        currentWeapon.gameObject.SetActive(false);
    }
}
