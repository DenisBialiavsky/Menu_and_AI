using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    [Header("Игрок")]
    [Tooltip("Target, which need following")]
    public Transform myPlayer;

    private NavMeshAgent myAgent;

    [Tooltip("Function not work")]
    public int hp_enemy;

    [Tooltip("Function not work")]
    [SerializeField] private GameObject fireballPrefab;
    private GameObject _fireball;



    // Start is called before the first frame update
    void Start()
    {
        myAgent = GetComponent<NavMeshAgent>();
        hp_enemy = 2;
        Debug.Log("HP enemy:" + hp_enemy);
    }

    // Update is called once per frame
    void Update()
    {
        if (myAgent == null) return;

        //myAgent.destination = myPlayer.position;
        myAgent.SetDestination(myPlayer.position);

       
    }

  
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Enemy>())
        {
            Destroy(other.gameObject);
            hp_enemy -= 2;
           
            Debug.Log("HP enemy:" + hp_enemy);

        }
            

           




        }
    }



