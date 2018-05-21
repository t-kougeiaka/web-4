using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    float rotSpeed = 0; //回転速度


    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//マウスが押されたら回転速度をを設定する
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 10;
        }
        transform.Rotate(0, 0, this.rotSpeed);

        this.rotSpeed += 0.96f;
	}
}
