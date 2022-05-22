using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Monster 
{
    public Sprite portrait;
    public string name;
    public int at;
    public int def;
    public int maxHp;
    public int currentHp;

    public Monster(Sprite _portrait, string _name, int _at, int _def, int _maxHp)
    {
        portrait = _portrait;
        name = _name;
        at = _at;
        def = _def;
        maxHp = _maxHp;
        currentHp = _maxHp;
    }

}
