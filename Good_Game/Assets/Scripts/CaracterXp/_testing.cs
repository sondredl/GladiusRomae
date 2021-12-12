using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _testing : MonoBehaviour
{
    //[SerializeField] private _LevelWindow _levelWindow;

    [SerializeField] private LevelWindow levelWindow;
    [SerializeField] private MeleeController player;
    [SerializeField] private MeleeEnemyController Enemy;

    private void Awake()
    {
        LevelSystem levelSystem = new LevelSystem();
        Debug.Log(levelSystem.GetLevelNumber());
        levelSystem.AddExperience(50);
        Debug.Log(levelSystem.GetLevelNumber());
        levelSystem.AddExperience(500);
        Debug.Log(levelSystem.GetLevelNumber());

        levelWindow.SetLevelSystem(levelSystem);

        // refrence to the Level (levelSystem) with the same values

        player.SetLevelSystem(levelSystem);
    }
    /*
    public void AddExperience()
    {

        if (MeleeEnemyController.isAlive == true)
        {
            levelSystem.AddExperience(5000);
            Debug.Log(levelSystem.GetLevelNumber());
            levelWindow.SetLevelSystem(levelSystem);
            player.SetLevelSystem(levelSystem);
        }
    }
    */
    /*

    _LevelSystem _levelsystem = new _LevelSystem();
    Debug.Log(_levelsystem._GetLevelNumber());
        _levelsystem._AddExperience(50);
        Debug.Log(_levelsystem._GetLevelNumber());
        _levelsystem._AddExperience(1000);
        Debug.Log(_levelsystem._GetLevelNumber());


        _levelWindow._SetLevelSystem(_levelsystem);
    */
}
