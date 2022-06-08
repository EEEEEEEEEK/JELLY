using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamControl : MonoBehaviour
{
    public Transform target; //플레이어의 트랜스폼 컴포넌트 불러오기//


    Vector3 offsetPosition;


    // Start is called before the first frame update
    void Start()
    {
       offsetPosition = this.transform.position - target.position;
    }

    // Update is called once per frame
    void FixedUpdate() //최대한 맞춰주는 업데이
    {


        Vector3 lerpPosition =
            Vector3.Lerp(this.transform.position, target.position + offsetPosition, 4.0f * Time.deltaTime);



        //카메라가 늦게 따라가게 //

        this.transform.position = lerpPosition;

        this.transform.LookAt(target.position);//Look at Constraint 랑 같은 기능 물체를 쳐다보게  

        

    }
}
