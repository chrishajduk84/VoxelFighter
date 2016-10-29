using UnityEngine;
using System.Collections;

public class Square : MonoBehaviour {
	public GameObject selector;
	private int gridX, gridY, helperID;

	public void ShowHelper() {
		// Show Helper Square (To hint where the new obj will be placed):
		float x = this.transform.position.x;
		float z = this.transform.position.z;

		Object obj = Instantiate (selector, new Vector3 (x, 0.5f, z), Quaternion.identity);
		helperID = obj.GetInstanceID ();
	}

	public int GetHelperID(){
		return this.helperID;
	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
