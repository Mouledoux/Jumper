/********************************************** //
 * Created by: Durward Craig Jr               * //
 * Contact Email: Durward.CraigJr@outlook.com * //
 ********************************************** //
 *////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using System;

/// <summary>
/// Contains useful functions that are used throughout classes
/// </summary>
public static class Utility {

    /// <summary>
    /// Used for random number generation
    /// </summary>
    private static Random random = new Random(Guid.NewGuid().GetHashCode());

    /// <summary>
    /// Returns a random int between a max and min
    /// </summary>
    /// <param name="min"></param>
    /// <param name="max"></param>
    /// <returns></returns>
    internal static int randomValue(int min, int max)
    {
        return random.Next(min, max);
    }
}
