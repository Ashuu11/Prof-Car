using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LabTimeManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static int Minutecount;
    public static int Secondcount;
    public static float Milicount;
    public static string MilliDisplay;

    public GameObject MinuteBox;
    public GameObject SecondBox;
    public GameObject MilliBox;


    // Update is called once per frame
    void Update()
    {
        Milicount += Time.deltaTime * 10;
        MilliDisplay = Milicount.ToString("F0");
        MilliBox.GetComponent<Text>().text = "" + MilliDisplay;

        if(Milicount >= 10)  {
            Milicount = 0;
            Secondcount += 1;
        }
        if(Secondcount <= 9){
            SecondBox.GetComponent<Text>().text = "0" + Secondcount + ".";
        }
        else{
            SecondBox.GetComponent<Text>().text = "" + Secondcount + ".";
        }
        if(Secondcount >= 60){
            Secondcount = 0;
            Minutecount += 1;
        }
        if(Minutecount<=9){
            MinuteBox.GetComponent<Text>().text = "0" + Minutecount + ":";
        }
        else{
            MinuteBox.GetComponent<Text>().text = "" + Minutecount + ":";
        }
    }
}
