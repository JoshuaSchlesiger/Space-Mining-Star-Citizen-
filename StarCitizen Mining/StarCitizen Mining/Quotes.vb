Public Class Quotes

    Dim HideMain As Boolean


    Private Sub Quotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.BackColor = Color.FromArgb(47, 53, 66)


        btnCalculator.BackColor = Color.FromArgb(255, 71, 87)
        btnMainMenu.BackColor = Color.FromArgb(255, 71, 87)
        btnPriceList.BackColor = Color.FromArgb(255, 71, 87)
        btnQuotes.BackColor = Color.FromArgb(46, 213, 115)
        btnJobs.BackColor = Color.FromArgb(255, 71, 87)

    End Sub

#Region "Navigation"
    Private Sub Quotes_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        If HideMain = False Then
            Main_menu.Show()
        End If
    End Sub

    Private Sub btnJobs_Click(sender As Object, e As EventArgs) Handles btnJobs.Click
        HideMain = True
        Me.Close()
        Jobs.Show()
    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        HideMain = True
        Me.Close()
        Main_menu.Show()
    End Sub

    Private Sub btnPriceList_Click(sender As Object, e As EventArgs) Handles btnPriceList.Click
        HideMain = True
        Me.Close()
        PriceList.Show()
    End Sub

    Private Sub btnCalculator_Click(sender As Object, e As EventArgs) Handles btnCalculator.Click
        HideMain = True
        Me.Close()
        Space_Calculator.Show()
    End Sub
#End Region


#Region "Links"
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim webAddress As String = "https://discord.gg/uWQX5Zy8sT"
        Process.Start(webAddress)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim webAddress As String = "https://www.twitch.tv/dochsergeanttv"
        Process.Start(webAddress)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim webAddress As String = "https://www.flaticon.com/"
        Process.Start(webAddress)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim webAddress As String = "https://github.com/DochSergeantTV/Space-Miner-Star-Citizen-"
        Process.Start(webAddress)
    End Sub
#End Region

End Class