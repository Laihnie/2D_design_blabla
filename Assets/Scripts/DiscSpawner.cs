using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class DiscSpawner : MonoBehaviour
{
    [SerializeField] private DiscController m_discPrefab;
    [SerializeField] private float m_spawnFrequency;
   
    void Start()
    {
        StartCoroutine(C_Spawn());
    }

    private void SpawnDisc()
    {
        DiscController spawnedDisc = Instantiate(m_discPrefab, transform.position, Quaternion.identity);
    }

    private IEnumerator C_Spawn()
    {
        m_spawnFrequency = Random.Range(5, 10);
        yield return new WaitForSeconds(m_spawnFrequency);
        SpawnDisc();
        StartCoroutine(C_Spawn());
    }
    
}
