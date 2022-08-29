using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomSpawner : MonoBehaviour
{
    public GameObject objPrefab;
    [SerializeField] int _poolSize;
    private List<GameObject> _pool = new List<GameObject>();

    void Start()
    {
        for(int i = 0; i < _poolSize; i++)
        {
            _pool.Add(Instantiate(objPrefab, transform.position, Quaternion.identity));
        }
    }

    void FixedUpdate()
    {
        GameObject tmpPoolObject = FindInactivePoolObject();
        if (tmpPoolObject != null)
        {
            tmpPoolObject.transform.position = transform.position;
            tmpPoolObject.SetActive(true);
        }
    }

    private GameObject FindInactivePoolObject()
    {
        foreach(GameObject go in _pool)
        {
            if (!go.activeInHierarchy)
            {
                return go;
            }
        }
        return null;
    }
}
