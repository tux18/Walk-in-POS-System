﻿Public Class Admin_Form


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Dim main = New Main_Form()
        main.Show()
    End Sub
End Class