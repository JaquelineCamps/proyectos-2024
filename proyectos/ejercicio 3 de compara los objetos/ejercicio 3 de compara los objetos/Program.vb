Imports System
Imports System.Collections.Concurrent
Imports System.Collections.Generic
Imports System.Diagnostics.CodeAnalysis
Imports System.Linq

Public Class Venta
    Public Property Cliente As String
    Public Property Producto As String
    Public Property Cantidad As Integer
    Public Property Fecha As Date
End Class

Module Program
    Sub Main()

        Dim ventas As New List(Of Venta) From {
            New Venta With {.Cliente = "ClienteA", .Producto = "Producto1", .Cantidad = 5, .Fecha = #2024-07-10#},
            New Venta With {.Cliente = "ClienteA", .Producto = "Producto2", .Cantidad = 3, .Fecha = #2024-07-10#},
            New Venta With {.Cliente = "ClienteB", .Producto = "Producto1", .Cantidad = 2, .Fecha = #2024-07-12#},
            New Venta With {.Cliente = "ClienteB", .Producto = "Producto2", .Cantidad = 1, .Fecha = #2024-07-12#},
            New Venta With {.Cliente = "ClienteC", .Producto = "Producto1", .Cantidad = 7, .Fecha = #2024-07-03#},
            New Venta With {.Cliente = "ClienteC", .Producto = "Producto2", .Cantidad = 6, .Fecha = #2024-07-03#}
        }

        'cantidad de ventas por cliente
        Dim ventasPorCliente = From venta In ventas
                               Group By cliente = venta.Cliente
                                 Into Totalventas = Sum(venta.Cantidad)
                               Select cliente, Totalventas

        Console.WriteLine("Cantidad de ventas por  cliente:")
        For Each resultado In ventasPorCliente
            Console.WriteLine($"{resultado.cliente}: {resultado.Totalventas} unidades")
        Next

        ' Obtener la cantidad total por producto
        Dim ventasPorProducto = From venta In ventas
                                Group By Producto = venta.Producto
                                Into Totalventas = Sum(venta.Cantidad)
                                Select Producto, Totalventas


        Console.WriteLine(vbCrLf & "Cantidad de ventas por producto:")
        For Each resultado In ventasPorProducto
            Console.WriteLine($"{resultado.Producto}: {resultado.Totalventas} unidades")
        Next

        ' Determinar el día con más ventas
        Dim diaConMasVentas = (From Venta In ventas
                               Group By fecha = Venta.Fecha
                              Into Totalventas = Sum(Venta.Cantidad)
                               Order By Totalventas Descending
                               Select fecha).First()


        Console.WriteLine(vbCrLf & $"Dia con mas ventas: {diaConMasVentas.ToShortDateString()}")

        Console.ReadLine()

    End Sub
End Module