using UnityEngine;
using System.Collections;

public class MissileLauncher : MonoBehaviour {
	public GameObject missile;
	private float x,y,z;
	private int interval = 1000;
	private int tick = 0;
	// Use this for initialization
	void Start () {
		this.x = transform.position.x;
		this.y = transform.position.y;
		this.z = transform.position.z;
	}

	void LaunchMissile(int x, int z){
		this.missile.GetComponent<Missile> ().xDirection = x;
		this.missile.GetComponent<Missile> ().zDirection = z;
		Instantiate(this.missile,new Vector3(this.x,this.y,this.z),Quaternion.identity);
	}

	// Update is called once per frame
	void Update () {
		this.tick += 1;
		if (this.tick >= this.interval) {
			LaunchMissile (1, 0);
			LaunchMissile (-1, 0);
			LaunchMissile (0, 1);
			LaunchMissile (0, -1);
			this.tick = 0;
		}
	}
}
