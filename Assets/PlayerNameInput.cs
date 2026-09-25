using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class PlayerNameInput : MonoBehaviour
{
    public InputField inputField;      
    public StringVariable playerName;  
    public Flowchart flowchart;        
    public GameObject nameInputPanel;  

    public void SaveName()
    {
        if (string.IsNullOrWhiteSpace(inputField.text))
            return; 

        playerName.Value = inputField.text;
        nameInputPanel.SetActive(false);
        flowchart.ExecuteBlock("AfterName");
    }
}