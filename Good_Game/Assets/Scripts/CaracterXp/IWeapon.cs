using System.Collections.Generic;

public interface IWeapon
{
    List<BaseStat> Stats { get; set; }
    void PerFormAttack();
    /*
    int CurrentDamage { get; set; }
    void PerformAttack(int damage) { }
    void PerformSpecialAttack();
    */
}
