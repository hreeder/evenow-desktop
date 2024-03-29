﻿Imports System
Imports System.Drawing.Text
Imports EveAI.Live

Public Class frmMain
    Dim api As EveApi
    Dim hotID As Integer = 30000142     'We need to hold on to the ID number of the hottest system for the killboard links (depending on which kb is active). Make Jita default.

    Private Sub timerTQStatus_Tick(sender As Object, e As EventArgs) Handles timerTQStatus.Tick
        updateTQStatus()
    End Sub

    Private Sub timerTime_Tick(sender As Object, e As EventArgs) Handles timerTime.Tick
        updateEveTime()
    End Sub

    Private Sub timerKills_Tick(sender As Object, e As EventArgs) Handles timerKills.Tick
        updateKills()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        api = New EveApi
        updateEveTime()
        updateTQStatus()
        updateKills()

        setFonts()
    End Sub

    Private Sub updateEveTime()
        Dim evetime As DateTime = DateTime.UtcNow
        valEveTime.Text = addZero(evetime.TimeOfDay.Hours) & ":" & addZero(evetime.TimeOfDay.Minutes) & ":" & addZero(evetime.TimeOfDay.Seconds)
    End Sub

    Private Function addZero(ByVal value As Integer) As String
        If value < 10 Then
            Return "0" & value
        Else
            Return value
        End If
    End Function

    Private Sub updateTQStatus()
        apiQueryTQStatus.RunWorkerAsync()
    End Sub

    Private Sub updateKills()
        apiQueryKillCount.RunWorkerAsync()
    End Sub

    Private Sub apiQueryTQStatus_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles apiQueryTQStatus.DoWork
        Dim status As ServerStatus = api.GetServerStatus

        Dim output(0 To 1) As String

        If status.Online = True Then
            output(0) = "ONLINE"
            output(1) = FormatNumber(status.PlayersOnline, 0, , , TriState.True)
        Else
            output(0) = "OFFLINE"
            output(1) = "0 - Server Offline"
        End If

        e.Result = output
    End Sub

    Private Sub apiQueryTQStatus_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles apiQueryTQStatus.RunWorkerCompleted
        valTQStatus.Text = e.Result(0)
        valOnlinePlayers.Text = e.Result(1)
    End Sub

    Private Sub apiQueryKillCount_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles apiQueryKillCount.DoWork
        Dim kills As List(Of Map.MapKill) = api.GetMapKillEntries

        Dim output(0 To 3) As String

        For Each kill As Map.MapKill In kills
            output(0) += kill.ShipKills

            If kill.ShipKills >= output(2) Then
                output(2) = kill.ShipKills
                output(1) = kill.SolarSystem.Name
                output(3) = kill.SolarSystemID
            End If
        Next kill

        e.Result = output
    End Sub

    Private Sub apiQueryKillCount_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles apiQueryKillCount.RunWorkerCompleted
        valKills.Text = FormatNumber(e.Result(0), 0, , , TriState.True)
        valMostShipsDestroyed.Text = e.Result(1)
        lblShipsDestroyedInHotSystem.Text = "Destroyed in " & e.Result(1)
        valShipsDestroyedInHotSystem.Text = FormatNumber(e.Result(2), 0, 0, 0, TriState.True)
        hotID = e.Result(3)
    End Sub

    Private Sub valMostShipsDestroyed_Click(sender As Object, e As EventArgs) Handles valMostShipsDestroyed.Click
        Dim url As String = ""

        If My.Settings.killboardProvider = "eve-kill" Then
            url = "http://eve-kill.net/?a=system_detail&sys_name=" & valMostShipsDestroyed.Text
        ElseIf My.Settings.killboardProvider = "zKb" Then
            url = "http://zkillboard.com/system/" & hotID
        ElseIf My.Settings.killboardProvider = "pleaseignore" Then
            url = "http://kb.pleaseignore.com/?a=system_detail&sys_id=" & hotID
        End If

        Process.Start(url)
    End Sub

    Private Sub btnConfig_Click(sender As Object, e As EventArgs) Handles btnConfig.Click
        Dim configForm As New frmConfig
        If configForm.ShowDialog() = DialogResult.OK Then

        End If
    End Sub

    Private Sub setFonts()
        lblEveTime.Font = CustomFont.GetInstance(18, FontStyle.Bold)
        valEveTime.Font = CustomFont.GetInstance(18, FontStyle.Bold)
        lblTQStatus.Font = CustomFont.GetInstance(18, FontStyle.Bold)
        valTQStatus.Font = CustomFont.GetInstance(18, FontStyle.Bold)
        lblOnlinePlayers.Font = CustomFont.GetInstance(18, FontStyle.Bold)
        valOnlinePlayers.Font = CustomFont.GetInstance(18, FontStyle.Bold)
        lblKills.Font = CustomFont.GetInstance(18, FontStyle.Bold)
        valKills.Font = CustomFont.GetInstance(18, FontStyle.Bold)
        lblMostShipsDestroyed.Font = CustomFont.GetInstance(18, FontStyle.Bold)
        valMostShipsDestroyed.Font = CustomFont.GetInstance(18, FontStyle.Bold)
        lblShipsDestroyedInHotSystem.Font = CustomFont.GetInstance(18, FontStyle.Bold)
        valShipsDestroyedInHotSystem.Font = CustomFont.GetInstance(18, FontStyle.Bold)
    End Sub
End Class
