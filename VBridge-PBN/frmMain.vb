Public Class frmMain

    Private boardInfo As New Dictionary(Of String, String)

    ' Maak een alias voor gebruik in subroutines
    Private Sub OpenFileDialog()
        ofdMembersFile.ShowDialog()
    End Sub

    ' Knop bladeren
    Private Sub cmdFile_Click(sender As System.Object, e As System.EventArgs) Handles cmdFile.Click
        ' Dialoogvenster openen
        OpenFileDialog()
    End Sub

    ' Op tekstvak CSV-bestand klikken
    Private Sub txtFilename_Click(sender As Object, e As System.EventArgs) Handles txtFilename.Click
        If txtFilename.Text = "" Then ' Nog geen bestand gekozen
            OpenFileDialog()
        End If
    End Sub

    ' Dialoogvenster bestandskeuze - bevestigd
    Private Sub ofdMembersFile_FileOk(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles ofdMembersFile.FileOk

        ' Bestandsnaam overnemen in tekstveld
        txtFilename.Text = ofdMembersFile.FileName

    End Sub

    Private Sub cmdClose_Click(sender As System.Object, e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdRead_Click(sender As System.Object, e As System.EventArgs) Handles cmdRead.Click

        If txtFilename.Text <> "" Then
            ReadPBNFile(txtFilename.Text)
        Else
            MsgBox("Kies eerst een geldig PBN-bestand.", MsgBoxStyle.Critical, "Geen PBN-bestand gekozen")
        End If

    End Sub

    Private Sub lblLink_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblLink.LinkClicked
        System.Diagnostics.Process.Start("http://www.hartenvier.be")
    End Sub

    Private Sub ReadPBNFile(ByVal filename As String)

        Dim intFileNumberOpen As Integer
        Dim strTekstregel As String
        Dim strCurrentBoard As String = ""
        Dim strDealer() As String
        Dim lstHands As List(Of String)
        Dim strHands() As String

        ' Haal filehandlers op
        ' Open bestanden voor lezen
        intFileNumberOpen = FreeFile()
        FileOpen(intFileNumberOpen, txtFilename.Text, OpenMode.Input)

        ' Lezen van oorspronkelijk bestand
        Do While Not EOF(intFileNumberOpen)
            strTekstregel = LineInput(intFileNumberOpen)

            If strTekstregel.Length > 9 AndAlso strTekstregel.Substring(0, 8) = "[Board " & Chr(34) Then
                strCurrentBoard = strTekstregel.Substring(8).TrimEnd({Chr(34), CChar("]")})
            End If

            If strTekstregel.Length > 8 AndAlso strTekstregel.Substring(0, 7) = "[Deal " & Chr(34) Then
                strDealer = strTekstregel.Substring(7).TrimEnd({Chr(34), CChar("]")}).Split(":")
                lstHands = strDealer(1).Split(" ").ToList()
                Select Case strDealer(0)
                    Case "N"
                        ' do nothing
                    Case "E"
                        ' shift 3 times
                        lstHands.Add(lstHands.First())
                        lstHands.RemoveAt(0)
                        lstHands.Add(lstHands.First())
                        lstHands.RemoveAt(0)
                        lstHands.Add(lstHands.First())
                        lstHands.RemoveAt(0)
                    Case "S"
                        ' shift 2 times
                        lstHands.Add(lstHands.First())
                        lstHands.RemoveAt(0)
                        lstHands.Add(lstHands.First())
                        lstHands.RemoveAt(0)
                    Case "W"
                        ' shift 1 time
                        lstHands.Add(lstHands.First())
                        lstHands.RemoveAt(0)
                End Select

                strHands = lstHands.ToArray

                boardInfo.Add(strCurrentBoard, Join(strHands, " "))
            End If
        Loop

        FileClose(intFileNumberOpen)

        Dim tmpBoardNumber As String
        For Each tmpBoardNumber In boardInfo.Keys
            cmbBoards.Items.Add(tmpBoardNumber)
        Next
        cmbBoards.Enabled = True

    End Sub

    Private Sub cmdLeegmaken_Click(sender As System.Object, e As System.EventArgs) Handles cmdLeegmaken.Click
        txtGift.Text = ""
    End Sub

    Private Sub cmdToon_Click(sender As System.Object, e As System.EventArgs) Handles cmdToon.Click
        Dim strHands As String = boardInfo(cmbBoards.Text)
        Dim strLine As String
        Dim lstHands As List(Of String) = strHands.Split(" ").ToList

        txtGift.Text = ""

        ' Noord
        strLine = "S  ".PadLeft(21) & lstHands(0).Split(".")(0)
        strLine = strLine.PadRight(52)
        txtGift.Text &= strLine & vbCrLf
        strLine = "H  ".PadLeft(21) & lstHands(0).Split(".")(1)
        strLine = strLine.PadRight(52)
        txtGift.Text &= strLine & vbCrLf
        strLine = "R  ".PadLeft(21) & lstHands(0).Split(".")(2)
        strLine = strLine.PadRight(52)
        txtGift.Text &= strLine & vbCrLf
        strLine = "K  ".PadLeft(21) & lstHands(0).Split(".")(3)
        strLine = strLine.PadRight(52)
        txtGift.Text &= strLine & vbCrLf
        txtGift.Text &= "".PadRight(52) & vbCrLf

        ' West en Oost
        strLine = "S  " & lstHands(3).Split(".")(0)
        strLine = strLine.PadRight(36) & "S  " & lstHands(1).Split(".")(0)
        strLine = strLine.PadRight(52)
        txtGift.Text &= strLine & vbCrLf
        strLine = "H  " & lstHands(3).Split(".")(1)
        strLine = strLine.PadRight(36) & "H  " & lstHands(1).Split(".")(1)
        strLine = strLine.PadRight(52)
        txtGift.Text &= strLine & vbCrLf
        strLine = "R  " & lstHands(3).Split(".")(2)
        strLine = strLine.PadRight(36) & "R  " & lstHands(1).Split(".")(2)
        strLine = strLine.PadRight(52)
        txtGift.Text &= strLine & vbCrLf
        strLine = "K  " & lstHands(3).Split(".")(3)
        strLine = strLine.PadRight(36) & "K  " & lstHands(1).Split(".")(3)
        strLine = strLine.PadRight(52)
        txtGift.Text &= strLine & vbCrLf
        txtGift.Text &= "".PadRight(52) & vbCrLf

        ' Zuid
        strLine = "S  ".PadLeft(21) & lstHands(2).Split(".")(0)
        strLine = strLine.PadRight(52)
        txtGift.Text &= strLine & vbCrLf
        strLine = "H  ".PadLeft(21) & lstHands(2).Split(".")(1)
        strLine = strLine.PadRight(52)
        txtGift.Text &= strLine & vbCrLf
        strLine = "R  ".PadLeft(21) & lstHands(2).Split(".")(2)
        strLine = strLine.PadRight(52)
        txtGift.Text &= strLine & vbCrLf
        strLine = "K  ".PadLeft(21) & lstHands(2).Split(".")(3)
        strLine = strLine.PadRight(52)
        txtGift.Text &= strLine


    End Sub
End Class
