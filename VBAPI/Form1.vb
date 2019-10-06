Imports System.Net

Public Class Form1
    Dim wClient As New System.Net.WebClient
    Private Sub Btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim result As String = wClient.DownloadString("http://localhost/vbapi/?action=login&username=" + txt_user.Text + "&password=" + txt_pass.Text)
        If result = "success" Then
            MessageBox.Show("Login Success", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Username And Password Incorrect.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Btn_register_Click(sender As Object, e As EventArgs) Handles btn_register.Click
        Dim result As String = wClient.DownloadString("http://localhost/vbapi/?action=register&username=" + txt_user.Text + "&password=" + txt_pass.Text)
        If result = "success" Then
            MessageBox.Show("Register Success", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Plase Try Again", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class
