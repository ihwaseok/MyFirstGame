using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViewGameover : MonoBehaviour
{
    public static ViewGameover instance;
    public Text score;
    public Text coinsLabel;

    void Awake()
    {
        instance = this;
    }
}
