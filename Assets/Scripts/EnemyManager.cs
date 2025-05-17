using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] private List<Pattern> patterns;
    private int seed;
    private Pattern currentPattern;

    public void Init(int seed)
    {
        this.seed = seed;
    }

    private void Start()
    {
        currentPattern = patterns[seed % patterns.Count];

        for(int i = 0; i < currentPattern.objs.Count; i++)
        {
            GameObject obj = Instantiate(currentPattern.objs[i]);
            Vector2 vector2 = Random.insideUnitCircle * 50;
            obj.transform.position = transform.position+ new Vector3(vector2.x,1,vector2.y);
        }
    }
}
