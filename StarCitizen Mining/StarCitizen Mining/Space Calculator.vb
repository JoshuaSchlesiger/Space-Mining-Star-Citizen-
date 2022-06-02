Imports System.Math

Public Class Space_Calculator

    Dim HideMain As Boolean
    Dim Mass As Integer

    Dim StoneSCU As Double
    Dim StonecSCU As Double

    Private Sub Space_Calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.BackColor = Color.FromArgb(47, 53, 66)
        lblcSCU.ForeColor = Color.FromArgb(116, 125, 140)
        lblMineral.ForeColor = Color.FromArgb(116, 125, 140)
        lblRawProfit.ForeColor = Color.FromArgb(116, 125, 140)
        lblRefinedProfit.ForeColor = Color.FromArgb(116, 125, 140)
        lblTrash.ForeColor = Color.FromArgb(116, 125, 140)

        lblValueStone.ForeColor = Color.FromArgb(164, 176, 190)
        lblValueTrash.ForeColor = Color.FromArgb(255, 71, 87)
        lblValueMineral.ForeColor = Color.FromArgb(164, 176, 190)
        lblValueRaw.ForeColor = Color.FromArgb(46, 213, 115)
        lblValueRefined.ForeColor = Color.FromArgb(46, 213, 115)


        lblValueStone2.ForeColor = Color.FromArgb(164, 176, 190)
        lblValueTrash2.ForeColor = Color.FromArgb(255, 71, 87)
        lblValueMineral2.ForeColor = Color.FromArgb(164, 176, 190)


        lblType.ForeColor = Color.FromArgb(164, 176, 190)
        lblPercentage.ForeColor = Color.FromArgb(164, 176, 190)
        lblPriceRaw.ForeColor = Color.FromArgb(164, 176, 190)
        lblPriceRefined.ForeColor = Color.FromArgb(164, 176, 190)
        lblQuantity.ForeColor = Color.FromArgb(164, 176, 190)

        lblMass.ForeColor = Color.FromArgb(164, 176, 190)
        tbMass.BackColor = Color.FromArgb(116, 125, 140)

        cbType1.BackColor = Color.FromArgb(116, 125, 140)
        tbPriceRaw1.BackColor = Color.FromArgb(116, 125, 140)
        tbPriceRefined1.BackColor = Color.FromArgb(116, 125, 140)
        tbQuantity1.BackColor = Color.FromArgb(116, 125, 140)
        tbPercentage1.BackColor = Color.FromArgb(116, 125, 140)

        cbType2.BackColor = Color.FromArgb(116, 125, 140)
        tbPriceRaw2.BackColor = Color.FromArgb(116, 125, 140)
        tbPriceRefined2.BackColor = Color.FromArgb(116, 125, 140)
        tbQuantity2.BackColor = Color.FromArgb(116, 125, 140)
        tbPercentage2.BackColor = Color.FromArgb(116, 125, 140)

        cbType3.BackColor = Color.FromArgb(116, 125, 140)
        tbPriceRaw3.BackColor = Color.FromArgb(116, 125, 140)
        tbPriceRefined3.BackColor = Color.FromArgb(116, 125, 140)
        tbQuantity3.BackColor = Color.FromArgb(116, 125, 140)
        tbPercentage3.BackColor = Color.FromArgb(116, 125, 140)

        btnCalculator.BackColor = Color.FromArgb(46, 213, 115)
        btnMainMenu.BackColor = Color.FromArgb(255, 71, 87)
        btnPriceList.BackColor = Color.FromArgb(255, 71, 87)
        btnQuotes.BackColor = Color.FromArgb(255, 71, 87)
        btnJobs.BackColor = Color.FromArgb(255, 71, 87)

        lblValueStone.Text = "0 cSCU"
        lblValueMineral.Text = "0 cSCU"
        lblValueTrash.Text = "0 cSCU"
        lblValueRaw.Text = "0" + Environment.NewLine + "aUEC"
        lblValueRefined.Text = "0" + Environment.NewLine + "aUEC"

        lblValueStone2.Text = "0 SCU"
        lblValueMineral2.Text = "0 SCU"
        lblValueTrash2.Text = "0 SCU"

        If IO.File.Exists("SpaceMiner/Database/Pricelist/RawPrices.csv") Then

        Else
            PriceList.Save()
        End If

    End Sub

