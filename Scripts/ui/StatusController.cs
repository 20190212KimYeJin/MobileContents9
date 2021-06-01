using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusController : MonoBehaviour
{
    [SerializeField] //체력
    private int hp;
    private int currentHp;

    [SerializeField] //스태미나
    private int sp;
    private int currentSp;

    [SerializeField] //스태미나 증가
    private int spIncreseSpeed;

    [SerializeField]
    private int spDelay; //스태미나 재회복 딜레이
    private int currentSpRechargeTime;

    private bool spUsed; //스태미나 감소 여부

    [SerializeField]
    private int dp; //방어력
    private int currentDp;

    [SerializeField]
    private int hungry; //배고픔
    private int currentHungry;

    [SerializeField] //줄어드는 속도
    private int hungryDecrease; // 몇 초마다 줄지
    private int currentHungryDecrease;

    [SerializeField]
    private int thirsty; //목마름
    private int currentThirsty;

    [SerializeField] //줄어드는 속도
    private int thirstyDecrease;
    private int currentThirstyDecrease;

    [SerializeField]
    private int satisfy; // 만족도
    private int currentSatisfy;

    [SerializeField] //필요 이미지
    private Image[] images_Gauge;
    private const int HP = 0, DP = 1, SP = 2, HUNGRY = 3, THIRSTY = 4, SATISFY = 5; // 상수화 시킴


    void Start() //초기값 설정
    {
        currentHp = hp;
        currentDp = dp;
        currentSp = sp;
        currentHungry = hungry;
        currentThirsty = thirsty;
        currentSatisfy = satisfy;
    }

    void Update()
    {
        Hungry();
        Thirsty();
        GaugeUpdate();
        SPRechargeTime();
        SPRecover();
    }

    private void SPRechargeTime() //sp 자동 회복
    {
        if(spUsed)
        {
            if (currentSpRechargeTime < spDelay)
                currentSpRechargeTime++;

            else
                spUsed = false;
        }

    }

    private void SPRecover()
    {
        if (!spUsed && currentSp < sp)
        {
            currentSp += spIncreseSpeed;
        }
    }

    private void Hungry()
    {
        if (currentHungry > 0) // 지금 배고픔이 0보다 크면
        {
            if (currentHungryDecrease <= hungryDecrease)
                currentHungryDecrease++; //1씩 증가

            else
            {
                currentHungry--; //지금 배고픔은 1씩 감소
                currentHungryDecrease = 0;
            }
        }

        else // 0이 되었으면
        {
            Debug.Log("배고픔");
        }
    }

    private void Thirsty()
    {
        if (currentThirsty > 0) // 지금 배고픔이 0보다 크면
        {
            if (currentThirstyDecrease <= thirstyDecrease)
                currentThirstyDecrease++; //1씩 증가

            else
            {
                currentThirsty--; //지금 배고픔은 1씩 감소
                currentThirstyDecrease = 0;
            }
        }

        else // 0이 되었으면
        {
            Debug.Log("목마름");
        }
    }

    private void GaugeUpdate()
    {
        images_Gauge[HP].fillAmount = (float)currentHp / hp; // 최대값1과 최소값0 사이를 왔다갔다 하도록        
        images_Gauge[DP].fillAmount = (float)currentDp / dp;
        images_Gauge[SP].fillAmount = (float)currentSp / sp;
        images_Gauge[HUNGRY].fillAmount = (float)currentHungry / hungry;
        images_Gauge[THIRSTY].fillAmount = (float)currentThirsty / thirsty;
        images_Gauge[SATISFY].fillAmount = (float)currentSatisfy / satisfy;
    }

    public void DecreaseStamina(int _count)
    {
        spUsed = true;
        currentSpRechargeTime = 0;

        if (currentSp - _count > 0)
            currentSp -= _count;
        else
            currentSp = 0;
    }
}

/*
GameObject hpBase;

// Start is called before the first frame update
void Start()
{
    this.hpGage = GameObject.Find("hp_image");
}

public void DecreseHP()
{
    this.hpBase.GetComponent<Image>().fillAmount -= 0.1f;
}

// Update is called once per frame
void Update()
{

}
*/