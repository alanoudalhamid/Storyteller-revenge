using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Navigator : MonoBehaviour {

    public string SceneToLoad;
    float counter;
    bool counting;

    // Use this for initialization
    void Start () {

        counter = 0;
        counting = false;

    }
	
	// Update is called once per frame
	void Update () {
        if (counting)
        {
            if (Time.time - counter >= 3)
            {
                SceneManager.LoadScene(SceneToLoad);
            }
        }
	}

    private void LoadOnEnter()
    {
        counting = false;
        counter = Time.time;

    }

    private void ExitTrigger()
    {
        counting = false;
    }

}
