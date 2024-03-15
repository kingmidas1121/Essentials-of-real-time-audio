using UnityEngine;

public class MemberHiding : MonoBehaviour
{
    public class Creature
    {
        // ������ ����� ������ Sound
        public void Sound()
        {
            Debug.Log("Creature version of the Sound() method");
        }
    }

    public class Animal : Creature
    {
        // �� ������� ����� � ����� Creature.
        new public void Sound()
        {
            Debug.Log("Animal version of the Sound() method");
        }
    }

    public class Dog : Animal
    {
        // �� ������� ����� � ����� Animal.
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
            // ����� � ��� ������� ����� Sound() ����� Creature.
            creature.Sound();
            animal.Sound();
            dog.Sound();
        }
    }

}
