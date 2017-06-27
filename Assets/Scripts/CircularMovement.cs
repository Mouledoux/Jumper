/* * * * *
 * EricMouledoux
 * EricMouledoux@Gmail.com
 * * * * */
 
using UnityEngine;

/// <summary>
/// Component used to rotate object in place at a constant speed
/// </summary>
public class CircularMovement : MonoBehaviour
{
    /// <summary>
    /// Should the object turn counter-clockwise
    /// </summary>
    [SerializeField]
    private bool CCW;

    void Update()
    {
        RotateAtGlobalSpeed();
    }

    /// <summary>
    /// rotates the object at the predefined global speed
    /// </summary>
    /// <returns></returns>
    private int RotateAtGlobalSpeed()
    {
        transform.Rotate(transform.forward, (Speed.globalSpeed * 90) * (CCW ? 1 : -1));
        return 0;
    }
}
