using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMusicSwitcher : MonoBehaviour
{
    public AudioSource musicSource; // —сылка на компонент AudioSource с музыкой, например, музыка дл€ живого м€чика
    public AudioClip destroyedMusic; // ћузыка дл€ уничтоженного м€чика

    private bool isBallDestroyed = false; // ‘лаг дл€ отслеживани€ уничтожени€ м€чика

    void Start()
    {
        // Ќаходим AudioSource в сцене, если он не был присоединен в редакторе
        if (musicSource == null)
        {
            musicSource = FindObjectOfType<AudioSource>();
            if (musicSource == null)
            {
                Debug.LogError("AudioSource not found in the scene!");
            }
        }
    }

    void Update()
    {
        // ѕровер€ем, если м€чик был уничтожен, и включаем музыку дл€ уничтоженного м€чика
        if (isBallDestroyed)
        {
            
        }
    }

    // ћетод дл€ воспроизведени€ музыки дл€ уничтоженного м€чика
    void PlayDestroyedMusic()
    {
        musicSource.Stop(); // ќстанавливаем текущую музыку, если она проигрываетс€
        musicSource.clip = destroyedMusic; // ”станавливаем новую музыку дл€ проигрывани€
        musicSource.Play(); // ѕроигрываем новую музыку
    }
}
