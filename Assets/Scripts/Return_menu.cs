using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Return_menu : MonoBehaviour
{
    // Start is called before the first frame update
    public string SceneName;
    public Button playButton;

    void Start()
    {
        playButton.onClick.AddListener(TaskOnClick);
    }



    void TaskOnClick()
    {
        SceneManager.LoadScene(SceneName);
        Time.timeScale = 1;
    }
}
