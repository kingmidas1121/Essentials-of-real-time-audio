using UnityEngine;

public class Inheritance : MonoBehaviour
{
    public class Fruit
    {
        public string color;

        // ����������� ����� Fruit
        public Fruit()
        {
            color = "orange";
            Debug.Log("����������� ����� Fruit ����������");
        }

        public void Chop()
        {
            Debug.Log("����� " + color + " ���� �������.");
        }

        // ³��������� �����, ���� ���� ���� �������������� � �������� ������
        public virtual void SayHello()
        {
            Debug.Log("�����, � �����.");
        }
    }

    // ���� Apple ��������� ���������� �� Fruit
    public class Apple : Fruit
    {
        // ����������� ����� Apple
        public Apple()
        {
            color = "red";
            Debug.Log("����������� ����� Apple ����������");
        }

        // �������������� ������ SayHello � ����� Fruit
        public override void SayHello()
        {
            Debug.Log("�����, � ������.");
        }
    }

    public class Banana : Fruit
    {
        // ����������� ����� Banana
        public Banana()
        {
            color = "yellow";
            Debug.Log("����������� ����� Banana ����������");
        }

        // �������������� ������ SayHello � ����� Fruit
        public override void SayHello()
        {
            Debug.Log("�����, � �����.");
        }
    }

    public class FruitSalad : MonoBehaviour
    {
        void Start()
        {
            // ��������� ���������� �����
            Fruit myFruit = new Fruit();
            Fruit myApple = new Apple();
            Fruit myBanana = new Banana();

            // ������ ������
            myFruit.SayHello();
            myApple.SayHello();
            myBanana.SayHello();
        }
    }

}
