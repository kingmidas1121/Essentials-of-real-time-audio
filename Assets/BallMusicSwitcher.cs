using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMusicSwitcher : MonoBehaviour
{
    public AudioSource musicSource; // ������ �� ��������� AudioSource � �������, ��������, ������ ��� ������ ������
    public AudioClip destroyedMusic; // ������ ��� ������������� ������

    private bool isBallDestroyed = false; // ���� ��� ������������ ����������� ������

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
        // ���������, ���� ����� ��� ���������, � �������� ������ ��� ������������� ������
        if (isBallDestroyed)
        {
            
        }
    }

    // ����� ��� ��������������� ������ ��� ������������� ������
    void PlayDestroyedMusic()
    {
        musicSource.Stop(); // ������������� ������� ������, ���� ��� �������������
        musicSource.clip = destroyedMusic; // ������������� ����� ������ ��� ������������
        musicSource.Play(); // ����������� ����� ������
    }
}
