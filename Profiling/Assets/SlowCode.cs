using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SlowCode : MonoBehaviour
{
    private float timeValueRed;
    private float timeValueGreen;
    private float timeValueBlue;
    void Update()
    {
        GetComponent<Renderer>().material.color = ColorForTime();
    }

    private Color ColorForTime()
    {
        timeValueRed += Time.deltaTime;
        if (timeValueRed > 1f)
            timeValueRed -= 1f;
        timeValueGreen += Time.deltaTime * 2f;
        if (timeValueGreen > 1f)
            timeValueGreen -= 1f;
        timeValueBlue += Time.deltaTime * 3f;
        if (timeValueBlue > 1f)
            timeValueBlue -= 1f;
        return new Color(timeValueRed, timeValueGreen, timeValueBlue);
    }
}