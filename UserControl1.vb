Imports System.Threading

Public Class ColorPalette
    'Variable to pick colors
    Public Colour1, Colour2 As New Color
    'This shows the active color(Colour1 or Colour2)
    Dim w As Boolean = True

    Private Sub TrackBarRed_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBarRed.Scroll
        Panel1.Select() 'To set panel selcted if not trackbar get selected
        txtR.Text = TrackBarRed.Value 'Change value on textbox according to value of trackbar
        SetColor1() 'Set the color to COLOR1 or COLOR2
        UpdateIndicator() 'Update the color indicator
    End Sub

    Private Sub TrackBarGreen_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBarGreen.Scroll
        Panel1.Select() 'To set panel selcted if not trackbar get selected
        txtG.Text = TrackBarGreen.Value 'Change value on textbox according to value of trackbar
        SetColor1() 'Set the color to COLOR1 or COLOR2
        UpdateIndicator() 'Update the color indicator
    End Sub

    Private Sub TrackBarBlue_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBarBlue.Scroll
        Panel1.Select() 'To set panel selcted if not trackbar get selected
        txtB.Text = TrackBarBlue.Value 'Change value on textbox according to value of trackbar
        SetColor1() 'Set the color to COLOR1 or COLOR2
        UpdateIndicator() 'Update the color indicator
    End Sub

    Private Sub txtR_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtR.TextChanged
        txtR.Text = ValidateText(txtR.Text) 'Validate the text-Check whether the input is numeric and between 0 & 256
        TrackBarRed.Value = Val(txtR.Text)  'Change value on trackbar according to value of textbox
        SetColor2() 'Set the color to COLOR1 or COLOR2
        UpdateIndicator() 'Update the color indicator
    End Sub

    Private Sub txtG_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtG.TextChanged
        txtG.Text = ValidateText(txtG.Text) 'Validate the text-Check whether the input is numeric and between 0 & 256
        TrackBarGreen.Value = txtG.Text  'Change value on trackbar according to value of textbox
        SetColor2() 'Set the color to COLOR1 or COLOR2
        UpdateIndicator() 'Update the color indicator
    End Sub

    Private Sub txtB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtB.TextChanged
        txtB.Text = ValidateText(txtB.Text) 'Validate the text-Check whether the input is numeric and between 0 & 256
        TrackBarBlue.Value = txtB.Text  'Change value on trackbar according to value of textbox
        SetColor2() 'Set the color to COLOR1 or COLOR2
        UpdateIndicator() 'Update the color indicator
    End Sub

    Private Sub ColorBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorBox1.Click
        Panel1.Select() 'To set panel selcted if not trackbar get selected

        w = True 'Set w true telling colour1 is selected
        ColorBox1.BringToFront() 'Bring colorbox to front

        ''''''''''Set values of track bars & text boxes accoring to color in colorbox
        Dim r As Byte = Colour1.R
        Dim g As Byte = Colour1.G
        Dim b As Byte = Colour1.B

        TrackBarRed.Value = Convert.ToInt32(r)
        txtR.Text = Convert.ToString(r)

        TrackBarGreen.Value = Convert.ToInt32(g)
        txtG.Text = Convert.ToString(g)

        TrackBarBlue.Value = Convert.ToInt32(b)
        txtB.Text = Convert.ToString(b)


        UpdateIndicator() 'Update the color indicator
    End Sub

    Private Sub ColorBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorBox2.Click
        Panel1.Select() 'To set panel selcted if not trackbar get selected

        w = False 'Set w true telling colour1 is selected
        ColorBox2.BringToFront() 'Bring colorbox to front

        ''''''''''Set values of track bars & text boxes accoring to color in colorbox
        Dim r As Byte = Colour2.R
        Dim g As Byte = Colour2.G
        Dim b As Byte = Colour2.B

        TrackBarRed.Value = Convert.ToInt32(r)
        txtR.Text = Convert.ToString(r)

        TrackBarGreen.Value = Convert.ToInt32(g)
        txtG.Text = Convert.ToString(g)

        TrackBarBlue.Value = Convert.ToInt32(b)
        txtB.Text = Convert.ToString(b)

        UpdateIndicator() 'Update the color indicator
    End Sub

    Private Function ValidateText(ByVal s As String) As String
        Dim tmp As String = ""

        'Get all numeric characters entered to textbox
        For Each C As Char In s
            If Char.IsDigit(C) Then
                tmp = tmp + C
            End If
        Next

        'Check whether the vaalue is <256 or >0
        If Val(tmp) > 255 Then
            Return 255 'If the value is greater than the largest value 255 is returned
        ElseIf Val(tmp) < 0 Then
            Return 0 'If the value is smaller than the smaller value 0 is returned
        End If

        If tmp.StartsWith("0") Then
            tmp = tmp.Remove(0, 1)
        End If

        If tmp.Length < 1 Then
            tmp = "0"
        End If

        Return tmp
    End Function

    Private Sub SetColor1()
        'Set selected color to colour1 or colour2
        If w = True Then
            ColorBox1.BackColor = Color.FromArgb(TrackBarRed.Value, TrackBarGreen.Value, TrackBarBlue.Value)
        Else
            ColorBox2.BackColor = Color.FromArgb(TrackBarRed.Value, TrackBarGreen.Value, TrackBarBlue.Value)
        End If
        Colour1 = ColorBox1.BackColor
        Colour2 = ColorBox2.BackColor
    End Sub

    Private Sub SetColor2()
        'Set selected color to colour1 or colour2
        If w = True Then
            ColorBox1.BackColor = Color.FromArgb(Val(txtR.Text), Val(txtG.Text), Val(txtB.Text))
        Else
            ColorBox2.BackColor = Color.FromArgb(Val(txtR.Text), Val(txtG.Text), Val(txtB.Text))
        End If
        Colour1 = ColorBox1.BackColor
        Colour2 = ColorBox2.BackColor
    End Sub

    Private Sub UpdateIndicator()
        Dim t As Thread = New Thread(AddressOf DrawImages) With {.IsBackground = True, .Name = "DrawI"}
        t.Start()
    End Sub

    Dim hexa As String

    Private Sub DrawImages()
        '''''''DRAW BITMAPS AND SET THEM AS BACKGROUNDS OF THE INDICATORS'''''''

        Dim r As New Bitmap(256, 25)
        Dim g As New Bitmap(256, 25)
        Dim b As New Bitmap(256, 25)

        Dim s1, s2, s3 As String


        If w = True Then
            For i As Integer = 0 To 255
                For j As Integer = 0 To 24
                    r.SetPixel(i, j, Color.FromArgb(i, Colour1.G, Colour1.B))
                    g.SetPixel(i, j, Color.FromArgb(Colour1.R, i, Colour1.B))
                    b.SetPixel(i, j, Color.FromArgb(Colour1.R, Colour1.G, i))
                Next
            Next
            s1 = Hex(Val(Colour1.R))
            s2 = Hex(Val(Colour1.G))
            s3 = Hex(Val(Colour1.B))
        Else
            For i As Integer = 0 To 255
                For j As Integer = 0 To 24
                    r.SetPixel(i, j, Color.FromArgb(i, Colour2.G, Colour2.B))
                    g.SetPixel(i, j, Color.FromArgb(Colour2.R, i, Colour2.B))
                    b.SetPixel(i, j, Color.FromArgb(Colour2.R, Colour2.G, i))
                Next
            Next
            s1 = Hex(Val(Colour2.R))
            s2 = Hex(Val(Colour2.G))
            s3 = Hex(Val(Colour2.B))
        End If

        If s1.Length = 1 Then
            s1 = "0" + s1
        End If
        If s2.Length = 1 Then
            s2 = "0" + s2
        End If
        If s3.Length = 1 Then
            s3 = "0" + s3
        End If

        ImageRed.BackgroundImage = r
        ImageGreen.BackgroundImage = g
        ImageBlue.BackgroundImage = b
        hexa = s1 + s2 + s3
    End Sub

    Private Sub ColorPalette_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        txtARGB.Text = hexa
    End Sub

End Class
