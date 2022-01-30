using System.Collections.Generic;
using UnityEngine;

public class FiringBehaviour : MonoBehaviour
{
    public List<GameObject> potionJuiceList;
    private FiringBehaviour obj;
    private int i = 0;

    private void Start()
    {
        
    }
    private void Update()
    {
        potionJuiceList[i].SetActive(true);
        i++;

        if(i >= potionJuiceList.Count)
        {
            i = 0;
            obj = GetComponent<FiringBehaviour>();
            obj.enabled = !obj.enabled;
        }
    }
}
