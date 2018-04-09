using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HutongGames.PlayMaker;

public class Root : MonoBehaviour {

	[Range(1, 20)]
	public int botsAmout; 

	[Range(10, 40)]
	public int bulletsAmout;

	private PlayMakerFSM rootFSM;

	// Use this for initialization
	void Start () {
		FsmVariables.GlobalVariables.FindFsmInt ("CONST_BOTS_AMOUNT").Value = botsAmout;
		FsmVariables.GlobalVariables.FindFsmInt ("CONST_BULLETS_AMOUNT").Value = bulletsAmout;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
