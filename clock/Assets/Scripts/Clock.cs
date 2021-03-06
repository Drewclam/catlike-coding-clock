using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Clock : MonoBehaviour {
    [SerializeField]
    Transform hoursPivot;

    [SerializeField]
    Transform minutesPivot;

    [SerializeField]
    Transform secondsPivot;

    const float hoursToDegrees = -30;
    const float minutesToDegrees = -6f;
    const float secondsToDegrees = -6f;

    private void Update() {
        //DateTime time = DateTime.Now;
        TimeSpan time = DateTime.Now.TimeOfDay;
        hoursPivot.localRotation = Quaternion.Euler(0f, 0f, hoursToDegrees * (float)time.TotalHours);
        minutesPivot.localRotation = Quaternion.Euler(0f, 0f, minutesToDegrees * (float)time.TotalMinutes);
        secondsPivot.localRotation = Quaternion.Euler(0f, 0f, secondsToDegrees * (float)time.TotalSeconds);
    }
}
