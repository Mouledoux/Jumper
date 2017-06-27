/********************************************** //
 * Created by: Durward Craig Jr               * //
 * Contact Email: Durward.CraigJr@outlook.com * //
 ********************************************** //
 *////////////////////////////////////////////////

using UnityEngine;

/// <summary>
/// Component for a "coin" entity
/// </summary>
public class Coin : MonoBehaviour {

    /// <summary>
    /// The color of the coin
    /// </summary>
    private Color m_Color;

    /// <summary>
    /// The value of the coin
    /// </summary>
    private uint m_Value;

    /// <summary>
    /// The rotation speed
    /// </summary>
    private uint m_Rotation;

    private void Start()
    {
        //Initialize Color
        //Initialize Speed
    }

    private void Update()
    {
        
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Coin"/> class with passed value.
    /// </summary>
    /// <param name="a_Value">a value.</param>
    public Coin(uint a_Value, Color color)
    {
        //Make sure the value passed is greater than 0
        if (a_Value > 0)
            m_Value = a_Value;
        else
            m_Value = 1;

        //Set the color
        m_Color = color;
        setColor();
    }

    /// <summary>
    /// Sets the color of the coin.
    /// </summary>
    private void setColor()
    {
        GetComponent<SpriteRenderer>().color = m_Color;
    }

    /// <summary>
    /// Picks up the coin.
    /// </summary>
    private void pickUp()
    {
        Destroy(this.gameObject);
    }

    
}
