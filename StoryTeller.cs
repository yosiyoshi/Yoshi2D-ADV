using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace story_test
{
public class StoryTeller : MonoBehaviour
{
    public static string[] texts;
    public static string[] names;
//  public static string[] images;
    public Text name;
    public Text text;
//  public Text image;
//  public string filename;
    public Image charaA;
    public Image bgA;
    private Sprite sprite;
//  private Sprite sprite2;

    int lineNum=0;

    public void OnClick()
    {
        TextAsset textAsset = new TextAsset();
        textAsset = Resources.Load("story", typeof(TextAsset)) as TextAsset;
        TextAsset textAsset2 = new TextAsset();
        textAsset2 = Resources.Load("name", typeof(TextAsset)) as TextAsset;
        TextAsset textAsset3 = new TextAsset();
        textAsset3 = Resources.Load("image", typeof(TextAsset)) as TextAsset;
        texts = textAsset.text.Split('\n');
        names = textAsset2.text.Split('\n');
//      images = textAsset3.text.Split('\n');
//      filename = images[lineNum];
//      sprite = Resources.Load<Sprite>(filename);
        sprite = Resources.Load<Sprite>("nadezhda");
//      sprite2 = Resources.Load<Sprite>("bluesky012");
        charaA = charaA.GetComponent<Image>();
        charaA.sprite = sprite;
//      bgA = bgA.GetComponent<Image>();
//      bgA.sprite = sprite2;
        name.text = names[lineNum];
        text.text = texts[lineNum];
        lineNum++;
              }
    }
}
