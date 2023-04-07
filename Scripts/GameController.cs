using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameController : MonoBehaviour
{
    int score = 1;
    public GameObject player;
    public PlayerMove playerStats;
    public SpriteRenderer[] hearts = new SpriteRenderer[3];
    public TMP_Text scoreText;
    public TMP_Text elementNameText;
    public TMP_Text pauseText;
    void Start()
    {
        scoreText.text = "Atomic No.: 1";
        elementNameText.text = "Element Name: Hydrogen";
    }
    public void AddScore(int amount)
    {
        score += amount;
        scoreText.text = "Atomic No.: " + score;

        player.GetComponent<Rigidbody>().isKinematic = false;
        player.GetComponent<Rigidbody>().useGravity = true;

        if (score == 2)
        {
            elementNameText.text = "Element Name: Helium";
        }
        else if(score == 3)
        {
            elementNameText.text = "Element Name: Lithium";
        }
        else if (score == 4)
        {
            elementNameText.text = "Element Name: Beryllium";
        }
        else if (score == 5)
        {
            elementNameText.text = "Element Name: Boron";
        }
        else if (score == 6)
        {
            elementNameText.text = "Element Name: Carbon";
        }
        else if (score == 7)
        {
            elementNameText.text = "Element Name: Nitrogen";
        }
        else if (score == 8)
        {
            elementNameText.text = "Element Name: Oxygen";
        }
        else if (score == 9)
        {
            elementNameText.text = "Element Name: Fluorine";
        }
        else if (score == 10)
        {
            elementNameText.text = "Element Name: Neon";
        }
        else if (score == 11)
        {
            elementNameText.text = "Element Name: Sodium";
        }
        else if (score == 12)
        {
            elementNameText.text = "Element Name: Magnesium";
        }
        else if (score == 13)
        {
            elementNameText.text = "Element Name: Aluminum";
        }
        else if (score == 14)
        {
            elementNameText.text = "Element Name: Silicon";
        }
        else if (score == 15)
        {
            elementNameText.text = "Element Name: Phosphorus";
        }
        else if (score == 16)
        {
            elementNameText.text = "Element Name: Sulfur";
        }
        else if (score == 17)
        {
            elementNameText.text = "Element Name: Chlorine";
        }
        else if (score == 18)
        {
            elementNameText.text = "Element Name: Argon";
        }
        else if (score == 19)
        {
            elementNameText.text = "Element Name: Potassium";
        }
        else if (score == 20)
        {
            elementNameText.text = "Element Name: Calcium";
        }
        else if (score == 21)
        {
            elementNameText.text = "Element Name: Scandium";
        }
        else if (score == 22)
        {
            elementNameText.text = "Element Name: Titanium";
        }
        else if (score == 23)
        {
            elementNameText.text = "Element Name: Vanadium";
        }
        else if (score == 24)
        {
            elementNameText.text = "Element Name: Chromium";
        }
        else if (score == 25)
        {
            elementNameText.text = "Element Name: Manganese";
        }
        else if (score == 26)
        {
            elementNameText.text = "Element Name: Iron";
        }
        else if (score == 27)
        {
            elementNameText.text = "Element Name: Cobalt";
        }
        else if (score == 28)
        {
            elementNameText.text = "Element Name: Nickel";
        }
        else if (score == 29)
        {
            elementNameText.text = "Element Name: Copper";
        }
        else if (score == 30)
        {
            elementNameText.text = "Element Name: Zinc";
        }
        else if (score == 31)
        {
            elementNameText.text = "Element Name: Gallium";
        }
        else if (score == 32)
        {
            elementNameText.text = "Element Name: Germanium";
        }
        else if (score == 33)
        {
            elementNameText.text = "Element Name: Arsenic";
        }
        else if (score == 34)
        {
            elementNameText.text = "Element Name: Selenium";
        }
        else if (score == 35)
        {
            elementNameText.text = "Element Name: Bromine";
        }
        else if (score == 36)
        {
            elementNameText.text = "Element Name: Krypton";
        }
        else if (score == 37)
        {
            elementNameText.text = "Element Name: Rubidium";
        }
        else if (score == 38)
        {
            elementNameText.text = "Element Name: Strontium";
        }
        else if (score == 39)
        {
            elementNameText.text = "Element Name: Yttrium";
        }
        else if (score == 40)
        {
            elementNameText.text = "Element Name: Zirconium";
        }//

    }
    public int GetScore()
    {
        return score;
    }
    void pauseGame()
    {
        if (Time.timeScale == 1)
        {
            pauseText.text = "Paused";
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
            pauseText.text = "";
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            pauseGame();
        }
        if(playerStats.getLife() == 2)
        {
            Destroy(hearts[2]);
        }
        if(playerStats.getLife() == 1)
        {
            Destroy(hearts[1]);
        }
        if (playerStats.getLife() == 0)
        {
            Destroy(hearts[0]);
        }
    }
    void Win()
    {
        SceneManager.LoadScene("YouWin");
    }
}
