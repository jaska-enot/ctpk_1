using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private ZombieActions zombie;
    [SerializeField] private HeroActions hero;
    [SerializeField] private float roundTime;
    [SerializeField] private TMP_Text timer;
    
    [Header("UI")]
    [SerializeField] private GameObject winPannel;
    [SerializeField] private GameObject failPannel;

    private GameObject activePannel = GameObject.Find("activePannel");

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        roundTime -= Time.deltaTime;
        timer.SetText(roundTime.ToString());

        if (roundTime <= 0.0f)
        {
            //activePannel.SetActive(false);
            winPannel.SetActive(true);
        }
        Debug.Log($"В менеджере {zombie.isTriggered}");
        if (zombie.isTriggered)
        {
            //activePannel.SetActive(false);
            failPannel.SetActive(true);
        }
        

    }

    public void OnStartNewGameClick()
    {
        SceneManager.LoadScene("Zombie");
    }
}
