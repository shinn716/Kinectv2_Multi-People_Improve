using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shkinect : MonoBehaviour {

	public GameObject[] people;
	public Camera KinectCam;
	public float step;

	float xvalue;
	float yvalue;
	float zvalue;

	void Start () {

		for(int i=0; i<people.Length; i++)
			people [i].SetActive (false);

		yvalue = KinectCam.transform.position.y;
		xvalue = KinectCam.transform.position.x;
		zvalue = KinectCam.transform.position.z;
	}
	
	// Update is called once per frame
	void Update () {

		int index = KinectManager.PlayerNumber;

		if (index == 1) {
			people [0].SetActive (true);
			people [1].SetActive (false);
			people [2].SetActive (false);
			people [3].SetActive (false);
			people [4].SetActive (false);
		} else if (index == 2) {
			people [0].SetActive (true);
			people [1].SetActive (true);
			people [2].SetActive (false);
			people [3].SetActive (false);
			people [4].SetActive (false);
		} else if (index == 3) {
			people [0].SetActive (true);
			people [1].SetActive (true);
			people [2].SetActive (true);
			people [3].SetActive (false);
			people [4].SetActive (false);
		} else if (index == 4) {
			people [0].SetActive (true);
			people [1].SetActive (true);
			people [2].SetActive (true);
			people [3].SetActive (true);
			people [4].SetActive (false);
		} else if (index == 5) {
			people [0].SetActive (true);
			people [1].SetActive (true);
			people [2].SetActive (true);
			people [3].SetActive (true);
			people [4].SetActive (true);
		}


		if(Input.GetKey(KeyCode.UpArrow) ){
			yvalue += step;
			Vector3 pos;
			pos = new Vector3 (KinectCam.transform.position.x, yvalue, KinectCam.transform.position.z);
			KinectCam.transform.position = pos;
		}
		if(Input.GetKey(KeyCode.DownArrow) ){
			yvalue -= step;
			Vector3 pos;
			pos = new Vector3 (KinectCam.transform.position.x, yvalue, KinectCam.transform.position.z);
			KinectCam.transform.position = pos;
		}
		if(Input.GetKey(KeyCode.LeftArrow) ){
			xvalue -= step;
			Vector3 pos;
			pos = new Vector3 (xvalue, KinectCam.transform.position.y, KinectCam.transform.position.z);
			KinectCam.transform.position = pos;
		}
		if(Input.GetKey(KeyCode.RightArrow) ){
			xvalue += step;
			Vector3 pos;
			pos = new Vector3 (xvalue, KinectCam.transform.position.y, KinectCam.transform.position.z);
			KinectCam.transform.position = pos;
		}

		if(Input.GetKey(".") ){
			zvalue += step;
			Vector3 pos;
			pos = new Vector3 (KinectCam.transform.position.x, KinectCam.transform.position.y, zvalue);
			KinectCam.transform.position = pos;
		}

		if(Input.GetKey("/") ){
			zvalue -= step;
			Vector3 pos;
			pos = new Vector3 (KinectCam.transform.position.x, KinectCam.transform.position.y, zvalue);
			KinectCam.transform.position = pos;
		}
	


	}

}
