using UnityEngine;
using UnityEngine.UI;

public class CaptainDialogue : MonoBehaviour
{
    public Text dialogueText; // Assign in Inspector

    void Start()
    {
        string credential = PlayerPrefs.GetString("SelectedCredential", "AI");
        
        if (dialogueText != null)
        {
            dialogueText.text = "Welcome to the spaceship, cadet! You selected: " + credential;
        }
        else
        {
            Debug.LogError("DialogueText is not assigned in the Inspector!");
        }
    }
}