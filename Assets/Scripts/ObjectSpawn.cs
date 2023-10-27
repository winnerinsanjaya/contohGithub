using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject prefabs;

    [SerializeField]
    private float countDown;

    private float orCountDown;
    // Start is called before the first frame update
    void Start()
    {
        orCountDown = countDown;
    }

    // Update is called once per frame
    void Update()
    {
        countDown -= Time.deltaTime;

        if(countDown > 0)
        {
            return;
        }
        SpawnObj();

        countDown = orCountDown;
    }

    private void SpawnObj()
    {
        Instantiate(prefabs, this.transform.position, Quaternion.identity, this.transform);
    }
}
