using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpSound : MonoBehaviour
{
    [SerializeField] AudioClip jump;
    private void OnCollisionEnter(Collision collosion)
    {
        AudioSource.PlayClipAtPoint(jump, transform.position);
    }
}
