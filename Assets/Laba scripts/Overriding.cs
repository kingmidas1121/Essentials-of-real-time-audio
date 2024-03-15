using UnityEngine;

public class Overriding : MonoBehaviour
{
    public class Food
    {
        public Food()
        {
            Debug.Log("1st Food Constructor Called");
        }

        // Ці методи є віртуальними і, отже, можуть бути перевизначені
        // у дочірніх класах
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

        // Ці методи є перевизначенням і, отже,
        // можуть перевизначити будь-які віртуальні методи у батьківському класі.
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

            // Зверніть увагу, що версії методів Pizza
            // перевизначають версії їжі. Також зверніть увагу,
            // що оскільки версії Pizza викликають версії Food з
            // ключовим словом "base", обидві версії викликаються.
            myPizza.Describe();
            myPizza.Eat();

            // Перевизначення також корисне в поліморфних ситуаціях.
            // Оскільки методи класу Food є "віртуальними" і
            // методи класу Pizza є "перевизначеннями", коли ми
            // узгодимо Pizza до Food, використовуються методи Pizza.
            Food myFood = new Pizza();
            myFood.Describe();
            myFood.Eat();
        }
    }

}
