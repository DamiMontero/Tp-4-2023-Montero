Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Ingrese la cantidad del producto:")
        Dim cantidad As Integer = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine("Ingrese el precio unitario del producto:")
        Dim precioUnitario As Double = Convert.ToDouble(Console.ReadLine())

        Dim subtotal As Double = cantidad * precioUnitario

        Dim descuento As Double = 0
        Dim porcentajeDescuento As Double = 0

        If cantidad >= 10 And cantidad <= 50 Then
            descuento = subtotal * 0.05
            porcentajeDescuento = 5
        ElseIf cantidad >= 51 And cantidad <= 250 Then
            descuento = subtotal * 0.1
            porcentajeDescuento = 10
        ElseIf cantidad >= 251 Then
            descuento = subtotal * 0.2
            porcentajeDescuento = 20
        End If

        Dim total As Double = subtotal - descuento

        Console.WriteLine("Subtotal: " & subtotal)
        Console.WriteLine("Porcentaje de descuento aplicado: " & porcentajeDescuento & "%")
        Console.WriteLine("Monto descontado: " & descuento)
        Console.WriteLine("Total: " & total)

        Console.WriteLine("Presione una tecla para salir...")
        Console.ReadKey()
    End Sub
End Module
