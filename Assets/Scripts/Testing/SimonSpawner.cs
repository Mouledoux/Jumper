using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimonSpawner : MonoBehaviour
{
    public float m_spawnWaveRate;
    public float m_spawnCoinRate;
    public List<GameObject> m_spawnableObjects = new List<GameObject>();
    public List<GameObject> m_gameObjectSequence = new List<GameObject>();

    // Use this for initialization
    void Start()
    {
        StartCoroutine(_Spawn());
    }

    IEnumerator _Spawn()
    {
        int index = 0;
        while (Application.isPlaying)
        {
            if (index >= m_gameObjectSequence.Count)
            {
                index = 0;
                m_gameObjectSequence.Add(m_spawnableObjects[Utility.randomValue(0, m_spawnableObjects.Count)]);
                m_spawnWaveRate += (0.1f);
                //continue;
            }
            else
            {
                Instantiate(m_gameObjectSequence[index]);
                index++;
                yield return new WaitForSeconds(1f / m_spawnCoinRate);
                continue;
            }

            yield return new WaitForSeconds(1f / m_spawnWaveRate);
        }
    }
}
