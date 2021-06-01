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

    public void IncreaseHP(int _count) // 체력 회복
    {
        if (currentHp + _count < hp)
            currentHp += _count;

        else
            currentHp = hp;
    }

    public void DecreaseHP(int _count) // 아이템 잘못 먹거나 체력 닮
    {
        if(currentDp > 0) //체력을 깎으려는데 방어력이 있는 경우
        {
            DecreaseDP(_count);
            return;
        }

        currentHp -= _count;

            if (currentHp <= 0)
            Debug.Log("hp = 0");
    }

    public void IncreaseDP(int _count) // 방어력
    {
        if (currentDp + _count < dp)
            currentDp += _count;

        else
            currentDp = dp;
    }

    public void DecreaseDP(int _count) // 방어력 닮
    {
        currentDp -= _count;

            if (currentDp <= 0)
            Debug.Log("dp = 0");
    }

    public void IncreaseHungry(int _count) // 배고픔
    {
        if (currentHungry + _count < hungry)
            currentHungry += _count;

        else
            currentHungry = hungry;
    }

    public void DecreaseHungry(int _count) // 음식 잘못 먹은 경우 || 배고픔 닮
    {
        if (currentHungry - _count < 0)
            currentHungry = 0;
        else
            currentHungry -= _count;

    }

    public void IncreaseThirsty(int _count) // 배고픔
    {
        if (currentThirsty + _count < thirsty)
            currentThirsty += _count;

        else
            currentThirsty = hungry;
    }

    public void DecreaseThirsty(int _count) // 목마름
    {
        if (currentThirsty - _count < 0)
            currentThirsty = 0;
        else
            currentThirsty -= _count;

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

    public int GetCurrentSP()
    {
        return currentSp; //sp가 0이면 못움직이게
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