using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0; // ȸ���ӵ�


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Debug.Log("���콺 Ŭ�� �Էµ�");
            rotSpeed += 10;
        }


        transform.Rotate(0, 0, rotSpeed); // ȸ���ӵ���ŭ �귿�� ȸ����Ŵ
        rotSpeed *= 0.992f;



        if (rotSpeed < 0.001f && rotSpeed != 0)
        {

            if (transform.rotation.eulerAngles.z % 360 + 30 <= 60)
                Debug.Log("��� ����");

            if (transform.rotation.eulerAngles.z % 360 + 30 <= 120)
            
                Debug.Log("�������");
            

            if (transform.rotation.eulerAngles.z % 360 + 30 <= 180)
            
                Debug.Log("��� �ſ� ����");
            

            if (transform.rotation.eulerAngles.z % 360 + 30 <= 240)
            
                Debug.Log("��� ����");
            

            if (transform.rotation.eulerAngles.z % 360 + 30 <= 300)
            
                Debug.Log("��� ����");
            
            else
            
                Debug.Log("��� ����");
            rotSpeed = 0;

        }

        


        
            
        
    }
}