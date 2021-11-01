using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private void Awake()
    {
        if(GameManager.instance != null)
        {
            Destroy(gameObject);
            return;
        }


        instance = this;
        SceneManager.sceneLoaded += LoadState;
        DontDestroyOnLoad(gameObject);
        
    }

    // Ressources
    public List<Sprite> playerSprites;
    public List<Sprite> weaponSprites;
    public List<int> weaponPrices;
    public List<int> xpTable;

    //references
    public Player player;
    // public weapon weapon...

    //logic
    public int pesos;
    public int experience;

    /*
    int preferedSkin
    int pesos
    int experience
    int weaponLevel
    */

    //Save state
    public void SaveState()
    {
        string s = "";

        s += "0" + "|";
        s += pesos.ToString() + "|";
        s += experience.ToString() + "|";
        s += "0";

        PlayerPrefs.SetString("SaveState", s);
    }

    public void LoadState(Scene s, LoadSceneMode mode)
    {
        string[] date = PlayerPrefs.GetString("SaveState").Split('|');
        //change player skin
        pesos = int.Parse(data[1]);
        experience = int.Parse(data[2]);

        Debug.Log("Load State");
    }
}
