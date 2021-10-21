using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public bool Tap()
    {
        if (!enabled)
        {
            return false;
        }

        if (Input.GetMouseButtonDown(0))
        {
            return true;
        }

        for (int i = 0; i < Input.touchCount; i++)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                return true;
            }
        }
        return false;
    }
}
