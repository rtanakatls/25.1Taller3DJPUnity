using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Scriptable Objects/Data")]
public class Data : ScriptableObject
{
    [SerializeField] private int life;

    public int Life { get { return life; }}
}
