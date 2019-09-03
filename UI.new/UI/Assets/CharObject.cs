using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.UI;
using Vector3 = UnityEngine.Vector3;

public class CharObject : MonoBehaviour
{
    public char character;
    public Text text;
    public RectTransform rectTransform;
    public int index;

    [Header("Appearance")]
    public Color normalColor;
    public Color selectColor;

    public CharObject Init(char c)
    {
        character = c;
        text.text = c.ToString();
        gameObject.SetActive(true);
        return this;
    }

    static int xPosition = 230;
    static string words = "";

    public void OnClick(Button b)
    {
        Text t = transform.Find("Char").GetComponent<Text>();
        b.interactable = false;

        words += t.text;

        t.transform.position = new Vector3(xPosition, transform.position.y - 900, transform.position.z);

        xPosition += 68;

        //for (int i=0; i < original.Length;i++)
        if (words.Length == WordSpell.gameWord.Length)
        {
            if (words == WordSpell.gameWord)
            {
                WordSpell.main.NextWord();
            }
            else
            {
                // restart scene

                WordSpell.main.Restart();
            }

            words = string.Empty;
            xPosition = 230;

        }
    }

}
