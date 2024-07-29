Imports System

Module Program
    Sub Main(args As String())
        ' Definamos una lista de notas
        Dim notas As New List(Of Integer) From {7, 8, 9, 6, 10, 5, 8, 7}

        ' Usamos LINQ para filtrar las notas sobresalientes
        Dim notasSobresalientes = From nota In notas
                                  Where nota >= 8
                                  Select nota

        ' Mostramos las notas sobresalientes
        Console.WriteLine("Notas sobresalientes:")
        For Each nota In notasSobresalientes
            Console.WriteLine(nota)
        Next

        ' Esperamos a que el usuario presione una tecla antes de cerrar
        Console.ReadKey()
    End Sub
End Module
