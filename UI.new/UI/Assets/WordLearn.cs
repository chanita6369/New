using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class WordLearn : MonoBehaviour
{
    int number = 0;

    void Start()
    {
        setActive();
    }

    public void ControlLearnWord(int i) {

        number += i;

        if(number > transform.childCount - 1)
        {
            number = 0;
        }
        else if(number < 0)
        {
            number = transform.childCount - 1;
        }
        setActive();
    }

    public void setActive()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(false);
        }
        transform.GetChild(number).gameObject.SetActive(true);
    }

    //public void OnClick()
    //{
        //number++;
        //ControlLearnWord(number);
    //}
}
