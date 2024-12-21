using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SoundAndPause : MonoBehaviour
{
    private bool isSound;
    public AudioSource sound;
    public AudioSource backSound;
    public Image soundButton;
    public Sprite soundOff;
    public Sprite soundOn;

    private void Start()
    {
        isSound = true;
    }

    /// <summary>
    /// Включает отключает звуки
    /// </summary>
    public void ChangeSound()
    {
        if (sound.isPlaying)
        {
            isSound = false;
            sound.Pause();
            backSound.mute = true;
            soundButton.sprite = soundOn;
        }
        else
        {
            isSound = true;
            sound.Play();
            backSound.mute = false;
            soundButton.sprite = soundOff;
        }

    }

    /// <summary>
    /// Ставит все на паузу при открытии меню
    /// </summary>
    public void Pause()
    {
        if (isSound && sound.isPlaying)
        {
            sound.Pause();
            backSound.mute = true;
        }
        else if (isSound && !sound.isPlaying)
        {
            sound.Play();
            backSound.mute = false;
        }
        if (Time.timeScale == 0) Time.timeScale = 1;
        else Time.timeScale = 0;

    }

    /// <summary>
    /// Перезапуск сцены
    /// </summary>
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
