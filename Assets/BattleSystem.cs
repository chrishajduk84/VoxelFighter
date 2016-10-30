using UnityEngine;
using System.Collections;

public class BattleSystem : MonoBehaviour {
    public Camera mainCamera;
    public Canvas menuCanvas;
    public GameObject firstPersonController;

    const float totalTime = 20; //Seconds

    float startTime;
    bool battleStarted = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (battleStarted)
        {
            //Movement of the camera


            //Update Text Timer
            //TODO

            //Once the time is up revert to the previous camera
            if (Time.time - startTime > totalTime)
            {
                battleStarted = false;
                stopBattle();
            }
        }
	}

    public void startBattle()
    {
        Instantiate(firstPersonController, new Vector3(1, 1, 1), Quaternion.identity);
        startTime = Time.time;
        battleStarted = true;
        mainCamera.enabled = false;

        //Change text and function pointer
        menuCanvas.enabled = false;
    }
    public void stopBattle()
    {
        mainCamera.enabled = true;
        menuCanvas.enabled = true;
    }
}
