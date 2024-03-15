using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTransform : MonoBehaviour
{
    public AudioSource musicSource; // ������ �� ��������� AudioSource � �������, ��������, ������ ��� ������ ������
    public AudioClip destroyedMusic; // ������ ��� ������������� ������

    void Start()
    {
        // ������� AudioSource � �����, ���� �� �� ��� ����������� � ���������
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
        if (transform.position.y < 0)
        {
            Debug.Log("Death music is playing");
            PlayDestroyedMusic();
            Destroy(gameObject);
        }
    }
    void PlayDestroyedMusic()
    {
        musicSource.Stop(); // ������������� ������� ������, ���� ��� �������������
        musicSource.clip = destroyedMusic; // ������������� ����� ������ ��� ������������
        musicSource.Play(); // ����������� ����� ������
    }
}
