using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterItem 
{
    public List <BaseStat> Stats { get; set; }  
    public string ObjectSlug { get; set; }
    public CharacterItem(List<BaseStat> _Stats,string _ObjectSlug)
    {
        this.Stats = _Stats;
        this.ObjectSlug = _ObjectSlug;

    }

}
