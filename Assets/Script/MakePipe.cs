using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    //������ ������ �޾ƿ��°�
    public GameObject Pipe;
    //�ð��� ���� 
    float timer = 0;
    //�帣�� �ð�
    public float time_Diff;

    void Update()
    {
        //�h�� �ð���ŭ Ÿ�̸ӿ� ����
        timer+=Time.deltaTime;
        //Ÿ�̸Ӱ� Diff���� ������� �������� ���� 
        if(timer> time_Diff)
        {
           GameObject newpipe = Instantiate(Pipe);
            //������ �������� ��ġ�� ������
            newpipe.transform.position = new Vector3(6, Random.Range(-2.7f,5.0f), 0);
            timer = 0;
            //�������� 30�ʰ� ������ ������Ʈ �ı�
            Destroy(newpipe,30.0f);
        }
    }
}
