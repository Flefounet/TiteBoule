using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuActions : MonoBehaviour {


    //Load Scene 1 (level1) on click -- applied to StartButton
    public void MenuActionOnClick()
    {
         SceneManager.LoadScene("_scene_lvl1");
    }
}