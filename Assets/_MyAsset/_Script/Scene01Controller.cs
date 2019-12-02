using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene01Controller : MonoBehaviour {
	public GameObject Message;
	// Use this for initialization
	void Start () {
		Message.SetActive(false);
	}
	
	// Update is called once per frame
	public void ShowMessage () {
		Message.SetActive(true);
	}

	public void HideMessage () {
		Message.SetActive(false);
	}
}
