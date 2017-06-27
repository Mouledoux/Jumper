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

    /// <summary>
    /// Value to modify the global sped by if desired
    /// </summary>
    [SerializeField]
    private float m_SpeedMod = 1;

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
        transform.Rotate(transform.forward, (Speed.globalSpeed * m_SpeedMod) * (CCW ? 1 : -1));
        return 0;
    }
}
