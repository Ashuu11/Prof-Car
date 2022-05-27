using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class yellow : MonoBehaviour
{
    public void LoadSceneOnClick(int scene2)
    {
        SceneManager.LoadScene(scene2);
    }
}
