using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundMove : MonoBehaviour
{
    public float speed = 1;
    void Update()
    {
        //지면 이동 (좌측으로 계속 이동)
        transform.Translate(Vector2.left * Time.deltaTime * speed);
        if (transform.position.x < -28.82f)
        { 
            //지면의 x축이 -28.82 보다 작아지 경우  다시 0,0으로 초기화 
            //한후 다시 왼쪽으로 이동 (반복)
            transform.position = new Vector2(0, 0);
        }
    }
}
