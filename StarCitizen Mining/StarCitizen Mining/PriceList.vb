Imports Microsoft.VisualBasic.FileIO
Imports System.ComponentModel
Imports System
Imports System.Text
Public Class PriceList

    Dim HideMain As Boolean

    Private Sub PriceList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(47, 53, 66)
        btnCalculator.BackColor = Color.FromArgb(255, 71, 87)
        btnMainMenu.BackColor = Color.FromArgb(255, 71, 87)
        btnPriceList.BackColor = Color.FromArgb(46, 213, 115)
        btnQuotes.BackColor = Color.FromArgb(255, 71, 87)
        btnJobs.BackColor = Color.FromArgb(255, 71, 87)


        lblOre.ForeColor = Color.FromArgb(164, 176, 190)
        lblPriceRaw.ForeColor = Color.FromArgb(164, 176, 190)
        lblPriceRefined.ForeColor = Color.FromArgb(164, 176, 190)

        tbRawQuant.BackColor = Color.FromArgb(116, 125, 140)
        tbRefinedQuant.BackColor = Color.FromArgb(116, 125, 140)
        lblQuant.ForeColor = Color.FromArgb(255, 127, 80)

        tbRawBexalite.BackColor = Color.FromArgb(116, 125, 140)
        tbRefinedBexalite.BackColor = Color.FromArgb(116, 125, 140)
        lblBexalite.ForeColor = Color.FromArgb(123, 237, 159)

        tbRawTaranite.BackColor = Color.FromArgb(116, 125, 140)
        tbRefinedTaranite.BackColor = Color.FromArgb(116, 125, 140)
        lblTaranite.ForeColor = Color.FromArgb(123, 237, 159)

        tbRawBorase.BackColor = Color.FromArgb(116, 125, 140)
        tbRefinedBorase.BackColor = Color.FromArgb(116, 125, 140)
        lblBorase.ForeColor = Color.FromArgb(123, 237, 159)

        tbRawLaranite.BackColor = Color.FromArgb(116, 125, 140)
        tbRefinedLaranite.BackColor = Color.FromArgb(116, 125, 140)
        lblLaranite.ForeColor = Color.FromArgb(123, 237, 159)

        tbRawAgricium.BackColor = Color.FromArgb(116, 125, 140)
        tbRefinedAgricium.BackColor = Color.FromArgb(116, 125, 140)
        lblAgricium.ForeColor = Color.FromArgb(123, 237, 159)

        tbRawHephaestanite.BackColor = Color.FromArgb(116, 125, 140)
        tbRefinedHephaestanite.BackColor = Color.FromArgb(116, 125, 140)
        lblHephaestanite.ForeColor = Color.FromArgb(206, 214, 224)

        tbRawTitanium.BackColor = Color.FromArgb(116, 125, 140)
        tbRefinedTitanium.BackColor = Color.FromArgb(116, 125, 140)
        lblTitanium.ForeColor = Color.FromArgb(206, 214, 224)

        tbRawDiamond.BackColor = Color.FromArgb(116, 125, 140)
        tbRefinedDiamond.BackColor = Color.FromArgb(116, 125, 140)
        lblDiamond.ForeColor = Color.FromArgb(206, 214, 224)

        tbRawGold.BackColor = Color.FromArgb(116, 125, 140)
        tbRefinedGold.BackColor = Color.FromArgb(116, 125, 140)
        lblGold.ForeColor = Color.FromArgb(206, 214, 224)

        btnReset.BackColor = Color.FromArgb(255, 71, 87)

        btnSave.BackColor = Color.FromArgb(46, 213, 115)

        If IO.File.Exists("SpaceMiner/Database/Pricelist/RawPrices.csv") Then
            Load_File()
        Else
            Save()
        End If


    End Sub

#Region "Navigation"
    Private Sub PriceList_Closed(sender As Object, e As EventArgs) Handles Me.Closed
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


    Private Sub btnQuotes_Click(sender As Object, e As EventArgs) Handles btnQuotes.Click
        HideMain = True
        Me.Close()
        Quotes.Show()
    End Sub

    Private Sub btnCalculator_Click(sender As Object, e As EventArgs) Handles btnCalculator.Click
        HideMain = True
        Me.Close()
        Space_Calculator.Show()
    End Sub
#End Region

