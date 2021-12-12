using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _LevelWindow : MonoBehaviour
{
    private Text levelText;
    private Image experienceBarImage;

    private _LevelSystem _levelSystem;



    private void Awake()
    {
        levelText = transform.Find("levelText").GetComponent<Text>();
        experienceBarImage = transform.Find("experienceBar").Find("bar").GetComponent<Image>();

        //_SetExperienceBarSize(.5f);
        //_SetLevelNumber(7);

    }

    private void _SetExperienceBarSize(float experienceNormalized)
    {
        experienceBarImage.fillAmount = experienceNormalized;
    }

    private void _SetLevelNumber(int levelNumber)
    {
        levelText.text = "LEVEL\n" + (levelNumber + 1);
    }

    public void _SetLevelSystem(_LevelSystem _levelSystem)
    {
        this._levelSystem = _levelSystem;

        _SetLevelNumber(_levelSystem._GetLevelNumber());

        _SetExperienceBarSize(_levelSystem._GetExperienceNormalized());
    }
    
}
