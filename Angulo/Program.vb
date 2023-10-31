Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Ingrese el tamaño de un ángulo en grados:")
        Dim tamañoAngulo As Integer = Convert.ToInt32(Console.ReadLine())

        Select Case tamañoAngulo
            Case -1 To 0, 361 To 10000
                Console.WriteLine("Error: El valor ingresado debe estar entre 0º y 360º.")
            Case 1 To 89
                Console.WriteLine("El ángulo es agudo.")
            Case 90
                Console.WriteLine("El ángulo es recto.")
            Case 91 To 179
                Console.WriteLine("El ángulo es obtuso.")
            Case 180
                Console.WriteLine("El ángulo es llano.")
            Case 181 To 359
                Console.WriteLine("El ángulo es cóncavo.")
            Case 360
                Console.WriteLine("El ángulo es llano.")
        End Select

        Console.WriteLine("Presione una tecla para salir...")
        Console.ReadKey()
    End Sub
End Module