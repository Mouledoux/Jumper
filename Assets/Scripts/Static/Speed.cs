/* * * * *
 * EricMouledoux
 * EricMouledoux@Gmail.com
 * * * * */

/// <summary>
/// Global value for object to be at conistant speeds
/// </summary>
public class Speed
{
    /// <summary>
    /// Static value for the global speed value
    /// </summary>
    private static float m_GlobalSpeed = 1;

    /// <summary>
    /// Getter and Setter for the gloabl seed
    /// </summary>
    public static float globalSpeed
    {
        // Returns the current global speed based on the current framerate
        get { return m_GlobalSpeed * UnityEngine.Time.deltaTime; }
        // Makes sure the speed can never be set lower than 0
        set { m_GlobalSpeed = value >= 0 ? value : 0; }
    }
}
