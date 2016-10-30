using UnityEngine;
using System.Collections;

public class GridSystem : MonoBehaviour {
	public GameObject square;
	public LayerMask hoverableLayers;

	const float gridSpacing = 1.01f;

	void Start () {
		// Initiate squares along grid system
		for (int u = 0; u < 6; u++) {
			for (int v = 0; v < 6; v++) {
				Instantiate(square, new Vector3(gridSpacing*u, 0f, gridSpacing*v), Quaternion.identity);
			}
		}
	}

	void Update () {
		// Check if mouse is hovering over a grid
		RaycastHit hit = new RaycastHit ();
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

		if (Physics.Raycast (ray, out hit, 100, hoverableLayers)) {

			// Get the square associated with the hit gameobject
			Square square = hit.transform.gameObject.GetComponent<BrickController>().square;
			if (square == null) return;

			int idToIgnore = 0;
			if (Input.GetMouseButtonDown (0) ) {
				// On click Place Brick:
				square.PlaceBrick ();
			} else {
				// Show Helper Brick:
				square.ShowHelper ();
				idToIgnore = square.GetHelperID ();
			}

			// Remove Old Helper Grids:
			RemoveObjectsWithTag("HelperCube",idToIgnore);
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
