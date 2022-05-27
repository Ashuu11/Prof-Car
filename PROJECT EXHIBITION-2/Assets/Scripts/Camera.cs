using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject TheCar;
    public float Carx;

    public float Cary;
    public float Carz;
    // Update is called once per frame
    void Update()
    {
        Carx = TheCar.transform.eulerAngles.x;

        Cary = TheCar.transform.eulerAngles.y;

        Carz = TheCar.transform.eulerAngles.z;
        transform.eulerAngles = new Vector3(Carx - Carx, Cary, Carz - Carz);
    }
}
