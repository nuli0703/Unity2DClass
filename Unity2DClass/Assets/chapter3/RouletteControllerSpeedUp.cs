using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteControllerSpeedUp : MonoBehaviour
{
    float rotSpeed = 0; // ȸ���ӵ�


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


        //ȸ���ӵ���ŭ �귿�� ȸ���Ѵ�.
        transform.Rotate(0, 0, rotSpeed);

        rotSpeed *= 0.99f;
    }
}
