using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeRooms : MonoBehaviour {

    float timer;

    public bool end = false;

    void Update() {
        if (Input.GetAxis("openvr-r-triggerpull") > 0.1f || OVRInput.Get(OVRInput.Button.One))
        {
            timer += Time.deltaTime;
            if (timer >= 2)
            {
                if (!end)
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                else
                    SceneManager.LoadScene(0);
            }
        }
        else
            timer = 0;
	}
}
