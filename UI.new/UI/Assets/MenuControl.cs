using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void SelectType()
    {
        SceneManager.LoadScene("MenuSelectType");
    }

    //Menu Select Group Type 
    public void MenuSpell()
    {
        SceneManager.LoadScene("MenuSpell");
    }

    public void MenuLearn()
    {
        SceneManager.LoadScene("MenuLearning");
    }

    //Menu Select spelling Word
    public void CareerBtn()
    {
        SceneManager.LoadScene("CareerScene");
    }

    public void EmotionBtn()
    {
        SceneManager.LoadScene("EmotionScene");
    }

    public void FruitBtn()
    {
        SceneManager.LoadScene("FruitScene");
    }

    public void PlaceBtn()
    {
        SceneManager.LoadScene("PlaceScene");
    }

    public void OtherBtn()
    {
        SceneManager.LoadScene("OtherScene");
    }

    //Menu Select Learning Word
    public void SelFruit()
    {
        SceneManager.LoadScene("FruitLearnScene");
    }
}
