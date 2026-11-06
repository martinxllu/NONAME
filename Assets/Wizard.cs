using UnityEngine;

public class Wizard : MonoBehaviour
{

    // store wizard's mana
    private int mana = 100;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("The wizard is ready to cast spells!");

        Element fire = new Fire();
        // Call a custom method with an element and a mana cost.
        CastSpell(fire,8);

        Element ice = new Ice();
        CastSpell(ice, 22);
    }

    void CastSpell(Element element, int cost)
    {
        // Modify the mana field.
        mana = mana - cost;
        element.Cast();
        Debug.Log("Remaining mana: " + mana);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

// the wizard can cast different elements
// Polymorphism
public class Element 
{
    public virtual void Cast()
    {
        Debug.Log("Casting an element");
    }
}

public class Fire : Element
{
    public override void Cast()
    {
        Debug.Log("The wizard casts a fireball");
    }
}

public class Ice : Element
{
    public override void Cast()
    {
        Debug.Log("The wizard casts an ice blast");
    }
}