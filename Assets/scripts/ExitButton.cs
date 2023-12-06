using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ExitButton : MonoBehaviour
{
    [SerializeField] Button button;
    void Awake()
    {
        button.onClick.AddListener(Exit);
    }
    void Exit()
    {
        Application.Quit();
    }
}
