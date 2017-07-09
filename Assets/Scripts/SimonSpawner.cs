using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimonSpawner : MonoBehaviour
{
    public float m_spawnRate = 1f;
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
                m_spawnRate += 0.05f;

                int nextObjectInex = Utility.randomValue(0, m_spawnableObjects.Count);

                if (m_gameObjectSequence.Count > 2)
                {
                    if (m_spawnableObjects[nextObjectInex] == m_gameObjectSequence[m_gameObjectSequence.Count - 1] &&
                        m_spawnableObjects[nextObjectInex] == m_gameObjectSequence[m_gameObjectSequence.Count - 2])
                    {
                        nextObjectInex = (nextObjectInex + 1) % m_spawnableObjects.Count;
                    }
                }

                m_gameObjectSequence.Add(m_spawnableObjects[nextObjectInex]);
            }

            Instantiate(m_gameObjectSequence[index]);
            index++;
            yield return new WaitForSeconds(1f / m_spawnRate);
        }
    }

    public void ClearSpawnQue()
    {
        m_gameObjectSequence.Clear();
    }
}
