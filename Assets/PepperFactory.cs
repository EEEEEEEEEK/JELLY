using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PepperFactory : MonoBehaviour
{
    public GameObject PepperoniPrefab;

    public Rect spawnBound; //영역설정 //

    private int pepperoniCounter;

    private int stageStartpepperNum;




    // Start is called before the first frame update
    void Start()
    {
        stageStartpepperNum = 2;


        createPepperoni(stageStartpepperNum);
    }


    public void KillPepper(GameObject gb) // 파라미터 ()가 있다는건 함수라는것 , () 안에거가 누구인지 알려줌 
    {
        --pepperoniCounter; //배드가이가 줄어들면 //
        Destroy(gb);

        if (pepperoniCounter == 0)
        {
            goNextStage();

        }


    }

    void goNextStage()
    {
        ++stageStartpepperNum;

        createPepperoni(stageStartpepperNum);

    }


    void createPepperoni(int numOfpepper)
    {


        for (int i = 0; i != numOfpepper; ++i) //그냥 외우기 .. 5번 반복
        {

            Vector3 pos; //구조체라 vector3 pos; 까지만 써도 됨

            pos.y = 0.0f;

            //float x_min = -13.0f; //범위 지정
            //float x_max = 13.0f;
            //float z_min = -15.0f;
            // float z_max = 15.0f;

            pos.x = Random.Range(spawnBound.xMin, spawnBound.xMax);
            pos.z = Random.Range(spawnBound.yMin, spawnBound.yMax); // 유니티는 y가 윗방향 / X,Y,Z,H 는 z가 윗방향 


            Instantiate(PepperoniPrefab, pos, Quaternion.identity);

        }

        pepperoniCounter = numOfpepper;


    }





    // Update is called once per frame
    void Update()
    {
        
    }
}
