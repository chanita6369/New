using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlLearnWord : MonoBehaviour
{
    float x, y;
    public GameObject LearnWord;
    public int Btn;

    void Start()
    {
        x = transform.localScale.x;
        y = transform.localScale.y;
    }

    public void OnMouseDown()
    {
        transform.localScale = new Vector2(x * 200f, y / 200f);
    }

    public void OnMouseUp()
    {
        transform.localScale = new Vector2(x, y);

        LearnWord.GetComponent<WordLearn>().ControlLearnWord(Btn);
    }

}
