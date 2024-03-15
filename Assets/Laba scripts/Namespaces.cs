using System.Collections;
using System.Collections.Generic;
using Random = UnityEngine.Random;
using UnityEngine;
using Player;
using static UnityEditor.Progress;

public class Namespaces : MonoBehaviour
{

}
    public class UsingNamespaces1 : UnityEngine.MonoBehaviour
{

}
public class UsingNamespaces2 : UnityEngine.MonoBehaviour
{

}
public class PlayerMovement : MonoBehaviour
{
    void Start()
    {
        float speed = Random.value;
    }
}
namespace Player
{
    public class PlayerMovement : MonoBehaviour
    {

    }
}
namespace EditorTools.MapCreation
{
    public class Drawing
    {
    }
}
public class AIManager
{
     public System.Collections.ArrayList list;
}
