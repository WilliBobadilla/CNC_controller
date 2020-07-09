<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.cmbPort = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDisconnect = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbBaud = New System.Windows.Forms.ComboBox()
        Me.textboxenvia = New System.Windows.Forms.TextBox()
        Me.recibidolab = New System.Windows.Forms.Label()
        Me.enviaboton = New System.Windows.Forms.Button()
        Me.Labeltexto = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TextBoxdiam = New System.Windows.Forms.TextBox()
        Me.TextBoxpot = New System.Windows.Forms.TextBox()
        Me.Labeldiam = New System.Windows.Forms.Label()
        Me.Labelpot = New System.Windows.Forms.Label()
        Me.Buttoncortar = New System.Windows.Forms.Button()
        Me.Labelcortespre = New System.Windows.Forms.Label()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Borrarbtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Textpasadas = New System.Windows.Forms.TextBox()
        Me.buttonreset = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Labelconexion = New System.Windows.Forms.Label()
        Me.Buttoncomands = New System.Windows.Forms.Button()
        Me.Buttonencender = New System.Windows.Forms.Button()
        Me.Buttonapagar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnConnect
        '
        Me.btnConnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConnect.Location = New System.Drawing.Point(735, 48)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(167, 31)
        Me.btnConnect.TabIndex = 0
        Me.btnConnect.Text = "Conectar "
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(556, 205)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(167, 61)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Cortes predeterminados"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(735, 205)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(167, 61)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Modo manual"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'cmbPort
        '
        Me.cmbPort.FormattingEnabled = True
        Me.cmbPort.Location = New System.Drawing.Point(556, 58)
        Me.cmbPort.Name = "cmbPort"
        Me.cmbPort.Size = New System.Drawing.Size(142, 21)
        Me.cmbPort.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(552, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 24)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Puertos"
        '
        'btnDisconnect
        '
        Me.btnDisconnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisconnect.Location = New System.Drawing.Point(735, 95)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(167, 32)
        Me.btnDisconnect.TabIndex = 6
        Me.btnDisconnect.Text = "Desconectar"
        Me.btnDisconnect.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(552, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 24)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Velocidad "
        '
        'cmbBaud
        '
        Me.cmbBaud.FormattingEnabled = True
        Me.cmbBaud.Location = New System.Drawing.Point(556, 106)
        Me.cmbBaud.Name = "cmbBaud"
        Me.cmbBaud.Size = New System.Drawing.Size(142, 21)
        Me.cmbBaud.TabIndex = 8
        '
        'textboxenvia
        '
        Me.textboxenvia.Location = New System.Drawing.Point(41, 53)
        Me.textboxenvia.Name = "textboxenvia"
        Me.textboxenvia.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxenvia.Size = New System.Drawing.Size(350, 20)
        Me.textboxenvia.TabIndex = 9
        Me.textboxenvia.Visible = False
        '
        'recibidolab
        '
        Me.recibidolab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.recibidolab.Location = New System.Drawing.Point(41, 128)
        Me.recibidolab.Name = "recibidolab"
        Me.recibidolab.Size = New System.Drawing.Size(350, 159)
        Me.recibidolab.TabIndex = 10
        Me.recibidolab.Visible = False
        '
        'enviaboton
        '
        Me.enviaboton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enviaboton.Location = New System.Drawing.Point(293, 303)
        Me.enviaboton.Name = "enviaboton"
        Me.enviaboton.Size = New System.Drawing.Size(98, 35)
        Me.enviaboton.TabIndex = 11
        Me.enviaboton.Text = "Enviar"
        Me.enviaboton.UseVisualStyleBackColor = True
        Me.enviaboton.Visible = False
        '
        'Labeltexto
        '
        Me.Labeltexto.AutoSize = True
        Me.Labeltexto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labeltexto.Location = New System.Drawing.Point(37, 26)
        Me.Labeltexto.Name = "Labeltexto"
        Me.Labeltexto.Size = New System.Drawing.Size(126, 24)
        Me.Labeltexto.TabIndex = 12
        Me.Labeltexto.Text = "Modo Manual"
        Me.Labeltexto.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(41, 53)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(143, 83)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(207, 53)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(143, 83)
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(378, 53)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(143, 83)
        Me.PictureBox3.TabIndex = 15
        Me.PictureBox3.TabStop = False
        '
        'TextBoxdiam
        '
        Me.TextBoxdiam.Location = New System.Drawing.Point(417, 205)
        Me.TextBoxdiam.Name = "TextBoxdiam"
        Me.TextBoxdiam.Size = New System.Drawing.Size(104, 20)
        Me.TextBoxdiam.TabIndex = 19
        '
        'TextBoxpot
        '
        Me.TextBoxpot.Location = New System.Drawing.Point(417, 169)
        Me.TextBoxpot.Name = "TextBoxpot"
        Me.TextBoxpot.Size = New System.Drawing.Size(104, 20)
        Me.TextBoxpot.TabIndex = 18
        '
        'Labeldiam
        '
        Me.Labeldiam.AutoSize = True
        Me.Labeldiam.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labeldiam.Location = New System.Drawing.Point(274, 204)
        Me.Labeldiam.Name = "Labeldiam"
        Me.Labeldiam.Size = New System.Drawing.Size(98, 25)
        Me.Labeldiam.TabIndex = 17
        Me.Labeldiam.Text = "Diametro"
        '
        'Labelpot
        '
        Me.Labelpot.AutoSize = True
        Me.Labelpot.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelpot.Location = New System.Drawing.Point(275, 164)
        Me.Labelpot.Name = "Labelpot"
        Me.Labelpot.Size = New System.Drawing.Size(95, 24)
        Me.Labelpot.TabIndex = 16
        Me.Labelpot.Text = "Velocidad"
        '
        'Buttoncortar
        '
        Me.Buttoncortar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttoncortar.Location = New System.Drawing.Point(423, 303)
        Me.Buttoncortar.Name = "Buttoncortar"
        Me.Buttoncortar.Size = New System.Drawing.Size(98, 35)
        Me.Buttoncortar.TabIndex = 20
        Me.Buttoncortar.Text = "Cortar"
        Me.Buttoncortar.UseVisualStyleBackColor = True
        '
        'Labelcortespre
        '
        Me.Labelcortespre.AutoSize = True
        Me.Labelcortespre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelcortespre.Location = New System.Drawing.Point(41, 26)
        Me.Labelcortespre.Name = "Labelcortespre"
        Me.Labelcortespre.Size = New System.Drawing.Size(212, 24)
        Me.Labelcortespre.TabIndex = 21
        Me.Labelcortespre.Text = "Cortes predeterminados"
        '
        'SerialPort1
        '
        '
        'Borrarbtn
        '
        Me.Borrarbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Borrarbtn.Location = New System.Drawing.Point(41, 303)
        Me.Borrarbtn.Name = "Borrarbtn"
        Me.Borrarbtn.Size = New System.Drawing.Size(98, 35)
        Me.Borrarbtn.TabIndex = 22
        Me.Borrarbtn.Text = "Borrar"
        Me.Borrarbtn.UseVisualStyleBackColor = True
        Me.Borrarbtn.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(274, 239)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 25)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Pasadas"
        '
        'Textpasadas
        '
        Me.Textpasadas.Location = New System.Drawing.Point(417, 241)
        Me.Textpasadas.Name = "Textpasadas"
        Me.Textpasadas.Size = New System.Drawing.Size(104, 20)
        Me.Textpasadas.TabIndex = 24
        '
        'buttonreset
        '
        Me.buttonreset.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonreset.Location = New System.Drawing.Point(155, 303)
        Me.buttonreset.Name = "buttonreset"
        Me.buttonreset.Size = New System.Drawing.Size(98, 35)
        Me.buttonreset.TabIndex = 25
        Me.buttonreset.Text = "Reset"
        Me.buttonreset.UseVisualStyleBackColor = True
        Me.buttonreset.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(556, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 20)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Estado: "
        '
        'Labelconexion
        '
        Me.Labelconexion.AutoSize = True
        Me.Labelconexion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelconexion.ForeColor = System.Drawing.Color.Red
        Me.Labelconexion.Location = New System.Drawing.Point(618, 152)
        Me.Labelconexion.Name = "Labelconexion"
        Me.Labelconexion.Size = New System.Drawing.Size(105, 18)
        Me.Labelconexion.TabIndex = 27
        Me.Labelconexion.Text = "Desconectado"
        '
        'Buttoncomands
        '
        Me.Buttoncomands.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttoncomands.Location = New System.Drawing.Point(416, 303)
        Me.Buttoncomands.Name = "Buttoncomands"
        Me.Buttoncomands.Size = New System.Drawing.Size(114, 35)
        Me.Buttoncomands.TabIndex = 28
        Me.Buttoncomands.Text = "Comandos"
        Me.Buttoncomands.UseVisualStyleBackColor = True
        Me.Buttoncomands.Visible = False
        '
        'Buttonencender
        '
        Me.Buttonencender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonencender.Location = New System.Drawing.Point(397, 118)
        Me.Buttonencender.Name = "Buttonencender"
        Me.Buttonencender.Size = New System.Drawing.Size(133, 32)
        Me.Buttonencender.TabIndex = 29
        Me.Buttonencender.Text = "Encender Láser"
        Me.Buttonencender.UseVisualStyleBackColor = True
        Me.Buttonencender.Visible = False
        '
        'Buttonapagar
        '
        Me.Buttonapagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonapagar.Location = New System.Drawing.Point(397, 169)
        Me.Buttonapagar.Name = "Buttonapagar"
        Me.Buttonapagar.Size = New System.Drawing.Size(133, 32)
        Me.Buttonapagar.TabIndex = 30
        Me.Buttonapagar.Text = "Apagar Láser"
        Me.Buttonapagar.UseVisualStyleBackColor = True
        Me.Buttonapagar.Visible = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(735, 277)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(167, 61)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "Acerca de"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(579, 263)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(228, 144)
        Me.TextBox1.TabIndex = 32
        Me.TextBox1.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(41, 152)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox2.Size = New System.Drawing.Size(100, 135)
        Me.TextBox2.TabIndex = 33
        Me.TextBox2.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 405)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Buttonapagar)
        Me.Controls.Add(Me.Buttonencender)
        Me.Controls.Add(Me.Buttoncomands)
        Me.Controls.Add(Me.Labelconexion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.buttonreset)
        Me.Controls.Add(Me.Textpasadas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Borrarbtn)
        Me.Controls.Add(Me.Labelcortespre)
        Me.Controls.Add(Me.Buttoncortar)
        Me.Controls.Add(Me.TextBoxdiam)
        Me.Controls.Add(Me.TextBoxpot)
        Me.Controls.Add(Me.Labeldiam)
        Me.Controls.Add(Me.Labelpot)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Labeltexto)
        Me.Controls.Add(Me.enviaboton)
        Me.Controls.Add(Me.recibidolab)
        Me.Controls.Add(Me.textboxenvia)
        Me.Controls.Add(Me.cmbBaud)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnDisconnect)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbPort)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnConnect)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(921, 444)
        Me.MinimumSize = New System.Drawing.Size(921, 444)
        Me.Name = "Form1"
        Me.Text = "Easy RY Controller"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    'Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents cmbPort As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnDisconnect As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbBaud As System.Windows.Forms.ComboBox
    Friend WithEvents textboxenvia As System.Windows.Forms.TextBox
    Friend WithEvents recibidolab As System.Windows.Forms.Label
    Friend WithEvents enviaboton As System.Windows.Forms.Button
    Friend WithEvents Labeltexto As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBoxdiam As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxpot As System.Windows.Forms.TextBox
    Friend WithEvents Labeldiam As System.Windows.Forms.Label
    Friend WithEvents Labelpot As System.Windows.Forms.Label
    Friend WithEvents Buttoncortar As System.Windows.Forms.Button
    Friend WithEvents Labelcortespre As System.Windows.Forms.Label
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents Borrarbtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Textpasadas As System.Windows.Forms.TextBox
    Friend WithEvents buttonreset As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Labelconexion As System.Windows.Forms.Label
    Friend WithEvents Buttoncomands As System.Windows.Forms.Button
    Friend WithEvents Buttonencender As System.Windows.Forms.Button
    Friend WithEvents Buttonapagar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox

End Class
