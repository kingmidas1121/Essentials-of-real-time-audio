using UnityEngine;

public class Inheritance : MonoBehaviour
{
    public class Fruit
    {
        public string color;

        // Конструктор класу Fruit
        public Fruit()
        {
            color = "orange";
            Debug.Log("Конструктор класу Fruit викликаний");
        }

        public void Chop()
        {
            Debug.Log("Фрукт " + color + " було нарізано.");
        }

        // Віртуальний метод, який може бути перевизначений у похідних класах
        public virtual void SayHello()
        {
            Debug.Log("Привіт, я фрукт.");
        }
    }

    // Клас Apple успадковує властивості від Fruit
    public class Apple : Fruit
    {
        // Конструктор класу Apple
        public Apple()
        {
            color = "red";
            Debug.Log("Конструктор класу Apple викликаний");
        }

        // Перевизначення методу SayHello з класу Fruit
        public override void SayHello()
        {
            Debug.Log("Привіт, я яблуко.");
        }
    }

    public class Banana : Fruit
    {
        // Конструктор класу Banana
        public Banana()
        {
            color = "yellow";
            Debug.Log("Конструктор класу Banana викликаний");
        }

        // Перевизначення методу SayHello з класу Fruit
        public override void SayHello()
        {
            Debug.Log("Привіт, я банан.");
        }
    }

    public class FruitSalad : MonoBehaviour
    {
        void Start()
        {
            // Створення екземплярів класів
            Fruit myFruit = new Fruit();
            Fruit myApple = new Apple();
            Fruit myBanana = new Banana();

            // Виклик методів
            myFruit.SayHello();
            myApple.SayHello();
            myBanana.SayHello();
        }
    }

}
