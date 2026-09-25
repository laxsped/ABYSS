using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class PlayerNameInput : MonoBehaviour
{
    public InputField inputField;
    public StringVariable playerName;

    public void SaveName()
    {
        playerName.Value = inputField.text;
    }
}