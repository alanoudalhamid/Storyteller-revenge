using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneTransition : MonoBehaviour {

    Animator Fade;
    string SceneToLoad;
    // Use this for initialization
    void Start () {
        Fade = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            FadeScene("Waterfall");
        }
	}

    public void FadeScene(string NameOfScene)
    {
        SceneToLoad = NameOfScene;
        Fade.SetBool("FadeOut", true);
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(SceneToLoad);
    }
}
