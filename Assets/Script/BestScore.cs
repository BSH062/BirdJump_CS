using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScore : MonoBehaviour
{
    private void Start()
    {
        GetComponent<Text>().text = "Best Score : " + Score.Bestscore.ToString();
    }
}
