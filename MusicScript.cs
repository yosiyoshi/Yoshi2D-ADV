using UnityEngine;
using System.Collections;

public class MusicScript : MonoBehaviour {
    public bool DontDestroyEnabled = true;

    // Use this for initialization
    void Start () {
        if (DontDestroyEnabled) {
            // Keep BGM
            DontDestroyOnLoad (this);
        }
    }

    // Update is called once per frame
    void Update () {

    }
}