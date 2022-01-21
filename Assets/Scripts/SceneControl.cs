using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SceneControl : MonoBehaviour
{

    private Vector3 target;
    private float targetPlayerPos;
    private Vector3 targetGravity;

    private Material build;
    private Color white;
    private Color black;
    // Start is called before the first frame update
    void Start()
    {
        Global.isBlack = true;
        Global.BG = GameObject.Find("BG");
        Global.player = GameObject.Find("player");
        Global.playerRb = Global.player.GetComponent<Rigidbody2D>();
        Global.whiteBound = GameObject.Find("WhiteBound").transform;
        Global.blackBound = GameObject.Find("BlackBound").transform;
        Global.bAwBound = GameObject.Find("BlackAndWhiteBound").transform;
        Global.bAwUp = GameObject.Find("BlackandWhite");
        Global.bAwDown = GameObject.Find("BlackandWhite2");
        //white = GameObject.Find("white").GetComponent<Renderer>().material.color;
        //black = GameObject.Find("black").GetComponent<Renderer>().material.color;
        //build = GameObject.Find("building").GetComponent<Renderer>().material;

    }

    void Update()
    {

        targetGravity = -Physics.gravity;
        targetPlayerPos = - Global.player.transform.position.y;

        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(ReverseBGandPlayer());
            //player.transform.DOMove(target, 0.5f);
            //Physics.gravity = targetGravity;
        }
        //cameraMove();
        PlayerUpAndDown();
        BlackAndWhiteUpAndDown();
        Global.bAwDown.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;//不可删

    }

    void cameraMove()
    {

         Camera.main.transform.position = new Vector3(Global.player.transform.position.x, Global.player.transform.position.y, Camera.main.transform.position.z);

    }

    void PlayerUpAndDown()
    {
        if (Global.player.transform.position.y < Global.bAwBound.position.y)
        {
            Global.player.GetComponent<GravityReverse>().enabled = true;
        }
        if (Global.player.transform.position.y > Global.bAwBound.position.y)
        {
            Global.player.GetComponent<GravityReverse>().enabled = false;
        }
    }

    void BlackAndWhiteUpAndDown()
    {
        if(Global.bAwDown.transform.position.y < Global.bAwBound.position.y - 1.0f)
        {
            Global.bAwDown.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX;
            Global.bAwDown.GetComponent<GravityReverse>().enabled = true;
        }
        if (Global.bAwDown.transform.position.y > Global.bAwBound.position.y + 0.5f)
        {
            Global.bAwDown.GetComponent<GravityReverse>().enabled = false;
        }
    }
    IEnumerator ReverseBGandPlayer()
    {
        if (Global.isBlack)
        {
            yield return new WaitForSeconds(0.1f);
            //build.SetColor("_Color", white);
            Global.player.transform.DOMoveY(targetPlayerPos, 0.5f);
            yield return new WaitForSeconds(0.5f);
            Global.isBlack = false;
        }
        else
        {
            yield return new WaitForSeconds(0.1f);
            //build.SetColor("_Color", white);
            Global.player.transform.DOMoveY(targetPlayerPos, 0.5f);
            yield return new WaitForSeconds(0.5f);
            Global.isBlack = true;
        }
    }

}
