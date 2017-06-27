/********************************************** //
 * Created by: Durward Craig Jr               * //
 * Contact Email: Durward.CraigJr@outlook.com * //
 ********************************************** //
 *////////////////////////////////////////////////

using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// Component for spawning objects in the game
/// </summary>
public class Spawner : MonoBehaviour {

    public float m_spawnRate;
    private float time;
    

    public void Start()
    {
        time = Time.time;
    }

    public void Update()
    {
        if (Time.time - time > m_spawnRate)
        {
            spawnCoin();
            time = Time.time;
        }
    }

    /// <summary>
    /// Spawns the specified object.
    /// </summary>
    /// <param name="obj">The object to spawn.</param>
    public void spawn(GameObject a_obj)
    {
        GameObject obj = Instantiate(a_obj);

        obj.transform.position = this.transform.position;
    }

    public void spawnCoin()
    {
        GameObject coin = Instantiate(Resources.Load("Coin")) as GameObject;
        coin.transform.position = transform.position;
    }
}
