using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    [SerializeField]
    private protected string animalName;

    [SerializeField]
    protected int hp;

    [SerializeField]
    protected float walkSpeed;

    [SerializeField]
    protected float runSpeed;

    protected float applySpeed;

    protected Vector3 direction; //돼지 방향

    protected bool isAction; //행동 여부 판별
    protected bool isWalking; //걸음 여부 판별
    protected bool isRunning; //뜀 판별
    protected bool isDead; //죽음 판별

    [SerializeField]
    protected float walkTime;//걷는 시간

    [SerializeField]
    protected float waitTime; //대기 시간

    [SerializeField]
    protected float runTime; //뛰는 시간

    protected float currentTime; //대기 시간

    //필요 컴포넌트
    [SerializeField]
    protected Animator anim;
    [SerializeField]
    protected Rigidbody rigid;
    [SerializeField]
    protected BoxCollider boxCol;
    protected AudioSource theAudio; //pan level custom에서 3d 사운드 조절

    [SerializeField]
    protected AudioClip[] sound_normal;

    [SerializeField]
    protected AudioClip sound_hurt;

    [SerializeField]
    protected AudioClip sound_dead;

    // Start is called before the first frame update
    void Start()
    {
        theAudio = GetComponent<AudioSource>();
        currentTime = waitTime;
        isAction = true; //행동중
    }

    // Update is called once per frame
    void Update()
    {
        if (!isDead)
        {
            Move();
            Rotation();
            ElapseTime(); //시간경과함수 
        }

    }

    protected void Move()
    {
        if (isWalking || isRunning)
            rigid.MovePosition(transform.position + (transform.forward * applySpeed * Time.deltaTime)); //1초에 walkspeed만큼 나아감
    }

    protected void Rotation()
    {
        if (isWalking || isRunning)
        {
            Vector3 _rotation = Vector3.Lerp(transform.eulerAngles, new Vector3(0f, direction.y, 0f), 0.01f);
            //자기자신 위치(transform.eulerAngles), 목표
            rigid.MoveRotation(Quaternion.Euler(_rotation)); //벡터3를 쿼터니언으로 만들어 자연스러운 회전값
        }
    }

    protected void ElapseTime()
    {
        if (isAction)
        {
            currentTime -= Time.deltaTime; //1초마다 깎음
            if (currentTime <= 0)
            {
                ReSet(); //다음 행동 개시
            }
        }
    }

   protected virtual void ReSet() // virtual 사용으로 기능 완성을 pig에서 해도 됨
    {
        isWalking = false; //무한 걷기 막음
        isRunning = false;
        isAction = true;
        applySpeed = walkSpeed;
        direction.Set(0f, Random.Range(0f, 360f), 0f); // y값 자유 회전

        anim.SetBool("Walking", isWalking);
        anim.SetBool("Running", isRunning);
        //리셋할 때 뛰든 걷든 다 취소되게 만듦
    }



    protected void TryWalk()
    {
        isWalking = true;
        anim.SetBool("Walking", isWalking);
        currentTime = walkTime;
        applySpeed = walkSpeed;
        Debug.Log("걷기");
    }



    public virtual void Damage(int _dmg, Vector3 _targetPos) //데미지 맞으면 런 호출하도록
    {
        if (!isDead)
        {
            hp -= _dmg;

            if (hp <= 0)
            {
                Dead();
                return;
            }

            PlaySE(sound_hurt);
            anim.SetTrigger("Hurt");
        }
    }

    protected void Dead()
    {
        PlaySE(sound_dead);
        isWalking = false;
        isRunning = false;
        isDead = true;
        anim.SetTrigger("Dead");
    }

    protected void RandomSound()
    {
        int _random = Random.Range(0, 3); //일상 사운드
        PlaySE(sound_normal[_random]);
    }

    protected void PlaySE(AudioClip _clip)
    {
        theAudio.clip = _clip;
        theAudio.Play();
    }
}
