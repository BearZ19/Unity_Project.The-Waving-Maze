
using UnityEngine;
using UnityEngine.SceneManagement;

public class FromPlayToFinish : MonoBehaviour
{
    public string sceneToLoad;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            Debug.Log("To finish Colider!");
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
