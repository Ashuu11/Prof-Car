using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LapComplete : MonoBehaviour
{
    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;

    public GameObject MinuteDisplay;
    public GameObject SecondDisplay;
    public GameObject MilliDisplay;

    public GameObject LaptimeBox;

    void OnTriggerEnter(Collider other)
    {
        if (LabTimeManager.Secondcount <= 9)
        {
            SecondDisplay.GetComponent<Text>().text = "0" + LabTimeManager.Secondcount + ".";
        }
        else
        {
            SecondDisplay.GetComponent<Text>().text = "" + LabTimeManager.Secondcount + ".";
        }
        if (LabTimeManager.Secondcount <= 9)
        {
            MinuteDisplay.GetComponent<Text>().text = "0" + LabTimeManager.Minutecount + ".";
        }
        else
        {
            MinuteDisplay.GetComponent<Text>().text = "" + LabTimeManager.Minutecount + "."; ;
        }
        MilliDisplay.GetComponent<Text>().text = "" + LabTimeManager.Milicount;
        LabTimeManager.Minutecount = 0;
        LabTimeManager.Secondcount = 0;
        LabTimeManager.Milicount = 0;
        HalfLapTrig.SetActive(true);
        LapCompleteTrig.SetActive(false);
    }

}
