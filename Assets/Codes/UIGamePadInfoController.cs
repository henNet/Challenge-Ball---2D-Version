using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class UIGamePadInfoController : MonoBehaviour
{
    public GameObject[] txtGamepadInfo;
    public GameObject[] txtKeyBoardInfo;

    // Update is called once per frame
    void Update()
    {
        checkJoystickGamepad();
    }

    void setTxtGamepadInfo(bool value)
    {
        for (int i = 0; i < txtGamepadInfo.Length; i++)
        {
            txtGamepadInfo[i].gameObject.SetActive(value);
        }
    }

    void setTxtKeyboardInfo(bool value)
    {
        for (int i = 0; i < txtKeyBoardInfo.Length; i++)
        {
            txtKeyBoardInfo[i].gameObject.SetActive(value);
        }
    }

    void checkJoystickGamepad()
    {
        var gamepad = Gamepad.current;
        var joystick = Joystick.current;

        if (joystick == null && gamepad == null)
        {
            Debug.Log("Sem Joystick ou Gamepad");
            setTxtGamepadInfo(false);
            setTxtKeyboardInfo(true);
            Cursor.visible = true;
            return;
        }

        Cursor.visible = false;
        setTxtGamepadInfo(true);
        setTxtKeyboardInfo(false);
    }
}
