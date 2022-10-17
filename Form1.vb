Imports System.IO
Imports System.Net
Imports System.Threading
Public Class Form1
    'Jayson O. Amodia
    'jayson.amodia@lasermet.com

    'Variable Declaration
    Private myThread As System.Threading.Thread
    Dim alwaysOnTop As Boolean = True
    Public TA11Connected As Boolean
    Public TA12Connected As Boolean
    Public TA13Connected As Boolean
    Public TA21Connected As Boolean
    Public TA22Connected As Boolean
    Public TA23Connected As Boolean
    Public TA24Connected As Boolean
    Public statusArray11() As Char
    Public statusArray12() As Char
    Public statusArray13() As Char
    Public statusArray21() As Char
    Public statusArray22() As Char
    Public statusArray23() As Char
    Public statusArray24() As Char
    Public checkStatusDone As Boolean
    Public runSLPStatus As Boolean = False
    'End Variable Declaration

    Public showDataStatus As Boolean = False

    Public Sub loadThread()
        myThread = New System.Threading.Thread(AddressOf checkStatus)
        myThread.Start()
    End Sub

    Public Sub checkStatus()
        'TA11 Setting Start

        Dim checkStatusRequest11 As HttpWebRequest = DirectCast(WebRequest.Create("http://192.168.1.10/allStatus"), HttpWebRequest)
        checkStatusRequest11.Timeout = My.Settings.timeOut
        Try
            Dim checkStatusResponse11 As HttpWebResponse
            checkStatusResponse11 = DirectCast(checkStatusRequest11.GetResponse(), HttpWebResponse)
            Dim checkStatusReader11 As New StreamReader(checkStatusResponse11.GetResponseStream())
            Dim thepage11 As String = checkStatusReader11.ReadToEnd
            statusArray11 = thepage11.ToCharArray
            TA11Connected = True
        Catch ex As WebException
            TA11Connected = False
            Console.WriteLine(TA11Connected)
        End Try
        'TA11 Setting End

        'TA12 Setting Start
        Dim checkStatusRequest12 As HttpWebRequest = DirectCast(WebRequest.Create("http://192.168.1.11/allStatus"), HttpWebRequest)
        checkStatusRequest12.Timeout = My.Settings.timeOut
        Try
            Dim checkStatusResponse12 As HttpWebResponse
            checkStatusResponse12 = DirectCast(checkStatusRequest12.GetResponse(), HttpWebResponse)
            Dim checkStatusReader12 As New StreamReader(checkStatusResponse12.GetResponseStream())
            Dim thepage12 As String = checkStatusReader12.ReadToEnd
            statusArray12 = thepage12.ToCharArray
            TA12Connected = True
        Catch ex As WebException
            TA12Connected = False
            Console.WriteLine(TA12Connected)
        End Try
        'TA12 Setting End

        'TA13 Setting Start
        Dim checkStatusRequest13 As HttpWebRequest = DirectCast(WebRequest.Create("http://192.168.1.12/allStatus"), HttpWebRequest)
        checkStatusRequest13.Timeout = My.Settings.timeOut
        Try
            Dim checkStatusResponse13 As HttpWebResponse
            checkStatusResponse13 = DirectCast(checkStatusRequest13.GetResponse(), HttpWebResponse)
            Dim checkStatusReader13 As New StreamReader(checkStatusResponse13.GetResponseStream())
            Dim thepage13 As String = checkStatusReader13.ReadToEnd
            statusArray13 = thepage13.ToCharArray
            TA13Connected = True
        Catch ex As WebException
            TA13Connected = False
            Console.WriteLine(TA13Connected)
        End Try
        'TA13 Setting End

        'TA21 Setting Start
        Dim checkStatusRequest21 As HttpWebRequest = DirectCast(WebRequest.Create("http://192.168.1.13/allStatus"), HttpWebRequest)
        checkStatusRequest21.Timeout = My.Settings.timeOut
        Try
            Dim checkStatusResponse21 As HttpWebResponse
            checkStatusResponse21 = DirectCast(checkStatusRequest21.GetResponse(), HttpWebResponse)
            Dim checkStatusReader21 As New StreamReader(checkStatusResponse21.GetResponseStream())
            Dim thepage21 As String = checkStatusReader21.ReadToEnd
            statusArray21 = thepage21.ToCharArray
            TA21Connected = True
        Catch ex As WebException
            TA21Connected = False
            Console.WriteLine(TA21Connected)
        End Try
        'TA21 Setting End

        'TA22 Setting Start
        Dim checkStatusRequest22 As HttpWebRequest = DirectCast(WebRequest.Create("http://192.168.1.14/allStatus"), HttpWebRequest)
        checkStatusRequest22.Timeout = My.Settings.timeOut
        Try
            Dim checkStatusResponse22 As HttpWebResponse
            checkStatusResponse22 = DirectCast(checkStatusRequest22.GetResponse(), HttpWebResponse)
            Dim checkStatusReader22 As New StreamReader(checkStatusResponse22.GetResponseStream())
            Dim thepage22 As String = checkStatusReader22.ReadToEnd
            statusArray22 = thepage22.ToCharArray
            TA22Connected = True
        Catch ex As WebException
            TA22Connected = False
            Console.WriteLine(TA22Connected)
        End Try
        'TA22 Setting End

        'TA23 Setting Start
        Dim checkStatusRequest23 As HttpWebRequest = DirectCast(WebRequest.Create("http://192.168.1.15/allStatus"), HttpWebRequest)
        checkStatusRequest23.Timeout = My.Settings.timeOut
        Try
            Dim checkStatusResponse23 As HttpWebResponse
            checkStatusResponse23 = DirectCast(checkStatusRequest23.GetResponse(), HttpWebResponse)
            Dim checkStatusReader23 As New StreamReader(checkStatusResponse23.GetResponseStream())
            Dim thepage23 As String = checkStatusReader23.ReadToEnd
            statusArray23 = thepage23.ToCharArray
            TA23Connected = True
        Catch ex As WebException
            TA23Connected = False
            Console.WriteLine(TA23Connected)
        End Try
        'TA23 Setting End

        'TA24 Setting Start
        Dim checkStatusRequest24 As HttpWebRequest = DirectCast(WebRequest.Create("http://192.168.1.16/allStatus"), HttpWebRequest)
        checkStatusRequest24.Timeout = My.Settings.timeOut
        Try
            Dim checkStatusResponse24 As HttpWebResponse
            checkStatusResponse24 = DirectCast(checkStatusRequest24.GetResponse(), HttpWebResponse)
            Dim checkStatusReader24 As New StreamReader(checkStatusResponse24.GetResponseStream())
            Dim thepage24 As String = checkStatusReader24.ReadToEnd
            statusArray24 = thepage24.ToCharArray
            TA24Connected = True
        Catch ex As WebException
            TA24Connected = False
            Console.WriteLine(TA24Connected)
        End Try
        'TA24 Setting End
        checkStatusDone = True
        myThread.Abort()

    End Sub

    Public Sub updateUI()

        'TA11 Status Check Start
        If (TA11Connected = True) Then
            lblTA11ShutterStatus.Visible = False
            btnTA11Opn.Enabled = True
            btnTA11Cls.Enabled = True
            Try
                '1 for remote and 0 for local
                If (statusArray11(1).ToString = "1") Then
                    'FOR REMOTE
                    lblTA11ShutterStatus.Visible = False
                    btnTA11Opn.Enabled = True
                    btnTA11Cls.Enabled = True
                    If (statusArray11(0).ToString = "1") Then
                        btnTA11Opn.BackColor = Color.WhiteSmoke
                        btnTA11Cls.BackColor = Color.Red
                    Else
                        btnTA11Opn.BackColor = Color.Green
                        btnTA11Cls.BackColor = Color.WhiteSmoke
                    End If
                Else
                    'FOR LOCAL
                    If (statusArray11(0).ToString = "1") Then
                        lblTA11ShutterStatus.Text = "Shutter Open"
                    Else
                        lblTA11ShutterStatus.Text = "Shutter Closed"
                    End If
                    lblTA11ShutterStatus.Visible = True
                    btnTA11Opn.Enabled = False
                    btnTA11Cls.Enabled = False
                End If
            Catch
            End Try
        Else
            lblTA11ShutterStatus.Text = "Disconnected"
            lblTA11ShutterStatus.Visible = True
            btnTA11Opn.Enabled = False
            btnTA11Cls.Enabled = False
        End If
        'TA11 Status Check End

        'TA12 Status Check Start
        If (TA12Connected = True) Then
            lblTA12ShutterStatus.Visible = False
            btnTA12Opn.Enabled = True
            btnTA12Cls.Enabled = True
            Try
                '1 for remote and 0 for local
                If (statusArray12(1).ToString = "1") Then
                    'FOR REMOTE
                    lblTA12ShutterStatus.Visible = False
                    btnTA12Opn.Enabled = True
                    btnTA12Cls.Enabled = True
                    If (statusArray12(0).ToString = "1") Then
                        btnTA12Opn.BackColor = Color.WhiteSmoke
                        btnTA12Cls.BackColor = Color.Red
                    Else
                        btnTA12Opn.BackColor = Color.Green
                        btnTA12Cls.BackColor = Color.WhiteSmoke
                    End If
                Else
                    'FOR LOCAL
                    If (statusArray12(0).ToString = "1") Then
                        lblTA12ShutterStatus.Text = "Shutter Open"
                    Else
                        lblTA12ShutterStatus.Text = "Shutter Closed"
                    End If
                    lblTA12ShutterStatus.Visible = True
                    btnTA12Opn.Enabled = False
                    btnTA12Cls.Enabled = False
                End If
            Catch
            End Try
        Else
            lblTA12ShutterStatus.Text = "Disconnected"
            lblTA12ShutterStatus.Visible = True
            btnTA12Opn.Enabled = False
            btnTA12Cls.Enabled = False
        End If
        'TA12 Status Check End

        'TA13 Status Check Start
        If (TA13Connected = True) Then
            lblTA13ShutterStatus.Visible = False
            btnTA13Opn.Enabled = True
            btnTA13Cls.Enabled = True
            Try
                '1 for remote and 0 for local
                If (statusArray13(1).ToString = "1") Then
                    'FOR REMOTE
                    lblTA13ShutterStatus.Visible = False
                    btnTA13Opn.Enabled = True
                    btnTA13Cls.Enabled = True
                    If (statusArray13(0).ToString = "1") Then
                        btnTA13Opn.BackColor = Color.WhiteSmoke
                        btnTA13Cls.BackColor = Color.Red
                    Else
                        btnTA13Opn.BackColor = Color.Green
                        btnTA13Cls.BackColor = Color.WhiteSmoke
                    End If
                Else
                    'FOR LOCAL
                    If (statusArray13(0).ToString = "1") Then
                        lblTA13ShutterStatus.Text = "Shutter Open"
                    Else
                        lblTA13ShutterStatus.Text = "Shutter Closed"
                    End If
                    lblTA13ShutterStatus.Visible = True
                    btnTA13Opn.Enabled = False
                    btnTA13Cls.Enabled = False
                End If
            Catch
            End Try
        Else
            lblTA13ShutterStatus.Text = "Disconnected"
            lblTA13ShutterStatus.Visible = True
            btnTA13Opn.Enabled = False
            btnTA13Cls.Enabled = False
        End If
        'TA13 Status Check End

        'TA21 Status Check Start
        If (TA21Connected = True) Then
            lblTA21ShutterStatus.Visible = False
            btnTA21Opn.Enabled = True
            btnTA21Cls.Enabled = True
            Try
                '1 for remote and 0 for local
                If (statusArray21(1).ToString = "1") Then
                    'FOR REMOTE
                    lblTA21ShutterStatus.Visible = False
                    btnTA21Opn.Enabled = True
                    btnTA21Cls.Enabled = True
                    If (statusArray21(0).ToString = "1") Then
                        btnTA21Opn.BackColor = Color.WhiteSmoke
                        btnTA21Cls.BackColor = Color.Red
                    Else
                        btnTA21Opn.BackColor = Color.Green
                        btnTA21Cls.BackColor = Color.WhiteSmoke
                    End If
                Else
                    'FOR LOCAL
                    If (statusArray21(0).ToString = "1") Then
                        lblTA21ShutterStatus.Text = "Shutter Open"
                    Else
                        lblTA21ShutterStatus.Text = "Shutter Closed"
                    End If
                    lblTA21ShutterStatus.Visible = True
                    btnTA21Opn.Enabled = False
                    btnTA21Cls.Enabled = False
                End If
            Catch
            End Try
        Else
            lblTA21ShutterStatus.Text = "Disconnected"
            lblTA21ShutterStatus.Visible = True
            btnTA21Opn.Enabled = False
            btnTA21Cls.Enabled = False
        End If
        'TA21 Status Check End

        'TA22 Status Check Start
        If (TA22Connected = True) Then
            lblTA22ShutterStatus.Visible = False
            btnTA22Opn.Enabled = True
            btnTA22Cls.Enabled = True
            Try
                '1 for remote and 0 for local
                If (statusArray22(1).ToString = "1") Then
                    'FOR REMOTE
                    lblTA22ShutterStatus.Visible = False
                    btnTA22Opn.Enabled = True
                    btnTA22Cls.Enabled = True
                    If (statusArray22(0).ToString = "1") Then
                        btnTA22Opn.BackColor = Color.WhiteSmoke
                        btnTA22Cls.BackColor = Color.Red
                    Else
                        btnTA22Opn.BackColor = Color.Green
                        btnTA22Cls.BackColor = Color.WhiteSmoke
                    End If
                Else
                    'FOR LOCAL
                    If (statusArray22(0).ToString = "1") Then
                        lblTA22ShutterStatus.Text = "Shutter Open"
                    Else
                        lblTA22ShutterStatus.Text = "Shutter Closed"
                    End If
                    lblTA22ShutterStatus.Visible = True
                    btnTA22Opn.Enabled = False
                    btnTA22Cls.Enabled = False
                End If
            Catch
            End Try
        Else
            lblTA22ShutterStatus.Text = "Disconnected"
            lblTA22ShutterStatus.Visible = True
            btnTA22Opn.Enabled = False
            btnTA22Cls.Enabled = False
        End If
        'TA22 Status Check End

        'TA23 Status Check Start
        If (TA23Connected = True) Then
            lblTA23ShutterStatus.Visible = False
            btnTA23Opn.Enabled = True
            btnTA23Cls.Enabled = True
            Try
                '1 for remote and 0 for local
                If (statusArray23(1).ToString = "1") Then
                    'FOR REMOTE
                    lblTA23ShutterStatus.Visible = False
                    btnTA23Opn.Enabled = True
                    btnTA23Cls.Enabled = True
                    If (statusArray23(0).ToString = "1") Then
                        btnTA23Opn.BackColor = Color.WhiteSmoke
                        btnTA23Cls.BackColor = Color.Red
                    Else
                        btnTA23Opn.BackColor = Color.Green
                        btnTA23Cls.BackColor = Color.WhiteSmoke
                    End If
                Else
                    'FOR LOCAL
                    If (statusArray23(0).ToString = "1") Then
                        lblTA23ShutterStatus.Text = "Shutter Open"
                    Else
                        lblTA23ShutterStatus.Text = "Shutter Closed"
                    End If
                    lblTA23ShutterStatus.Visible = True
                    btnTA23Opn.Enabled = False
                    btnTA23Cls.Enabled = False
                End If
            Catch
            End Try
        Else
            lblTA23ShutterStatus.Text = "Disconnected"
            lblTA23ShutterStatus.Visible = True
            btnTA23Opn.Enabled = False
            btnTA23Cls.Enabled = False
        End If
        'TA23 Status Check End

        'TA24 Status Check Start
        If (TA24Connected = True) Then
            lblTA24ShutterStatus.Visible = False
            btnTA24Opn.Enabled = True
            btnTA24Cls.Enabled = True
            Try
                '1 for remote and 0 for local
                If (statusArray24(1).ToString = "1") Then
                    'FOR REMOTE
                    lblTA24ShutterStatus.Visible = False
                    btnTA24Opn.Enabled = True
                    btnTA24Cls.Enabled = True
                    If (statusArray24(0).ToString = "1") Then
                        btnTA24Opn.BackColor = Color.WhiteSmoke
                        btnTA24Cls.BackColor = Color.Red
                    Else
                        btnTA24Opn.BackColor = Color.Green
                        btnTA24Cls.BackColor = Color.WhiteSmoke
                    End If
                Else
                    'FOR LOCAL
                    If (statusArray24(0).ToString = "1") Then
                        lblTA24ShutterStatus.Text = "Shutter Open"
                    Else
                        lblTA24ShutterStatus.Text = "Shutter Closed"
                    End If
                    lblTA24ShutterStatus.Visible = True
                    btnTA24Opn.Enabled = False
                    btnTA24Cls.Enabled = False
                End If
            Catch
            End Try
        Else
            lblTA24ShutterStatus.Text = "Disconnected"
            lblTA24ShutterStatus.Visible = True
            btnTA24Opn.Enabled = False
            btnTA24Cls.Enabled = False
        End If
        'TA24 Status Check End

    End Sub
    Public Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If checkStatusDone = True Then
            updateUI()
            checkStatusDone = False
        End If
    End Sub


    'Load
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = My.Settings.refreshRate
        Me.MinimumSize = Me.Size
        Dim sheetNumbers() As String = {"Sheet 1", "Sheet 2"}
        cbSheets.Items.AddRange(sheetNumbers)
        cbSheets.SelectedIndex = 0
        loadThread()
        Timer1.Enabled = True
        Timer2.Enabled = True

        Me.TopMost = False
    End Sub
    'Load


    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        myThread.Abort()
        Me.Close()
    End Sub
    Private Sub AlwaysOnTopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlwaysOnTopToolStripMenuItem.Click
        If alwaysOnTop = True Then
            alwaysOnTop = False
            Me.TopMost = False
            AlwaysOnTopToolStripMenuItem.Text = "Enable Always On Top"
            MessageBox.Show("Always On Top Disabled", "Settings Changed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf alwaysOnTop = False Then
            alwaysOnTop = True
            Me.TopMost = True
            AlwaysOnTopToolStripMenuItem.Text = "Disable Always On Top"
            MessageBox.Show("Always On Top Enabled", "Settings Changed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Public Sub cbSheets_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSheets.SelectedIndexChanged
        Dim doorInputs As New DOOR_INPUTS_AND_ALIGNMENT_MODES()
        Dim searchECS As New Search_ECS_and_Beam_Dumps_Input()
        Me.panelSheetViewer.Controls.Clear()

        If cbSheets.SelectedIndex = 0 Then
            doorInputs.TopLevel = False
            Me.panelSheetViewer.Controls.Add(doorInputs)
            doorInputs.Show()
            searchECS.Close()

        Else
            searchECS.TopLevel = False
            Me.panelSheetViewer.Controls.Add(searchECS)
            searchECS.Show()
            doorInputs.Close()
        End If
    End Sub







    'SHUTTER OPEN AND CLOSE EVENTS
    'TA11 Open and Close Events Start
    Private Sub btnTA11Opn_Click(sender As Object, e As EventArgs) Handles btnTA11Opn.Click
        Dim OpenTA11Request As HttpWebRequest = DirectCast(WebRequest.Create("http://192.168.1.10/allStatus?key=keyOn"), HttpWebRequest)
        OpenTA11Request.Timeout = My.Settings.timeOut
        Try
            Dim OpenTA11Response As HttpWebResponse
            OpenTA11Response = DirectCast(OpenTA11Request.GetResponse(), HttpWebResponse)
            Dim OpenTA11Reader As New StreamReader(OpenTA11Response.GetResponseStream())
            Dim thepage As String = OpenTA11Reader.ReadToEnd
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnTA11Cls_Click(sender As Object, e As EventArgs) Handles btnTA11Cls.Click
        Dim CloseTA11Request As HttpWebRequest = DirectCast(WebRequest.Create("http://192.168.1.10/allStatus?key=keyOff"), HttpWebRequest)
        CloseTA11Request.Timeout = My.Settings.timeOut
        Try
            Dim CloseTA11Response As HttpWebResponse
            CloseTA11Response = DirectCast(CloseTA11Request.GetResponse(), HttpWebResponse)
            Dim CloseTA11Reader As New StreamReader(CloseTA11Response.GetResponseStream())
            Dim thepage As String = CloseTA11Reader.ReadToEnd
        Catch ex As Exception

        End Try
    End Sub
    'TA11 Open and Close Events End

    'TA12 Open and Close Events Start
    Private Sub btnTA12Opn_Click(sender As Object, e As EventArgs) Handles btnTA12Opn.Click
        Dim OpenTA12Request As HttpWebRequest = DirectCast(WebRequest.Create("http://192.168.1.11/allStatus?key=keyOn"), HttpWebRequest)
        OpenTA12Request.Timeout = My.Settings.timeOut
        Try
            Dim OpenTA12Response As HttpWebResponse
            OpenTA12Response = DirectCast(OpenTA12Request.GetResponse(), HttpWebResponse)
            Dim OpenTA12Reader As New StreamReader(OpenTA12Response.GetResponseStream())
            Dim thepage As String = OpenTA12Reader.ReadToEnd
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnTA12Cls_Click(sender As Object, e As EventArgs) Handles btnTA12Cls.Click
        Dim CloseTA12Request As HttpWebRequest = DirectCast(WebRequest.Create("http://192.168.1.11/allStatus?key=keyOff"), HttpWebRequest)
        CloseTA12Request.Timeout = My.Settings.timeOut
        Try
            Dim CloseTA12Response As HttpWebResponse
            CloseTA12Response = DirectCast(CloseTA12Request.GetResponse(), HttpWebResponse)
            Dim CloseTA12Reader As New StreamReader(CloseTA12Response.GetResponseStream())
            Dim thepage As String = CloseTA12Reader.ReadToEnd
        Catch ex As Exception

        End Try
    End Sub
    'TA12 Open and Close Events End

    'TA13 Open and Close Events Start
    Private Sub btnTA13Opn_Click(sender As Object, e As EventArgs) Handles btnTA13Opn.Click
        Dim OpenTA13Request As HttpWebRequest = DirectCast(WebRequest.Create("http://192.168.1.12/allStatus?key=keyOn"), HttpWebRequest)
        OpenTA13Request.Timeout = My.Settings.timeOut
        Try
            Dim OpenTA13Response As HttpWebResponse
            OpenTA13Response = DirectCast(OpenTA13Request.GetResponse(), HttpWebResponse)
            Dim OpenTA13Reader As New StreamReader(OpenTA13Response.GetResponseStream())
            Dim thepage As String = OpenTA13Reader.ReadToEnd
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnTA13Cls_Click(sender As Object, e As EventArgs) Handles btnTA13Cls.Click
        Dim CloseTA13Request As HttpWebRequest = DirectCast(WebRequest.Create("http://192.168.1.12/allStatus?key=keyOff"), HttpWebRequest)
        CloseTA13Request.Timeout = My.Settings.timeOut
        Try
            Dim CloseTA13Response As HttpWebResponse
            CloseTA13Response = DirectCast(CloseTA13Request.GetResponse(), HttpWebResponse)
            Dim CloseTA13Reader As New StreamReader(CloseTA13Response.GetResponseStream())
            Dim thepage As String = CloseTA13Reader.ReadToEnd
        Catch ex As Exception

        End Try
    End Sub
    'TA13 Open and Close Events End

    'TA21 Open and Close Events Start
    Private Sub btnTA21Opn_Click(sender As Object, e As EventArgs) Handles btnTA21Opn.Click
        Dim OpenTA21Request As HttpWebRequest = DirectCast(WebRequest.Create("http://192.168.1.13/allStatus?key=keyOn"), HttpWebRequest)
        OpenTA21Request.Timeout = My.Settings.timeOut
        Try
            Dim OpenTA21Response As HttpWebResponse
            OpenTA21Response = DirectCast(OpenTA21Request.GetResponse(), HttpWebResponse)
            Dim OpenTA21Reader As New StreamReader(OpenTA21Response.GetResponseStream())
            Dim thepage As String = OpenTA21Reader.ReadToEnd
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnTA21Cls_Click(sender As Object, e As EventArgs) Handles btnTA21Cls.Click
        Dim CloseTA21Request As HttpWebRequest = DirectCast(WebRequest.Create("http://192.168.1.13/allStatus?key=keyOff"), HttpWebRequest)
        CloseTA21Request.Timeout = My.Settings.timeOut
        Try
            Dim CloseTA21Response As HttpWebResponse
            CloseTA21Response = DirectCast(CloseTA21Request.GetResponse(), HttpWebResponse)
            Dim CloseTA21Reader As New StreamReader(CloseTA21Response.GetResponseStream())
            Dim thepage As String = CloseTA21Reader.ReadToEnd
        Catch ex As Exception

        End Try
    End Sub
    'TA21 Open and Close Events End

    'TA22 Open and Close Events Start
    Private Sub btnTA22Opn_Click(sender As Object, e As EventArgs) Handles btnTA22Opn.Click
        Dim OpenTA22Request As HttpWebRequest = DirectCast(WebRequest.Create("http://192.168.1.14/allStatus?key=keyOn"), HttpWebRequest)
        OpenTA22Request.Timeout = My.Settings.timeOut
        Try
            Dim OpenTA22Response As HttpWebResponse
            OpenTA22Response = DirectCast(OpenTA22Request.GetResponse(), HttpWebResponse)
            Dim OpenTA22Reader As New StreamReader(OpenTA22Response.GetResponseStream())
            Dim thepage As String = OpenTA22Reader.ReadToEnd
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnTA22Cls_Click(sender As Object, e As EventArgs) Handles btnTA22Cls.Click
        Dim CloseTA22Request As HttpWebRequest = DirectCast(WebRequest.Create("http://192.168.1.14/allStatus?key=keyOff"), HttpWebRequest)
        CloseTA22Request.Timeout = My.Settings.timeOut
        Try
            Dim CloseTA22Response As HttpWebResponse
            CloseTA22Response = DirectCast(CloseTA22Request.GetResponse(), HttpWebResponse)
            Dim CloseTA22Reader As New StreamReader(CloseTA22Response.GetResponseStream())
            Dim thepage As String = CloseTA22Reader.ReadToEnd
        Catch ex As Exception

        End Try
    End Sub
    'TA22 Open and Close Events End

    'TA23 Open and Close Events Start
    Private Sub btnTA23Opn_Click(sender As Object, e As EventArgs) Handles btnTA23Opn.Click
        Dim OpenTA23Request As HttpWebRequest = DirectCast(WebRequest.Create("http://192.168.1.15/allStatus?key=keyOn"), HttpWebRequest)
        OpenTA23Request.Timeout = My.Settings.timeOut
        Try
            Dim OpenTA23Response As HttpWebResponse
            OpenTA23Response = DirectCast(OpenTA23Request.GetResponse(), HttpWebResponse)
            Dim OpenTA23Reader As New StreamReader(OpenTA23Response.GetResponseStream())
            Dim thepage As String = OpenTA23Reader.ReadToEnd
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnTA23Cls_Click(sender As Object, e As EventArgs) Handles btnTA23Cls.Click
        Dim CloseTA23Request As HttpWebRequest = DirectCast(WebRequest.Create("http://192.168.1.15/allStatus?key=keyOff"), HttpWebRequest)
        CloseTA23Request.Timeout = My.Settings.timeOut
        Try
            Dim CloseTA23Response As HttpWebResponse
            CloseTA23Response = DirectCast(CloseTA23Request.GetResponse(), HttpWebResponse)
            Dim CloseTA23Reader As New StreamReader(CloseTA23Response.GetResponseStream())
            Dim thepage As String = CloseTA23Reader.ReadToEnd
        Catch ex As Exception

        End Try
    End Sub
    'TA23 Open and Close Events End

    'TA24 Open and Close Events Start
    Private Sub btnTA24Opn_Click(sender As Object, e As EventArgs) Handles btnTA24Opn.Click
        Dim OpenTA24Request As HttpWebRequest = DirectCast(WebRequest.Create("http://192.168.1.16/allStatus?key=keyOn"), HttpWebRequest)
        OpenTA24Request.Timeout = My.Settings.timeOut
        Try
            Dim OpenTA24Response As HttpWebResponse
            OpenTA24Response = DirectCast(OpenTA24Request.GetResponse(), HttpWebResponse)
            Dim OpenTA24Reader As New StreamReader(OpenTA24Response.GetResponseStream())
            Dim thepage As String = OpenTA24Reader.ReadToEnd
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnTA24Cls_Click(sender As Object, e As EventArgs) Handles btnTA24Cls.Click
        Dim CloseTA24Request As HttpWebRequest = DirectCast(WebRequest.Create("http://192.168.1.16/allStatus?key=keyOff"), HttpWebRequest)
        CloseTA24Request.Timeout = My.Settings.timeOut
        Try
            Dim CloseTA24Response As HttpWebResponse
            CloseTA24Response = DirectCast(CloseTA24Request.GetResponse(), HttpWebResponse)
            Dim CloseTA24Reader As New StreamReader(CloseTA24Response.GetResponseStream())
            Dim thepage As String = CloseTA24Reader.ReadToEnd
        Catch ex As Exception

        End Try
    End Sub
    'TA24 Open and Close Events End
    'SHUTTER OPEN AND CLOSE EVENTS









    Private Sub DebugToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DebugToolStripMenuItem.Click
        Timer1.Enabled = False
        Me.Enabled = False
        Try
            myThread.Abort()
        Catch
        End Try
        My.Forms.TimeVariables.Show()
    End Sub

    Private Sub SLPAddressAssignmentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SLPAddressAssignmentsToolStripMenuItem.Click
        Timer1.Enabled = False
        Me.Enabled = False
        Try
            myThread.Abort()
        Catch ex As Exception
        End Try
        My.Forms.SLP_Assignments.Show()
    End Sub

    Private Sub GrayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GrayToolStripMenuItem.Click
        My.Settings.traceErrorColor = Color.Gray
        My.Settings.Save()
        MessageBox.Show("Changes applied.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub OrangeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrangeToolStripMenuItem.Click
        My.Settings.traceErrorColor = Color.Orange
        My.Settings.Save()
        MessageBox.Show("Changes applied.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ShowDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowDataToolStripMenuItem.Click
        If showDataStatus = True Then
            showDataStatus = False
            MessageBox.Show("SLP data are now hidden.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            showDataStatus = True
            MessageBox.Show("SLP data are now shown.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If (myThread.IsAlive = False) Then
            loadThread()
        End If
    End Sub

    Private Sub AboutUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutUsToolStripMenuItem.Click
        Process.Start("https://www.lasermet.com")
    End Sub

End Class