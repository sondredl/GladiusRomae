using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharStats : MonoBehaviour
{
    public List<BaseStat> stats = new List<BaseStat>();
    
    void Start()
    {
        stats.Add(new BaseStat(4, "Damage", "Damage level"));
        stats[0].AddStatBonus(new StatBonus(5));
        Debug.Log(stats[0].GetCalculatedStatValue());
    }

    public void AddStatBonus(List<BaseStat> statBonuses)
    {
        foreach(BaseStat statBonus in statBonuses)
        {
            stats.Find(x=> x.StatName == statBonus.StatName).AddStatBonus(new StatBonus(statBonus.BaseValue));


        }
    }

    public void RemoveStatBonus(List<BaseStat> statBonuses)
    {
        foreach (BaseStat statBonus in statBonuses)
        {
            stats.Find(x => x.StatName == statBonus.StatName).AddStatBonus(new StatBonus(statBonus.BaseValue));


        }
    }


}
