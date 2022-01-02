using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Resume : MonoBehaviour
{
    public GameObject Panel_pause;
    public Button resume;
    // Start is called before the first frame update
    void Start()
    {
        resume.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void TaskOnClick()
    {
        Panel_pause.SetActive(false);
        Time.timeScale = 1;
    }
}
