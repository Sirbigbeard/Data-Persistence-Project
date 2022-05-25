using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NameInput : MonoBehaviour
{
    public InputField input; 
    // Start is called before the first frame update
    void Start()
    {
        input = gameObject.GetComponent<InputField>();
        input.onSubmit.AddListener(SubmitName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void SubmitName(string name)
    {
        MainManager.playerName = name;
        Debug.Log(MainManager.playerName + "");
        SceneManager.LoadScene(1);
    }
}
