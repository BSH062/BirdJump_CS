using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerJump : MonoBehaviour
{
    Rigidbody2D rig;
    // Start is called before the first frame update
    void Start()
    {
        rig= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GetComponent<AudioSource>().Play();
            rig.velocity = Vector2.up * 4;
           
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Die")
        {
            if (Score.score > Score.Bestscore)
            {
                Score.Bestscore=Score.score;
            }
            SceneManager.LoadScene(1);

        }
    }
}
