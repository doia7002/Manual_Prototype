using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ConclusionScript : MonoBehaviour
{
    public TMP_Text text;
    public GameObject conclusion;
    private int currentTextIndex = 0;
    private string[] texts = { "이 집에는 나 외에는 거주는 사람이 없다", "현관에는 누군가 침입한 흔적이 있다", "마당에는 많은 발자국이 찍혀있다.", "이 방에는 나 이외에 숨소리가 하나 더 들린다.", "그렇다면 이 집에 침입한 성인남성이 숨을만한곳은 어디일까?" };

    public void Clear()
    {
        if (Input.GetMouseButtonDown(0))
        {
            currentTextIndex++;
            if (currentTextIndex >= texts.Length)
            {
                currentTextIndex = 0;
            }
            text.text = texts[currentTextIndex];
        }
    }



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}