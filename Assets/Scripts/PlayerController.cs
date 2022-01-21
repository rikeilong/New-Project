using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizantal;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float jumpFoeceW;
    [SerializeField] private float jumpFoeceB;
    private bool isGround = true;

    private void FixedUpdate()
    {
        //如果黑色世界重力为1，否则为-1
        

        horizantal = Input.GetAxis("Horizontal");
        transform.Translate(horizantal * Vector2.right * moveSpeed * Time.fixedDeltaTime);

        if (Input.GetKeyDown(KeyCode.W) && Global.isBlack && isGround)
        {
            isGround = false;
            Global.playerRb.AddForce(Vector2.up * jumpFoeceB, ForceMode2D.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.S) && !Global.isBlack && isGround)
        {
            isGround = false;
            Global.playerRb.AddForce(Vector2.down * jumpFoeceW, ForceMode2D.Impulse);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGround = true;
            Debug.Log("sss");
        }
    }
}
