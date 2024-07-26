Imports System
Imports System.Linq

Module module1
    Sub Main(args As String())

        ' Generar un conjunto de números del 1 al 100
        Dim numeros As IEnumerable(Of Integer) = Enumerable.Range(1, 100)

        ' Filtrar los números primos usando LINQ
        Dim numerosPrimos = From n In numeros
                            Where EsPrimo(n)
                            Select n

        ' Mostrar los números primos
        Console.WriteLine("Números primos entre 1 y 100:")
        For Each primo In numerosPrimos
            Console.WriteLine(primo)
        Next

        Console.ReadLine()
    End Sub

    ' Función que determina si un número es primo
    Function EsPrimo(ByVal numero As Integer) As Boolean
        If numero < 2 Then Return False
        For i As Integer = 2 To Math.Sqrt(numero)
            If numero Mod i = 0 Then
                Return False
            End If
        Next
        Return True
    End Function




End Module
