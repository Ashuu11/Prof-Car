using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfPointTrigger : MonoBehaviour
{
    public GameObject LapCompleteTrig;
    public GameObject HalfPointTrig;

    private void OnTriggerEnter(Collider other)
    {
        LapCompleteTrig.SetActive(true);
        HalfPointTrig.SetActive(false);
    }
}
