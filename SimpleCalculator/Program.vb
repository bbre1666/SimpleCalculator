Imports System
Imports System.Diagnostics.CodeAnalysis
Imports System.Net.Security

Module Program
    Sub Main(args As String())
        'declare varibles 
        Dim firstnumber As Integer
        Dim secondnumner As Integer
        Dim result As String
        Dim userimput As String

        Console.WriteLine("Hello Ready for some math")

        'assign varables 
        Console.WriteLine("Enter the first number")
        firstnumber = Console.ReadLine()
        Console.WriteLine("Enter the second number")
        secondnumner = Console.ReadLine()
        Console.WriteLine("what operation would you like preformed (+/*)")
        userimput = Console.ReadLine()

        'preform operation +
        If userimput = "+" Then
            Console.WriteLine(("expretion") & " " & firstnumber & "+" & secondnumner & ("=") & result)
            result = firstnumber + secondnumner
            Console.WriteLine(result)
        End If

        ''preform operation -
        'If userimput = "-" Then
        '    Console.WriteLine(("expretion") & " " & firstnumber & "-" & secondnumner & ("=") & result)
        '    result = firstnumber - secondnumner
        '    Console.WriteLine(result)
        'End If

        'preform operation *
        If userimput = "*" Then
            Console.WriteLine(("expretion") & " " & firstnumber & "*" & secondnumner & ("=") & result)
            result = firstnumber * secondnumner
            Console.WriteLine(result)
        End If

        ''preform operation /
        'If userimput = "/" Then
        '    Console.WriteLine(("expretion") & " " & firstnumber & "/" & secondnumner & ("=") & result)
        '    result = firstnumber / secondnumner
        '    Console.WriteLine(result)
        'End If

    End Sub
End Module