using UnityEngine;
using System.Collections;

public class GridSystem : MonoBehaviour {
	public GameObject square;

	const float gridSpacing = 1.03f;

	// Use this for initialization
	void Start () {
		// Initiate squares along grid system
		for (int u = 0; u < 6; u++) {
			for (int v = 0; v < 6; v++) {
				Instantiate(square, new Vector3(gridSpacing*u, 0f, gridSpacing*v), Quaternion.identity);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {

		// Check if mouse is hovering over a grid
		RaycastHit hit = new RaycastHit ();
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

		if (Physics.Raycast (ray, out hit)) {
			Square square = hit.transform.gameObject.GetComponent<Square>();
			if (square == null) return;
			
			square.ShowHelper ();
			int id = square.GetHelperID ();

			RemoveObjectsWithTag("HelperCube",id);
		}
	}

	void RemoveObjectsWithTag(string tag, int id) {
		GameObject[] objectsToRemove = GameObject.FindGameObjectsWithTag (tag);

		foreach (GameObject obj in objectsToRemove) {
			if (obj.GetInstanceID () != id)
				Destroy (obj);
		}

	}
}
