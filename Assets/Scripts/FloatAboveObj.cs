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
    /// The height the object rises to
    /// </summary>
    public float maxHeight = 3f;

    /// <summary>
    /// The minimum height above the parent object the child object is allowed
    /// </summary>
    public float minHeight = 1f;

    /// <summary>
    /// The speed the object floats between the max and min height
    /// </summary>
    public float floatSpeed = 2;

    /// <summary>
    /// The object the child floats above
    /// </summary>
    private Transform parent;

    /// <summary>
    /// The direction the object is floating. True if up. False if down
    /// </summary>
    private bool direction;


    /// <summary>
    /// Floats a child object on top of a specified parent
    /// </summary>
    /// <param name="child">The child.</param>
    /// <param name="parent">The parent.</param>
    public void FloatAboveObject(Transform parent)
    {
        this.parent = parent;
        positionObject();
        direction = true;
    }

    private void FixedUpdate()
    {
        if (parent == null)
            return;

        getHeight();

        floatObject();
    }

    /// <summary>
    /// Positions the child object on the parent
    /// </summary>
    private void positionObject()
    {
        transform.position = parent.position + (Vector3.up * minHeight);
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
    /// Floats the object above the parent
    /// </summary>
    private void floatObject()
    {
        if (direction)
            direction = !raiseObject();

        else
            direction = lowerObject();
    }

    /// <summary>
    /// Raises the object.
    /// </summary>
    /// <returns></returns>
    private bool raiseObject()
    {
        transform.position += Vector3.up * floatSpeed * Time.deltaTime;
        return transform.position.y >= maxHeight;
    }

    /// <summary>
    /// Lowers the object.
    /// </summary>
    /// <returns></returns>
    private bool lowerObject()
    {
        transform.position -= Vector3.up * floatSpeed * Time.deltaTime;
        return transform.position.y <= parent.position.y + minHeight;
    }


}
