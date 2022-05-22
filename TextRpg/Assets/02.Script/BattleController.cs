using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleController : MonoBehaviour
{
    Player player;
    Monster monster;

    public void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
    }

    public Image monsterPortaitImage;
    public Text monsterNameText;
    public Text monsterAtText;
    public Text monsterDefText;
    public Text monsterHpText;

    public Image playerPortaitImage;
    public Text playerNameText;
    public Text playerAtText;
    public Text playerDefText;
    public Text playerHpText;
    
    public void ReloadBattle(string monsterName)
    {
        //Player 의 정보를 세팅해줌

        playerPortaitImage.sprite = null;
        playerPortaitImage.sprite = player.portrait;

        playerNameText.text = "";
        playerNameText.text = player.name;

        playerAtText.text = "";
        playerAtText.text = player.at.ToString();

        playerDefText.text = "";
        playerDefText.text = player.def.ToString();

        playerHpText.text = "";
        playerHpText.text = player.currentHp.ToString() +"/"+ player.maxHp.ToString();

        //Player 의 정보를 세팅해줌

        if(MonsterLibrary.Instance.monsterLibrary[monsterName] != null)
        {
            monster = MonsterLibrary.Instance.monsterLibrary[monsterName];
        }
        else
        {
            Debug.Log("잘못된 이름입니다.");
            return;
        }

        monsterPortaitImage.sprite = null;
        monsterPortaitImage.sprite = monster.portrait;

        monsterNameText.text = "";
        monsterNameText.text = monster.name;

        monsterAtText.text = "";
        monsterAtText.text = monster.at.ToString();

        monsterDefText.text = "";
        monsterDefText.text = monster.def.ToString();

        monsterHpText.text = "";
        monsterHpText.text = monster.currentHp.ToString() + "/" + monster.maxHp.ToString();

    }
}
