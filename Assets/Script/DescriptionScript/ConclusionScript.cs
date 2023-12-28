using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ConclusionScript : MonoBehaviour
{
    public TMP_Text text;
    public GameObject conclusion;
    private int currentTextIndex = 0;
    private string[] texts = { "�� ������ �� �ܿ��� ���ִ� ����� ����", "�������� ������ ħ���� ������ �ִ�", "���翡�� ���� ���ڱ��� �����ִ�.", "�� �濡�� �� �̿ܿ� ���Ҹ��� �ϳ� �� �鸰��.", "�׷��ٸ� �� ���� ħ���� ���γ����� �������Ѱ��� ����ϱ�?" };

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