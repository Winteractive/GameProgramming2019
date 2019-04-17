using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>Class that displays XML Documentation Comments</summary>
public class Comments : MonoBehaviour
{
    /// <summary>The number variable of the comment class.</summary>
    /// <value>The number represents the order this has in a queue.</value>
    public int number;


    /// <summary>
    /// <c>Function_C</c> is a method in the <c>Comments</c> class.
    /// </summary>
    public void Function_C()
    {
    }

    /// <summary>
    /// This is the summary, the remark only shows up in the help file
    /// </summary>
    /// <remarks>
    /// If you're reading this you're in the help file or the Object Browser
    /// </remarks>
    public void Function_Remarks()
    {
    }

    /// <example> 
    /// This sample shows how to call the Function_Code() method.
    /// <code>
    /// class Comments : Monobehaviour 
    /// {
    ///     public void Function_Example_And_Code() 
    ///     {
    ///        // does nothing but call itself
    ///     }
    /// }
    /// </code>
    /// </example>
    public void Function_Example_And_Code()
    {
    }

    /// <summary>
    /// This function also calls <see cref="Function_Param"/> function after all other code
    /// </summary>
    public void Function_cref()
    {
        // code...
        Function_Param(1, 0.1f, true);
    }

    /// <summary>
    /// Function that shows the param XML comment
    /// </summary>
    /// <param name="integer">integer description here</param>
    /// <param name="floatingPoint">float description here</param>
    /// <param name="boolean">boolean description here</param>
    public void Function_Param(int integer, float floatingPoint, bool boolean)
    {

    }

    /// <summary>DoWork is a method in the TestClass class.
    /// <para>Here's how you could make a second paragraph in a description. <see cref="System.Console.WriteLine(System.String)"/> for information about output statements.</para>
    /// <seealso cref="Function_List"/>
    /// </summary>
    public void Function_Para()
    {
    }

    /// <summary>DoWork is a method in the TestClass class.  
    /// The <paramref name="int1"/> parameter takes a number.
    /// </summary>
    public void Function_Paramref(int int1)
    {
    }

    /// <summary>Here is an example of a bulleted list:
    /// <list type="Projectiles">
    /// <item>
    /// <description>Fireball.</description>
    /// </item>
    /// <item>
    /// <description>Ice Arrow.</description>
    /// </item>
    /// </list>
    /// </summary>
    public void Function_List()
    {
    }

    /// <summary>
    /// A Function showing the functionality of the XML return comment
    /// </summary>
    /// <returns>returns a random number between 0 and 1</returns>
    public float Function_Returns()
    {
        return Random.value;
    }


    /// <summary>A Function showing the functionality of the XML see comment
    /// see <see cref="AnotherScript"/> for an empty script.
    /// </summary>
    public void Function_See()
    {

    }

    /// <summary>A Function showing the functionality of the XML seeAlso comment
    /// <see cref="AnotherScript"/> for an empty script.x§
    /// <seealso cref="YetAnotherScript"/> for yet another empty script
    /// </summary>
    public void Function_SeeAlso()
    {

    }


    /// <summary>
    /// A test function to show XML syntax
    /// </summary>
    /// <param name="nmbr">any whole number</param>
    /// <returns>the number parameter plus 1</returns>
    public int ReturnANumberLargerThan(int nmbr)
    {
        return number++;
    }


}