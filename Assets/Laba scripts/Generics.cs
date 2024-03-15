using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generics : MonoBehaviour
{
    // Узагальнений клас Box
    public class Box<T>
    {
        private T item;

        // Конструктор класу Box
        public Box(T item)
        {
            this.item = item;
        }

        // Метод для отримання елементу з коробки
        public T GetItem()
        {
            return item;
        }
    }

    public class GenericExample : MonoBehaviour
    {
        void Start()
        {
            // Створюємо коробку з рядком
            Box<string> stringBox = new Box<string>("Hello, World!");

            // Отримуємо елемент з коробки та виводимо його
            Debug.Log("String from box: " + stringBox.GetItem());

            // Створюємо коробку з числом
            Box<int> intBox = new Box<int>(42);

            // Отримуємо елемент з коробки та виводимо його
            Debug.Log("Int from box: " + intBox.GetItem());

            // Створюємо коробку з об'єктом типу GameObject
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            Box<GameObject> gameObjectBox = new Box<GameObject>(cube);

            // Отримуємо елемент з коробки та виводимо інформацію про нього
            GameObject retrievedGameObject = gameObjectBox.GetItem();
            Debug.Log("GameObject from box: " + retrievedGameObject.name);
        }
    }
}

