using System.Collections;
using System.Collections.Generic;
using UnityEngine; //namespace
using TMPro; //텍스트메쉬프로 정의 


public class textchanger : MonoBehaviour
{
    TextMeshProUGUI  tmp; //변수만들기


    // Start is called before the first frame update
    void Start()
    {
        tmp = GetComponent<TextMeshProUGUI>(); // 변수에다가 오브젝트 안에 같이 소속되어있는 컨포넌트 TextMeshProUGUI 데려오기

        int abc = 666;

        tmp.text = abc.ToString();

        //tmp.text.ToIntArray


    }

    // Update is called once per frame
    void Update()
    {
        
    }





}
