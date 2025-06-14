using UnityEngine;

public class LifeController : MonoBehaviour
{
    [SerializeField] private int count;

    private void Awake()
    {
        count = PlayerPrefs.GetInt("Count", 0);
        
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            count++;
        }

        if(Input.GetKeyDown(KeyCode.P))
        {
            PlayerPrefs.SetInt("Count", count);
            PlayerPrefs.Save();
        }
    }
}
