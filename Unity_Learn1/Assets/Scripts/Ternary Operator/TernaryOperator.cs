using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* The Ternary Operator is the condensed form for an if/else statement. 
 * 
 * In it's most basic form, the Ternary Operator is used for deciding
 * between two values based on some boolean expression.
 * 
 * The syntax has the format:
 * variable = boolean ? "true expression" : "false expression";
 * 
 * A general rule for when to use a Ternary Operator in place of an if statement:
 * if your code needs a simple if/else structure with a single short expression
 * in each case.
 */

public class TernaryOperator : MonoBehaviour
{
    void Start()
    {
        int health = 10;
        string message;

        message = health > 0 ? "Player is alive" : "Player is dead";
    }

}
