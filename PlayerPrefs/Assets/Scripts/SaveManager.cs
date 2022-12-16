using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveManager : MonoBehaviour
{
    public Text nameText;
    public Text scoreText;
    public Text positionText;

    public string userName;
    public int userScore;
    public Vector3 userPosition;


    // Start is called before the first frame update
    void Start()
    {
        LoadData();
    }


    void LoadData()
    {
        nameText.text = "User Name: " + PlayerPrefs.GetString("name", "No name");
        scoreText.text = "User Score: " + PlayerPrefs.GetInt("score", 10).ToString();
        positionText.text = "User Position: " + PlayerPrefs.GetFloat("posX", 1).ToString() + "x " + PlayerPrefs.GetFloat("posY", 1).ToString() + "y " + PlayerPrefs.GetFloat("posZ", 1).ToString() + "z ";
    } 

    void SaveData()
    {
        PlayerPrefs.SetString("name", userName);
    }
}
