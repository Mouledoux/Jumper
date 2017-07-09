using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AnimationToWorldTime : MonoBehaviour
{
    Animator m_animator;
    float m_originalSpeed;

	// Use this for initialization
	void Start ()
    {
        m_animator = GetComponent<Animator>();
        m_originalSpeed = m_animator.speed;
	}
	
	// Update is called once per frame
	void Update ()
    {
        ModAnimationSpeedToWorldTime();
	}

    private void ModAnimationSpeedToWorldTime()
    {
        m_animator.speed = (m_originalSpeed * Speed.globalSpeed);
        print(m_animator.speed);
    }
}
