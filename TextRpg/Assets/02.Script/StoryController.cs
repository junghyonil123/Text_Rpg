using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryController : MonoBehaviour
{
    private Text storyText;
    private Text locationText;
    public GameObject battleCanvas;

    public void Start()
    {
        locationText = GameObject.Find("LocationText").GetComponent<Text>();
        storyText = GameObject.Find("StoryText").GetComponent<Text>();
        battleCanvas = GameObject.Find("BattleCanvas");
        ReloadMap("���۸���");
    }

    public void GoBattleButton()
    {
        battleCanvas.SetActive(true);
        gameObject.SetActive(false);
        battleCanvas.GetComponent<BattleController>().ReloadBattle("���");
    }

    public void ReloadMap(string mapName)
    {
        locationText.text = "";
        storyText.text = "";

        if (MapLibrary.Instance.mapLibrary[mapName] != null)
        {
            StartCoroutine(TextWriteEffect(0.05f,MapLibrary.Instance.mapLibrary[mapName].mapName, MapLibrary.Instance.mapLibrary[mapName].mapStory));
        }
        else
        {
            Debug.Log("���̸��� �߸��Ǿ����ϴ�.");
            return;
        }
    }

    IEnumerator TextWriteEffect(float interval, string _locationText, string _storyText)
    {
        foreach (char item in _locationText) //������ġ�� ���
        {
            locationText.text += item;
            yield return new WaitForSeconds(interval);
        }

        foreach (char item in _storyText) //������ġ�� ���� ������ �߰�
        {
            storyText.text += item;
            yield return new WaitForSeconds(interval);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

   
}
