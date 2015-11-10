Public Class Form2

    Dim guess As Integer
    Dim finish As Integer
    Dim nums(4) As Integer
   
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Public Sub btnCrack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrack.Click
        If guess = 0 Then
            btnChoice01.Enabled = False
            btnChoice02.Enabled = False
            btnChoice03.Enabled = False
            btnChoice04.Enabled = False


            If btnChoice01.BackColor = btnResult01.BackColor Then
                btnResponse01.BackColor = Color.White
                btnResponse01.Visible = True
            ElseIf btnChoice01.BackColor = btnResult02.BackColor Then
                btnResponse01.BackColor = Color.Black
                btnResponse01.Visible = True
            ElseIf btnChoice01.BackColor = btnResult03.BackColor Then
                btnResponse01.BackColor = Color.Black
                btnResponse01.Visible = True
            ElseIf btnChoice01.BackColor = btnResult04.BackColor Then
                btnResponse01.BackColor = Color.Black
                btnResponse01.Visible = True
            End If



            If btnChoice02.BackColor = btnResult02.BackColor Then
                btnResponse02.BackColor = Color.White
                btnResponse02.Visible = True
            ElseIf btnChoice02.BackColor = btnResult01.BackColor Then
                btnResponse02.BackColor = Color.Black
                btnResponse02.Visible = True
            ElseIf btnChoice02.BackColor = btnResult03.BackColor Then
                btnResponse02.BackColor = Color.Black
                btnResponse02.Visible = True
            ElseIf btnChoice02.BackColor = btnResult04.BackColor Then
                btnResponse02.BackColor = Color.Black
                btnResponse02.Visible = True
            End If



            If btnChoice03.BackColor = btnResult03.BackColor Then
                btnResponse03.BackColor = Color.White
                btnResponse03.Visible = True
            ElseIf btnChoice03.BackColor = btnResult01.BackColor Then
                btnResponse03.BackColor = Color.Black
                btnResponse03.Visible = True
            ElseIf btnChoice03.BackColor = btnResult02.BackColor Then
                btnResponse03.BackColor = Color.Black
                btnResponse03.Visible = True
            ElseIf btnChoice03.BackColor = btnResult04.BackColor Then
                btnResponse03.BackColor = Color.Black
                btnResponse03.Visible = True
            End If



            If btnChoice04.BackColor = btnResult04.BackColor Then
                btnResponse04.BackColor = Color.White
                btnResponse04.Visible = True
            ElseIf btnChoice04.BackColor = btnResult01.BackColor Then
                btnResponse04.BackColor = Color.Black
                btnResponse04.Visible = True
            ElseIf btnChoice04.BackColor = btnResult02.BackColor Then
                btnResponse04.BackColor = Color.Black
                btnResponse04.Visible = True
            ElseIf btnChoice04.BackColor = btnResult03.BackColor Then
                btnResponse04.BackColor = Color.Black
                btnResponse04.Visible = True
            End If


            btnChoice05.Visible = True
            btnChoice06.Visible = True
            btnChoice07.Visible = True
            btnChoice08.Visible = True
            guess = 1
        ElseIf guess = 1 Then
            btnChoice05.Enabled = False
            btnChoice06.Enabled = False
            btnChoice07.Enabled = False
            btnChoice08.Enabled = False

            If btnChoice05.BackColor = btnResult01.BackColor Then
                btnResponse05.BackColor = Color.White
                btnResponse05.Visible = True
            ElseIf btnChoice05.BackColor = btnResult02.BackColor Then
                btnResponse05.BackColor = Color.Black
                btnResponse05.Visible = True
            ElseIf btnChoice05.BackColor = btnResult03.BackColor Then
                btnResponse05.BackColor = Color.Black
                btnResponse05.Visible = True
            ElseIf btnChoice05.BackColor = btnResult04.BackColor Then
                btnResponse05.BackColor = Color.Black
                btnResponse05.Visible = True
            End If

            If btnChoice06.BackColor = btnResult02.BackColor Then
                btnResponse06.BackColor = Color.White
                btnResponse06.Visible = True
            ElseIf btnChoice06.BackColor = btnResult01.BackColor Then
                btnResponse06.BackColor = Color.Black
                btnResponse06.Visible = True
            ElseIf btnChoice06.BackColor = btnResult03.BackColor Then
                btnResponse06.BackColor = Color.Black
                btnResponse06.Visible = True
            ElseIf btnChoice06.BackColor = btnResult04.BackColor Then
                btnResponse06.BackColor = Color.Black
                btnResponse06.Visible = True
            End If

            If btnChoice07.BackColor = btnResult03.BackColor Then
                btnResponse07.BackColor = Color.White
                btnResponse07.Visible = True
            ElseIf btnChoice07.BackColor = btnResult01.BackColor Then
                btnResponse07.BackColor = Color.Black
                btnResponse07.Visible = True
            ElseIf btnChoice07.BackColor = btnResult02.BackColor Then
                btnResponse07.BackColor = Color.Black
                btnResponse07.Visible = True
            ElseIf btnChoice07.BackColor = btnResult04.BackColor Then
                btnResponse07.BackColor = Color.Black
                btnResponse07.Visible = True
            End If

            If btnChoice08.BackColor = btnResult04.BackColor Then
                btnResponse08.BackColor = Color.White
                btnResponse08.Visible = True
            ElseIf btnChoice08.BackColor = btnResult01.BackColor Then
                btnResponse08.BackColor = Color.Black
                btnResponse08.Visible = True
            ElseIf btnChoice08.BackColor = btnResult02.BackColor Then
                btnResponse08.BackColor = Color.Black
                btnResponse08.Visible = True
            ElseIf btnChoice08.BackColor = btnResult03.BackColor Then
                btnResponse08.BackColor = Color.Black
                btnResponse08.Visible = True
            End If

            btnChoice09.Visible = True
            btnChoice10.Visible = True
            btnChoice11.Visible = True
            btnChoice12.Visible = True
            guess = 2
        ElseIf guess = 2 Then
            btnChoice09.Enabled = False
            btnChoice10.Enabled = False
            btnChoice11.Enabled = False
            btnChoice12.Enabled = False

            If btnChoice09.BackColor = btnResult01.BackColor Then
                btnResponse09.BackColor = Color.White
                btnResponse09.Visible = True
            ElseIf btnChoice09.BackColor = btnResult02.BackColor Then
                btnResponse09.BackColor = Color.Black
                btnResponse09.Visible = True
            ElseIf btnChoice09.BackColor = btnResult03.BackColor Then
                btnResponse09.BackColor = Color.Black
                btnResponse09.Visible = True
            ElseIf btnChoice09.BackColor = btnResult04.BackColor Then
                btnResponse09.BackColor = Color.Black
                btnResponse09.Visible = True
            End If

            If btnChoice10.BackColor = btnResult02.BackColor Then
                btnResponse10.BackColor = Color.White
                btnResponse10.Visible = True
            ElseIf btnChoice10.BackColor = btnResult01.BackColor Then
                btnResponse10.BackColor = Color.Black
                btnResponse10.Visible = True
            ElseIf btnChoice10.BackColor = btnResult03.BackColor Then
                btnResponse10.BackColor = Color.Black
                btnResponse10.Visible = True
            ElseIf btnChoice10.BackColor = btnResult04.BackColor Then
                btnResponse10.BackColor = Color.Black
                btnResponse10.Visible = True
            End If

            If btnChoice11.BackColor = btnResult03.BackColor Then
                btnResponse11.BackColor = Color.White
                btnResponse11.Visible = True
            ElseIf btnChoice11.BackColor = btnResult01.BackColor Then
                btnResponse11.BackColor = Color.Black
                btnResponse11.Visible = True
            ElseIf btnChoice11.BackColor = btnResult02.BackColor Then
                btnResponse11.BackColor = Color.Black
                btnResponse11.Visible = True
            ElseIf btnChoice11.BackColor = btnResult04.BackColor Then
                btnResponse11.BackColor = Color.Black
                btnResponse11.Visible = True
            End If

            If btnChoice12.BackColor = btnResult04.BackColor Then
                btnResponse12.BackColor = Color.White
                btnResponse12.Visible = True
            ElseIf btnChoice12.BackColor = btnResult01.BackColor Then
                btnResponse12.BackColor = Color.Black
                btnResponse12.Visible = True
            ElseIf btnChoice12.BackColor = btnResult02.BackColor Then
                btnResponse12.BackColor = Color.Black
                btnResponse12.Visible = True
            ElseIf btnChoice12.BackColor = btnResult03.BackColor Then
                btnResponse12.BackColor = Color.Black
                btnResponse12.Visible = True
            End If

            btnChoice13.Visible = True
            btnChoice14.Visible = True
            btnChoice15.Visible = True
            btnChoice16.Visible = True
            guess = 3
        ElseIf guess = 3 Then
            btnChoice13.Enabled = False
            btnChoice14.Enabled = False
            btnChoice15.Enabled = False
            btnChoice16.Enabled = False

            If btnChoice13.BackColor = btnResult01.BackColor Then
                btnResponse13.BackColor = Color.White
                btnResponse13.Visible = True
            ElseIf btnChoice13.BackColor = btnResult02.BackColor Then
                btnResponse13.BackColor = Color.Black
                btnResponse13.Visible = True
            ElseIf btnChoice13.BackColor = btnResult03.BackColor Then
                btnResponse13.BackColor = Color.Black
                btnResponse13.Visible = True
            ElseIf btnChoice13.BackColor = btnResult04.BackColor Then
                btnResponse13.BackColor = Color.Black
                btnResponse13.Visible = True
            End If

            If btnChoice14.BackColor = btnResult02.BackColor Then
                btnResponse14.BackColor = Color.White
                btnResponse14.Visible = True
            ElseIf btnChoice14.BackColor = btnResult01.BackColor Then
                btnResponse14.BackColor = Color.Black
                btnResponse14.Visible = True
            ElseIf btnChoice14.BackColor = btnResult03.BackColor Then
                btnResponse14.BackColor = Color.Black
                btnResponse14.Visible = True
            ElseIf btnChoice14.BackColor = btnResult04.BackColor Then
                btnResponse14.BackColor = Color.Black
                btnResponse14.Visible = True
            End If

            If btnChoice15.BackColor = btnResult03.BackColor Then
                btnResponse15.BackColor = Color.White
                btnResponse15.Visible = True
            ElseIf btnChoice15.BackColor = btnResult01.BackColor Then
                btnResponse15.BackColor = Color.Black
                btnResponse15.Visible = True
            ElseIf btnChoice15.BackColor = btnResult02.BackColor Then
                btnResponse15.BackColor = Color.Black
                btnResponse15.Visible = True
            ElseIf btnChoice15.BackColor = btnResult04.BackColor Then
                btnResponse15.BackColor = Color.Black
                btnResponse15.Visible = True
            End If

            If btnChoice16.BackColor = btnResult04.BackColor Then
                btnResponse16.BackColor = Color.White
                btnResponse16.Visible = True
            ElseIf btnChoice16.BackColor = btnResult01.BackColor Then
                btnResponse16.BackColor = Color.Black
                btnResponse16.Visible = True
            ElseIf btnChoice16.BackColor = btnResult02.BackColor Then
                btnResponse16.BackColor = Color.Black
                btnResponse16.Visible = True
            ElseIf btnChoice16.BackColor = btnResult03.BackColor Then
                btnResponse16.BackColor = Color.Black
                btnResponse16.Visible = True
            End If

            btnChoice17.Visible = True
            btnChoice18.Visible = True
            btnChoice19.Visible = True
            btnChoice20.Visible = True
            guess = 4
        ElseIf guess = 4 Then
            btnChoice17.Enabled = False
            btnChoice18.Enabled = False
            btnChoice19.Enabled = False
            btnChoice20.Enabled = False

            If btnChoice17.BackColor = btnResult01.BackColor Then
                btnResponse17.BackColor = Color.White
                btnResponse17.Visible = True
            ElseIf btnChoice17.BackColor = btnResult02.BackColor Then
                btnResponse17.BackColor = Color.Black
                btnResponse17.Visible = True
            ElseIf btnChoice17.BackColor = btnResult03.BackColor Then
                btnResponse17.BackColor = Color.Black
                btnResponse17.Visible = True
            ElseIf btnChoice17.BackColor = btnResult04.BackColor Then
                btnResponse17.BackColor = Color.Black
                btnResponse17.Visible = True
            End If

            If btnChoice18.BackColor = btnResult02.BackColor Then
                btnResponse18.BackColor = Color.White
                btnResponse18.Visible = True
            ElseIf btnChoice18.BackColor = btnResult01.BackColor Then
                btnResponse18.BackColor = Color.Black
                btnResponse18.Visible = True
            ElseIf btnChoice18.BackColor = btnResult03.BackColor Then
                btnResponse18.BackColor = Color.Black
                btnResponse18.Visible = True
            ElseIf btnChoice18.BackColor = btnResult04.BackColor Then
                btnResponse18.BackColor = Color.Black
                btnResponse18.Visible = True
            End If

            If btnChoice19.BackColor = btnResult03.BackColor Then
                btnResponse19.BackColor = Color.White
                btnResponse19.Visible = True
            ElseIf btnChoice19.BackColor = btnResult01.BackColor Then
                btnResponse19.BackColor = Color.Black
                btnResponse19.Visible = True
            ElseIf btnChoice19.BackColor = btnResult02.BackColor Then
                btnResponse19.BackColor = Color.Black
                btnResponse19.Visible = True
            ElseIf btnChoice19.BackColor = btnResult04.BackColor Then
                btnResponse19.BackColor = Color.Black
                btnResponse19.Visible = True
            End If

            If btnChoice20.BackColor = btnResult04.BackColor Then
                btnResponse20.BackColor = Color.White
                btnResponse20.Visible = True
            ElseIf btnChoice20.BackColor = btnResult01.BackColor Then
                btnResponse20.BackColor = Color.Black
                btnResponse20.Visible = True
            ElseIf btnChoice20.BackColor = btnResult02.BackColor Then
                btnResponse20.BackColor = Color.Black
                btnResponse20.Visible = True
            ElseIf btnChoice20.BackColor = btnResult03.BackColor Then
                btnResponse20.BackColor = Color.Black
                btnResponse20.Visible = True
            End If


            btnChoice21.Visible = True
            btnChoice22.Visible = True
            btnChoice23.Visible = True
            btnChoice24.Visible = True
            guess = 5
        ElseIf guess = 5 Then
            btnChoice21.Enabled = False
            btnChoice22.Enabled = False
            btnChoice23.Enabled = False
            btnChoice24.Enabled = False

            If btnChoice21.BackColor = btnResult01.BackColor Then
                btnResponse21.BackColor = Color.White
                btnResponse21.Visible = True
            ElseIf btnChoice21.BackColor = btnResult02.BackColor Then
                btnResponse21.BackColor = Color.Black
                btnResponse21.Visible = True
            ElseIf btnChoice21.BackColor = btnResult03.BackColor Then
                btnResponse21.BackColor = Color.Black
                btnResponse21.Visible = True
            ElseIf btnChoice21.BackColor = btnResult04.BackColor Then
                btnResponse21.BackColor = Color.Black
                btnResponse21.Visible = True
            End If

            If btnChoice22.BackColor = btnResult02.BackColor Then
                btnResponse22.BackColor = Color.White
                btnResponse22.Visible = True
            ElseIf btnChoice22.BackColor = btnResult01.BackColor Then
                btnResponse22.BackColor = Color.Black
                btnResponse22.Visible = True
            ElseIf btnChoice22.BackColor = btnResult03.BackColor Then
                btnResponse22.BackColor = Color.Black
                btnResponse22.Visible = True
            ElseIf btnChoice22.BackColor = btnResult04.BackColor Then
                btnResponse22.BackColor = Color.Black
                btnResponse22.Visible = True
            End If

            If btnChoice23.BackColor = btnResult03.BackColor Then
                btnResponse23.BackColor = Color.White
                btnResponse23.Visible = True
            ElseIf btnChoice23.BackColor = btnResult01.BackColor Then
                btnResponse23.BackColor = Color.Black
                btnResponse23.Visible = True
            ElseIf btnChoice23.BackColor = btnResult02.BackColor Then
                btnResponse23.BackColor = Color.Black
                btnResponse23.Visible = True
            ElseIf btnChoice23.BackColor = btnResult04.BackColor Then
                btnResponse23.BackColor = Color.Black
                btnResponse23.Visible = True
            End If

            If btnChoice24.BackColor = btnResult04.BackColor Then
                btnResponse24.BackColor = Color.White
                btnResponse24.Visible = True
            ElseIf btnChoice24.BackColor = btnResult01.BackColor Then
                btnResponse24.BackColor = Color.Black
                btnResponse24.Visible = True
            ElseIf btnChoice24.BackColor = btnResult02.BackColor Then
                btnResponse24.BackColor = Color.Black
                btnResponse24.Visible = True
            ElseIf btnChoice24.BackColor = btnResult03.BackColor Then
                btnResponse24.BackColor = Color.Black
                btnResponse24.Visible = True
            End If

            btnResult01.Visible = True
            btnResult02.Visible = True
            btnResult03.Visible = True
            btnResult04.Visible = True
            lblResult.Text = "You lose :<"
        End If

        If btnResponse01.BackColor = Color.White Then
            If btnResponse02.BackColor = Color.White Then
                If btnResponse03.BackColor = Color.White Then
                    If btnResponse04.BackColor = Color.White Then
                        finish = 1
                        btnChoice05.Enabled = False
                        btnChoice06.Enabled = False
                        btnChoice07.Enabled = False
                        btnChoice08.Enabled = False
                        btnResult01.Visible = True
                        btnResult02.Visible = True
                        btnResult03.Visible = True
                        btnResult04.Visible = True
                    End If
                End If
            End If
        End If

        If btnResponse05.BackColor = Color.White Then
            If btnResponse06.BackColor = Color.White Then
                If btnResponse07.BackColor = Color.White Then
                    If btnResponse08.BackColor = Color.White Then
                        finish = 1
                        btnChoice09.Enabled = False
                        btnChoice10.Enabled = False
                        btnChoice11.Enabled = False
                        btnChoice12.Enabled = False
                        btnResult01.Visible = True
                        btnResult02.Visible = True
                        btnResult03.Visible = True
                        btnResult04.Visible = True
                    End If
                End If
            End If
        End If

        If btnResponse09.BackColor = Color.White Then
            If btnResponse10.BackColor = Color.White Then
                If btnResponse11.BackColor = Color.White Then
                    If btnResponse12.BackColor = Color.White Then
                        finish = 1
                        btnChoice13.Enabled = False
                        btnChoice14.Enabled = False
                        btnChoice15.Enabled = False
                        btnChoice16.Enabled = False
                        btnResult01.Visible = True
                        btnResult02.Visible = True
                        btnResult03.Visible = True
                        btnResult04.Visible = True
                    End If
                End If
            End If
        End If

        If btnResponse13.BackColor = Color.White Then
            If btnResponse14.BackColor = Color.White Then
                If btnResponse15.BackColor = Color.White Then
                    If btnResponse16.BackColor = Color.White Then
                        finish = 1
                        btnChoice17.Enabled = False
                        btnChoice18.Enabled = False
                        btnChoice19.Enabled = False
                        btnChoice20.Enabled = False
                        btnResult01.Visible = True
                        btnResult02.Visible = True
                        btnResult03.Visible = True
                        btnResult04.Visible = True

                    End If
                End If
            End If
        End If

        If btnResponse17.BackColor = Color.White Then
            If btnResponse18.BackColor = Color.White Then
                If btnResponse19.BackColor = Color.White Then
                    If btnResponse20.BackColor = Color.White Then
                        finish = 1
                        btnChoice21.Enabled = False
                        btnChoice22.Enabled = False
                        btnChoice23.Enabled = False
                        btnChoice24.Enabled = False
                        btnResult01.Visible = True
                        btnResult02.Visible = True
                        btnResult03.Visible = True
                        btnResult04.Visible = True
                    End If
                End If
            End If
        End If

        If finish = 1 Then
            lblResult.Text = "Well done, you've won"

        End If

    End Sub

    Private Sub code()
        Dim randomnum As New Random
        Dim randval As Integer

        nums(0) = 1
        nums(1) = 2
        nums(2) = 3
        nums(3) = 4
        nums(4) = 5

        randval = randomnum.Next(0, nums.Length)

        If randval = 1 Then
            btnResult01.BackColor = Color.Red
            btnResult02.BackColor = Color.Yellow
            btnResult03.BackColor = Color.Blue
            btnResult04.BackColor = Color.Green
        ElseIf randval = 2 Then
            btnResult01.BackColor = Color.Yellow
            btnResult02.BackColor = Color.Purple
            btnResult03.BackColor = Color.Green
            btnResult04.BackColor = Color.Blue
        ElseIf randval = 3 Then
            btnResult01.BackColor = Color.Red
            btnResult02.BackColor = Color.Green
            btnResult03.BackColor = Color.Blue
            btnResult04.BackColor = Color.Purple
        ElseIf randval = 4 Then
            btnResult01.BackColor = Color.Green
            btnResult02.BackColor = Color.Blue
            btnResult03.BackColor = Color.Red
            btnResult04.BackColor = Color.Purple
        ElseIf randval = 5 Then
            btnResult01.BackColor = Color.Yellow
            btnResult02.BackColor = Color.Blue
            btnResult03.BackColor = Color.Purple
            btnResult04.BackColor = Color.Red
        End If
    End Sub

    Private Sub btnChoice01_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChoice01.Click
        If btnChoice01.BackColor = SystemColors.Control Then
            btnChoice01.BackColor = Color.Red
        ElseIf btnChoice01.BackColor = Color.Red Then
            btnChoice01.BackColor = Color.Blue
        ElseIf btnChoice01.BackColor = Color.Blue Then
            btnChoice01.BackColor = Color.Green
        ElseIf btnChoice01.BackColor = Color.Green Then
            btnChoice01.BackColor = Color.Yellow
        ElseIf btnChoice01.BackColor = Color.Yellow Then
            btnChoice01.BackColor = Color.Purple
        ElseIf btnChoice01.BackColor = Color.Purple Then
            btnChoice01.BackColor = SystemColors.Control
        End If
    End Sub

    Private Sub btnChoice02_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChoice02.Click
        If btnChoice02.BackColor = SystemColors.Control Then
            btnChoice02.BackColor = Color.Red
        ElseIf btnChoice02.BackColor = Color.Red Then
            btnChoice02.BackColor = Color.Blue
        ElseIf btnChoice02.BackColor = Color.Blue Then
            btnChoice02.BackColor = Color.Green
        ElseIf btnChoice02.BackColor = Color.Green Then
            btnChoice02.BackColor = Color.Yellow
        ElseIf btnChoice02.BackColor = Color.Yellow Then
            btnChoice02.BackColor = Color.Purple
        ElseIf btnChoice02.BackColor = Color.Purple Then
            btnChoice02.BackColor = SystemColors.Control
        End If
    End Sub

    Private Sub btnChoice03_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChoice03.Click
        If btnChoice03.BackColor = SystemColors.Control Then
            btnChoice03.BackColor = Color.Red
        ElseIf btnChoice03.BackColor = Color.Red Then
            btnChoice03.BackColor = Color.Blue
        ElseIf btnChoice03.BackColor = Color.Blue Then
            btnChoice03.BackColor = Color.Green
        ElseIf btnChoice03.BackColor = Color.Green Then
            btnChoice03.BackColor = Color.Yellow
        ElseIf btnChoice03.BackColor = Color.Yellow Then
            btnChoice03.BackColor = Color.Purple
        ElseIf btnChoice03.BackColor = Color.Purple Then
            btnChoice03.BackColor = SystemColors.Control
        End If
    End Sub

    Private Sub btnChoice04_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChoice04.Click
        If btnChoice04.BackColor = SystemColors.Control Then
            btnChoice04.BackColor = Color.Red
        ElseIf btnChoice04.BackColor = Color.Red Then
            btnChoice04.BackColor = Color.Blue
        ElseIf btnChoice04.BackColor = Color.Blue Then
            btnChoice04.BackColor = Color.Green
        ElseIf btnChoice04.BackColor = Color.Green Then
            btnChoice04.BackColor = Color.Yellow
        ElseIf btnChoice04.BackColor = Color.Yellow Then
            btnChoice04.BackColor = Color.Purple
        ElseIf btnChoice04.BackColor = Color.Purple Then
            btnChoice04.BackColor = SystemColors.Control
        End If
    End Sub

    Private Sub btnChoice05_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChoice05.Click
        If btnChoice05.BackColor = SystemColors.Control Then
            btnChoice05.BackColor = Color.Red
        ElseIf btnChoice05.BackColor = Color.Red Then
            btnChoice05.BackColor = Color.Blue
        ElseIf btnChoice05.BackColor = Color.Blue Then
            btnChoice05.BackColor = Color.Green
        ElseIf btnChoice05.BackColor = Color.Green Then
            btnChoice05.BackColor = Color.Yellow
        ElseIf btnChoice05.BackColor = Color.Yellow Then
            btnChoice05.BackColor = Color.Purple
        ElseIf btnChoice05.BackColor = Color.Purple Then
            btnChoice05.BackColor = SystemColors.Control
        End If
    End Sub

    Private Sub btnChoice06_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChoice06.Click
        If btnChoice06.BackColor = SystemColors.Control Then
            btnChoice06.BackColor = Color.Red
        ElseIf btnChoice06.BackColor = Color.Red Then
            btnChoice06.BackColor = Color.Blue
        ElseIf btnChoice06.BackColor = Color.Blue Then
            btnChoice06.BackColor = Color.Green
        ElseIf btnChoice06.BackColor = Color.Green Then
            btnChoice06.BackColor = Color.Yellow
        ElseIf btnChoice06.BackColor = Color.Yellow Then
            btnChoice06.BackColor = Color.Purple
        ElseIf btnChoice06.BackColor = Color.Purple Then
            btnChoice06.BackColor = SystemColors.Control
        End If
    End Sub

    Private Sub btnChoice07_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChoice07.Click
        If btnChoice07.BackColor = SystemColors.Control Then
            btnChoice07.BackColor = Color.Red
        ElseIf btnChoice07.BackColor = Color.Red Then
            btnChoice07.BackColor = Color.Blue
        ElseIf btnChoice07.BackColor = Color.Blue Then
            btnChoice07.BackColor = Color.Green
        ElseIf btnChoice07.BackColor = Color.Green Then
            btnChoice07.BackColor = Color.Yellow
        ElseIf btnChoice07.BackColor = Color.Yellow Then
            btnChoice07.BackColor = Color.Purple
        ElseIf btnChoice07.BackColor = Color.Purple Then
            btnChoice07.BackColor = SystemColors.Control
        End If
    End Sub

    Private Sub btnChoice08_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChoice08.Click
        If btnChoice08.BackColor = SystemColors.Control Then
            btnChoice08.BackColor = Color.Red
        ElseIf btnChoice08.BackColor = Color.Red Then
            btnChoice08.BackColor = Color.Blue
        ElseIf btnChoice08.BackColor = Color.Blue Then
            btnChoice08.BackColor = Color.Green
        ElseIf btnChoice08.BackColor = Color.Green Then
            btnChoice08.BackColor = Color.Yellow
        ElseIf btnChoice08.BackColor = Color.Yellow Then
            btnChoice08.BackColor = Color.Purple
        ElseIf btnChoice08.BackColor = Color.Purple Then
            btnChoice08.BackColor = SystemColors.Control
        End If
    End Sub

    Private Sub btnChoice09_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChoice09.Click
        If btnChoice09.BackColor = SystemColors.Control Then
            btnChoice09.BackColor = Color.Red
        ElseIf btnChoice09.BackColor = Color.Red Then
            btnChoice09.BackColor = Color.Blue
        ElseIf btnChoice09.BackColor = Color.Blue Then
            btnChoice09.BackColor = Color.Green
        ElseIf btnChoice09.BackColor = Color.Green Then
            btnChoice09.BackColor = Color.Yellow
        ElseIf btnChoice09.BackColor = Color.Yellow Then
            btnChoice09.BackColor = Color.Purple
        ElseIf btnChoice09.BackColor = Color.Purple Then
            btnChoice09.BackColor = SystemColors.Control
        End If
    End Sub

    Private Sub btnChoice10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChoice10.Click
        If btnChoice10.BackColor = SystemColors.Control Then
            btnChoice10.BackColor = Color.Red
        ElseIf btnChoice10.BackColor = Color.Red Then
            btnChoice10.BackColor = Color.Blue
        ElseIf btnChoice10.BackColor = Color.Blue Then
            btnChoice10.BackColor = Color.Green
        ElseIf btnChoice10.BackColor = Color.Green Then
            btnChoice10.BackColor = Color.Yellow
        ElseIf btnChoice10.BackColor = Color.Yellow Then
            btnChoice10.BackColor = Color.Purple
        ElseIf btnChoice10.BackColor = Color.Purple Then
            btnChoice10.BackColor = SystemColors.Control
        End If
    End Sub

    Private Sub btnChoice11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChoice11.Click
        If btnChoice11.BackColor = SystemColors.Control Then
            btnChoice11.BackColor = Color.Red
        ElseIf btnChoice11.BackColor = Color.Red Then
            btnChoice11.BackColor = Color.Blue
        ElseIf btnChoice11.BackColor = Color.Blue Then
            btnChoice11.BackColor = Color.Green
        ElseIf btnChoice11.BackColor = Color.Green Then
            btnChoice11.BackColor = Color.Yellow
        ElseIf btnChoice11.BackColor = Color.Yellow Then
            btnChoice11.BackColor = Color.Purple
        ElseIf btnChoice11.BackColor = Color.Purple Then
            btnChoice11.BackColor = SystemColors.Control
        End If
    End Sub

    Private Sub btnChoice12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChoice12.Click
        If btnChoice12.BackColor = SystemColors.Control Then
            btnChoice12.BackColor = Color.Red
        ElseIf btnChoice12.BackColor = Color.Red Then
            btnChoice12.BackColor = Color.Blue
        ElseIf btnChoice12.BackColor = Color.Blue Then
            btnChoice12.BackColor = Color.Green
        ElseIf btnChoice12.BackColor = Color.Green Then
            btnChoice12.BackColor = Color.Yellow
        ElseIf btnChoice12.BackColor = Color.Yellow Then
            btnChoice12.BackColor = Color.Purple
        ElseIf btnChoice12.BackColor = Color.Purple Then
            btnChoice12.BackColor = SystemColors.Control
        End If
    End Sub

    Private Sub btnChoice13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChoice13.Click
        If btnChoice13.BackColor = SystemColors.Control Then
            btnChoice13.BackColor = Color.Red
        ElseIf btnChoice13.BackColor = Color.Red Then
            btnChoice13.BackColor = Color.Blue
        ElseIf btnChoice13.BackColor = Color.Blue Then
            btnChoice13.BackColor = Color.Green
        ElseIf btnChoice13.BackColor = Color.Green Then
            btnChoice13.BackColor = Color.Yellow
        ElseIf btnChoice13.BackColor = Color.Yellow Then
            btnChoice13.BackColor = Color.Purple
        ElseIf btnChoice13.BackColor = Color.Purple Then
            btnChoice13.BackColor = SystemColors.Control
        End If
    End Sub

    Private Sub btnChoice14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChoice14.Click
        If btnChoice14.BackColor = SystemColors.Control Then
            btnChoice14.BackColor = Color.Red
        ElseIf btnChoice14.BackColor = Color.Red Then
            btnChoice14.BackColor = Color.Blue
        ElseIf btnChoice14.BackColor = Color.Blue Then
            btnChoice14.BackColor = Color.Green
        ElseIf btnChoice14.BackColor = Color.Green Then
            btnChoice14.BackColor = Color.Yellow
        ElseIf btnChoice14.BackColor = Color.Yellow Then
            btnChoice14.BackColor = Color.Purple
        ElseIf btnChoice14.BackColor = Color.Purple Then
            btnChoice14.BackColor = SystemColors.Control
        End If
    End Sub

    Private Sub btnChoice15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChoice15.Click
        If btnChoice15.BackColor = SystemColors.Control Then
            btnChoice15.BackColor = Color.Red
        ElseIf btnChoice15.BackColor = Color.Red Then
            btnChoice15.BackColor = Color.Blue
        ElseIf btnChoice15.BackColor = Color.Blue Then
            btnChoice15.BackColor = Color.Green
        ElseIf btnChoice15.BackColor = Color.Green Then
            btnChoice15.BackColor = Color.Yellow
        ElseIf btnChoice15.BackColor = Color.Yellow Then
            btnChoice15.BackColor = Color.Purple
        ElseIf btnChoice15.BackColor = Color.Purple Then
            btnChoice15.BackColor = SystemColors.Control
        End If
    End Sub

    Private Sub btnChoice16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChoice16.Click
        If btnChoice16.BackColor = SystemColors.Control Then
            btnChoice16.BackColor = Color.Red
        ElseIf btnChoice16.BackColor = Color.Red Then
            btnChoice16.BackColor = Color.Blue
        ElseIf btnChoice16.BackColor = Color.Blue Then
            btnChoice16.BackColor = Color.Green
        ElseIf btnChoice16.BackColor = Color.Green Then
            btnChoice16.BackColor = Color.Yellow
        ElseIf btnChoice16.BackColor = Color.Yellow Then
            btnChoice16.BackColor = Color.Purple
        ElseIf btnChoice16.BackColor = Color.Purple Then
            btnChoice16.BackColor = SystemColors.Control
        End If
    End Sub

    Private Sub btnChoice17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChoice17.Click
        If btnChoice17.BackColor = SystemColors.Control Then
            btnChoice17.BackColor = Color.Red
        ElseIf btnChoice17.BackColor = Color.Red Then
            btnChoice17.BackColor = Color.Blue
        ElseIf btnChoice17.BackColor = Color.Blue Then
            btnChoice17.BackColor = Color.Green
        ElseIf btnChoice17.BackColor = Color.Green Then
            btnChoice17.BackColor = Color.Yellow
        ElseIf btnChoice17.BackColor = Color.Yellow Then
            btnChoice17.BackColor = Color.Purple
        ElseIf btnChoice17.BackColor = Color.Purple Then
            btnChoice17.BackColor = SystemColors.Control
        End If
    End Sub

    Private Sub btnChoice18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChoice18.Click
        If btnChoice18.BackColor = SystemColors.Control Then
            btnChoice18.BackColor = Color.Red
        ElseIf btnChoice18.BackColor = Color.Red Then
            btnChoice18.BackColor = Color.Blue
        ElseIf btnChoice18.BackColor = Color.Blue Then
            btnChoice18.BackColor = Color.Green
        ElseIf btnChoice18.BackColor = Color.Green Then
            btnChoice18.BackColor = Color.Yellow
        ElseIf btnChoice18.BackColor = Color.Yellow Then
            btnChoice18.BackColor = Color.Purple
        ElseIf btnChoice18.BackColor = Color.Purple Then
            btnChoice18.BackColor = SystemColors.Control
        End If
    End Sub

    Private Sub btnChoice19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChoice19.Click
        If btnChoice19.BackColor = SystemColors.Control Then
            btnChoice19.BackColor = Color.Red
        ElseIf btnChoice19.BackColor = Color.Red Then
            btnChoice19.BackColor = Color.Blue
        ElseIf btnChoice19.BackColor = Color.Blue Then
            btnChoice19.BackColor = Color.Green
        ElseIf btnChoice19.BackColor = Color.Green Then
            btnChoice19.BackColor = Color.Yellow
        ElseIf btnChoice19.BackColor = Color.Yellow Then
            btnChoice19.BackColor = Color.Purple
        ElseIf btnChoice19.BackColor = Color.Purple Then
            btnChoice19.BackColor = SystemColors.Control
        End If
    End Sub

    Private Sub btnChoice20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChoice20.Click
        If btnChoice20.BackColor = SystemColors.Control Then
            btnChoice20.BackColor = Color.Red
        ElseIf btnChoice20.BackColor = Color.Red Then
            btnChoice20.BackColor = Color.Blue
        ElseIf btnChoice20.BackColor = Color.Blue Then
            btnChoice20.BackColor = Color.Green
        ElseIf btnChoice20.BackColor = Color.Green Then
            btnChoice20.BackColor = Color.Yellow
        ElseIf btnChoice20.BackColor = Color.Yellow Then
            btnChoice20.BackColor = Color.Purple
        ElseIf btnChoice20.BackColor = Color.Purple Then
            btnChoice20.BackColor = SystemColors.Control
        End If
    End Sub

    Private Sub btnChoice21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChoice21.Click
        If btnChoice21.BackColor = SystemColors.Control Then
            btnChoice21.BackColor = Color.Red
        ElseIf btnChoice21.BackColor = Color.Red Then
            btnChoice21.BackColor = Color.Blue
        ElseIf btnChoice21.BackColor = Color.Blue Then
            btnChoice21.BackColor = Color.Green
        ElseIf btnChoice21.BackColor = Color.Green Then
            btnChoice21.BackColor = Color.Yellow
        ElseIf btnChoice21.BackColor = Color.Yellow Then
            btnChoice21.BackColor = Color.Purple
        ElseIf btnChoice21.BackColor = Color.Purple Then
            btnChoice21.BackColor = SystemColors.Control
        End If
    End Sub

    Private Sub btnChoice22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChoice22.Click
        If btnChoice22.BackColor = SystemColors.Control Then
            btnChoice22.BackColor = Color.Red
        ElseIf btnChoice22.BackColor = Color.Red Then
            btnChoice22.BackColor = Color.Blue
        ElseIf btnChoice22.BackColor = Color.Blue Then
            btnChoice22.BackColor = Color.Green
        ElseIf btnChoice22.BackColor = Color.Green Then
            btnChoice22.BackColor = Color.Yellow
        ElseIf btnChoice22.BackColor = Color.Yellow Then
            btnChoice22.BackColor = Color.Purple
        ElseIf btnChoice22.BackColor = Color.Purple Then
            btnChoice22.BackColor = SystemColors.Control
        End If
    End Sub

    Private Sub btnChoice23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChoice23.Click
        If btnChoice23.BackColor = SystemColors.Control Then
            btnChoice23.BackColor = Color.Red
        ElseIf btnChoice23.BackColor = Color.Red Then
            btnChoice23.BackColor = Color.Blue
        ElseIf btnChoice23.BackColor = Color.Blue Then
            btnChoice23.BackColor = Color.Green
        ElseIf btnChoice23.BackColor = Color.Green Then
            btnChoice23.BackColor = Color.Yellow
        ElseIf btnChoice23.BackColor = Color.Yellow Then
            btnChoice23.BackColor = Color.Purple
        ElseIf btnChoice23.BackColor = Color.Purple Then
            btnChoice23.BackColor = SystemColors.Control
        End If
    End Sub

    Private Sub btnChoice24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChoice24.Click
        If btnChoice24.BackColor = SystemColors.Control Then
            btnChoice24.BackColor = Color.Red
        ElseIf btnChoice24.BackColor = Color.Red Then
            btnChoice24.BackColor = Color.Blue
        ElseIf btnChoice24.BackColor = Color.Blue Then
            btnChoice24.BackColor = Color.Green
        ElseIf btnChoice24.BackColor = Color.Green Then
            btnChoice24.BackColor = Color.Yellow
        ElseIf btnChoice24.BackColor = Color.Yellow Then
            btnChoice24.BackColor = Color.Purple
        ElseIf btnChoice24.BackColor = Color.Purple Then
            btnChoice24.BackColor = SystemColors.Control
        End If
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        code()
    End Sub

   

End Class