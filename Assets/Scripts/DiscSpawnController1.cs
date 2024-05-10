using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.WSA;

public class DiscSpawnController : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Rigidbody2D m_rb;


    [Header("Values")]
    [SerializeField] private float m_speed = 01;
    


    private void Start()
    {
        Launch();    
    }

    private void Launch()
    {
        Vector2 randomDir = Random.insideUnitCircle.normalized;
        m_rb.AddForce(randomDir * m_speed, ForceMode2D.Impulse);
    }


}
