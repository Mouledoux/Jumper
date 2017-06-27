/********************************************** //
 * Created by: Durward Craig Jr               * //
 * Contact Email: Durward.CraigJr@outlook.com * //
 ********************************************** //
 *////////////////////////////////////////////////

 /* Description: This script outlines what a coin entity is.
  */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

    /// <summary>
    /// Stores different possible colors of coins
    /// </summary>
    private enum e_Color
    {
        Red,
        Blue,
        Yellow
    }

    /// <summary>
    /// The color of the coin
    /// </summary>
    private e_Color m_Color;

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

    public Coin(uint a_Value)
    {
        if (a_Value > 0)
        m_Value = a_Value;
    }
}
