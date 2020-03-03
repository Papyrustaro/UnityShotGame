using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SamplePlayerMove : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }

    private void PlayerMove()
    {
        this.transform.Translate(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
    }
}
