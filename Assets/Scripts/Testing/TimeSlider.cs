using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeSlider : MonoBehaviour
{
    [Range(0, 10)]
    public float speed;
	
	// Update is called once per frame
	void Update () {
        Speed.globalSpeed = speed;
	}
}
