using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public List<GameObject> skeletonsList, ogresList;
    public FloatData waveSpawnSclData;
    public IntData waveCountData;
    private EnemySpawner obj;
    public float waveScl, waveSpwnLimit;
    private int i = 0;

    private void Awake()
    {
        waveCountData.value = 0;
        waveScl = waveSpawnSclData.value;
    }
    public IEnumerator SpawnWave()
    {
        waveScl = waveSpawnSclData.value;

        yield return new WaitForSeconds(1);

        skeletonsList[i].SetActive(true);

        Debug.Log("spawnEnemy");
        waveSpwnLimit = (waveScl * waveScl + 5 + (waveCountData.value * 1.5f));

        i++;

        if(waveCountData.value > 3)
        {
            ogresList[i].SetActive(true);
        }

        if (i >= (waveSpwnLimit))
        {
            Debug.Log("Stopspawning");
            i = 0;
            StopAllCoroutines();
            obj = gameObject.GetComponent<EnemySpawner>();
            obj.enabled = false;
        }
    }

    private void Update()
    {
        StartCoroutine(SpawnWave());
    }
}
