<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lblOnlinePlayers
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblEveTime = New System.Windows.Forms.Label()
        Me.lblTQStatus = New System.Windows.Forms.Label()
        Me.valTQStatus = New System.Windows.Forms.Label()
        Me.timerTime = New System.Windows.Forms.Timer(Me.components)
        Me.timerTQStatus = New System.Windows.Forms.Timer(Me.components)
        Me.valEveTime = New System.Windows.Forms.Label()
        Me.valOnlinePlayers = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.apiQueryTQStatus = New System.ComponentModel.BackgroundWorker()
        Me.apiQueryKillCount = New System.ComponentModel.BackgroundWorker()
        Me.lblKills = New System.Windows.Forms.Label()
        Me.lblMostShipsDestroyed = New System.Windows.Forms.Label()
        Me.valMostShipsDestroyed = New System.Windows.Forms.Label()
        Me.valKills = New System.Windows.Forms.Label()
        Me.lblShipsDestroyedInHotSystem = New System.Windows.Forms.Label()
        Me.valShipsDestroyedInHotSystem = New System.Windows.Forms.Label()
        Me.timerKills = New System.Windows.Forms.Timer(Me.components)
        Me.btnConfig = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblEveTime
        '
        Me.lblEveTime.AutoSize = True
        Me.lblEveTime.BackColor = System.Drawing.Color.Transparent
        Me.lblEveTime.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEveTime.ForeColor = System.Drawing.Color.White
        Me.lblEveTime.Location = New System.Drawing.Point(12, 9)
        Me.lblEveTime.Name = "lblEveTime"
        Me.lblEveTime.Size = New System.Drawing.Size(100, 29)
        Me.lblEveTime.TabIndex = 0
        Me.lblEveTime.Text = "EVE Time"
        '
        'lblTQStatus
        '
        Me.lblTQStatus.AutoSize = True
        Me.lblTQStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblTQStatus.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTQStatus.ForeColor = System.Drawing.Color.White
        Me.lblTQStatus.Location = New System.Drawing.Point(12, 87)
        Me.lblTQStatus.Name = "lblTQStatus"
        Me.lblTQStatus.Size = New System.Drawing.Size(162, 29)
        Me.lblTQStatus.TabIndex = 1
        Me.lblTQStatus.Text = "Tranquility Status"
        '
        'valTQStatus
        '
        Me.valTQStatus.AutoSize = True
        Me.valTQStatus.BackColor = System.Drawing.Color.Transparent
        Me.valTQStatus.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valTQStatus.ForeColor = System.Drawing.Color.White
        Me.valTQStatus.Location = New System.Drawing.Point(12, 116)
        Me.valTQStatus.Name = "valTQStatus"
        Me.valTQStatus.Size = New System.Drawing.Size(116, 29)
        Me.valTQStatus.TabIndex = 2
        Me.valTQStatus.Text = "UNKNOWN"
        '
        'timerTime
        '
        Me.timerTime.Enabled = True
        Me.timerTime.Interval = 500
        '
        'timerTQStatus
        '
        Me.timerTQStatus.Enabled = True
        Me.timerTQStatus.Interval = 300000
        '
        'valEveTime
        '
        Me.valEveTime.AutoSize = True
        Me.valEveTime.BackColor = System.Drawing.Color.Transparent
        Me.valEveTime.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valEveTime.ForeColor = System.Drawing.Color.White
        Me.valEveTime.Location = New System.Drawing.Point(12, 38)
        Me.valEveTime.Name = "valEveTime"
        Me.valEveTime.Size = New System.Drawing.Size(116, 29)
        Me.valEveTime.TabIndex = 2
        Me.valEveTime.Text = "UNKNOWN"
        '
        'valOnlinePlayers
        '
        Me.valOnlinePlayers.AutoSize = True
        Me.valOnlinePlayers.BackColor = System.Drawing.Color.Transparent
        Me.valOnlinePlayers.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valOnlinePlayers.ForeColor = System.Drawing.Color.White
        Me.valOnlinePlayers.Location = New System.Drawing.Point(12, 188)
        Me.valOnlinePlayers.Name = "valOnlinePlayers"
        Me.valOnlinePlayers.Size = New System.Drawing.Size(116, 29)
        Me.valOnlinePlayers.TabIndex = 4
        Me.valOnlinePlayers.Text = "UNKNOWN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 29)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Online Players"
        '
        'apiQueryTQStatus
        '
        '
        'apiQueryKillCount
        '
        '
        'lblKills
        '
        Me.lblKills.AutoSize = True
        Me.lblKills.BackColor = System.Drawing.Color.Transparent
        Me.lblKills.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKills.ForeColor = System.Drawing.Color.White
        Me.lblKills.Location = New System.Drawing.Point(12, 234)
        Me.lblKills.Name = "lblKills"
        Me.lblKills.Size = New System.Drawing.Size(174, 29)
        Me.lblKills.TabIndex = 0
        Me.lblKills.Text = "Ship Kills (Last Hr)"
        '
        'lblMostShipsDestroyed
        '
        Me.lblMostShipsDestroyed.AutoSize = True
        Me.lblMostShipsDestroyed.BackColor = System.Drawing.Color.Transparent
        Me.lblMostShipsDestroyed.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMostShipsDestroyed.ForeColor = System.Drawing.Color.White
        Me.lblMostShipsDestroyed.Location = New System.Drawing.Point(12, 312)
        Me.lblMostShipsDestroyed.Name = "lblMostShipsDestroyed"
        Me.lblMostShipsDestroyed.Size = New System.Drawing.Size(204, 29)
        Me.lblMostShipsDestroyed.TabIndex = 1
        Me.lblMostShipsDestroyed.Text = "Most Ships Destroyed"
        '
        'valMostShipsDestroyed
        '
        Me.valMostShipsDestroyed.AutoSize = True
        Me.valMostShipsDestroyed.BackColor = System.Drawing.Color.Transparent
        Me.valMostShipsDestroyed.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valMostShipsDestroyed.ForeColor = System.Drawing.Color.White
        Me.valMostShipsDestroyed.Location = New System.Drawing.Point(12, 341)
        Me.valMostShipsDestroyed.Name = "valMostShipsDestroyed"
        Me.valMostShipsDestroyed.Size = New System.Drawing.Size(116, 29)
        Me.valMostShipsDestroyed.TabIndex = 2
        Me.valMostShipsDestroyed.Text = "UNKNOWN"
        '
        'valKills
        '
        Me.valKills.AutoSize = True
        Me.valKills.BackColor = System.Drawing.Color.Transparent
        Me.valKills.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valKills.ForeColor = System.Drawing.Color.White
        Me.valKills.Location = New System.Drawing.Point(12, 263)
        Me.valKills.Name = "valKills"
        Me.valKills.Size = New System.Drawing.Size(116, 29)
        Me.valKills.TabIndex = 2
        Me.valKills.Text = "UNKNOWN"
        '
        'lblShipsDestroyedInHotSystem
        '
        Me.lblShipsDestroyedInHotSystem.AutoSize = True
        Me.lblShipsDestroyedInHotSystem.BackColor = System.Drawing.Color.Transparent
        Me.lblShipsDestroyedInHotSystem.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShipsDestroyedInHotSystem.ForeColor = System.Drawing.Color.White
        Me.lblShipsDestroyedInHotSystem.Location = New System.Drawing.Point(12, 384)
        Me.lblShipsDestroyedInHotSystem.Name = "lblShipsDestroyedInHotSystem"
        Me.lblShipsDestroyedInHotSystem.Size = New System.Drawing.Size(122, 29)
        Me.lblShipsDestroyedInHotSystem.TabIndex = 3
        Me.lblShipsDestroyedInHotSystem.Text = "Destroyed in"
        '
        'valShipsDestroyedInHotSystem
        '
        Me.valShipsDestroyedInHotSystem.AutoSize = True
        Me.valShipsDestroyedInHotSystem.BackColor = System.Drawing.Color.Transparent
        Me.valShipsDestroyedInHotSystem.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valShipsDestroyedInHotSystem.ForeColor = System.Drawing.Color.White
        Me.valShipsDestroyedInHotSystem.Location = New System.Drawing.Point(12, 413)
        Me.valShipsDestroyedInHotSystem.Name = "valShipsDestroyedInHotSystem"
        Me.valShipsDestroyedInHotSystem.Size = New System.Drawing.Size(116, 29)
        Me.valShipsDestroyedInHotSystem.TabIndex = 4
        Me.valShipsDestroyedInHotSystem.Text = "UNKNOWN"
        '
        'timerKills
        '
        Me.timerKills.Enabled = True
        Me.timerKills.Interval = 600000
        '
        'btnConfig
        '
        Me.btnConfig.Location = New System.Drawing.Point(427, 437)
        Me.btnConfig.Name = "btnConfig"
        Me.btnConfig.Size = New System.Drawing.Size(68, 27)
        Me.btnConfig.TabIndex = 5
        Me.btnConfig.Text = "Configure"
        Me.btnConfig.UseVisualStyleBackColor = True
        '
        'lblOnlinePlayers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.EvENow.My.Resources.Resources.bg4_mobile
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(496, 465)
        Me.Controls.Add(Me.btnConfig)
        Me.Controls.Add(Me.valShipsDestroyedInHotSystem)
        Me.Controls.Add(Me.valOnlinePlayers)
        Me.Controls.Add(Me.lblShipsDestroyedInHotSystem)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.valKills)
        Me.Controls.Add(Me.valEveTime)
        Me.Controls.Add(Me.valMostShipsDestroyed)
        Me.Controls.Add(Me.valTQStatus)
        Me.Controls.Add(Me.lblMostShipsDestroyed)
        Me.Controls.Add(Me.lblTQStatus)
        Me.Controls.Add(Me.lblKills)
        Me.Controls.Add(Me.lblEveTime)
        Me.Name = "lblOnlinePlayers"
        Me.Text = "EVE NOW (BETA 0.1)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEveTime As System.Windows.Forms.Label
    Friend WithEvents lblTQStatus As System.Windows.Forms.Label
    Friend WithEvents valTQStatus As System.Windows.Forms.Label
    Friend WithEvents timerTime As System.Windows.Forms.Timer
    Friend WithEvents timerTQStatus As System.Windows.Forms.Timer
    Friend WithEvents valEveTime As System.Windows.Forms.Label
    Friend WithEvents valOnlinePlayers As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents apiQueryTQStatus As System.ComponentModel.BackgroundWorker
    Friend WithEvents apiQueryKillCount As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblKills As System.Windows.Forms.Label
    Friend WithEvents lblMostShipsDestroyed As System.Windows.Forms.Label
    Friend WithEvents valMostShipsDestroyed As System.Windows.Forms.Label
    Friend WithEvents valKills As System.Windows.Forms.Label
    Friend WithEvents lblShipsDestroyedInHotSystem As System.Windows.Forms.Label
    Friend WithEvents valShipsDestroyedInHotSystem As System.Windows.Forms.Label
    Friend WithEvents timerKills As System.Windows.Forms.Timer
    Friend WithEvents btnConfig As System.Windows.Forms.Button

End Class
