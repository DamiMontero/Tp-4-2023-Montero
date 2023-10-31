Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Ingrese el primer valor:")
        Dim num1 As Integer = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine("Ingrese el segundo valor:")
        Dim num2 As Integer = Convert.ToInt32(Console.ReadLine())

        If num1 > num2 Then
            Console.WriteLine("El primer valor (" & num1 & ") es mayor que el segundo valor (" & num2 & ").")
        ElseIf num1 < num2 Then
            Console.WriteLine("El primer valor (" & num1 & ") es menor que el segundo valor (" & num2 & ").")
        Else
            Console.WriteLine("El primer valor (" & num1 & ") es igual que el segundo valor (" & num2 & ").")
        End If

        Console.WriteLine("Presione una tecla para salir...")
        Console.ReadKey()
    End Sub
End Module