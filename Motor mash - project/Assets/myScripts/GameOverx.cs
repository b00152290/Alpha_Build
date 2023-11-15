using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverx : MonoBehaviour
{
    public static GameObject overscreen;
    public static GameObject User;

    void Start()
    {
        User = GameObject.Find("player");
        overscreen = GameObject.Find("Overscreen");
        overscreen.SetActive(false);
    }

    void Update()
    {
       
    }

    public static void turnOn()
    {
        overscreen.SetActive(true);
        Destroy(User);
    }

    public void retry()
    {
        SceneManager.LoadScene("SampleScene");
        Debug.Log("click");
    }
}
