using UnityEngine;
using System.Collections.Generic;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private List<Pattern> patterns;
    [SerializeField] private int seed;
    private Pattern currentPattern;

    private void Awake()
    {
        seed = Random.Range(0, 1000000);
        currentPattern = patterns[seed % patterns.Count];

        int index = 0;
        for(int i=0;i<20;i++)
        {
            GameObject obj = Instantiate(currentPattern.objs[index]);
            obj.transform.position = Vector3.forward * i * 100;
            obj.GetComponent<EnemyManager>().Init(seed);
            index++;
            if (index >= currentPattern.objs.Count)
            {
                index = 0;
            }
        }
    }
}
