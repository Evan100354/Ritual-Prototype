using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private GameObject prefab;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private int instanceCount = 100;

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Debug.Log("space");
            for (int i = 0; i < instanceCount; i++)
            {
                Instantiate(prefab, new Vector3(spawnPoint.position.x + (Random.Range(-1.5f, 2f)),spawnPoint.position.y + (Random.Range(-2.5f,2.5f)), spawnPoint.position.z + (Random.Range(-5f, 5f))), Quaternion.identity);
            }
        }
    }
}
