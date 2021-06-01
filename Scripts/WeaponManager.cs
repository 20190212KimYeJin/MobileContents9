using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    public static bool isChangeWeapon = false;
    //static : 공유 자원
    //중복 교체 방지

    [SerializeField] //무기 교체 딜레이
    private float changeWeaponDelayTime;

    [SerializeField]
    private float changeWeaponEndDelayTime;

    [SerializeField]
    private Gun[] guns;

    [SerializeField]
    private Hand[] hands;

    //무기 접근 관리
    private Dictionary<string, Gun> gunDictionary = new Dictionary<string, Gun>();
    private Dictionary<string, Gun> handDictionary = new Dictionary<string, Hand>();

    [SerializeField]
    private string currentWeaponType; //현재 무기 타입

    public static Transform currentWeapon; //현재 무기
    public static Animator currentWeaponAnim; //현재 무기 애니메이션

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
