using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene2 : MonoBehaviour
{
    public void LoadSceneOnClick(int menu2)
    {
        SceneManager.LoadScene(menu2);
    }
}
