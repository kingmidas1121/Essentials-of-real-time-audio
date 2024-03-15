using UnityEngine;

public class MemberHiding : MonoBehaviour
{
    public class Creature
    {
        // Базова версія методу Sound
        public void Sound()
        {
            Debug.Log("Creature version of the Sound() method");
        }
    }

    public class Animal : Creature
    {
        // Це приховує версію з класу Creature.
        new public void Sound()
        {
            Debug.Log("Animal version of the Sound() method");
        }
    }

    public class Dog : Animal
    {
        // Це приховує версію з класу Animal.
        new public void Sound()
        {
            Debug.Log("Dog version of the Sound() method");
        }
    }

    public class Zoo : MonoBehaviour
    {
        void Start()
        {
            Creature creature = new Creature();
            Creature animal = new Animal();
            Creature dog = new Dog();
            // Кожен з них викликає метод Sound() класу Creature.
            creature.Sound();
            animal.Sound();
            dog.Sound();
        }
    }

}
