Public Class Main_menu

    Private Sub Main_menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(47, 53, 66)
        lblHeadline.ForeColor = Color.FromArgb(255, 255, 255)
        lblSpaceCalculator.ForeColor = Color.FromArgb(255, 255, 255)
        lblPrices.ForeColor = Color.FromArgb(255, 255, 255)
        lblJobs.ForeColor = Color.FromArgb(255, 255, 255)
        lblQuotes.ForeColor = Color.FromArgb(255, 255, 255)
        lblSupport.ForeColor = Color.FromArgb(255, 255, 255)
        Save()
    End Sub

    Private Sub pbSpaceCalculator_Click(sender As Object, e As EventArgs) Handles pbSpaceCalculator.Click
        Space_Calculator.Show()
        Me.Hide()
    End Sub

    Private Sub pbJobs_Click(sender As Object, e As EventArgs) Handles pbJobs.Click
        Jobs.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PriceList.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Quotes.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblSupport.Click
        Dim webAddress As String = "https://www.twitch.tv/dochsergeanttv"
        Process.Start(webAddress)
    End Sub

    Private Sub Save()


        Try


            If IO.File.Exists("SpaceMiner/Database/Pricelist/RawPrices.csv") Then

            Else
                My.Computer.FileSystem.CreateDirectory("SpaceMiner\Database\Pricelist")
                Dim objWriter As IO.StreamWriter = IO.File.AppendText("SpaceMiner/Database/Pricelist/RawPrices.csv")

                objWriter.Write("!" & "44,00" & "!")

                objWriter.Write("20,33" & "!")

                objWriter.Write("16,29" & "!")

                objWriter.Write("16,29" & "!")

                objWriter.Write("15,51" & "!")

                objWriter.Write("13,75" & "!")

                objWriter.Write("7,38" & "!")

                objWriter.Write("4,47" & "!")

                objWriter.Write("3,68" & "!")

                objWriter.Write("3,20" & "!")

                objWriter.Close()


            End If


        Catch ex As Exception
            MessageBox.Show("Not possible to save raw data", "Error")
        End Try



        Try



            If IO.File.Exists("SpaceMiner/Database/Pricelist/RefinedPrices.csv") Then

            Else
                Dim objWriter As IO.StreamWriter = IO.File.AppendText("SpaceMiner/Database/Pricelist/RefinedPrices.csv")

                objWriter.Write("!" & "88,00" & "!")

                objWriter.Write("44,00" & "!")

                objWriter.Write("35,31" & "!")

                objWriter.Write("35,31" & "!")

                objWriter.Write("30,59" & "!")

                objWriter.Write("27,50" & "!")

                objWriter.Write("15,85" & "!")

                objWriter.Write("8,90" & "!")

                objWriter.Write("7,35" & "!")

                objWriter.Write("6,41" & "!")

                objWriter.Close()

            End If
        Catch ex As Exception
            MessageBox.Show("Not possible to save refined data", "Error")
        End Try

    End Sub

End Class