<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        picPlayer = New PictureBox()
        picGoal = New PictureBox()
        lblTitle = New Label()
        lblStatus = New Label()
        lblTime = New Label()
        lblLives = New Label()
        lblScore = New Label()
        btnStart = New Button()
        btnRestart = New Button()
        btnExit = New Button()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Panel5 = New Panel()
        Panel6 = New Panel()
        Panel7 = New Panel()
        Panel8 = New Panel()
        gameTimer = New Timer(components)
        CType(picPlayer, ComponentModel.ISupportInitialize).BeginInit()
        CType(picGoal, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picPlayer
        ' 
        picPlayer.Image = CType(resources.GetObject("picPlayer.Image"), Image)
        picPlayer.Location = New Point(105, 378)
        picPlayer.Name = "picPlayer"
        picPlayer.Size = New Size(33, 34)
        picPlayer.SizeMode = PictureBoxSizeMode.StretchImage
        picPlayer.TabIndex = 0
        picPlayer.TabStop = False
        ' 
        ' picGoal
        ' 
        picGoal.Image = CType(resources.GetObject("picGoal.Image"), Image)
        picGoal.Location = New Point(688, 39)
        picGoal.Name = "picGoal"
        picGoal.Size = New Size(14, 91)
        picGoal.SizeMode = PictureBoxSizeMode.StretchImage
        picGoal.TabIndex = 1
        picGoal.TabStop = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(267, 30)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(123, 28)
        lblTitle.TabIndex = 2
        lblTitle.Text = "Maze Game"
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblStatus.Location = New Point(23, 28)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(60, 25)
        lblStatus.TabIndex = 3
        lblStatus.Text = "Status"
        ' 
        ' lblTime
        ' 
        lblTime.AutoSize = True
        lblTime.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTime.Location = New Point(23, 81)
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(50, 25)
        lblTime.TabIndex = 3
        lblTime.Text = "Time"
        ' 
        ' lblLives
        ' 
        lblLives.AutoSize = True
        lblLives.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblLives.Location = New Point(23, 125)
        lblLives.Name = "lblLives"
        lblLives.Size = New Size(50, 25)
        lblLives.TabIndex = 3
        lblLives.Text = "Lives"
        ' 
        ' lblScore
        ' 
        lblScore.AutoSize = True
        lblScore.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblScore.Location = New Point(23, 162)
        lblScore.Name = "lblScore"
        lblScore.Size = New Size(56, 25)
        lblScore.TabIndex = 3
        lblScore.Text = "Score"
        ' 
        ' btnStart
        ' 
        btnStart.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnStart.Location = New Point(26, 206)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(93, 36)
        btnStart.TabIndex = 4
        btnStart.Text = "Start"
        btnStart.UseVisualStyleBackColor = True
        ' 
        ' btnRestart
        ' 
        btnRestart.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRestart.Location = New Point(12, 258)
        btnRestart.Name = "btnRestart"
        btnRestart.Size = New Size(93, 36)
        btnRestart.TabIndex = 4
        btnRestart.Text = "Restart"
        btnRestart.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnExit.Location = New Point(12, 300)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(93, 36)
        btnExit.TabIndex = 4
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Panel1.Location = New Point(250, 135)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(19, 81)
        Panel1.TabIndex = 5
        Panel1.Tag = "wall"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Panel2.Location = New Point(399, 217)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(130, 16)
        Panel2.TabIndex = 6
        Panel2.Tag = "wall"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Panel3.Location = New Point(374, 288)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(16, 87)
        Panel3.TabIndex = 7
        Panel3.Tag = "wall"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Panel4.Location = New Point(516, 135)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(107, 22)
        Panel4.TabIndex = 8
        Panel4.Tag = "wall"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Panel5.Location = New Point(659, 237)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(18, 91)
        Panel5.TabIndex = 9
        Panel5.Tag = "wall"
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Panel6.Location = New Point(492, 368)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(150, 20)
        Panel6.TabIndex = 10
        Panel6.Tag = "wall"
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Panel7.Location = New Point(390, 70)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(24, 85)
        Panel7.TabIndex = 11
        Panel7.Tag = "wall"
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Panel8.Location = New Point(199, 284)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(102, 23)
        Panel8.TabIndex = 12
        Panel8.Tag = "wall"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel8)
        Controls.Add(Panel7)
        Controls.Add(Panel6)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(btnExit)
        Controls.Add(btnRestart)
        Controls.Add(btnStart)
        Controls.Add(lblScore)
        Controls.Add(lblLives)
        Controls.Add(lblTime)
        Controls.Add(lblStatus)
        Controls.Add(lblTitle)
        Controls.Add(picGoal)
        Controls.Add(picPlayer)
        Name = "Form1"
        Text = "Form1"
        CType(picPlayer, ComponentModel.ISupportInitialize).EndInit()
        CType(picGoal, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picPlayer As PictureBox
    Friend WithEvents picGoal As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents lblLives As Label
    Friend WithEvents lblScore As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents btnRestart As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents gameTimer As Timer

End Class
