using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    public void OnButtonClick()
    {
        // Dapatkan indeks scene saat ini
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // Pindah ke scene selanjutnya dalam urutan build (berdasarkan indeks)
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void OnExit()
    {
        // Keluar dari game
        Application.Quit();
    }

}
