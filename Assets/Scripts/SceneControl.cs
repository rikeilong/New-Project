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
        Global.whiteBound = GameObject.Find("WhiteBound").transform;
        Global.blackBound = GameObject.Find("BlackBound").transform;
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
        cameraMove();

    }

    void cameraMove()
    {

         Camera.main.transform.position = new Vector3(Global.player.transform.position.x, Global.player.transform.position.y, Camera.main.transform.position.z);

    }
    IEnumerator ReverseBGandPlayer()
    {
        if (Global.isBlack)
        {
            yield return new WaitForSeconds(0.1f);
            //build.SetColor("_Color", white);
            Global.player.transform.DOMoveY(targetPlayerPos, 0.5f);
            yield return new WaitForSeconds(0.5f);
            Global.player.GetComponent<GravityReverse>().enabled = true;
            Global.isBlack = false;
        }
        else
        {
            yield return new WaitForSeconds(0.1f);
            //build.SetColor("_Color", white);
            Global.player.transform.DOMoveY(targetPlayerPos, 0.5f);
            yield return new WaitForSeconds(0.5f);
            Global.player.GetComponent<GravityReverse>().enabled = false;
            Global.isBlack = true;
        }
    }

}
