﻿using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public float Timer;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        UIManager.Instance.MainTimer.text = Timer.ToString();

    }


}
