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
    private string[] texts = { "이 집에는 나 외에는 거주는 사람이 없다", "현관에는 누군가 침입한 흔적이 있다", "마당에는 많은 발자국이 찍혀있다.", "이 방에는 나 이외에 숨소리가 하나 더 들린다.", "그렇다면 이 집에 침입한 성인남성이 숨을만한곳은 어디일까?" };
    private string[] engage = {"크아아악!", "이새끼 감히 우리 동료를!", "아...이거 큰일이네..." };

    public void Clue1()
    {
        text.text = "어딘가에 쓸린 자국이다.";
        
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
        text.text = "문이 살짝 열려있다. 나는 분명 문을 닫고 갔다.";
        gatebutton.SetActive(false);
        indoorbutton.SetActive(true);

    }
    public void footprint()
    {
        text.text = "성인 남자크기의 발자국이다. 마당곳곳에 어지러이 찍혀져있다.";
    }
    public void intoRoom()
    {
        indoor.SetActive(false);
        clue2box.SetActive(false) ;
        RoomDoor.SetActive(false) ;
        Room.SetActive(true);
        conclusion.SetActive(true);
        text.text = "이제 모든 단서를 모은것 같다";

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
        text.text = "나 이외에는 살고있지 않는 집이다";
        
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
