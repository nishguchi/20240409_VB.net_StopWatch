Public Class Form1

    Dim times As Integer = 0
    Dim RapWindow As New RapTime
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '計測開始
        Timer1.Start()

        'ボタン色を変更
        Button1.ForeColor = Color.Blue
        Button3.ForeColor = Color.SteelBlue
        Button4.ForeColor = Color.DarkBlue
        Button5.ForeColor = Color.SteelBlue
        Button2.ForeColor = Color.DarkGray

        'ボタン表記変更
        Button1.Text = "計測中"
        Button2.Text = "停止"

    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        '表示単位繰り上げ
        'ミリ秒
        If times = 9 Then
            '稼働中の場合計測を止める
            times = 0
            Label1.Text = 0
            Label2.Text += 1

        End If

        '秒
        If Label2.Text = 59 Then
            Label2.Text = 0
            Label3.Text += 1
        End If

        '分
        If Label3.Text = 59 Then
            Label2.Text = 0
            Label3.Text += 1
        End If

        '時間
        'タイマーストップ
        If Label4.Text = 24 Then
            Timer1.Stop()
        End If


        'ミリ秒に追加
        times = Integer.Parse(Label1.Text) + 1
        Label1.Text = times

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '稼働中の場合計測を止める
        Timer1.Stop()

        'ボタン色を変更
        Button1.ForeColor = Color.DarkGray
        Button2.ForeColor = Color.Red

        'ボタン表記変更
        Button2.Text = "停止中"
        Button1.Text = "計測"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        RapWindow.Show()
        RapWindow.ListBox1.Items.Add(Label4.Text + "" + Label3.Text + ":" + Label2.Text + ":" + Label1.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'アプリ終了
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Application.Restart()
    End Sub
End Class
