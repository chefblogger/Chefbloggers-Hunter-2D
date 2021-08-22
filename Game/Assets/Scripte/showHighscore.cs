using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class showHighscore : MonoBehaviour
{

    public Text HighscoreText;
    public Text LifepointText;
    public Text LevelText;

    // Start is called before the first frame update
    void Start()
    {
        HighscoreText.text = "HIGHSCORE: " + PlayerPrefs.GetInt("highscore");
        LifepointText.text = "Reincarnations: " + PlayerPrefs.GetInt("lifepoint");
        //LevelText.text = "LEVEL: " + PlayerPrefs.GetInt("LevelNummer");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
