Imports System.ComponentModel
Imports System.Reflection.Emit

Public Class RapTime

    Private Sub RapTime_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'controlボックス使用不可
        Me.ControlBox = Not Me.ControlBox
        Button1.ForeColor = Color.Gray
        Button2.ForeColor = Color.Gray
        Button3.ForeColor = Color.SteelBlue
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        ListBox1.Items.Add(Form1.Label4.Text + "" + Form1.Label3.Text + ":" + Form1.Label2.Text + ":" + Form1.Label1.Text)

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

End Class