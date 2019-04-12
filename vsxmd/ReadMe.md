<a name='assembly'></a>
# Assembly-CSharp

## Contents

- [Comments](#T-Comments 'Comments')
  - [number](#F-Comments-number 'Comments.number')
  - [Function_C()](#M-Comments-Function_C 'Comments.Function_C')
  - [Function_Example_And_Code()](#M-Comments-Function_Example_And_Code 'Comments.Function_Example_And_Code')
  - [Function_List()](#M-Comments-Function_List 'Comments.Function_List')
  - [Function_Para()](#M-Comments-Function_Para 'Comments.Function_Para')
  - [Function_Param(integer,floatingPoint,boolean)](#M-Comments-Function_Param-System-Int32,System-Single,System-Boolean- 'Comments.Function_Param(System.Int32,System.Single,System.Boolean)')
  - [Function_Paramref()](#M-Comments-Function_Paramref-System-Int32- 'Comments.Function_Paramref(System.Int32)')
  - [Function_Remarks()](#M-Comments-Function_Remarks 'Comments.Function_Remarks')
  - [Function_Returns()](#M-Comments-Function_Returns 'Comments.Function_Returns')
  - [Function_See()](#M-Comments-Function_See 'Comments.Function_See')
  - [Function_SeeAlso()](#M-Comments-Function_SeeAlso 'Comments.Function_SeeAlso')
  - [Function_cref()](#M-Comments-Function_cref 'Comments.Function_cref')
  - [NewFunc(i,b)](#M-Comments-NewFunc-System-Int32,System-Boolean- 'Comments.NewFunc(System.Int32,System.Boolean)')

<a name='T-Comments'></a>
## Comments `type`

##### Namespace



##### Summary

Class that displays XML Documentation Comments

<a name='F-Comments-number'></a>
### number `constants`

##### Summary

The number variable of the comment class.

<a name='M-Comments-Function_C'></a>
### Function_C() `method`

##### Summary

`Function_C` is a method in the `Comments` class.

##### Parameters

This method has no parameters.

<a name='M-Comments-Function_Example_And_Code'></a>
### Function_Example_And_Code() `method`

##### Parameters

This method has no parameters.

##### Example

This sample shows how to call the Function_Code() method.

```
class Comments : Monobehaviour 
{
    public void Function_Example_And_Code() 
    {
       // does nothing but call itself
    }
}
```

<a name='M-Comments-Function_List'></a>
### Function_List() `method`

##### Summary

Here is an example of a bulleted list:

##### Parameters

This method has no parameters.

<a name='M-Comments-Function_Para'></a>
### Function_Para() `method`

##### Summary

DoWork is a method in the TestClass class.

Here's how you could make a second paragraph in a description. [WriteLine](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Console.WriteLine 'System.Console.WriteLine(System.String)') for information about output statements.

##### Parameters

This method has no parameters.

<a name='M-Comments-Function_Param-System-Int32,System-Single,System-Boolean-'></a>
### Function_Param(integer,floatingPoint,boolean) `method`

##### Summary

Function that shows the param XML comment

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| integer | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | integer description here |
| floatingPoint | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') | float description here |
| boolean | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | boolean description here |

<a name='M-Comments-Function_Paramref-System-Int32-'></a>
### Function_Paramref() `method`

##### Summary

DoWork is a method in the TestClass class.  
The `int1` parameter takes a number.

##### Parameters

This method has no parameters.

<a name='M-Comments-Function_Remarks'></a>
### Function_Remarks() `method`

##### Summary

This is the summary, the remark only shows up in the help file

##### Parameters

This method has no parameters.

##### Remarks

If you're reading this you're in the help file or the Object Browser

<a name='M-Comments-Function_Returns'></a>
### Function_Returns() `method`

##### Summary

A Function showing the functionality of the XML return comment

##### Returns

returns a random number between 0 and 1

##### Parameters

This method has no parameters.

<a name='M-Comments-Function_See'></a>
### Function_See() `method`

##### Summary

A Function showing the functionality of the XML see comment
see [AnotherScript](#T-AnotherScript 'AnotherScript') for an empty script.

##### Parameters

This method has no parameters.

<a name='M-Comments-Function_SeeAlso'></a>
### Function_SeeAlso() `method`

##### Summary

A Function showing the functionality of the XML seeAlso comment
[AnotherScript](#T-AnotherScript 'AnotherScript') for an empty script.xยง
for yet another empty script

##### Parameters

This method has no parameters.

<a name='M-Comments-Function_cref'></a>
### Function_cref() `method`

##### Summary

This function also calls [Function_Param](#M-Comments-Function_Param-System-Int32,System-Single,System-Boolean- 'Comments.Function_Param(System.Int32,System.Single,System.Boolean)') function after all other code

##### Parameters

This method has no parameters.

<a name='M-Comments-NewFunc-System-Int32,System-Boolean-'></a>
### NewFunc(i,b) `method`

##### Summary

A new function I just made

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| i | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| b | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |
