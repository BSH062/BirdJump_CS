using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController : MonoBehaviour
{
    public float speed = 1;
    //Ʈ�������� �⺻������ ����վ ������ص���
    //transform�� 3������ǥ�̱⶧���� ������ 2D�� 3D��ǥ�� �����ؾ���
    void Update()
    {
        //Vector3.left�� �������θ� (-1,0,0) �̵��϶�� ����Ƽ �⺻ �޼ҵ���
       transform.position+=Vector3.left*Time.deltaTime*speed;
    }
}
