using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerJump : MonoBehaviour
{
    Rigidbody2D rig;
    void Start()
    {
        //�÷��̾ ����ִ� ��ü ������Ʈ ������ 
        rig= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //�׽�Ʈ���̶� ������ ���콺 �Է°��� �ް� ����
        //�����Ҷ� GetTouch(0) ���� �����ؾ� ��ġ�� �۵� 
        if(Input.GetMouseButtonDown(0))
        {
            //�÷��̾ �������ִ� ����� �ҽ��� �ִ� �Ҹ�(���� �Ҹ�) ���
            GetComponent<AudioSource>().Play();
            //������ ���� �� �������� 4��ŭ ���� 
            rig.velocity = Vector2.up * 4;
           
        }
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //�÷��̾�� ������ �ݶ��̴� �±װ� Die�� ��� 
        if(collision.gameObject.tag=="Die")
        {
            //���� ���ھ �ְ� �������� ���ٸ� 
            if (Score.score > Score.Bestscore)
            {
                //�ְ� ��Ͽ� ���� ����� ����
                Score.Bestscore=Score.score;
            }
            //�� ��ȯ (���� ���� ��)
            SceneManager.LoadScene(1);

        }
    }
}
