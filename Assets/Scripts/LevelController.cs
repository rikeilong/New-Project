using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class LevelController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Global.level1.jumpbuild = GameObject.Find("jumpbuild");
        Global.level1.jumpbuild2 = GameObject.Find("jumpbuild (1)");


        //Global.level2.cubeB = GameObject.Find("BlackCube");
        //Global.level2.cubeW = GameObject.Find("WhiteCube");
        Global.level2.cube = GameObject.Find("BlackandWhite");
    }

    // Update is called once per frame
    void Update()
    {
        Global.level1.targetPos = new Vector3(Global.level1.jumpbuild.transform.position.x, -Global.level1.jumpbuild.transform.position.y, Global.level1.jumpbuild.transform.position.z);
        Global.level1.targetPos2 = new Vector3(Global.level1.jumpbuild2.transform.position.x, -Global.level1.jumpbuild2.transform.position.y, Global.level1.jumpbuild2.transform.position.z);
        //if (Global.isWhite)
        //{
        //    Global.level2.cube.GetComponent<GravityReverse>().enabled = false;
        //    Global.level2.cube.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
        //}

        if (Input.GetKeyDown(KeyCode.Q))
        {
            StartCoroutine(level1());
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            StartCoroutine(level2());
        }
    }

    IEnumerator level1()
    {
        Global.level1.jumpbuild.transform.DOMove(Global.level1.targetPos, 1.0f);
        yield return new WaitForSeconds(1.0f);
        Global.level1.jumpbuild2.transform.DOMove(Global.level1.targetPos2, 1.0f);
    }

    IEnumerator level2()
    {
        yield return new WaitForSeconds(0.1f);
        Global.level2.cube.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        Global.level2.cube.GetComponent<GravityReverse>().enabled = true;
        yield return new WaitForSeconds(3f);
        Global.level2.cube.transform.position = new Vector3(Global.level2.cube.transform.position.x, -Global.level2.cube.transform.position.y, Global.level2.cube.transform.position.z);

        //if (Global.level2.cube.transform.position.y > Global.blackBound.position.y)
        //{
        //    //Global.level2.cubeB.transform.position = new Vector3(Global.level2.cubeB.transform.position.x, -Global.level2.cubeB.transform.position.y, Global.level2.cubeB.transform.position.z);
        //    //Global.level2.cubeW.transform.position = new Vector3(Global.level2.cubeW.transform.position.x, -Global.level2.cubeW.transform.position.y, Global.level2.cubeW.transform.position.z);
        //    Global.level2.cube.transform.position = new Vector3(Global.level2.cube.transform.position.x, -Global.level2.cube.transform.position.y, Global.level2.cube.transform.position.z);
        //    Debug.Log("ssss");
        //}
    }
}
