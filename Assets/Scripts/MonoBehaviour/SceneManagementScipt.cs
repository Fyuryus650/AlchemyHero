using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagementScipt : MonoBehaviour
{

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
