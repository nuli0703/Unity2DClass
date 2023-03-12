using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteControllerSpeedUp : MonoBehaviour
{
    float rotSpeed = 0; // 회전속도


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rotSpeed += 10;

        }


        //회전속도만큼 룰렛을 회전한다.
        transform.Rotate(0, 0, rotSpeed);

        rotSpeed *= 0.99f;
    }
}
