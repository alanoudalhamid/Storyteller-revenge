using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
using UnityEngine;

public class SceneControl : MonoBehaviour
{

    public VideoPlayer videoPlayer;
    public AudioSource[] audioSources;
    private AudioSource Soundtrack;
    public string SceneToLoad;
    public bool VideoScene;


    private Animator Fade;



    void Start()
    {
        Fade = GetComponent<Animator>();
        videoPlayer.loopPointReached += LoadScene;
        Soundtrack = MyUnitySingleton.Instance.gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            if (VideoScene)
            {
                if (videoPlayer.isPlaying)
                {
                    videoPlayer.Pause();
                    for (int i = 0; i < audioSources.Length; i++)
                    {
                        audioSources[i].Pause();
                        if (Soundtrack != null)
                        {
                            Soundtrack.Pause();
                        }
                    }
                }

                else
                {
                    PlayVideo();
                }
            }
        }
    }

        public void FadeScene(string NameOfScene)
        {
            SceneToLoad = NameOfScene;
            Fade.Play("Fade_Out");
        }

        public void LoadScene(VideoPlayer vp)
        {
            SceneManager.LoadScene(SceneToLoad);
        }

    public void LoadScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

    public void PlayVideo()
    {
        videoPlayer.Play();
        for (int i = 0; i < audioSources.Length; i++)
        {
            audioSources[i].UnPause();
            
            if (Soundtrack != null)
            {
                Soundtrack.UnPause();
            }
        }
    }

}

