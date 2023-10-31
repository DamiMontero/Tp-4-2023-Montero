Imports System
Module Program
    Sub Main(args As String())
        Console.WriteLine("Ingrese el primer valor:")
        Dim num1 As Integer = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine("Ingrese el segundo valor:")
        Dim num2 As Integer = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine("Ingrese el tercer valor:")
        Dim num3 As Integer = Convert.ToInt32(Console.ReadLine())

        If num1 < num2 And num1 < num3 Then
            Console.WriteLine("El menor número es: " & num1)
        ElseIf num2 < num1 And num2 < num3 Then
            Console.WriteLine("El menor número es: " & num2)
        Else
            Console.WriteLine("El menor número es: " & num3)
        End If

        Console.WriteLine("Presione una tecla para salir...")
        Console.ReadKey()
    End Sub
End Module
