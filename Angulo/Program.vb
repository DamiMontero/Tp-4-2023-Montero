Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Ingrese el tama�o de un �ngulo en grados:")
        Dim tama�oAngulo As Integer = Convert.ToInt32(Console.ReadLine())

        Select Case tama�oAngulo
            Case -1 To 0, 361 To 10000
                Console.WriteLine("Error: El valor ingresado debe estar entre 0� y 360�.")
            Case 1 To 89
                Console.WriteLine("El �ngulo es agudo.")
            Case 90
                Console.WriteLine("El �ngulo es recto.")
            Case 91 To 179
                Console.WriteLine("El �ngulo es obtuso.")
            Case 180
                Console.WriteLine("El �ngulo es llano.")
            Case 181 To 359
                Console.WriteLine("El �ngulo es c�ncavo.")
            Case 360
                Console.WriteLine("El �ngulo es llano.")
        End Select

        Console.WriteLine("Presione una tecla para salir...")
        Console.ReadKey()
    End Sub
End Module