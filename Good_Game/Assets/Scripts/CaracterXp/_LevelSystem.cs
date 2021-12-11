using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _LevelSystem : MonoBehaviour
{

    private int level;
    private int experience;
    private int experienceToNextLevel;

    public _LevelSystem()
    {
        level = 0;
        experience = 0;
        experienceToNextLevel = 100;

    }


    public void _AddExperience (int amount)
    {
        experience += amount;
        if(experience >= experienceToNextLevel )
        {
            level++;
            experience -= experienceToNextLevel;

        }
    }

    public int _GetLevelNumber()
    {
        return level;
    }
}
