Imports System
Imports System.Diagnostics.CodeAnalysis

Module Program
    Sub Main(args As String())
        'declare varibles 
        Dim firstnumber As Integer
        Dim secondnumber As Decimal
        Dim result As Decimal
        Dim testresult As Boolean = True
        Dim userimput As String

        Console.WriteLine("Hello Ready for some math")

        'assign varables 
        Console.WriteLine("What is the first number")
        firstnumber = Console.ReadLine()
        Console.WriteLine("What is the second number")
        secondnumber = Console.ReadLine()
        Console.WriteLine("what operation would you like preformed")
        userimput = Console.ReadLine()

        'preform operation
        Console.WriteLine(firstnumber & userimput & secondnumber & ("="))
        result += firstnumber userimput secondnumber

    End Sub
End Module
