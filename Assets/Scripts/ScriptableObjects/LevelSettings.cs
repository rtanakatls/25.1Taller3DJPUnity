using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DefaulLevelSettingsName", menuName = "TLS/LevelSettings")]
public class LevelSettings : ScriptableObject
{

    [SerializeField] private List<Pattern> patterns;

    public List<Pattern> PatternList { get {  return patterns; } }
}