#Region "Navigation"
    Private Sub Space_Calculator_Closed(sender As Object, e As EventArgs) Handles Me.Closed

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

    Private Sub btnQuotes_Click(sender As Object, e As EventArgs) Handles btnQuotes.Click
        HideMain = True
        Me.Close()
        Quotes.Show()
    End Sub

#End Region

#Region "Calculation"
    Private Sub tbMass_TextChanged(sender As Object, e As EventArgs) Handles tbMass.TextChanged
        Try
            Mass = CInt(tbMass.Text)
            StonecSCU = 2 * Mass
            lblValueStone.Text = StonecSCU & " cSCU"
            StoneSCU = Mass / 50
            lblValueStone2.Text = StoneSCU & " SCU"

            tbPercentage1.Text = 0
            tbPercentage2.Text = 0
            tbPercentage3.Text = 0

            cbType1.Text = ""
            cbType2.Text = ""
            cbType3.Text = ""
        Catch ex As Exception

        End Try

    End Sub

    Private Sub tbPercentage1_TextChanged(sender As Object, e As EventArgs) Handles tbPercentage1.TextChanged
        Try
            tbQuantity1.Text = (tbPercentage1.Text / 5000) * Mass
            tbQuantity2.Text = (tbPercentage2.Text / 5000) * Mass
            tbQuantity3.Text = (tbPercentage3.Text / 5000) * Mass
            Calc()
        Catch ex As Exception

        End Try
    End Sub


    Private Sub tbPercentage2_TextChanged(sender As Object, e As EventArgs) Handles tbPercentage2.TextChanged
        Try
            tbQuantity1.Text = (tbPercentage1.Text / 5000) * Mass
            tbQuantity2.Text = (tbPercentage2.Text / 5000) * Mass
            tbQuantity3.Text = (tbPercentage3.Text / 5000) * Mass
            Calc()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tbPercentage3_TextChanged(sender As Object, e As EventArgs) Handles tbPercentage3.TextChanged
        Try
            tbQuantity1.Text = (tbPercentage1.Text / 5000) * Mass
            tbQuantity2.Text = (tbPercentage2.Text / 5000) * Mass
            tbQuantity3.Text = (tbPercentage3.Text / 5000) * Mass
            Calc()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub cbType1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbType1.SelectedIndexChanged

        Dim x As Integer = cbType1.SelectedIndex

        Select Case x
            Case 0
                Read(1, 1)
            Case 1
                Read(2, 1)
            Case 2
                Read(3, 1)
            Case 3
                Read(4, 1)
            Case 4
                Read(5, 1)
            Case 5
                Read(6, 1)
            Case 6
                Read(7, 1)
            Case 7
                Read(8, 1)
            Case 8
                Read(9, 1)
            Case 9
                Read(10, 1)
        End Select


        Try
            Calc()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cbType2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbType2.SelectedIndexChanged

        Dim y As Integer = cbType2.SelectedIndex

        Select Case y
            Case 0
                Read(1, 2)
            Case 1
                Read(2, 2)
            Case 2
                Read(3, 2)
            Case 3
                Read(4, 2)
            Case 4
                Read(5, 2)
            Case 5
                Read(6, 2)
            Case 6
                Read(7, 2)
            Case 7
                Read(8, 2)
            Case 8
                Read(9, 2)
            Case 9
                Read(10, 2)
        End Select

        Try
            Calc()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbType3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbType3.SelectedIndexChanged

        Dim z As Integer = cbType3.SelectedIndex

        Select Case z
            Case 0
                Read(1, 3)
            Case 1
                Read(2, 3)
            Case 2
                Read(3, 3)
            Case 3
                Read(4, 3)
            Case 4
                Read(5, 3)
            Case 5
                Read(6, 3)
            Case 6
                Read(7, 3)
            Case 7
                Read(8, 3)
            Case 8
                Read(9, 3)
            Case 9
                Read(10, 3)
        End Select

        Try
            Calc()
        Catch ex As Exception

        End Try

    End Sub


    Private Sub Calc()
        Dim Buffer As Double

        lblValueRaw.Text = (tbPriceRaw1.Text * 100 * tbQuantity1.Text) + (tbPriceRaw2.Text * 100 * tbQuantity2.Text) + (tbPriceRaw3.Text * 100 * tbQuantity3.Text)
        Buffer = lblValueRaw.Text
        lblValueRaw.Text = Math.Round(Buffer, 2)
        lblValueRaw.Text &= Environment.NewLine & "aUEC"

        lblValueRefined.Text = (tbPriceRefined1.Text * 100 * tbQuantity1.Text) + (tbPriceRefined2.Text * 100 * tbQuantity2.Text) + (tbPriceRefined3.Text * 100 * tbQuantity3.Text)
        Buffer = lblValueRefined.Text
        lblValueRefined.Text = Math.Round(Buffer, 2)
        lblValueRefined.Text &= Environment.NewLine & "aUEC"

        Buffer = tbQuantity1.Text
        Buffer += tbQuantity2.Text
        Buffer += tbQuantity3.Text

        Buffer = Math.Round(Buffer, 2)
        lblValueMineral2.Text = Buffer & " SCU"

        lblValueMineral.Text = Buffer * 100 & " cSCU"

        StonecSCU = Math.Round(StonecSCU, 2)
        StoneSCU = Math.Round(StoneSCU, 2)

        lblValueTrash.Text = StonecSCU - Buffer * 100 & " cSCU"
        lblValueTrash2.Text = StoneSCU - Buffer & " SCU"

        Buffer = tbPercentage1.Text
        Buffer += tbPercentage2.Text
        Buffer += tbPercentage3.Text

        If Buffer > 100 Then
            MessageBox.Show("Over 100% isn't possible", "Error")
            tbPercentage1.Text = 0
            tbPercentage2.Text = 0
            tbPercentage3.Text = 0
        End If



    End Sub
