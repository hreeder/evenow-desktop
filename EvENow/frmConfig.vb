Imports System.Windows.Forms

Public Class frmConfig

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Select Case cmbKbProvider.SelectedIndex
            Case 0
                My.Settings.killboardProvider = "eve-kill"
            Case 1
                My.Settings.killboardProvider = "zKb"
            Case 2
                My.Settings.killboardProvider = "pleaseignore"
        End Select

        My.Settings.Save()

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case My.Settings.killboardProvider
            Case "eve-kill"
                cmbKbProvider.SelectedIndex = 0
            Case "zKb"
                cmbKbProvider.SelectedIndex = 1
            Case "pleaseignore"
                cmbKbProvider.SelectedIndex = 2
        End Select
    End Sub
End Class
