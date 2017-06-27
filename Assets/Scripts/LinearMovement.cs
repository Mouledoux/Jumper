/* * * * *
 * EricMouledoux
 * EricMouledoux@Gmail.com
 * * * * */
 
using UnityEngine;

/// <summary>
/// Component used to move object in a straight line in 2d space at a constant speed
/// </summary>
public class LinearMovement : MonoBehaviour
{
    /// <summary>
    /// Direction in 2D space the object is moving in
    /// </summary>
    [SerializeField]
    private Vector2 m_Direction;

    /// <summary>
    /// Getter and Setter for the direction
    /// </summary>
    public Vector2 direction
    {
        // Returns the normalized direction
        get { return m_Direction.normalized; }
        // Sets the direction to a normalized Vector2
        set { m_Direction = value.normalized; }
    }
	
	void Update ()
    {
        MoveAtGloablSpeed();
	}

    /// <summary>
    /// Moves the object in the set direction at the predefined global speed
    /// </summary>
    /// <returns></returns>
    private int MoveAtGloablSpeed()
    {
        transform.position += (Vector3)(direction * Speed.globalSpeed);
        return 0;
    }
}
