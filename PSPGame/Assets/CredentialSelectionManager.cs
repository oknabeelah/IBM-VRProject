using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CredentialSelectionManager : MonoBehaviour
{
    public void SelectCredential(string credentialName)
    {
        PlayerPrefs.SetString("SelectedCredential", credentialName);
        SceneManager.LoadScene("GameScene"); 
    }
}
