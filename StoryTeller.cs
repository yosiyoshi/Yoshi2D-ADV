using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryTeller : MonoBehaviour
{
    public Text name;
    public Text text;
    public Image charaA;
    public Image bgA;
    private Sprite sprite;
    private Sprite sprite2;

    int x=0;

    public void OnClick()
    {
    if (x==0) {
        sprite = Resources.Load<Sprite>("bluesky012");
        sprite2 = Resources.Load<Sprite>("nadezhda");
        bgA = bgA.GetComponent<Image>();
        bgA.sprite = sprite;
        charaA = charaA.GetComponent<Image>();
        charaA.sprite = sprite2;
        name.text = "CharacterName";
        text.text = "Text";
	x++;
              }
    if (x==1) {
        name.text = "CharacterName";
        text.text = "Text2";
              }
    }
}
