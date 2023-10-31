Imports System

Enum NombreDia
    Lunes = 1
    Martes = 2
    Miércoles = 3
    Jueves = 4
    Viernes = 5
    Sábado = 6
    Domingo = 7
End Enum

Module Program
    Sub Main(args As String())
        Console.WriteLine("Ingrese el valor numérico correspondiente al día de la semana:")
        Dim valor As Integer = Convert.ToInt32(Console.ReadLine())

        Select Case valor
            Case 1 To 7
                Console.WriteLine($"El día corresponde a: {[Enum].GetName(GetType(NombreDia), valor)}")
            Case Else
                Console.WriteLine("Error: El valor ingresado debe estar entre 1 y 7.")
        End Select

        Console.WriteLine("Presione una tecla para salir...")
        Console.ReadKey()
    End Sub
End Module
