Imports System.Threading
Imports NLog

Public Class SpamWorker

    Private Shared Log As ILogger = LogManager.GetCurrentClassLogger()

    Public Sub SpanLog(entries As Integer)

        For index = 0 To entries

            Log.Trace("Index" & index)

            If (index Mod 1000 = 0) Then Thread.Sleep(25)
        Next


    End Sub

End Class