#Region "Save"
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Save()
    End Sub


    Sub Save()

        Try
            My.Computer.FileSystem.DeleteFile("SpaceMiner/Database/Pricelist/RawPrices.csv")
        Catch ex As Exception

        End Try

        Try
            My.Computer.FileSystem.CreateDirectory("SpaceMiner\Database\Pricelist")
            Dim objWriter As IO.StreamWriter = IO.File.AppendText("SpaceMiner/Database/Pricelist/RawPrices.csv")

            If IO.File.Exists("SpaceMiner/Database/Pricelist/RawPrices.csv") Then

                objWriter.Write("!" & tbRawQuant.Text & "!")

                objWriter.Write(tbRawBexalite.Text & "!")

                objWriter.Write(tbRawTaranite.Text & "!")

                objWriter.Write(tbRawBorase.Text & "!")

                objWriter.Write(tbRawLaranite.Text & "!")

                objWriter.Write(tbRawAgricium.Text & "!")

                objWriter.Write(tbRawHephaestanite.Text & "!")

                objWriter.Write(tbRawTitanium.Text & "!")

                objWriter.Write(tbRawDiamond.Text & "!")

                objWriter.Write(tbRawGold.Text & "!")

            End If
            objWriter.Close()

        Catch ex As Exception
            MessageBox.Show("Not possible to save raw data", "Error")
        End Try

        Try
            My.Computer.FileSystem.DeleteFile("SpaceMiner/Database/Pricelist/RefinedPrices.csv")
        Catch ex As Exception

        End Try


        Try

            Dim objWriter As IO.StreamWriter = IO.File.AppendText("SpaceMiner/Database/Pricelist/RefinedPrices.csv")

            If IO.File.Exists("SpaceMiner/Database/Pricelist/RefinedPrices.csv") Then

                objWriter.Write("!" & tbRefinedQuant.Text & "!")

                objWriter.Write(tbRefinedBexalite.Text & "!")

                objWriter.Write(tbRefinedTaranite.Text & "!")

                objWriter.Write(tbRefinedBorase.Text & "!")

                objWriter.Write(tbRefinedLaranite.Text & "!")

                objWriter.Write(tbRefinedAgricium.Text & "!")

                objWriter.Write(tbRefinedHephaestanite.Text & "!")

                objWriter.Write(tbRefinedTitanium.Text & "!")

                objWriter.Write(tbRefinedDiamond.Text & "!")

                objWriter.Write(tbRefinedGold.Text & "!")

            End If
            objWriter.Close()

        Catch ex As Exception
            MessageBox.Show("Not possible to save refined data", "Error")
        End Try

    End Sub


#End Region

#Region "Reset"

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Reset()
    End Sub


    Private Sub Reset()
        tbRawQuant.Text = "44,00"
        tbRefinedQuant.Text = "88,00"

        tbRawBexalite.Text = "20,33"
        tbRefinedBexalite.Text = "44,00"

        tbRawTaranite.Text = "16,29"
        tbRefinedTaranite.Text = "35,31"

        tbRawBorase.Text = "16,29"
        tbRefinedBorase.Text = "35,31"

        tbRawLaranite.Text = "15,51"
        tbRefinedLaranite.Text = "30,59"

        tbRawAgricium.Text = "13,75"
        tbRefinedAgricium.Text = "27,50"

        tbRawHephaestanite.Text = "7,38"
        tbRefinedHephaestanite.Text = "15,85"

        tbRawTitanium.Text = "4,47"
        tbRefinedTitanium.Text = "8,90"

        tbRawDiamond.Text = "3,68"
        tbRefinedDiamond.Text = "7,35"

        tbRawGold.Text = "3,20"
        tbRefinedGold.Text = "6,41"

        Save()

    End Sub

#End Region

#Region "Load"
    Private Sub Load_File()

        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("SpaceMiner/Database/Pricelist/RawPrices.csv")
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters("!")

            Dim currentRow As String()

            While Not MyReader.EndOfData
                currentRow = MyReader.ReadFields()
                Dim currentField As String
                Dim i As Integer

                For Each currentField In currentRow

                    Select Case i
                        Case 1
                            tbRawQuant.Text = currentField
                        Case 2
                            tbRawBexalite.Text = currentField
                        Case 3
                            tbRawTaranite.Text = currentField
                        Case 4
                            tbRawBorase.Text = currentField
                        Case 5
                            tbRawLaranite.Text = currentField
                        Case 6
                            tbRawAgricium.Text = currentField
                        Case 7
                            tbRawHephaestanite.Text = currentField
                        Case 8
                            tbRawTitanium.Text = currentField
                        Case 9
                            tbRawDiamond.Text = currentField
                        Case 10
                            tbRawGold.Text = currentField
                    End Select

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

                    Select Case i
                        Case 1
                            tbRefinedQuant.Text = currentField
                        Case 2
                            tbRefinedBexalite.Text = currentField
                        Case 3
                            tbRefinedTaranite.Text = currentField
                        Case 4
                            tbRefinedBorase.Text = currentField
                        Case 5
                            tbRefinedLaranite.Text = currentField
                        Case 6
                            tbRefinedAgricium.Text = currentField
                        Case 7
                            tbRefinedHephaestanite.Text = currentField
                        Case 8
                            tbRefinedTitanium.Text = currentField
                        Case 9
                            tbRefinedDiamond.Text = currentField
                        Case 10
                            tbRefinedGold.Text = currentField
                    End Select

                    i += 1

                Next

                i = 0

            End While
        End Using


    End Sub


#End Region

End Class