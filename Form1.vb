
Option Strict On

    Imports System.Drawing
    Imports System.Windows.Forms

    Public Class Form1

        Private Const PlayerSpeed As Integer = 5
        Private Const StartingLives As Integer = 3
        Private Const RoundSeconds As Integer = 60

        Private gameStarted As Boolean = False
        Private startPosition As Point
        Private lives As Integer
        Private score As Integer
        Private timeRemaining As Integer

        Private Sub Form1_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

            Me.KeyPreview = True

            startPosition = picPlayer.Location

            gameTimer.Stop()
            gameTimer.Interval = 1000

            lives = StartingLives
            score = 0
            timeRemaining = RoundSeconds

            lblTitle.Text = "Maze Game"
            lblStatus.Text = "Click Start to begin."

            UpdateLabels()
            picPlayer.BringToFront()
        End Sub

        Private Sub StartGame()
            gameTimer.Stop()
            gameStarted = False

            picPlayer.Location = startPosition

            lives = StartingLives
            score = 0
            timeRemaining = RoundSeconds

            UpdateLabels()

            If TouchingWall(Me) Then
                lblStatus.Text =
                "Move the player's starting position away from the walls."

                MessageBox.Show(
                Me,
                "The player starts inside a wall. " &
                "Move picPlayer to an empty space in the Designer.",
                "Check maze layout"
            )

                Return
            End If

            gameStarted = True
            lblStatus.Text = "Use the arrow keys to reach the green goal."

            picPlayer.BringToFront()
            gameTimer.Start()
        End Sub

        Private Sub btnStart_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnStart.Click

            StartGame()
        End Sub

        Private Sub btnRestart_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnRestart.Click

            StartGame()
        End Sub

        ' Handle arrow keys even while a button has focus.
        Protected Overrides Function ProcessCmdKey(
        ByRef msg As Message,
        keyData As Keys
    ) As Boolean

            Dim key As Keys = keyData And Keys.KeyCode

            Select Case key
                Case Keys.Left, Keys.Right, Keys.Up, Keys.Down

                    If gameStarted Then
                        MovePlayer(key)
                    End If

                    ' Prevent arrow keys from navigating between buttons.
                    Return True
            End Select

            Return MyBase.ProcessCmdKey(msg, keyData)
        End Function

        Private Sub MovePlayer(key As Keys)
            Dim dx As Integer = 0
            Dim dy As Integer = 0

            Select Case key
                Case Keys.Left
                    dx = -1
                Case Keys.Right
                    dx = 1
                Case Keys.Up
                    dy = -1
                Case Keys.Down
                    dy = 1
            End Select

            ' Check every pixel so the player cannot jump through thin walls.
            For stepNumber As Integer = 1 To PlayerSpeed
                If Not gameStarted Then Return

                picPlayer.Left += dx
                picPlayer.Top += dy

                KeepPlayerInsideBounds()

                If TouchingWall(Me) Then
                    HandleWallHit()
                    Return
                End If

                If ScreenBounds(picPlayer).IntersectsWith(
                ScreenBounds(picGoal)
            ) Then
                    ShowWin()
                    Return
                End If
            Next
        End Sub

        Private Sub KeepPlayerInsideBounds()
            Dim area As Rectangle = picPlayer.Parent.ClientRectangle

            Dim maxX As Integer =
            Math.Max(area.Left, area.Right - picPlayer.Width)

            Dim maxY As Integer =
            Math.Max(area.Top, area.Bottom - picPlayer.Height)

            picPlayer.Left =
            Math.Max(area.Left, Math.Min(picPlayer.Left, maxX))

            picPlayer.Top =
            Math.Max(area.Top, Math.Min(picPlayer.Top, maxY))
        End Sub

        ' Convert bounds to the same coordinate system.
        Private Function ScreenBounds(ctrl As Control) As Rectangle
            Return ctrl.Parent.RectangleToScreen(ctrl.Bounds)
        End Function

        ' Search the form and any nested panels for tagged walls.
        Private Function TouchingWall(container As Control) As Boolean
            Dim playerRectangle As Rectangle = ScreenBounds(picPlayer)

            For Each ctrl As Control In container.Controls
                If ctrl Is picPlayer Then Continue For
                If Not ctrl.Visible Then Continue For

                Dim isWall As Boolean =
                String.Equals(
                    Convert.ToString(ctrl.Tag).Trim(),
                    "wall",
                    StringComparison.OrdinalIgnoreCase
                )

                If isWall AndAlso
                playerRectangle.IntersectsWith(ScreenBounds(ctrl)) Then

                    Return True
                End If

                If ctrl.HasChildren AndAlso TouchingWall(ctrl) Then
                    Return True
                End If
            Next

            Return False
        End Function

        Private Sub HandleWallHit()
            lives -= 1
            picPlayer.Location = startPosition

            UpdateLabels()

            If lives <= 0 Then
                EndGame("You lost all your lives.")
            Else
                lblStatus.Text =
                "You touched a wall! Try again from the start."
            End If
        End Sub

        Private Sub ShowWin()
            gameStarted = False
            gameTimer.Stop()

            score = timeRemaining * 2
            UpdateLabels()

            lblStatus.Text = "Level Complete!"

            MessageBox.Show(
            Me,
            "Congratulations! You escaped the maze." &
            Environment.NewLine &
            "Score: " & score.ToString(),
            "You win",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        )
        End Sub

        Private Sub EndGame(reason As String)
            gameStarted = False
            gameTimer.Stop()

            lblStatus.Text = "Game Over! " & reason

            MessageBox.Show(
            Me,
            reason & Environment.NewLine &
            "Click Restart to play again.",
            "Game Over",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        )
        End Sub

        Private Sub gameTimer_Tick(
        sender As Object,
        e As EventArgs
    ) Handles gameTimer.Tick

            If Not gameStarted Then Return

            timeRemaining = Math.Max(0, timeRemaining - 1)
            UpdateLabels()

            If timeRemaining = 0 Then
                EndGame("Time is up.")
            End If
        End Sub

        Private Sub UpdateLabels()
            lblLives.Text = "Lives: " & lives.ToString()
            lblScore.Text = "Score: " & score.ToString()
            lblTime.Text = "Time: " & timeRemaining.ToString()
        End Sub

        Protected Overrides Sub OnFormClosed(e As FormClosedEventArgs)
            gameTimer.Stop()
            MyBase.OnFormClosed(e)
        End Sub

    End Class


