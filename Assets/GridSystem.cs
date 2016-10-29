using UnityEngine;
using System.Collections;

public class GridSystem : MonoBehaviour {
	public GameObject square;

	const float gridSpacing = 1.2f;
	// Use this for initialization
	void Start () {

		this.transform.position = new Vector3(0,this.transform.position.y,0);

		for (int u = 0; u < 6; u++) {
			for (int v = 0; v < 6; v++) {
				Instantiate(square, new Vector3(gridSpacing*u, 0f, gridSpacing*v), Quaternion.identity);

			}
		}


//		this.transform.position.Set (-10, 0, 0);
//		this.transform.Translate (new Vector3(100, 0, 0));
//		this.transform.Translate (new Vector3(-100, 0, 0));

	}
	
	// Update is called once per frame
	void Update () {

	}
}
