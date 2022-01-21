using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityReverse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 9.81f));
        //this.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 11.1f));
    }
}
