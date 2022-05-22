using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Sprite portrait;
    public new string name = "°¡³ª´Ù";
    public int at;
    public int def;
    public int maxHp;
    public int currentHp;

    public Player(string _name, int _at, int _def, int _maxHp)
    {
        name = _name;
        at = _at;
        def = _def;
        maxHp = _maxHp;
    }
}
