using UnityEngine;

[CreateAssetMenu(fileName = "PlayerSettings", menuName = "PlayerSettings")]
public class PlayerSettingsScriptObj : ScriptableObject
{
    public int life;

    public void resetLife()
    {
        life = 5;
    }
}
