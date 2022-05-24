using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    /* Este método é uma alternativa ao Singleton, porque muita das vezes usamos o Singleton
    apenas porque queremos manter um objeto ativo em todas as cenas, e isto já é o suficiente */

    [SerializeField]
    private GameObject _persistentObjectPrefab;

    private static bool _hasSpawned = false;

    private void Awake()
    {
        if (_hasSpawned) return;

        SpawnPersistedObject();
        _hasSpawned = true;
    }

    private void SpawnPersistedObject()
    {
        GameObject persistentObject = Instantiate(_persistentObjectPrefab);
        DontDestroyOnLoad(persistentObject);
    }
}
