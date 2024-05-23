Partial Class Form1
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    ' Declare the form controls
    Private pnlMain As Panel
    Private pnlLogin As Panel
    Private pnlSignUp As Panel
    Private pnlUserInfo As Panel

    Private btnLoginMain As Button
    Private btnSignUpMain As Button
    Private lblPasswordCriteria As Label
    Private lblLoginUsername As Label
    Private txtLoginUsername As TextBox
    Private lblLoginPassword As Label
    Private txtLoginPassword As TextBox
    Private btnLogin As Button
    Private btnBackToMainFromLogin As Button

    Private lblSignUpName As Label
    Private txtSignUpName As TextBox
    Private lblSignUpUsername As Label
    Private txtSignUpUsername As TextBox
    Private lblSignUpPassword As Label
    Private txtSignUpPassword As TextBox
    Private lblSignUpEmail As Label
    Private txtSignUpEmail As TextBox
    Private btnSignUp As Button
    Private btnBackToMainFromSignUp As Button

    Private lblUserName As Label
    Private lblUserLoisir As Label
    Private lblUserSexe As Label
    Private lblUserSchool As Label
    Private btnUpdateUserInfo As Button
    Private lblWelcome As Label
    Private btnBackToMainFromUserInfo As Button
    Private Sub InitializeComponent()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.btnLoginMain = New System.Windows.Forms.Button()
        Me.btnSignUpMain = New System.Windows.Forms.Button()
        Me.pnlLogin = New System.Windows.Forms.Panel()
        Me.lblLoginUsername = New System.Windows.Forms.Label()
        Me.txtLoginUsername = New System.Windows.Forms.TextBox()
        Me.lblLoginPassword = New System.Windows.Forms.Label()
        Me.txtLoginPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnBackToMainFromLogin = New System.Windows.Forms.Button()
        Me.pnlSignUp = New System.Windows.Forms.Panel()
        Me.btnBackToMainFromSignUp = New System.Windows.Forms.Button()
        Me.lblSignUpName = New System.Windows.Forms.Label()
        Me.txtSignUpName = New System.Windows.Forms.TextBox()
        Me.lblSignUpUsername = New System.Windows.Forms.Label()
        Me.txtSignUpUsername = New System.Windows.Forms.TextBox()
        Me.lblSignUpPassword = New System.Windows.Forms.Label()
        Me.txtSignUpPassword = New System.Windows.Forms.TextBox()
        Me.lblSignUpEmail = New System.Windows.Forms.Label()
        Me.txtSignUpEmail = New System.Windows.Forms.TextBox()
        Me.btnSignUp = New System.Windows.Forms.Button()
        Me.lblPasswordCriteria = New System.Windows.Forms.Label()
        Me.pnlUserInfo = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CSV_expo = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.duree = New System.Windows.Forms.TextBox()
        Me.CF = New System.Windows.Forms.TextBox()
        Me.CV = New System.Windows.Forms.TextBox()
        Me.FI = New System.Windows.Forms.TextBox()
        Me.VI = New System.Windows.Forms.TextBox()
        Me.savings = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.btnBackToMainFromUserInfo = New System.Windows.Forms.Button()
        Me.lblUserLoisir = New System.Windows.Forms.Label()
        Me.lblUserSexe = New System.Windows.Forms.Label()
        Me.lblUserSchool = New System.Windows.Forms.Label()
        Me.btnUpdateUserInfo = New System.Windows.Forms.Button()
        Me.pnlMain.SuspendLayout()
        Me.pnlLogin.SuspendLayout()
        Me.pnlSignUp.SuspendLayout()
        Me.pnlUserInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lblWelcome.Location = New System.Drawing.Point(287, 469)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(630, 65)
        Me.lblWelcome.TabIndex = 2
        Me.lblWelcome.Text = "💸 money  🤑  money 💸"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.pnlMain.Controls.Add(Me.btnLoginMain)
        Me.pnlMain.Controls.Add(Me.btnSignUpMain)
        Me.pnlMain.Controls.Add(Me.lblWelcome)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1069, 670)
        Me.pnlMain.TabIndex = 0
        '
        'btnLoginMain
        '
        Me.btnLoginMain.BackColor = System.Drawing.Color.Goldenrod
        Me.btnLoginMain.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnLoginMain.ForeColor = System.Drawing.Color.White
        Me.btnLoginMain.Location = New System.Drawing.Point(161, 203)
        Me.btnLoginMain.Name = "btnLoginMain"
        Me.btnLoginMain.Size = New System.Drawing.Size(210, 128)
        Me.btnLoginMain.TabIndex = 0
        Me.btnLoginMain.Text = "Login"
        Me.btnLoginMain.UseVisualStyleBackColor = False
        '
        'btnSignUpMain
        '
        Me.btnSignUpMain.BackColor = System.Drawing.Color.Goldenrod
        Me.btnSignUpMain.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSignUpMain.ForeColor = System.Drawing.Color.White
        Me.btnSignUpMain.Location = New System.Drawing.Point(839, 203)
        Me.btnSignUpMain.Name = "btnSignUpMain"
        Me.btnSignUpMain.Size = New System.Drawing.Size(220, 128)
        Me.btnSignUpMain.TabIndex = 1
        Me.btnSignUpMain.Text = "Sign Up"
        Me.btnSignUpMain.UseVisualStyleBackColor = False
        '
        'pnlLogin
        '
        Me.pnlLogin.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.pnlLogin.Controls.Add(Me.lblLoginUsername)
        Me.pnlLogin.Controls.Add(Me.txtLoginUsername)
        Me.pnlLogin.Controls.Add(Me.lblLoginPassword)
        Me.pnlLogin.Controls.Add(Me.txtLoginPassword)
        Me.pnlLogin.Controls.Add(Me.btnLogin)
        Me.pnlLogin.Controls.Add(Me.btnBackToMainFromLogin)
        Me.pnlLogin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlLogin.Location = New System.Drawing.Point(0, 0)
        Me.pnlLogin.Name = "pnlLogin"
        Me.pnlLogin.Size = New System.Drawing.Size(1069, 670)
        Me.pnlLogin.TabIndex = 1
        Me.pnlLogin.Visible = False
        '
        'lblLoginUsername
        '
        Me.lblLoginUsername.Font = New System.Drawing.Font("Segoe UI Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoginUsername.Location = New System.Drawing.Point(36, 94)
        Me.lblLoginUsername.Name = "lblLoginUsername"
        Me.lblLoginUsername.Size = New System.Drawing.Size(133, 40)
        Me.lblLoginUsername.TabIndex = 0
        Me.lblLoginUsername.Text = "Username"
        '
        'txtLoginUsername
        '
        Me.txtLoginUsername.Location = New System.Drawing.Point(226, 78)
        Me.txtLoginUsername.Multiline = True
        Me.txtLoginUsername.Name = "txtLoginUsername"
        Me.txtLoginUsername.Size = New System.Drawing.Size(539, 56)
        Me.txtLoginUsername.TabIndex = 1
        '
        'lblLoginPassword
        '
        Me.lblLoginPassword.Font = New System.Drawing.Font("Segoe UI Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoginPassword.Location = New System.Drawing.Point(36, 203)
        Me.lblLoginPassword.Name = "lblLoginPassword"
        Me.lblLoginPassword.Size = New System.Drawing.Size(133, 37)
        Me.lblLoginPassword.TabIndex = 2
        Me.lblLoginPassword.Text = "Password"
        '
        'txtLoginPassword
        '
        Me.txtLoginPassword.Location = New System.Drawing.Point(226, 187)
        Me.txtLoginPassword.Multiline = True
        Me.txtLoginPassword.Name = "txtLoginPassword"
        Me.txtLoginPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtLoginPassword.Size = New System.Drawing.Size(539, 56)
        Me.txtLoginPassword.TabIndex = 3
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Goldenrod
        Me.btnLogin.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(371, 425)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(182, 78)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'btnBackToMainFromLogin
        '
        Me.btnBackToMainFromLogin.BackColor = System.Drawing.Color.Purple
        Me.btnBackToMainFromLogin.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnBackToMainFromLogin.ForeColor = System.Drawing.Color.White
        Me.btnBackToMainFromLogin.Location = New System.Drawing.Point(829, 477)
        Me.btnBackToMainFromLogin.Name = "btnBackToMainFromLogin"
        Me.btnBackToMainFromLogin.Size = New System.Drawing.Size(203, 69)
        Me.btnBackToMainFromLogin.TabIndex = 5
        Me.btnBackToMainFromLogin.Text = "Back"
        Me.btnBackToMainFromLogin.UseVisualStyleBackColor = False
        '
        'pnlSignUp
        '
        Me.pnlSignUp.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.pnlSignUp.Controls.Add(Me.btnBackToMainFromSignUp)
        Me.pnlSignUp.Controls.Add(Me.lblSignUpName)
        Me.pnlSignUp.Controls.Add(Me.txtSignUpName)
        Me.pnlSignUp.Controls.Add(Me.lblSignUpUsername)
        Me.pnlSignUp.Controls.Add(Me.txtSignUpUsername)
        Me.pnlSignUp.Controls.Add(Me.lblSignUpPassword)
        Me.pnlSignUp.Controls.Add(Me.txtSignUpPassword)
        Me.pnlSignUp.Controls.Add(Me.lblSignUpEmail)
        Me.pnlSignUp.Controls.Add(Me.txtSignUpEmail)
        Me.pnlSignUp.Controls.Add(Me.btnSignUp)
        Me.pnlSignUp.Controls.Add(Me.lblPasswordCriteria)
        Me.pnlSignUp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSignUp.Location = New System.Drawing.Point(0, 0)
        Me.pnlSignUp.Name = "pnlSignUp"
        Me.pnlSignUp.Size = New System.Drawing.Size(1069, 670)
        Me.pnlSignUp.TabIndex = 2
        Me.pnlSignUp.Visible = False
        '
        'btnBackToMainFromSignUp
        '
        Me.btnBackToMainFromSignUp.BackColor = System.Drawing.Color.Purple
        Me.btnBackToMainFromSignUp.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnBackToMainFromSignUp.ForeColor = System.Drawing.Color.White
        Me.btnBackToMainFromSignUp.Location = New System.Drawing.Point(1067, 574)
        Me.btnBackToMainFromSignUp.Name = "btnBackToMainFromSignUp"
        Me.btnBackToMainFromSignUp.Size = New System.Drawing.Size(175, 72)
        Me.btnBackToMainFromSignUp.TabIndex = 12
        Me.btnBackToMainFromSignUp.Text = "Back"
        Me.btnBackToMainFromSignUp.UseVisualStyleBackColor = False
        '
        'lblSignUpName
        '
        Me.lblSignUpName.Font = New System.Drawing.Font("Segoe UI Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignUpName.Location = New System.Drawing.Point(20, 55)
        Me.lblSignUpName.Name = "lblSignUpName"
        Me.lblSignUpName.Size = New System.Drawing.Size(100, 39)
        Me.lblSignUpName.TabIndex = 0
        Me.lblSignUpName.Text = "Name"
        '
        'txtSignUpName
        '
        Me.txtSignUpName.Location = New System.Drawing.Point(140, 50)
        Me.txtSignUpName.Multiline = True
        Me.txtSignUpName.Name = "txtSignUpName"
        Me.txtSignUpName.Size = New System.Drawing.Size(329, 48)
        Me.txtSignUpName.TabIndex = 1
        '
        'lblSignUpUsername
        '
        Me.lblSignUpUsername.Font = New System.Drawing.Font("Segoe UI Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignUpUsername.Location = New System.Drawing.Point(12, 153)
        Me.lblSignUpUsername.Name = "lblSignUpUsername"
        Me.lblSignUpUsername.Size = New System.Drawing.Size(122, 43)
        Me.lblSignUpUsername.TabIndex = 2
        Me.lblSignUpUsername.Text = "Username"
        '
        'txtSignUpUsername
        '
        Me.txtSignUpUsername.Location = New System.Drawing.Point(140, 153)
        Me.txtSignUpUsername.Multiline = True
        Me.txtSignUpUsername.Name = "txtSignUpUsername"
        Me.txtSignUpUsername.Size = New System.Drawing.Size(329, 48)
        Me.txtSignUpUsername.TabIndex = 3
        '
        'lblSignUpPassword
        '
        Me.lblSignUpPassword.Font = New System.Drawing.Font("Segoe UI Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignUpPassword.Location = New System.Drawing.Point(12, 263)
        Me.lblSignUpPassword.Name = "lblSignUpPassword"
        Me.lblSignUpPassword.Size = New System.Drawing.Size(122, 31)
        Me.lblSignUpPassword.TabIndex = 4
        Me.lblSignUpPassword.Text = "Password"
        '
        'txtSignUpPassword
        '
        Me.txtSignUpPassword.Location = New System.Drawing.Point(140, 263)
        Me.txtSignUpPassword.Multiline = True
        Me.txtSignUpPassword.Name = "txtSignUpPassword"
        Me.txtSignUpPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSignUpPassword.Size = New System.Drawing.Size(329, 48)
        Me.txtSignUpPassword.TabIndex = 5
        '
        'lblSignUpEmail
        '
        Me.lblSignUpEmail.Font = New System.Drawing.Font("Segoe UI Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignUpEmail.Location = New System.Drawing.Point(20, 379)
        Me.lblSignUpEmail.Name = "lblSignUpEmail"
        Me.lblSignUpEmail.Size = New System.Drawing.Size(100, 23)
        Me.lblSignUpEmail.TabIndex = 6
        Me.lblSignUpEmail.Text = "Email"
        '
        'txtSignUpEmail
        '
        Me.txtSignUpEmail.Location = New System.Drawing.Point(140, 371)
        Me.txtSignUpEmail.Multiline = True
        Me.txtSignUpEmail.Name = "txtSignUpEmail"
        Me.txtSignUpEmail.Size = New System.Drawing.Size(336, 48)
        Me.txtSignUpEmail.TabIndex = 7
        '
        'btnSignUp
        '
        Me.btnSignUp.BackColor = System.Drawing.Color.Goldenrod
        Me.btnSignUp.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSignUp.ForeColor = System.Drawing.Color.White
        Me.btnSignUp.Location = New System.Drawing.Point(161, 537)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(215, 73)
        Me.btnSignUp.TabIndex = 11
        Me.btnSignUp.Text = "Sign Up"
        Me.btnSignUp.UseVisualStyleBackColor = False
        '
        'lblPasswordCriteria
        '
        Me.lblPasswordCriteria.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPasswordCriteria.Location = New System.Drawing.Point(20, 317)
        Me.lblPasswordCriteria.Name = "lblPasswordCriteria"
        Me.lblPasswordCriteria.Size = New System.Drawing.Size(485, 51)
        Me.lblPasswordCriteria.TabIndex = 6
        Me.lblPasswordCriteria.Text = "Password must be at least 8 characters long and include a number and a special ch" &
    "aracter"
        '
        'pnlUserInfo
        '
        Me.pnlUserInfo.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.pnlUserInfo.Controls.Add(Me.Button4)
        Me.pnlUserInfo.Controls.Add(Me.Button3)
        Me.pnlUserInfo.Controls.Add(Me.Button2)
        Me.pnlUserInfo.Controls.Add(Me.CSV_expo)
        Me.pnlUserInfo.Controls.Add(Me.Label3)
        Me.pnlUserInfo.Controls.Add(Me.duree)
        Me.pnlUserInfo.Controls.Add(Me.CF)
        Me.pnlUserInfo.Controls.Add(Me.CV)
        Me.pnlUserInfo.Controls.Add(Me.FI)
        Me.pnlUserInfo.Controls.Add(Me.VI)
        Me.pnlUserInfo.Controls.Add(Me.savings)
        Me.pnlUserInfo.Controls.Add(Me.Label2)
        Me.pnlUserInfo.Controls.Add(Me.Label1)
        Me.pnlUserInfo.Controls.Add(Me.lblUserName)
        Me.pnlUserInfo.Controls.Add(Me.btnBackToMainFromUserInfo)
        Me.pnlUserInfo.Controls.Add(Me.lblUserLoisir)
        Me.pnlUserInfo.Controls.Add(Me.lblUserSexe)
        Me.pnlUserInfo.Controls.Add(Me.lblUserSchool)
        Me.pnlUserInfo.Controls.Add(Me.btnUpdateUserInfo)
        Me.pnlUserInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlUserInfo.Location = New System.Drawing.Point(0, 0)
        Me.pnlUserInfo.Name = "pnlUserInfo"
        Me.pnlUserInfo.Size = New System.Drawing.Size(1069, 670)
        Me.pnlUserInfo.TabIndex = 3
        Me.pnlUserInfo.Visible = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Firebrick
        Me.Button4.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(537, 543)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(204, 67)
        Me.Button4.TabIndex = 26
        Me.Button4.Text = "Reset"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Thistle
        Me.Button3.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(797, 354)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(203, 69)
        Me.Button3.TabIndex = 25
        Me.Button3.Text = "Plot a Graph"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Thistle
        Me.Button2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(797, 263)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(203, 69)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "Generate a PDF"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'CSV_expo
        '
        Me.CSV_expo.BackColor = System.Drawing.Color.Thistle
        Me.CSV_expo.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.CSV_expo.ForeColor = System.Drawing.Color.Black
        Me.CSV_expo.Location = New System.Drawing.Point(797, 174)
        Me.CSV_expo.Name = "CSV_expo"
        Me.CSV_expo.Size = New System.Drawing.Size(203, 69)
        Me.CSV_expo.TabIndex = 23
        Me.CSV_expo.Text = "Export as CSV"
        Me.CSV_expo.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Black", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(853, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 41)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Export"
        '
        'duree
        '
        Me.duree.BackColor = System.Drawing.Color.DarkGray
        Me.duree.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.duree.Location = New System.Drawing.Point(488, 371)
        Me.duree.Multiline = True
        Me.duree.Name = "duree"
        Me.duree.Size = New System.Drawing.Size(206, 59)
        Me.duree.TabIndex = 21
        Me.duree.Text = "Durée de l'épargne"
        '
        'CF
        '
        Me.CF.BackColor = System.Drawing.Color.RosyBrown
        Me.CF.Location = New System.Drawing.Point(226, 186)
        Me.CF.Multiline = True
        Me.CF.Name = "CF"
        Me.CF.Size = New System.Drawing.Size(190, 54)
        Me.CF.TabIndex = 20
        Me.CF.Text = "..."
        Me.CF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CV
        '
        Me.CV.BackColor = System.Drawing.Color.RosyBrown
        Me.CV.Location = New System.Drawing.Point(226, 277)
        Me.CV.Multiline = True
        Me.CV.Name = "CV"
        Me.CV.Size = New System.Drawing.Size(190, 54)
        Me.CV.TabIndex = 19
        Me.CV.Text = "..."
        Me.CV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FI
        '
        Me.FI.BackColor = System.Drawing.Color.RosyBrown
        Me.FI.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic)
        Me.FI.Location = New System.Drawing.Point(488, 186)
        Me.FI.Multiline = True
        Me.FI.Name = "FI"
        Me.FI.Size = New System.Drawing.Size(206, 54)
        Me.FI.TabIndex = 18
        Me.FI.Text = "..."
        Me.FI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'VI
        '
        Me.VI.BackColor = System.Drawing.Color.RosyBrown
        Me.VI.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VI.Location = New System.Drawing.Point(488, 277)
        Me.VI.Multiline = True
        Me.VI.Name = "VI"
        Me.VI.Size = New System.Drawing.Size(206, 54)
        Me.VI.TabIndex = 17
        Me.VI.Text = "..."
        Me.VI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'savings
        '
        Me.savings.BackColor = System.Drawing.Color.DarkGray
        Me.savings.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.savings.Location = New System.Drawing.Point(224, 372)
        Me.savings.Multiline = True
        Me.savings.Name = "savings"
        Me.savings.Size = New System.Drawing.Size(192, 59)
        Me.savings.TabIndex = 16
        Me.savings.Text = "Montant à épargner"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Black", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(526, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 31)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Incomes"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(254, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 47)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Charges"
        '
        'lblUserName
        '
        Me.lblUserName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblUserName.Location = New System.Drawing.Point(51, 52)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(300, 23)
        Me.lblUserName.TabIndex = 0
        Me.lblUserName.Text = "Name"
        '
        'btnBackToMainFromUserInfo
        '
        Me.btnBackToMainFromUserInfo.BackColor = System.Drawing.Color.Purple
        Me.btnBackToMainFromUserInfo.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnBackToMainFromUserInfo.ForeColor = System.Drawing.Color.White
        Me.btnBackToMainFromUserInfo.Location = New System.Drawing.Point(27, 537)
        Me.btnBackToMainFromUserInfo.Name = "btnBackToMainFromUserInfo"
        Me.btnBackToMainFromUserInfo.Size = New System.Drawing.Size(203, 69)
        Me.btnBackToMainFromUserInfo.TabIndex = 9
        Me.btnBackToMainFromUserInfo.Text = "Back to Main"
        Me.btnBackToMainFromUserInfo.UseVisualStyleBackColor = False
        '
        'lblUserLoisir
        '
        Me.lblUserLoisir.Font = New System.Drawing.Font("Segoe UI Black", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblUserLoisir.Location = New System.Drawing.Point(27, 287)
        Me.lblUserLoisir.Name = "lblUserLoisir"
        Me.lblUserLoisir.Size = New System.Drawing.Size(154, 44)
        Me.lblUserLoisir.TabIndex = 2
        Me.lblUserLoisir.Text = "Variables"
        '
        'lblUserSexe
        '
        Me.lblUserSexe.Font = New System.Drawing.Font("Segoe UI Black", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblUserSexe.Location = New System.Drawing.Point(51, 186)
        Me.lblUserSexe.Name = "lblUserSexe"
        Me.lblUserSexe.Size = New System.Drawing.Size(100, 42)
        Me.lblUserSexe.TabIndex = 4
        Me.lblUserSexe.Text = "Fixes"
        '
        'lblUserSchool
        '
        Me.lblUserSchool.Font = New System.Drawing.Font("Segoe UI Black", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblUserSchool.Location = New System.Drawing.Point(36, 369)
        Me.lblUserSchool.Name = "lblUserSchool"
        Me.lblUserSchool.Size = New System.Drawing.Size(145, 54)
        Me.lblUserSchool.TabIndex = 6
        Me.lblUserSchool.Text = "Epargne"
        '
        'btnUpdateUserInfo
        '
        Me.btnUpdateUserInfo.BackColor = System.Drawing.Color.Goldenrod
        Me.btnUpdateUserInfo.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnUpdateUserInfo.ForeColor = System.Drawing.Color.White
        Me.btnUpdateUserInfo.Location = New System.Drawing.Point(797, 543)
        Me.btnUpdateUserInfo.Name = "btnUpdateUserInfo"
        Me.btnUpdateUserInfo.Size = New System.Drawing.Size(204, 67)
        Me.btnUpdateUserInfo.TabIndex = 8
        Me.btnUpdateUserInfo.Text = "Update"
        Me.btnUpdateUserInfo.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.ClientSize = New System.Drawing.Size(1069, 670)
        Me.Controls.Add(Me.pnlUserInfo)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlLogin)
        Me.Controls.Add(Me.pnlSignUp)
        Me.Name = "Form1"
        Me.Text = "Welcome -.-"
        Me.pnlMain.ResumeLayout(False)
        Me.pnlLogin.ResumeLayout(False)
        Me.pnlLogin.PerformLayout()
        Me.pnlSignUp.ResumeLayout(False)
        Me.pnlSignUp.PerformLayout()
        Me.pnlUserInfo.ResumeLayout(False)
        Me.pnlUserInfo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents Label1 As Label
    Private WithEvents Label2 As Label
    Private WithEvents savings As TextBox
    Private WithEvents CF As TextBox
    Private WithEvents CV As TextBox
    Private WithEvents FI As TextBox
    Private WithEvents VI As TextBox
    Private WithEvents duree As TextBox
    Private WithEvents Button3 As Button
    Private WithEvents Button2 As Button
    Private WithEvents CSV_expo As Button
    Private WithEvents Label3 As Label
    Private WithEvents Button4 As Button

End Class
