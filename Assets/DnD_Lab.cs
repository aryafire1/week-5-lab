using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DnD_Lab : MonoBehaviour
{
    public string CharacterName;
    public string Class;

    public int Level;
    public int Constitution;

    public bool IsHillDwarf;
    public bool HasTough;
    public bool Averaged;

    string HillDwarfString;
    string ToughString;
    string AveragedString;

    int HP;
    int CurrentModifier;

    //The first two columns are various possible Constitution scores, while the third contains the modifier that applies to each respective score.
    int[,] CONAndModifier = new int[16, 3]
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

    //int DebugInt = 21;

    //All classes currently in the system alongside their respective dice (8 is a d8, 12 is a d12, etc.)
    Dictionary<string, int> ClassAndDice = new Dictionary<string, int>()
    {
        {"artificer", 8},
        {"barbarian", 12},
        {"bard", 8},
        {"cleric", 8},
        {"druid", 8},
        {"fighter", 10},
        {"monk", 8},
        {"ranger", 10},
        {"rogue", 8},
        {"paladin", 10},
        {"sorcerer", 6},
        {"wizard", 6},
        {"warlock", 8},
    };

    void Start()
    {
        DetermineModifier();

        //Parameter is the value of Class, which is changed to lowercase to compare it to indexes in ClassAndDice.
        CalculateDice(ClassAndDice[Class.ToLower()]);

        BoolToString();

        CheckForNegative();

        Debug.LogFormat("My character {0} is a level {1} {2} with a CON score of {3} and {4} a Hill Dwarf and {5} Tough feat. I want the HP {6}. Total HP: {7}", CharacterName, Level, Class, Constitution, HillDwarfString, ToughString, AveragedString, HP);
    }

    //Calculates HP based on if the user wants their dice rolled or averaged.
    void CalculateDice(int DiceMax)
    {
        if(Averaged == true)
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
            //Debug.Log("subtotal HP: " + HP);
        }
        //Debug.Log("subtotal HP: " + HP);
    }

    //Determines modifier based on the given constitution score.
    void DetermineModifier()
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

        /*switch (Constitution)
        {
            case var value when value == DebugInt:
                CurrentModifier = DebugInt;
                Debug.Log(CurrentModifier);
                break;
        }*/
    }

    //Turns boolean inputs into strings which will be shown in the console. Also increases HP if applicable.
    void BoolToString()
    {
        if(IsHillDwarf == true)
        {
            HillDwarfString = "is";
            HP += Level;
        }
        else
        {
            HillDwarfString = "is not";
        }

        if(HasTough == true)
        {
            ToughString = "has";
            HP += Level * 2;
        }
        else
        {
            ToughString = "does not have";
        }

        if(Averaged == true)
        {
            AveragedString = "averaged";
        }
        else
        {
            AveragedString = "rolled";
        }
    }

    void CheckForNegative()
    {
        if(HP < 1)
        {
            HP = 1;
        }
    }
}
