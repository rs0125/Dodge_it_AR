//using Palmmedia.ReportGenerator.Core.Parser.Analysis;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameEnd : MonoBehaviour
{

    public Image gameover;
    public TextMeshProUGUI gametext;


    // Update is called once per frame
    void Update()
    {
        if (FindObjectOfType<GameManager>().gameended)
        {
            Invoke("gameoverUItrig", 1F);
        }

    }


    void gameoverUItrig()
    {
            gameover.enabled = true;
            gametext.enabled = true;
    }
}
