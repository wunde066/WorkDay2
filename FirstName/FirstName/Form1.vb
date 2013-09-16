Option Strict On

Public Class Form1

    Private Sub btnFirstName_Click(sender As System.Object, e As System.EventArgs) Handles btnFirstName.Click

        Dim fullname As String = txtFullName.Text

        Dim fullnametrimmed As String

        fullnametrimmed = fullname.Trim()

        fullname = txtFullName.Text

        Dim idxspace As Integer
        idxspace = fullnametrimmed.IndexOf(" ")

        Dim firstname As String

        firstname = fullnametrimmed.Substring(0, idxspace)

        txtfirstname.Text = FirstName

    End Sub

End Class
