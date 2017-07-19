/********************************************** //
 * Created by: Durward Craig Jr               * //
 * Contact Email: Durward.CraigJr@outlook.com * //
 ********************************************** //
 *////////////////////////////////////////////////

using UnityEngine;

/// <summary>
/// Used to float objects vertically above an object
/// </summary>
public class FloatAboveObj : MonoBehaviour {

    /// <summary>
    /// Is the object flo
    /// </summary>
    public bool away = false;

    /// <summary>
    /// The object the child floats above
    /// </summary>
    public Transform parent;

    /// <summary>
    /// The height the object floats above parent
    /// </summary>
    private float minHeight;

    /// <summary>
    /// Are we about to destroy the object?
    /// </summary>
    private bool destroy = false;

    /// <summary>
    /// Time it takes to destroy object
    /// </summary>
    private float destroyTime = 1f;

    /// <summary>
    /// The current time
    /// </summary>
    private float currentTime = 0f;


    /// <summary>
    /// Floats a child object on top of a specified parent
    /// </summary>
    /// <param name="child">The child.</param>
    /// <param name="parent">The parent.</param>
    public void FloatAboveObject(Transform parent)
    {
        this.parent = parent;
        minHeight = parent.gameObject.GetComponent<SpriteRenderer>().size.y;
    }

    private void FixedUpdate()
    {
        if (parent == null)
            return;
           
        positionObject();
        checkDestroy();
    }

    /// <summary>
    /// Check to see if the game object needs to be destroyed
    /// </summary>
    private void checkDestroy()
    {
        if (destroy)
        {
            floatAway(0);
            destroyObject();
        }
    }

    /// <summary>
    /// Initialize the current time and destroy time
    /// </summary>
    public void initializeDestroy()
    {
        currentTime = Time.time;
        destroyTime += Time.time;
        destroy = true;
    }

    /// <summary>
    /// Destroys the object.
    /// </summary>
    private void destroyObject()
    {
        if (currentTime > destroyTime)
            Destroy(gameObject);
        else
            currentTime = Time.time;
    }

    /// <summary>
    /// Positions the child object on the parent
    /// </summary>
    private void positionObject()
    {
        Vector3 desiredPosition = parent.position + (Vector3.up * minHeight);
        transform.position = Vector3.Lerp(transform.position, desiredPosition, 0.1f);
    }

    /// <summary>
    /// Gets the height of the child object
    /// </summary>
    /// <returns></returns>
    private float getHeight()
    {
        return Mathf.Abs(transform.position.y - parent.position.y);
    }

    /// <summary>
    /// Floats away the object in the specified direction.
    /// 0 = Top Left, 1 = Top, 2 = Top Right, 3 = Bottom Left, 4 = Bottom, 5 = Bottom Right
    /// </summary>
    /// <param name="direction">The direction.</param>
    private void floatAway(int direction)
    {
        transform.position = Vector3.Lerp(transform.position, determineDirection(direction), 0.0015f);
    }

    /// <summary>
    /// Returns the appropriate position for the specified direction
    /// </summary>
    /// <param name="direction">The direction.</param>
    /// <returns></returns>
    private Vector3 determineDirection(int direction)
    {
        Vector3 dir = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, Camera.main.nearClipPlane));

        switch (direction)
        {
            case 0:     //Top Left
                dir += Vector3.up * Screen.height;
                dir -= Vector3.right * (Screen.width / 2);
                break;

            case 1:     //Top
                dir += Vector3.up * Screen.height;
                break;

            case 2:     //Top Right
                dir += Vector3.right * Screen.width;
                dir += Vector3.up * Screen.height;
                break;

            case 3:     //Bottom Left
                dir -= Vector3.up * Screen.height;
                dir -= Vector3.right * (Screen.width / 2);
                break;

            case 4:     //Bottom
                dir -= Vector3.up * Screen.height;
                break;

            case 5:     //Bottom Right
                dir -= Vector3.up * Screen.height;
                dir += Vector3.right * Screen.width;
                break;
        }

        return dir;
    }


}
