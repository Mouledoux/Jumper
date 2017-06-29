using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int m_Coins;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("Hit");
    }
}
