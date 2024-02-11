using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

//Individual classes d6-d12 hold the DnD roles that correspond to their respective dice.
public class d6
{
    public bool ThisDice;

    string[] DnDClasses = { "sorcerer", "wizard" };

    //Checks and returns true if the given class matches up with any strings in DnDClasses.
    public d6(string CurrentClass)
    {
        if (DnDClasses.Contains(CurrentClass))
        {
            ThisDice = true;
            //Debug.Log("d6 is true");
        }
    }
}

public class d8
{
    public bool ThisDice;

    string[] DnDClasses = { "artificer", "bard", "cleric", "druid", "monk", "rogue", "warlock" };

    public d8(string CurrentClass)
    {
        if (DnDClasses.Contains(CurrentClass))
        {
            ThisDice = true;
            //Debug.Log("d8 is true");
        }
    }
}

public class d10
{
    public bool ThisDice;

    string[] DnDClasses = { "fighter", "ranger", "paladin" };

    public d10(string CurrentClass)
    {
        if (DnDClasses.Contains(CurrentClass))
        {
            ThisDice = true;
            //Debug.Log("d10 is true");
        }
    }
}

public class d12
{
    public bool ThisDice;

    string[] DnDClasses = { "barbarian" };

    public d12(string CurrentClass)
    {
        if (DnDClasses.Contains(CurrentClass))
        {
            ThisDice = true;
            //Debug.Log("d12 is true");
        }
    }
}

//Determines which of the four types of dice will be used based on the given DnD role.
public class dice
{
    public int DiceMax;

    public bool DetermineDice;

    public dice(string GivenClass)
    {
        //Checks for each respective ThisDice bool to determine which dice type to use. Only one of the four methods below can return true at a time.
        CheckForD6(GivenClass);
        CheckForD8(GivenClass);
        CheckForD10(GivenClass);
        CheckForD12(GivenClass);

        //If none of the above methods return true, meaning no dice type is decided on, a message is displayed in the console.
        if(DetermineDice == false)
        {
            Debug.Log("Invalid Class");
        }
    }

    void CheckForD6(string GivenClass)
    {
        d6 D6 = new d6(GivenClass);
        if (D6.ThisDice)
        {
            //Debug.Log("D6 is true");
            DiceMax = 6;
            DetermineDice = true;
        }
    }

    void CheckForD8(string GivenClass)
    {
        d8 D8 = new d8(GivenClass);
        if (D8.ThisDice)
        {
            //Debug.Log("D8 is true");
            DiceMax = 8;
            DetermineDice = true;
        }
    }

    void CheckForD10(string GivenClass)
    {
        d10 D10 = new d10(GivenClass);
        if (D10.ThisDice)
        {
            //Debug.Log("D10 is true");
            DiceMax = 10;
            DetermineDice = true;
        }

    }

    void CheckForD12(string GivenClass)
    {
        d12 D12 = new d12(GivenClass);
        if (D12.ThisDice)
        {
            //Debug.Log("D12 is true");
            DiceMax = 12;
            DetermineDice = true;
        }
        //Debug.Log("DetermineDice is " + DetermineDice);
    }
}

public class modifier
{
    public int CurrentModifier;

    public int[,] CONAndModifier = new int[16, 3]
    {
        {0, 1, -5},
        {2, 3, -4},
        {4, 5, -3},
        {6, 7, -2},
        {8, 9, -1},
        {10, 11, 0},
        {12, 13, 1},
        {14, 15, 2},
        {16, 17, 3},
        {18, 19, 4},
        {20, 21, 5},
        {22, 23, 6},
        {24, 25, 7},
        {26, 27, 8},
        {28, 29, 9},
        {30, 30, 10},
    };

    public modifier(int Constitution)
    {
        DetermineModifier(Constitution);
    }

