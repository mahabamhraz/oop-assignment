Module Module1
    Dim stlist As List(Of String) = New List(Of String)
    Dim ooplist As List(Of Decimal) = New List(Of Decimal)
    Dim javalist As List(Of Decimal) = New List(Of Decimal)
    Dim clist As List(Of Decimal) = New List(Of Decimal)
    Dim names As String, oopmark, javamark, cmark As Decimal
    Sub initial()
        Do
            Console.WriteLine("enter student name: ")
            names = Console.ReadLine()
            If names = "break" Then
                Exit Do
            End If
            Console.WriteLine("enter oop marks: ")
            oopmark = Console.ReadLine()
            Console.WriteLine("enter java marks: ")
            javamark = Console.ReadLine()
            Console.WriteLine("enter c programming marks: ")
            cmark = Console.ReadLine()
            stlist.Add(names)
            ooplist.Add(oopmark)
            javalist.Add(javamark)
            clist.Add(cmark)
        Loop While names <> "break"
    End Sub
    Sub display()
        Dim avg, oopavg, javaavg, cavg, total As Decimal
        Dim size As Integer
        size = stlist.Count - 1
        Console.WriteLine("Names    oop   java    C    Average")
        For i As Integer = 0 To size
            total = ooplist(i) + javalist(i) + clist(i)
            avg = total / 3
            Console.WriteLine(stlist(i) & "     " & ooplist(i) & "     " & javalist(i) & "     " & clist(i) & "    " & avg)
        Next
        Dim ooptotal, javatotal, ctotal As Decimal
        For i As Integer = 0 To size
            ooptotal = (ooptotal + ooplist(i))
            oopavg = ooptotal / ooplist.Count
            javatotal = javatotal + javalist(i)
            javaavg = javatotal / javalist.Count
            ctotal = ctotal + clist(i)
            cavg = ctotal / clist.Count
        Next
        Console.WriteLine("                             ")
        Console.WriteLine("         oop   java    c   ")
        Console.WriteLine("Averages " & oopavg & "    " & javaavg & "      " & cavg)
        Console.ReadLine()
    End Sub
    Sub Main()
        Call initial()
        Call display()
        Console.ReadLine()
    End Sub

End Module
