using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


public class Resset1 : MonoBehaviour
{
    public void onClick()
    {
        PlayerPrefs.DeleteAll();
    }
}
