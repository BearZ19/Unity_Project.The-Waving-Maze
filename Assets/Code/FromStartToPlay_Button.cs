
using UnityEngine;
using UnityEngine.SceneManagement;

public class FromStartToPlay_Button : MonoBehaviour
{
    public string sceneToLoad;
    public void LoadScene()
    {
        Debug.Log("Has been clicked!");
        SceneManager.LoadScene(sceneToLoad);
    }
}
