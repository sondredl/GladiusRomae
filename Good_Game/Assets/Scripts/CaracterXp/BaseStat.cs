using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
public class BaseStat 
{
    public List<StatBonus> BaseAdditives { get; set; }
    //start off with empty values baseValue
    public int BaseValue { get; set; }
    //Display characters sheets
    public string StatName { get; set; } 
    public string StatDescription { get; set; }

    public int FinalValue { get; set; }


    public BaseStat(int baseValue, string statName, string statDescription)
    {
        this.BaseAdditives = new List<StatBonus>();
        this.BaseValue = baseValue;
        this.StatName = statName;
        this.StatDescription = statDescription; 

    }

    public void AddStatBonus(StatBonus statBonus)
    {
        this.BaseAdditives.Add(statBonus);
    }

    public void RemoveStatBonus(StatBonus statBonus)
    {
        this.BaseAdditives.Remove(statBonus);
    }

    public int GetCalculatedStatValue()
    {
        this.BaseAdditives.ForEach(x => this.FinalValue += x.BonusValue );
        FinalValue += BaseValue;
        return FinalValue;
    }



    /*
    public enum BaseStatType{ Damage, Health }
    public List<StatBonus> BaseAdditives { get; set; }
    [JsonConverter(typeof(StringEnumConverter))]
    public BaseStatType StatType { get; set; }
    public int BaseValue { get; set; }
    public string StatName { get; set; }
    public string StatDescription { get; set; }
    public int FinalValue { get; set; }


    public BaseStat(int baseValue, string statName, string statDescription )
    {
        this.BaseAdditives = new List<StatBonus>();
        this.BaseValue = baseValue;
        this.StatName = statName;
        this.StatDescription = statName;

    }
    [Newtonsoft.Json.JsonConstructor]

    public BaseStat(BaseStatType startType, int baseValue, string statName)
    {
        this.BaseAdditives = new List<StatBonus>();
    }

    public void AddStatBonus(StatBonus statBonus)
    {
        this.BaseAdditives.Add(statBonus);
    }

    public void RemoveStatBonus(StatBonus statBonus)
    {
        this.BaseAdditives.Remove(BaseAdditives.Find(x=> x.BonusValue == statBonus.BonusValue));
    }

    public int GetCalculatedStatValue()
    {
        this.FinalValue = 0;
        this.BaseAdditives.ForEach(x => this.FinalValue += x.BonusValue);
        this.FinalValue += BaseValue;

        return this.FinalValue;
    }
    */
}
