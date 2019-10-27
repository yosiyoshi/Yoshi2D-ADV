using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace story_test2
{
public class StoryTeller2 : MonoBehaviour
{

    public void OnClick()
    {
    Debug.Log("Now scene is " + Application.loadedLevelName);
    Application.LoadLevel("SampleScene");
              }
    }
}
