using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject Pipe;
    float timer = 0;
    public float time_Diff;

    void Update()
    {
        timer+=Time.deltaTime;
        if(timer> time_Diff)//time_Diff초가 지났을때
        {
           GameObject newpipe = Instantiate(Pipe);
            newpipe.transform.position = new Vector3(6, Random.Range(-2.7f,5.0f), 0);
            timer = 0;
            Destroy(newpipe,30.0f);
        }
    }
}