#End Region

#Region "Read prices"

    Private Sub Read(type As Integer, line As Integer)

        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("SpaceMiner/Database/Pricelist/RawPrices.csv")
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters("!")

            Dim currentRow As String()

            While Not MyReader.EndOfData
                currentRow = MyReader.ReadFields()
                Dim currentField As String
                Dim i As Integer

                For Each currentField In currentRow

                    If i = type Then
                        If line = 1 Then
                            tbPriceRaw1.Text = currentField
                        ElseIf line = 2 Then
                            tbPriceRaw2.Text = currentField
                        ElseIf line = 3 Then
                            tbPriceRaw3.Text = currentField
                        End If
                    End If

                    i += 1

                Next

                i = 0
            End While
        End Using

        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("SpaceMiner/Database/Pricelist/RefinedPrices.csv")
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters("!")

            Dim currentRow As String()

            While Not MyReader.EndOfData
                currentRow = MyReader.ReadFields()
                Dim currentField As String
                Dim i As Integer

                For Each currentField In currentRow

                    If i = type Then
                        If line = 1 Then
                            tbPriceRefined1.Text = currentField
                        ElseIf line = 2 Then
                            tbPriceRefined2.Text = currentField
                        ElseIf line = 3 Then
                            tbPriceRefined3.Text = currentField
                        End If
                    End If

                    i += 1

                Next

                i = 0
            End While

        End Using

    End Sub



#End Region
End Class