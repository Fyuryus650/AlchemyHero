using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public List<GameObject> enemiesList;
    public FloatData waveSpawnSclData;
    private EnemySpawner obj;
    public float waveScl, waveSpwnLimit;
    private int i = 0;

    private IEnumerator SpawnWave()
    {
        waveScl = waveSpawnSclData.value;

        waveSpwnLimit = (waveScl * waveScl + 10);

        yield return new WaitForSeconds(1.5f);

        enemiesList[i].SetActive(true);
        i++;

        if (i >= (waveSpwnLimit + 31))
        {
            i = 0;
            StopAllCoroutines();
            obj = gameObject.GetComponent<EnemySpawner>();
            obj.enabled = false;
        }
    }
    public void BeginPlay()
    {
        StartCoroutine(SpawnWave());
    }


}
