/********************************************** //
 * Created by: Durward Craig Jr               * //
 * Contact Email: Durward.CraigJr@outlook.com * //
 ********************************************** //
 *////////////////////////////////////////////////

using UnityEngine;

public class CoinPickup : MonoBehaviour {

    private GameObject pickup;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        assignFloatScript(collision);
        collision.enabled = false;
        pickup = collision.gameObject;
    }

    /// <summary>
    /// Assigns the float script to the collided object.
    /// </summary>
    /// <param name="collision">The collision.</param>
    private void assignFloatScript(Collider2D collision)
    {
        Destroy(collision.GetComponent<LinearMovement>());
        collision.gameObject.AddComponent<FloatAboveObj>().FloatAboveObject(gameObject.transform);
        destroyLastPickup();
    }

    /// <summary>
    /// Gets rid of the last coin picked up
    /// </summary>
    private void destroyLastPickup()
    {
        if (pickup)
        {
            pickup.GetComponent<FloatAboveObj>().initializeDestroy();
        }
    }
}
