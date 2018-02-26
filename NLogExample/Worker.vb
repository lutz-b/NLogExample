
Imports System.Threading
Imports NLog

Public Class Worker

    Private Shared Log As ILogger

    Shared Sub New()
        Log = LogManager.GetCurrentClassLogger()
    End Sub

    Public Sub Method1()
        Log.Debug("StartMethod1")
        Log.Info("Do some Work")
        Thread.Sleep(100)
        Log.Debug("EndMethod1")
    End Sub

End Class
