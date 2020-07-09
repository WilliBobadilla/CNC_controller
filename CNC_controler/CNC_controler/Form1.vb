Imports System
Imports System.ComponentModel
Imports System.Threading
Imports System.IO.Ports
Imports System.Math

Delegate Sub SetTextCallback(ByVal [text] As String) 'Added to prevent threading errors during receiveing of data
'https://tiktakx.wordpress.com/2010/11/21/serial-port-interfacing-with-vb-net-2010/
'https://groups.google.com/forum/?hl=es#!topic/microsoft.public.es.dotnet.vb/RVHo2hn3rk0
'https://www.codeproject.com/Questions/183627/How-to-Receive-data-from-Serial-Port-RS232-in-VB-N



Public Class Form1


    Dim habilitado_imagen As Boolean
    Dim contador As Integer

    Dim myPort As Array  'puertos detectados van a ser almacenados aca 


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' cuando se carga la venta, se carga todos los puertos en myport 
        myPort = IO.Ports.SerialPort.GetPortNames() 'Get all com ports available
        cmbBaud.Items.Add(9600)     'las velocidades mas usadas
        cmbBaud.Items.Add(19200)
        cmbBaud.Items.Add(38400)
        cmbBaud.Items.Add(57600)
        cmbBaud.Items.Add(115200)

        For i = 0 To UBound(myPort)
            cmbPort.Items.Add(myPort(i))
        Next
        cmbPort.Text = cmbPort.Items.Item(0)    'setea por default estos valores en los combbox
        cmbBaud.Text = cmbBaud.Items.Item(0)
        btnDisconnect.Enabled = False

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'todos los controles manuales 
        recibidolab.Hide()
        textboxenvia.Hide()
        enviaboton.Hide()
        Labeltexto.Hide()
        Borrarbtn.Hide()
        buttonreset.Hide()
        Buttoncomands.Hide()
        Buttonencender.Hide()
        Buttonapagar.Hide()

        ' habilitamos los controles del modo predeterminado 
        PictureBox1.Visible = True
        PictureBox2.Visible = True
        PictureBox3.Visible = True
        Labeldiam.Visible = True
        Labelpot.Visible = True
        Buttoncortar.Visible = True
        TextBoxdiam.Visible = True
        TextBoxpot.Visible = True
        Labelcortespre.Visible = True
        Textpasadas.Visible = True
        Label1.Visible = True
        ' todos controles de predeterminado 


    End Sub




    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click
        SerialPort1.PortName = cmbPort.Text         'Set SerialPort1 to the selected COM port at startup
        SerialPort1.BaudRate = cmbBaud.Text         'Set Baud rate to the selected value on

        'Other Serial Port Property
        SerialPort1.Parity = IO.Ports.Parity.None
        SerialPort1.StopBits = IO.Ports.StopBits.One
        SerialPort1.DataBits = 8            'Open our serial port
        SerialPort1.Open()
        Labelconexion.Text = cmbPort.Text + " Conectado!"
        Labelconexion.ForeColor = Color.Green ' ponemos en verde el texto del estado 
        btnConnect.Enabled = False          'Disable Connect button
        btnDisconnect.Enabled = True        'and Enable Disconnect button



    End Sub



    Private Sub btnDisconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisconnect.Click
        SerialPort1.Close()             'cierra el puerto serial
        btnConnect.Enabled = True
        btnDisconnect.Enabled = False
        Labelconexion.Text = "Desconectado"
        Labelconexion.ForeColor = Color.Red  ' ponemos en rojo 


    End Sub





    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        recibidolab.Visible = True
        textboxenvia.Visible = True
        enviaboton.Visible = True
        Labeltexto.Visible = True
        Borrarbtn.Visible = True
        buttonreset.Visible = True
        Buttoncomands.Visible = True
        Buttonencender.Visible = True
        Buttonapagar.Visible = True

        ' activamos todos los controles  del modo manual

        ' vemos ahora para ocultar los otros controles 
        PictureBox1.Hide()
        PictureBox2.Hide()
        PictureBox3.Hide()
        Labeldiam.Hide()
        Labelpot.Hide()
        TextBoxdiam.Hide()
        TextBoxpot.Hide()
        Buttoncortar.Hide()
        Labelcortespre.Hide()
        Label1.Hide()
        Textpasadas.Hide()


    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If habilitado_imagen = False Then
            ' si es falgo que ponga el borde de otra forma 
            PictureBox1.BorderStyle = BorderStyle.Fixed3D


            PictureBox2.Enabled = False ' desabilitamos los demas controles 
            PictureBox3.Enabled = False
            habilitado_imagen = True
        Else
            PictureBox1.BorderStyle = BorderStyle.None


            PictureBox2.Enabled = True ' desabilitamos los demas controles 
            PictureBox3.Enabled = True
            habilitado_imagen = False
        End If
     

    End Sub

   

    Private Sub enviaboton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles enviaboton.Click
        Dim enviar_txt As String
        enviar_txt = textboxenvia.Text ' capturamos del modo manual 
        SerialPort1.Write(enviar_txt + vbCrLf)  ' enviamos por el puerto serial los datos
        textboxenvia.Text = " " ' vaciamos el contenido una vez enviado el dato 



    End Sub

    Private Sub Buttoncortar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttoncortar.Click
        Dim velocidad As String
        Dim mensaje As String

        Dim pasadas As Int16
        Dim pasadas_total As Int16
        Dim y As Double
        Dim cutsize As Double
        Dim grados As Double
        Dim resta As Double
        Dim valor As Double
        Dim radio As Double
        Dim diametro As Double

        Dim hola As String

        velocidad = TextBoxpot.Text

        mensaje = "(Codigo creado por Enrique Benitez y Guillermo Benitez)" + vbCrLf + "(Facultad Politecnica - Asuncion 2020)" + vbCrLf + "G90   (set absolute distance mode)" + vbCrLf + "G17   (set active plane to XY)" + vbCrLf + "G21   (set units to mm)" + vbCrLf + "F" + velocidad + "  (velocidad para G01)" + vbCrLf + "G10 P0 L20 X0 Y0 (set Zero x e y )" + vbCrLf + "M04"


        pasadas = Textpasadas.Text    'extraemos el dato de las padas 

        pasadas_total = pasadas * 360   ' calculo para la maquina
        cutsize = TextBoxdiam.Text
        diametro = TextBoxdiam.Text
        If PictureBox1.Enabled = True Then ' corte recto 
            mensaje = mensaje + vbCrLf + "G01 X" + pasadas_total.ToString() + vbCrLf    ' comando  

            mensaje = mensaje + "M03" + vbCrLf ' para pausar por 4 segundos la maquina
            mensaje = mensaje + "F1600" + vbCrLf ' cambiamos el feed
            mensaje = mensaje + "G01 X0 Y0" + vbCrLf  ' va al origen 
            SerialPort1.Write(mensaje)  ' enviamos los datos para la impresora
          
        End If

        If PictureBox2.Enabled = True Then ' boca de pez
            ' necesitamos segmentar esta parte para luego enviar los datos al CNC
            ' luego, vemos en cuantos segmentos debemos de dividir los datos y  

            '

            radio = diametro / 2

            mensaje = mensaje + vbCrLf ' agreamos un enter
            TextBox1.Text = TextBox1.Text + mensaje

            SerialPort1.Write(mensaje)

            '   System.Threading.Thread.Sleep(15)

            For i As Integer = 0 To (360 * pasadas)   ' vemos el de boca de pez, no hace falta sumarle +1 ya que toma el final
                grados = (i + 60) * 0.0174533 'grados = math.radians(i+60)   
                '   1 gradsexa------- 0.0174533 rad
                '   x gradsexa   ----- n radianes
                'textboxenvia.Text = textboxenvia.Text + grados.ToString() + "con i:" + i.ToString() + vbCrLf

                resta = Math.Sqrt(((radio) ^ 2) - ((radio * Math.Sin(grados)) ^ 2))
                valor = (radio / 2) - resta
                valor = Math.Round(valor, 3)
                'textboxenvia.Text = textboxenvia.Text + "x:" + i.ToString() + "Y:" + valor.ToString() + vbCrLf
                If valor = -0.0 Then
                    valor = 0.0

                End If
                ' mensaje = mensaje +
                mensaje = "G01 X" + i.ToString() + " " + "Y" + valor.ToString().Replace(",", ".") + vbCrLf
                TextBox1.Text = TextBox1.Text + mensaje

                hola = SerialPort1.ReadLine() 'esto espera a que responda 
                TextBox2.Text = TextBox2.Text + hola
                ' System.Threading.Thread.Sleep(15)
                ' While TextBox2.Text.Contains("ok") <> True Or TextBox2.Text.Contains("error") <> True


                'esperamos hasta que sea 
                '  OK

                '   End While
                SerialPort1.Write(mensaje)


                ' despues de generar cada uno de los comandos, podemos 
                ' enviar cada rato aca el mensaje para este caso



            Next
            '    While recibidolab.Text <> "ok"

            'esperamos hasta que sea 
            '  OK

            ' End While


            mensaje = "M03" + vbCrLf ' apagamos el laser
            mensaje = mensaje + "F1600" + vbCrLf ' cambiamos el feed
            mensaje = mensaje + "G01 X0 Y0" + vbCrLf  ' va al origen 
            SerialPort1.Write(mensaje)
            TextBox1.Text = TextBox1.Text + mensaje + contador.ToString()



            'vamos a partir de forma rustica varias partes 
            Dim pieza1 As String
            Dim pieza2 As String
            Dim pieza3 As String
            Dim pieza4 As String
            Dim pieza5 As String
            Dim pieza6 As String
            Dim pieza7 As String
            Dim pieza8 As String
            Dim pieza9 As String






        End If

        If PictureBox3.Enabled = True Then  ' cuadrado 

            y = cutsize / 8
            mensaje = mensaje + vbCrLf ' agreamos un enter
            For x As Integer = 45 To (360 * pasadas) Step 45



                mensaje = mensaje + "G01 " + "Y" + y.ToString() + vbCrLf
                mensaje = mensaje + "G01 " + "X" + x.ToString() + vbCrLf
                'cutsize = -cutsize
                ' y = y + cutsize
                y = -y
            Next
            mensaje = mensaje + "G01 " + "Y" + y.ToString() + vbCrLf

            mensaje = mensaje + "M03" + vbCrLf ' para pausar por 4 segundos la maquina
            mensaje = mensaje + "F1600" + vbCrLf ' cambiamos el feed
            mensaje = mensaje + "G01 X0 Y0" + vbCrLf  ' va al origen 
            SerialPort1.Write(mensaje)  ' enviamos los datos para la impresora
            'recibidolab.Text = mensaje  ' esto era solo para prueba

            TextBox2.Text = TextBox2.Text + contador

        End If


    End Sub

    Private Sub SerialPort1_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        ' cuando se recibe datos este es el que lo maneja
        ReceivedText(SerialPort1.ReadExisting())
    End Sub


    Private Sub ReceivedText(ByVal [text] As String)
        'compares the ID of the creating Thread to the ID of the calling Thread
        contador = contador + 1
        If Me.recibidolab.InvokeRequired Then
            Dim x As New SetTextCallback(AddressOf ReceivedText)
            Me.Invoke(x, New Object() {(text)})
        Else
            Me.recibidolab.Text &= [text]
            '  Me.TextBox2.Text &= [text]
        End If
    End Sub

   
    Private Sub Borrarbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Borrarbtn.Click
        recibidolab.Text = " " ' para borrar todo el texto de lo recibido 


       
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        If habilitado_imagen = False Then
            ' si es falgo que ponga el borde de otra forma 
            PictureBox2.BorderStyle = BorderStyle.Fixed3D
            PictureBox1.Enabled = False ' desabilitamos los demas controles 
            PictureBox3.Enabled = False
            habilitado_imagen = True
        Else
            PictureBox2.BorderStyle = BorderStyle.None
            PictureBox1.Enabled = True ' desabilitamos los demas controles 
            PictureBox3.Enabled = True
            habilitado_imagen = False
        End If
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        If habilitado_imagen = False Then
            ' si es falgo que ponga el borde de otra forma 
            PictureBox3.BorderStyle = BorderStyle.Fixed3D
            PictureBox2.Enabled = False ' desabilitamos los demas controles 
            PictureBox1.Enabled = False
            habilitado_imagen = True
        Else
            PictureBox3.BorderStyle = BorderStyle.None
            PictureBox2.Enabled = True ' desabilitamos los demas controles 
            PictureBox1.Enabled = True
            habilitado_imagen = False
        End If
    End Sub

    Private Sub buttonreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonreset.Click
        Dim mensaje As String

        mensaje = "G10 P0 L20 X0 Y0 Z0" + vbCrLf  ' le enviamos el enter al final 
        SerialPort1.Write(mensaje) ' enviamos el comando a la maquina
    End Sub

    Private Sub Buttoncomands_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttoncomands.Click
        Form2.Show()

    End Sub

   
    Private Sub Buttonencender_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonencender.Click


        SerialPort1.Write("M04" + vbCrLf)  ' encender



    End Sub

    Private Sub Buttonapagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonapagar.Click
        SerialPort1.Write("M03" + vbCrLf) ' apaga
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form3.Show()

    End Sub

    Private Sub textboxenvia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles textboxenvia.KeyDown
        ' si se presiona enter envia esto por el puerto serial
        Dim enviar_txt As String
        If e.KeyCode = Keys.Enter Then  ' si fue presionado enter

            enviar_txt = textboxenvia.Text ' capturamos del modo manual 
            SerialPort1.Write(enviar_txt + vbCrLf)  ' enviamos por el puerto serial los datos
            textboxenvia.Text = " " ' vaciamos el contenido una vez enviado el dato 

        End If
    End Sub

    
End Class
