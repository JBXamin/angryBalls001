using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int enemyCount;
    public int scene;
    public TMP_Text shots;
    public TMP_Text CurrentLevel;
    bool onlyone = true;
    public static bool powerUp = false;
    public static bool fired = false;
    void Start()
    {
        CurrentLevel.text = (SceneManager.GetActiveScene().buildIndex+1).ToString();
        shots.text = 0.ToString();
        ShootSling.shot = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (!onlyone)
        {
            shots.text = (ShootSling.shot-1).ToString();
        }
        if (onlyone)
        {
            shots.text = 0.ToString();
            ShootSling.shoot = true;
            onlyone = false;
        }
        check();
    }

    void check()
    {
        if(enemyCount == PlayerMovement.count)
        {
            PlayerMovement.count = 0;
            SceneManager.LoadScene(scene);
            
        }
    }
}
