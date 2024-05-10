using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.WSA;

public class DiscController : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Rigidbody2D m_rb;


    [Header("Values")]
    [SerializeField] private float m_speed = 01;
    [SerializeField] private float m_LifeDuration;
    


    [Header("Rotation")]
    [SerializeField] private Transform m_rotationHandler;
    [SerializeField] private float m_rotationSpeed = 25;


    private void Start()
    {
        Launch();    
    }

    private void Launch()
    {
        Vector2 randomDir = Random.insideUnitCircle.normalized;
        m_rb.AddForce(randomDir * m_speed, ForceMode2D.Impulse);
    }
    private void Update()
    {
        m_rotationHandler.Rotate(Vector3.forward * m_rotationSpeed * Time.deltaTime);
        StartCoroutine(DestroyDisc());

        
    }

    private IEnumerator DestroyDisc()
    {
        m_LifeDuration = Random.Range(50, 60);
        yield return new WaitForSeconds(m_LifeDuration);
        Destroy(gameObject);
    }

}
