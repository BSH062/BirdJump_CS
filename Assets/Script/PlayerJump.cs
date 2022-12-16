using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerJump : MonoBehaviour
{
    Rigidbody2D rig;
    void Start()
    {
        //플레이어가 들고있는 강체 컴포넌트 들고오기 
        rig= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //테스트용이라 지금은 마우스 입력값을 받고 있음
        //빌드할땐 GetTouch(0) 으로 변경해야 터치로 작동 
        if(Input.GetMouseButtonDown(0))
        {
            //플레이어가 가지고있는 오디오 소스에 있는 소리(점프 소리) 재생
            GetComponent<AudioSource>().Play();
            //누르는 순간 위 방향으로 4만큼 증가 
            rig.velocity = Vector2.up * 4;
           
        }
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //플레이어랑 접촉한 콜라이더 태그가 Die인 경우 
        if(collision.gameObject.tag=="Die")
        {
            //현재 스코어가 최고 점수보다 높다면 
            if (Score.score > Score.Bestscore)
            {
                //최고 기록에 현재 기록을 저장
                Score.Bestscore=Score.score;
            }
            //씬 전환 (게임 오버 씬)
            SceneManager.LoadScene(1);

        }
    }
}
