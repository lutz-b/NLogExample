Module Module1

    Sub Main()

        Dim w = New Worker
        w.Method1()

        Dim spam = New SpamWorker
        spam.SpanLog(21000)

        Console.WriteLine("Done. Pres any key to exit.")
        Console.ReadKey()

    End Sub

End Module
