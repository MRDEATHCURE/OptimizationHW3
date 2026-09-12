using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorLoader : MonoBehaviour
{
    [SerializeField] private string sceneToLoad;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
            return;

        SceneManager.LoadSceneAsync(sceneToLoad);
    }
}