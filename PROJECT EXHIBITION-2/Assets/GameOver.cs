using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "enemy")
        {
            Debug.Log("Game Over");

            SceneManager.LoadScene("w");
        }
    }
}
