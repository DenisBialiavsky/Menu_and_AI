using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class HP : MonoBehaviour
{
    [Tooltip("Function not work")]
    public int hp;
    public string SceneName = "2";



    // Start is called before the first frame update
    void Start()
    {
        hp = 4;
        Debug.Log("HP:" + hp);
    }

    // Update is called once per frame
    void Update()
    {
  
        
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.GetComponents<HP>() != null)
        {
            Destroy(other.gameObject);
           
            hp -= 2;
            if (hp == 0)
            {
                Destroy(gameObject);
                SceneManager.LoadScene(SceneName);
               

            }
            Debug.Log("HP:" + hp);
           
            
            
          
        }
    }

}
