using UnityEngine;
using UnityEngine.SceneManagement; // LoadScene
public class LoadShuttleGame : MonoBehaviour
{
    /// <summary>
    /// Will load a new scene upon being called
     /// </summary>
    /// <param name="levelName">The name of the level we want
     /// to go to</param>
     public void LoadLevel(string Shuttle_Game)
    {
    SceneManager.LoadScene(Shuttle_Game);
    }
}    