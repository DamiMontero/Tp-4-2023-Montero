Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Ingrese 5 valores enteros:")

        Dim valores(4) As Integer
        For i As Integer = 0 To 4
            valores(i) = Convert.ToInt32(Console.ReadLine())
        Next

        Dim mayorPosicion As Integer = 0
        Dim mayorValor As Integer = valores(0)
        For i As Integer = 1 To 4
            If valores(i) > mayorValor Then
                mayorValor = valores(i)
                mayorPosicion = i + 1
            End If
        Next

        Console.WriteLine("El " & mayorPosicion & "º número es el mayor valor.")

        Console.WriteLine("Presione una tecla para salir...")
        Console.ReadKey()
    End Sub
End Module
