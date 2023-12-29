using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using JetBrains.Annotations;
using Unity.VisualScripting;
using System.Runtime.CompilerServices;
using UnityEngine.SceneManagement;

public class GateScript : MonoBehaviour
{
    public TMP_Text text;
    public GameObject gatebutton;
    public GameObject Gate;
    public GameObject indoor;
    public GameObject Room;
    public GameObject indoorbutton;
    public GameObject clue1;
    public GameObject clue2;
    public GameObject clue2box;
    public GameObject RoomDoor;
    public GameObject conclusion;
    public GameObject Slash;
    public GameObject blood;
    public GameObject Scriptbtn;
    public GameObject change;
    Color newColor;
    string newColor_Code;
    private int currentTextIndex = 0;
    private string[] texts = { "�� ������ �� �ܿ��� ���ִ� ����� ����", "�������� ������ ħ���� ������ �ִ�", "���翡�� ���� ���ڱ��� �����ִ�.", "�� �濡�� �� �̿ܿ� ���Ҹ��� �ϳ� �� �鸰��.", "�׷��ٸ� �� ���� ħ���� ���γ����� �������Ѱ��� ����ϱ�?" };
    private string[] engage = {"ũ�ƾƾ�!", "�̻��� ���� �츮 ���Ḧ!", "��...�̰� ū���̳�..." };

    public void Clue1()
    {
        text.text = "��򰡿� ���� �ڱ��̴�.";
        
    }
    public void into() 
    {
        Gate.SetActive(false);
        indoor.SetActive(true);
        clue1.SetActive(false);
        clue2box.SetActive(true);
        RoomDoor.SetActive(true);
    }
    public void door()
    {
        text.text = "���� ��¦ �����ִ�. ���� �и� ���� �ݰ� ����.";
        gatebutton.SetActive(false);
        indoorbutton.SetActive(true);

    }
    public void footprint()
    {
        text.text = "���� ����ũ���� ���ڱ��̴�. ��������� �������� �������ִ�.";
    }
    public void intoRoom()
    {
        indoor.SetActive(false);
        clue2box.SetActive(false) ;
        RoomDoor.SetActive(false) ;
        Room.SetActive(true);
        conclusion.SetActive(true);
        text.text = "���� ��� �ܼ��� ������ ����";

    }
    public void Clear()
    {
        currentTextIndex++;
        if (currentTextIndex >= texts.Length)
        {
            currentTextIndex = 0;
        }
        text.text = texts[currentTextIndex];
        Slash.SetActive(true);
    }
    public void kill()
    { 
        blood.SetActive(true);       
        conclusion.SetActive(false);
        Slash.SetActive(false);
    }
    public void Script()
    {
        


        if (blood.active == true)
        {
            
            currentTextIndex++;
            if (currentTextIndex >= engage.Length)
            {
                currentTextIndex = 0;
            }
            text.text = engage[currentTextIndex];
            change.SetActive(true);
        }
        else { text.text = ""; }
    }
    public void changescene()
    {
        SceneManager.LoadScene("engage");
    }

    // Start is called before the first frame update
    void Start()
    {
        text.text = "�� �̿ܿ��� ������� �ʴ� ���̴�";
        
    }

    // Update is called once per frame
    void Update()
    {
        if (indoor != true)
        {
            text.text = "";
        }
        
    }

   
}
