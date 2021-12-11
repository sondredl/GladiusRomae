using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _testing : MonoBehaviour
{
    private void Awake()
    {
        _LevelSystem _levelsystem = new _LevelSystem();
        Debug.Log(_levelsystem._GetLevelNumber());
        _levelsystem._AddExperience(50);
        Debug.Log(_levelsystem._GetLevelNumber());
        _levelsystem._AddExperience(60);
    }
}
