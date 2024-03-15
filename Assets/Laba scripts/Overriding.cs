using UnityEngine;

public class Overriding : MonoBehaviour
{
    public class Food
    {
        public Food()
        {
            Debug.Log("1st Food Constructor Called");
        }

        // ֳ ������ � ����������� �, ����, ������ ���� ������������
        // � ������� ������
        public virtual void Eat()
        {
            Debug.Log("The food has been eaten.");
        }

        public virtual void Describe()
        {
            Debug.Log("This is a food.");
        }
    }

    public class Pizza : Food
    {
        public Pizza()
        {
            Debug.Log("1st Pizza Constructor Called");
        }

        // ֳ ������ � ��������������� �, ����,
        // ������ ������������� ����-�� �������� ������ � ������������ ����.
        public override void Eat()
        {
            base.Eat();
            Debug.Log("The pizza has been eaten.");
        }

        public override void Describe()
        {
            base.Describe();
            Debug.Log("This is a pizza.");
        }
    }

    public class FoodCourt : MonoBehaviour
    {
        void Start()
        {
            Pizza myPizza = new Pizza();

            // ������� �����, �� ���� ������ Pizza
            // �������������� ���� ��. ����� ������� �����,
            // �� ������� ���� Pizza ���������� ���� Food �
            // �������� ������ "base", ����� ���� ������������.
            myPizza.Describe();
            myPizza.Eat();

            // �������������� ����� ������� � ���������� ���������.
            // ������� ������ ����� Food � "�����������" �
            // ������ ����� Pizza � "����������������", ���� ��
            // �������� Pizza �� Food, ���������������� ������ Pizza.
            Food myFood = new Pizza();
            myFood.Describe();
            myFood.Eat();
        }
    }

}
