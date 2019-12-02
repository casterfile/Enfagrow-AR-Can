using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickingObject : MonoBehaviour {
	public GameObject Message;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseDown(){
         Message.SetActive(true);
  } 
}
