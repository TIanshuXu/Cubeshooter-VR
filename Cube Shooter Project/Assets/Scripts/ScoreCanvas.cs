using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCanvas : MonoBehaviour
{
    public int Score = 0;

    // Start is called before the first frame update
    void Start()
    {
        UpdateScore();
    }

    public void UpdateScore()
    {
        GameObject.Find("Score Text").gameObject.GetComponent<TextMeshProUGUI>().text = "Score: " + Score.ToString();
    }
}
