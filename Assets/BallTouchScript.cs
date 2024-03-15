using UnityEngine;

public class BallTouchScript : MonoBehaviour
{
    public float sizeIncrease = 0.5f; 
    public Transform platform; 

    private bool alreadyResized = false;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.transform == platform && !alreadyResized)
        {
            Resize();
            alreadyResized = true;
        }
    }

    void Resize()
    {
        transform.localScale += new Vector3(sizeIncrease, sizeIncrease, sizeIncrease);
    }
}
