//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class PlayerController : MonoBehaviour
//{
//    private int lastKey = 100;//��¼��һ�ΰ��µİ�ť
//    // Start is called before the first frame update
//    void Start()
//    {

//    }

//    // Update is called once per frame
//    void Update()
//    {
//        //��ת
//        if (Input.GetKeyDown(KeyCode.W))
//        {
//            this.GetComponent<Rigidbody>().AddForce(new Vector3(0, 1, 0) * 280.0f);
//        }
//        //ǰ��
//        if (Input.GetKey(KeyCode.D))
//        {
//            this.transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * 5, Space.World);
//            //�ж��Ƿ���Ҫ��ͷ
//            if (lastKey != (int)KeyCode.D)
//            {
//                this.transform.Rotate(0, 180, 0);
//            }
//            lastKey = (int)KeyCode.D;
//        }
//        //����
//        if (Input.GetKey(KeyCode.A))
//        {
//            this.transform.Translate(new Vector3(-1, 0, 0) * Time.deltaTime * 5, Space.World);
//            //�ж��Ƿ���Ҫ��ͷ
//            if (lastKey != (int)KeyCode.A)
//            {
//                this.transform.Rotate(0, 180, 0);
//            }
//            lastKey = (int)KeyCode.A;
//        }
//    }
//}
