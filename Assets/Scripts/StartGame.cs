using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private GameObject prefab;
    [SerializeField] private Transform spawnPoint;

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Instantiate(prefab, new Vector3(spawnPoint.position.x, spawnPoint.position.y, spawnPoint.position.z), Quaternion.identity);
        }
    }
}
