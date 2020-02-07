﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class Intro : MonoBehaviour
{
    private VideoPlayer _intro;
    void Awake()
    {

        _intro = GameObject.FindGameObjectWithTag(Tags.MAIN_CAMERA).GetComponent<VideoPlayer>();
        _intro.loopPointReached += EndReached;
        _intro.Prepare();
    }

    private void Start()
    {
        _intro.Play();
    }
    private void EndReached(VideoPlayer vp)
    {
        _intro.Stop();
        SceneManager.LoadScene(Scenes.GAME);
    }
}
