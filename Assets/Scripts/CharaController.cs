using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaController : MonoBehaviour
{
    [Header("VFX")]
    [SerializeField] private ParticleSystem m_deathVFX;

    [Header ("Variables")]
    [SerializeField] private float SpeedValue = 5;

    [Header ("RigidBody")]
    [SerializeField] private Rigidbody2D rb;

    private bool m_isAlive = true;

    public void TakeDamage(DiscController disc)
    {
        KillChara();
    }

    public void KillChara()
    {
        m_deathVFX.Play();
        m_isAlive = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Disc"))
        {
            DiscController disc = collision.GetComponentInParent<DiscController>();
            if (disc)
            {
                TakeDamage(disc);
            }
        }
    }

    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        Vector2 movement = new Vector2(moveX, moveY).normalized * SpeedValue;

        rb.velocity = movement;


        
    }
}
