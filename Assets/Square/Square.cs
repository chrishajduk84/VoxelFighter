using UnityEngine;
using System.Collections;

public class Square : MonoBehaviour {
	public GameObject selector , brick;
	private int gridX, gridY, helperID;
	private float x, z;

	private int numBricks = 0;

	public void ShowHelper() {
		// Show a helper block (to let user know where the brick will be placed)
		Object obj = Instantiate (selector, new Vector3 (this.x, 0.5f + numBricks, this.z), Quaternion.identity);
		helperID = obj.GetInstanceID ();
	}

	public void PlaceBrick() {
		// Place brick component, above the last brick on the square
		this.brick.GetComponent<BrickController> ().square = this;
		Instantiate (brick, new Vector3 (this.x, 0.5f + numBricks, this.z), Quaternion.identity);
		this.numBricks += 1;
	}

	public int GetHelperID(){
		return this.helperID;
	}

	void Start () {
		this.x = transform.position.x;
		this.z = transform.position.z;

		this.GetComponent<BrickController> ().square = this;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
