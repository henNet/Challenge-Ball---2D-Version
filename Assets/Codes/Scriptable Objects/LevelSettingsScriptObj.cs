using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LevelSettings", menuName = "LevelSettings")]
public class LevelSettingsScriptObj : ScriptableObject
{
    public int levelIndex;
    public String[] levelNames;

    public void resetLevelIndex()
    {
        levelIndex = 0;
    }
}
