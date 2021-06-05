using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldOfViewAngle : MonoBehaviour
{
    [SerializeField]
    private float viewAngle; //시야각

    [SerializeField]
    private float viewDistance; //시야 거리

    [SerializeField]
    private LayerMask targetMask; //타깃 마스크 - 플레이어

    private Pig thePig; //돼지가 도망가도록 설정하기 위함

    void Start()
    {
        thePig = GetComponent<Pig>();
    }

    void Update()
    {
        View();
    }

    private Vector3 BoundaryAngle(float _angle)
    {
        _angle += transform.eulerAngles.y; //z축은 돼지의 y가 기울어질 때마다 움직이므로 y값을 더함
        return new Vector3(Mathf.Sin(_angle * Mathf.Deg2Rad), 0f, Mathf.Cos(_angle * Mathf.Deg2Rad)); //원점은 돼지의 transform, cos(x)와 sin(z)가 정점(P)의 위치
        //Deg2Rad = 180 / 파이
    }

    private void View()
    {
        Vector3 _leftBoundary = BoundaryAngle(-viewAngle * 0.5f); //왼쪽으로 치우쳐야 하므로 빼기
        Vector3 _rightBoundary = BoundaryAngle(+viewAngle * 0.5f); //더하기, 왼+오 도합 130

        Debug.DrawRay(transform.position + transform.up, _leftBoundary, Color.red); //씬뷰에서 레이저 보임 (돼지 위치보다 위에서, 레이저가 나아갈 방향, 색)
        Debug.DrawRay(transform.position + transform.up, _rightBoundary, Color.red);

        Collider[] _target = Physics.OverlapSphere(transform.position, viewDistance, targetMask); //일정 반경 안에 있는 객체를 저장

        for (int i = 0; i < _target.Length; i++) //시야 거리 내에
        {
            Transform _targetTf = _target[i].transform;
            if(_targetTf.name == "Player") //플레이어가 있다면
            {
                Vector3 _direction = (_targetTf.position - transform.position).normalized; //방향과 방향 정규화
                float _angle = Vector3.Angle(_direction, transform.forward);

                if (_angle < viewAngle * 0.5f) //시야각의 절반 안에 있다면
                {
                    RaycastHit _hit;
                    if (Physics.Raycast(transform.position + transform.up, _direction, out _hit, viewDistance)) //시야거리까지 레이저 쏨
                    {
                        if(_hit.transform.name == "Player")
                        {
                            Debug.Log("플레이어가 돼지 시야 내에 있음");
                            Debug.DrawRay(transform.position + transform.up, _rightBoundary, Color.yellow);
                            thePig.Run(_hit.transform.position); //플레이어 발견하면 달리기
                        }                        
                    }
                }
            }
;       }
    }
}
