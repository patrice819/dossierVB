﻿Public Class Homepage

    Private Sub Homepage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        login.ShowDialog()
        Me.Dispose()


    End Sub
End Class
