using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddButtons20 : MonoBehaviour
{
    [SerializeField]
    private Transform puzzleField;

    [SerializeField]
    private GameObject button;

    private void Awake()
    {
        for (int i = 0; i < 20; i++)
        {
            GameObject _button = Instantiate(button);
            _button.name = "" + i;
            _button.transform.SetParent(puzzleField, false);
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }
}