using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generics : MonoBehaviour
{
    // ������������ ���� Box
    public class Box<T>
    {
        private T item;

        // ����������� ����� Box
        public Box(T item)
        {
            this.item = item;
        }

        // ����� ��� ��������� �������� � �������
        public T GetItem()
        {
            return item;
        }
    }

    public class GenericExample : MonoBehaviour
    {
        void Start()
        {
            // ��������� ������� � ������
            Box<string> stringBox = new Box<string>("Hello, World!");

            // �������� ������� � ������� �� �������� ����
            Debug.Log("String from box: " + stringBox.GetItem());

            // ��������� ������� � ������
            Box<int> intBox = new Box<int>(42);

            // �������� ������� � ������� �� �������� ����
            Debug.Log("Int from box: " + intBox.GetItem());

            // ��������� ������� � ��'����� ���� GameObject
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            Box<GameObject> gameObjectBox = new Box<GameObject>(cube);

            // �������� ������� � ������� �� �������� ���������� ��� �����
            GameObject retrievedGameObject = gameObjectBox.GetItem();
            Debug.Log("GameObject from box: " + retrievedGameObject.name);
        }
    }
}