    void DetermineModifier(int Constitution)
    {
        switch (Constitution)
        {
            case var value when value == CONAndModifier[0, 0]:
            case var value2 when value2 == CONAndModifier[0, 1]:
                CurrentModifier = CONAndModifier[0, 2];
                break;
            case var value when value == CONAndModifier[1, 0]:
            case var value2 when value2 == CONAndModifier[1, 1]:
                CurrentModifier = CONAndModifier[1, 2];
                break;
            case var value when value == CONAndModifier[2, 0]:
            case var value2 when value2 == CONAndModifier[2, 1]:
                CurrentModifier = CONAndModifier[2, 2];
                break;
            case var value when value == CONAndModifier[3, 0]:
            case var value2 when value2 == CONAndModifier[3, 1]:
                CurrentModifier = CONAndModifier[3, 2];
                break;
            case var value when value == CONAndModifier[4, 0]:
            case var value2 when value2 == CONAndModifier[4, 1]:
                CurrentModifier = CONAndModifier[4, 2];
                break;
            case var value when value == CONAndModifier[5, 0]:
            case var value2 when value2 == CONAndModifier[5, 1]:
                CurrentModifier = CONAndModifier[5, 2];
                break;
            case var value when value == CONAndModifier[6, 0]:
            case var value2 when value2 == CONAndModifier[6, 1]:
                CurrentModifier = CONAndModifier[6, 2];
                break;
            case var value when value == CONAndModifier[7, 0]:
            case var value2 when value2 == CONAndModifier[7, 1]:
                CurrentModifier = CONAndModifier[7, 2];
                break;
            case var value when value == CONAndModifier[8, 0]:
            case var value2 when value2 == CONAndModifier[8, 1]:
                CurrentModifier = CONAndModifier[8, 2];
                break;
            case var value when value == CONAndModifier[9, 0]:
            case var value2 when value2 == CONAndModifier[9, 1]:
                CurrentModifier = CONAndModifier[9, 2];
                break;
            case var value when value == CONAndModifier[10, 0]:
            case var value2 when value2 == CONAndModifier[10, 1]:
                CurrentModifier = CONAndModifier[10, 2];
                break;
            case var value when value == CONAndModifier[11, 0]:
            case var value2 when value2 == CONAndModifier[11, 1]:
                CurrentModifier = CONAndModifier[11, 2];
                break;
            case var value when value == CONAndModifier[12, 0]:
            case var value2 when value2 == CONAndModifier[12, 1]:
                CurrentModifier = CONAndModifier[12, 2];
                break;
            case var value when value == CONAndModifier[13, 0]:
            case var value2 when value2 == CONAndModifier[13, 1]:
                CurrentModifier = CONAndModifier[13, 2];
                break;
            case var value when value == CONAndModifier[14, 0]:
            case var value2 when value2 == CONAndModifier[14, 1]:
                CurrentModifier = CONAndModifier[14, 2];
                break;
            case var value when value == CONAndModifier[15, 0]:
                CurrentModifier = CONAndModifier[15, 2];
                break;
            default:
                Debug.Log("Invalid Constitution Score");
                break;
        }
    }
}

public class Solution2 : MonoBehaviour
{
    public string CharacterName;
    public string GivenClass;

    public int Level;
    public int Constitution;

    public bool IsHillDwarf;
    public bool HasTough;
    public bool Averaged;

    string HillDwarfString;
    string ToughString;
    string AveragedString;

    int HP;

    void Start()
    {
        //Determines dice based on DnD class.
        dice Dice = new dice(GivenClass.ToLower());

        //Determines modifier value based on CON score.
        modifier Modifier = new modifier(Constitution);

        CalculateSubHP(Dice.DiceMax, Modifier.CurrentModifier);

        CalculateExtraHP();

        CheckForNegative();

        FinalResults(Dice.DetermineDice, Modifier.CONAndModifier[0, 0], Modifier.CONAndModifier[15, 1]);
    }

    //Calculates subtotal HP based on dice averages/rolls and modifiers.
    void CalculateSubHP(int DiceMax, int CurrentModifier)
    {
        if (Averaged == true)
        {
            HP = (((DiceMax + 1) / 2) + CurrentModifier) * Level;
        }
        else
        {
            //Rolls dice based on class' dice type, then adds modifier value to the roll. Repeats per level.
            for (int i = 0; i < Level; i++)
            {
                int DiceRoll;
                DiceRoll = Random.Range(1, DiceMax);
                //Debug.Log("Dice Roll: " + DiceRoll);
                DiceRoll += CurrentModifier;
                //Debug.Log("DR with added modifier: " + DiceRoll);
                HP += DiceRoll;
            }
        }
        //Debug.Log("subtotal HP: " + HP);
    }

    //Adds additional HP if Hill Dwarf or Tough trait are true. Also turns these bools into strings.
    void CalculateExtraHP()
    {
        if (IsHillDwarf == true)
        {
            HillDwarfString = "is";
            HP += Level;
        }
        else
        {
            HillDwarfString = "is not";
        }

        if (HasTough == true)
        {
            ToughString = "has";
            HP += Level * 2;
        }
        else
        {
            ToughString = "does not have";
        }

        if (Averaged == true)
        {
            AveragedString = "averaged";
        }
        else
        {
            AveragedString = "rolled";
        }
    }

    //Checks if the final HP value is less than 1 and changes its value to 1 if true.
    void CheckForNegative()
    {
        if (HP < 1)
        {
            HP = 1;
        }
    }

    void FinalResults(bool DetermineDice, int MinCON, int MaxCON)
    {
        bool InvalidConstitution = false;

        //Invalidates the final score if the given constitution score < the minimum score or > the maximum score.
        if(Constitution < MinCON && Constitution > MaxCON)
        {
            InvalidConstitution = true;
        }

        //If there is a valid dice type and constitution score, the final HP is given. Otherwise, a separate console message gets displayed.
        if (DetermineDice == true && InvalidConstitution == false)
        {
            Debug.LogFormat("My character {0} is a level {1} {2} with a CON score of {3} and {4} a Hill Dwarf and {5} Tough feat. I want the HP {6}. Total HP: {7}", CharacterName, Level, GivenClass, Constitution, HillDwarfString, ToughString, AveragedString, HP);
        }
        else
        {
            Debug.Log("Unable to calculate HP; class or constitution score is invalid");
        }
    }
}
