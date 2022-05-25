using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

[System.Serializable]
public class HighScoreData : MonoBehaviour
{
    public Text highScore;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("test");
        highScore = gameObject.GetComponent<Text>();
        highScore.text = "poop";
        LoadScores();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadScores()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            highScore.text = JsonUtility.FromJson<string>(json);
        }
    }

}
