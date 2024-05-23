Imports System.IO
Imports System.Drawing
Imports System.Windows.Forms.DataVisualization.Charting
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.Text.RegularExpressions
Imports Microsoft.VisualBasic.ApplicationServices

Public Class Form1
    Private users As New Dictionary(Of String, User)()

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add event handlers
        AddHandler Me.btnLoginMain.Click, AddressOf Me.btnLoginMain_Click
        AddHandler Me.btnSignUpMain.Click, AddressOf Me.btnSignUpMain_Click
        AddHandler Me.btnLogin.Click, AddressOf Me.btnLogin_Click
        AddHandler Me.btnSignUp.Click, AddressOf Me.btnSignUp_Click
        AddHandler Me.btnBackToMainFromLogin.Click, AddressOf Me.btnBackToMainFromLogin_Click
        AddHandler Me.btnBackToMainFromSignUp.Click, AddressOf Me.btnBackToMainFromSignUp_Click
        AddHandler Me.btnUpdateUserInfo.Click, AddressOf Me.btnUpdateUserInfo_Click
        AddHandler Me.btnBackToMainFromUserInfo.Click, AddressOf Me.btnBackToMainFromUserInfo_Click
    End Sub

    Private Sub btnLoginMain_Click(sender As Object, e As EventArgs)
        pnlMain.Visible = False
        pnlLogin.Visible = True
    End Sub

    Private Sub btnSignUpMain_Click(sender As Object, e As EventArgs)
        pnlMain.Visible = False
        pnlSignUp.Visible = True
    End Sub

    Private Sub btnBackToMainFromLogin_Click(sender As Object, e As EventArgs)
        pnlLogin.Visible = False
        pnlMain.Visible = True
    End Sub

    Private Sub btnBackToMainFromSignUp_Click(sender As Object, e As EventArgs)
        pnlSignUp.Visible = False
        pnlMain.Visible = True
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs)
        Dim name As String = txtSignUpName.Text
        Dim username As String = txtSignUpUsername.Text
        Dim password As String = txtSignUpPassword.Text
        Dim email As String = txtSignUpEmail.Text

        If Not ValidatePassword(password) Then
            MessageBox.Show("Password must be at least 8 characters long and include a capital letter, a special character, and a number.")
            Return
        End If

        If String.IsNullOrEmpty(name) OrElse String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) OrElse String.IsNullOrEmpty(email) Then
            MessageBox.Show("Please fill all fields and select a photo.")
            Return
        End If

        If users.ContainsKey(username) Then
            MessageBox.Show("Username is already taken.")
            Return
        End If

        ' Create a new user and add to dictionary
        Dim newUser As New User(name, username, password, email)
        users.Add(username, newUser)

        MessageBox.Show("User registered successfully!")
        ClearSignUpFields()
        pnlSignUp.Visible = False
        pnlMain.Visible = True
    End Sub

    Private Function ValidatePassword(password As String) As Boolean
        Dim regex As New Regex("^(?=.*[A-Z])(?=.*[!@#$%^&*])(?=.*\d).{8,}$")
        Return regex.IsMatch(password)
    End Function

    Private Sub btnLogin_Click(sender As Object, e As EventArgs)
        Dim username As String = txtLoginUsername.Text
        Dim password As String = txtLoginPassword.Text

        If users.ContainsKey(username) AndAlso users(username).Password = password Then
            MessageBox.Show("Authentication successful!")
            ShowUserInfo(users(username))
            pnlLogin.Visible = False
            pnlUserInfo.Visible = True
        Else
            MessageBox.Show("Invalid username or password.")
        End If
    End Sub

    Private Sub ShowUserInfo(user As User)
        lblUserName.Text = user.Name
    End Sub

    Private Sub btnUpdateUserInfo_Click(sender As Object, e As EventArgs)
        Dim username As String = txtLoginUsername.Text

        If users.ContainsKey(username) Then
            ' Update user info logic
            MessageBox.Show("User information updated successfully!")
        Else
            MessageBox.Show("User not found.")
        End If
    End Sub

    Private Sub ClearSignUpFields()
        txtSignUpName.Text = ""
        txtSignUpUsername.Text = ""
        txtSignUpPassword.Text = ""
        txtSignUpEmail.Text = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize and add the chartPanel if it doesn't exist
        Dim chartPanel As New Panel()
        chartPanel.Name = "chartPanel"
        chartPanel.Size = New Size(600, 400)
        chartPanel.Location = New Point(10, 10) ' Adjust the location as needed
        Me.Controls.Add(chartPanel)
    End Sub

    Private Sub btnBackToMainFromUserInfo_Click(sender As Object, e As EventArgs)
        pnlUserInfo.Visible = False
        pnlMain.Visible = True
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles CF.TextChanged
        ' Handle text change
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs)
        Dim CFv As Double
        Dim CVv As Double
        Dim FIv As Double
        Dim VIv As Double
        Dim duration As Integer
        Dim Montant As Double
        Dim surplus As Double
        Dim quotient As Double

        Try
            CFv = Convert.ToDouble(CF.Text)
            CVv = Convert.ToDouble(CV.Text)
            FIv = Convert.ToDouble(FI.Text)
            VIv = Convert.ToDouble(VI.Text)
            Montant = Convert.ToDouble(savings.Text)
            duration = Convert.ToInt32(duree.Text)
        Catch ex As Exception
            MessageBox.Show("Veuillez entrer des valeurs valides.")
            Exit Sub
        End Try

        surplus = FIv + VIv - (CFv + CVv)
        quotient = Montant / duration

        If surplus < quotient Then
            MessageBox.Show("Non faisable")
        Else
            MessageBox.Show("Il faut épargner " & quotient.ToString("F2") & " par mois")
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs)
        ' CSV export logic here
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "CSV Files|*.csv"
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = saveFileDialog.FileName
            Using writer As New StreamWriter(filePath)
                ' Write CSV headers
                writer.WriteLine("Name,Username,Email")
                ' Write user data
                For Each user As User In users.Values
                    writer.WriteLine($"{user.Name},{user.Username},{user.Email}")
                Next
            End Using
            MessageBox.Show("User data exported to CSV successfully.")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "PDF Files|*.pdf"
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = saveFileDialog.FileName
            Dim doc As New Document()
            PdfWriter.GetInstance(doc, New FileStream(filePath, FileMode.Create))
            doc.Open()
            doc.Add(New iTextSharp.text.Paragraph("Sample PDF Document"))
            doc.Close()
            MessageBox.Show("PDF generated successfully.")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim chart As New Chart()
        chart.Size = New Size(600, 400)
        Dim chartArea As New ChartArea()
        chart.ChartAreas.Add(chartArea)

        Dim series As New Series()
        series.ChartType = SeriesChartType.Line
        series.Points.AddXY(1, 10)
        series.Points.AddXY(2, 20)
        series.Points.AddXY(3, 30)
        chart.Series.Add(series)

        ' Ensure that the chartPanel is declared and exists on the form
        If Me.Controls.ContainsKey("chartPanel") Then
            Dim chartPanel As Panel = CType(Me.Controls("chartPanel"), Panel)
            chartPanel.Controls.Add(chart)
            MessageBox.Show("Graph plotted successfully.")
        Else
            MessageBox.Show("chartPanel is not defined on the form.")
        End If
    End Sub




End Class
Public Class User
    Public Property Name As String
    Public Property Username As String
    Public Property Password As String
    Public Property Email As String
    Public Property Loisir As String
    Public Property Sexe As String
    Public Property School As String

    Public Sub New(name As String, username As String, password As String, email As String)
        Me.Name = name
        Me.Username = username
        Me.Password = password
        Me.Email = email
    End Sub
End Class