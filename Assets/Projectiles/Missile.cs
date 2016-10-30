using UnityEngine;
using System.Collections;

public class Missile : MonoBehaviour {

	public int xDirection, zDirection;
	public float magnitude;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate (xDirection*magnitude, 0, zDirection*magnitude);
		if (Mathf.Abs(this.transform.position.x) >= 20 
			|| Mathf.Abs(this.transform.position.z) >= 20)
			Destroy (this.gameObject);

		Debug.Log (this.transform.position.x);
		Debug.Log (this.transform.position.z);
	}
}
