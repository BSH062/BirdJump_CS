using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundMove : MonoBehaviour
{
    public float speed = 1;
    void Update()
    {
        //���� �̵� (�������� ��� �̵�)
        transform.Translate(Vector2.left * Time.deltaTime * speed);
        if (transform.position.x < -28.82f)
        { 
            //������ x���� -28.82 ���� �۾��� ���  �ٽ� 0,0���� �ʱ�ȭ 
            //���� �ٽ� �������� �̵� (�ݺ�)
            transform.position = new Vector2(0, 0);
        }
    }
}
