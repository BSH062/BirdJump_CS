using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    //파이프 프리팹 받아오는곳
    public GameObject Pipe;
    //시간초 재기용 
    float timer = 0;
    //흐르는 시간
    public float time_Diff;

    void Update()
    {
        //햔재 시간만큼 타이머에 저장
        timer+=Time.deltaTime;
        //타이머가 Diff보다 높을경우 파이프를 생성 
        if(timer> time_Diff)
        {
           GameObject newpipe = Instantiate(Pipe);
            //생성된 파이프가 배치될 포지션
            newpipe.transform.position = new Vector3(6, Random.Range(-2.7f,5.0f), 0);
            timer = 0;
            //생성된후 30초가 지나면 오브젝트 파괴
            Destroy(newpipe,30.0f);
        }
    }
}
