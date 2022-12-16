using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController : MonoBehaviour
{
    public float speed = 1;
    //트랜스폼은 기본적으로 들어잇어서 선언안해도댐
    //transform은 3차원좌표이기때문에 게임이 2D라도 3D좌표를 설정해야함
    void Update()
    {
        //Vector3.left는 왼쪽으로만 (-1,0,0) 이동하라는 유니티 기본 메소드임
       transform.position+=Vector3.left*Time.deltaTime*speed;
    }
}
