Imports System.IO
Imports System.Net
Public Class DOOR_INPUTS_AND_ALIGNMENT_MODES
    Dim OW_String(150) As String
    Public OW_Address(150) As String
    Dim OW_Data(150) As String
    Dim connectionPresent As Boolean = False
    Dim myThread3 As System.Threading.Thread
    Public checkStatusDone As Boolean = False
    'Coordinates
    'AND06 Polyline Coordinates
    Dim AND_01_A() As Point = {New Point(426, 80), New Point(698, 80), New Point(698, 110), New Point(706, 110)}
    Dim AND_01_B() As Point = {New Point(564, 197), New Point(698, 197), New Point(698, 129), New Point(706, 129)}
    Dim AND_01_OUT() As Point = {New Point(766, 120), New Point(913, 120)}
    'AND02 Polyline Coordinates
    Dim AND_02_A1() As Point = {New Point(426, 157.5), New Point(579.5, 157.5), New Point(579.5, 230.5), New Point(591, 230.5)}
    Dim AND_02_A2() As Point = {New Point(495.5, 157.5), New Point(495.5, 187), New Point(504, 187)}
    Dim AND_02_B1() As Point = {New Point(426, 235), New Point(495.5, 235), New Point(495.5, 282), New Point(672, 282), New Point(672, 327), New Point(681, 327)}
    Dim AND_02_B2() As Point = {New Point(495.5, 235), New Point(495.5, 206.5), New Point(504, 206.5)}
    'AND03 Polyline Coordinates
    Dim AND_03_B() As Point = {New Point(591, 250), New Point(579.5, 250), New Point(579.5, 352), New Point(564, 352)}
    Dim AND_03_OUT() As Point = {New Point(651, 240), New Point(795, 240)}
    'AND04 Polyline Coordinates
    Dim AND_04_A() As Point = {New Point(426, 313), New Point(495, 313), New Point(495, 342), New Point(504, 342)}
    Dim AND_04_B1() As Point = {New Point(504, 362), New Point(495, 362), New Point(495, 390), New Point(672, 390), New Point(672, 346), New Point(681, 346)}
    Dim AND_04_B2() As Point = {New Point(495, 390), New Point(426, 390)}
    'AND06 Polyline Coordinates
    Dim AND_06_A() As Point = {New Point(740, 336), New Point(810, 336), New Point(810, 392), New Point(818, 392)}
    Dim AND_06_B() As Point = {New Point(426, 468), New Point(810, 468), New Point(810, 411), New Point(818, 411)}
    Dim AND_06_OUT() As Point = {New Point(878, 402), New Point(1025, 402)}
    'AND16 Polyline Coordinates
    Dim AND_16_A1() As Point = {New Point(426, 606), New Point(495.5, 606), New Point(495.5, 597), New Point(504, 597)}
    Dim AND_16_A2() As Point = {New Point(495.5, 606), New Point(495.5, 616), New Point(504, 616)}
    Dim AND_16_OUT() As Point = {New Point(564, 606), New Point(928, 606)}
    'NC-01 Polyline Coordinates
    Dim NC_01_IN1() As Point = {New Point(426, 684), New Point(760, 684)}
    Dim NC_01_OUT() As Point = {New Point(873, 684), New Point(928, 684)}
    'NC-03 Polyline Coordinates
    Dim NC_03_IN1() As Point = {New Point(426, 761.5), New Point(760, 761.5)}
    Dim NC_03_OUT() As Point = {New Point(873, 761.5), New Point(928, 761.5)}
    'NC-05 Polyline Coordinates
    Dim NC_05_IN1() As Point = {New Point(426, 839), New Point(760, 839)}
    Dim NC_05_OUT() As Point = {New Point(873, 839), New Point(928, 839)}
    'Coordinates



    'Trace State Control
    Public Sub Trace_ON(ByVal Trace() As Point)
        Dim LoadLines As Graphics = CreateGraphics()
        Dim LoadPen As Pen = New Pen(Color.Green, 4)
        LoadLines.DrawLines(LoadPen, Trace)
    End Sub
    Public Sub Trace_OFF(ByVal Trace() As Point)
        Dim LoadLines As Graphics = CreateGraphics()
        Dim LoadPen As Pen = New Pen(Color.Red, 4)
        LoadLines.DrawLines(LoadPen, Trace)
    End Sub
    Public Sub Trace_Error(ByVal Trace() As Point)
        Dim LoadLines As Graphics = CreateGraphics()
        Dim LoadPen As Pen = New Pen(My.Settings.traceErrorColor, 4)
        LoadLines.DrawLines(LoadPen, Trace)
    End Sub

    Public Sub updateSLPMapSheet1()
        If connectionPresent = True Then
            'Connection Present Conditions
            'AND01
            Try
                Dim indexAND01 As Integer = Array.IndexOf(OW_Address, My.Settings.AND01Address)
                lblDataAND01.Text = OW_Data(indexAND01).ToString
            Catch
            End Try
            'AND01-A
            If (getTraceData1(My.Settings.AND01Address) = "01") Then
                Trace_ON(AND_01_A)
            ElseIf (getTraceData1(My.Settings.AND01Address) = "10") Then
                Trace_OFF(AND_01_A)
            Else
                Trace_Error(AND_01_A)
            End If
            'AND01-B
            'If (getTraceData2(My.Settings.AND01Address) = "01") Then
            '    Trace_ON(AND_01_B)
            'ElseIf (getTraceData2(My.Settings.AND01Address) = "10") Then
            '    Trace_OFF(AND_01_B)
            'Else
            '    Trace_Error(AND_01_B)
            'End If
            'AND01-OUT
            If (getTraceDataOUT(My.Settings.AND01Address) = "01") Then
                Trace_ON(AND_01_OUT)
            ElseIf (getTraceDataOUT(My.Settings.AND01Address) = "10") Then
                Trace_OFF(AND_01_OUT)
            Else
                Trace_Error(AND_01_OUT)
            End If
            'AND02
            Try
                Dim indexAND02 As Integer = Array.IndexOf(OW_Address, My.Settings.AND02Address)
                lblDataAND02.Text = OW_Data(indexAND02).ToString
            Catch
            End Try
            'AND02-A
            Console.WriteLine("AND02A: " + getTraceData1(My.Settings.AND02Address))
            Console.WriteLine("AND03A: " + getTraceData1(My.Settings.AND03Address))
            If (getTraceData1(My.Settings.AND02Address) = "01") And (getTraceData1(My.Settings.AND03Address) = "01") Then
                Trace_ON(AND_02_A1)
                Trace_ON(AND_02_A2)
            ElseIf (getTraceData1(My.Settings.AND02Address) = "10") And (getTraceData1(My.Settings.AND03Address) = "10") Then
                Trace_OFF(AND_02_A1)
                Trace_OFF(AND_02_A2)
            Else
                Trace_Error(AND_02_A1)
                Trace_Error(AND_02_A2)
            End If
            'AND02-B
            If (getTraceData2(My.Settings.AND02Address) = "01") And (getTraceData1(My.Settings.AND05Address) = "01") Then
                Trace_ON(AND_02_B1)
                Trace_ON(AND_02_B2)
            ElseIf (getTraceData2(My.Settings.AND02Address) = "10") And (getTraceData1(My.Settings.AND05Address) = "10") Then
                Trace_OFF(AND_02_B1)
                Trace_OFF(AND_02_B2)
            Else
                Trace_Error(AND_02_B1)
                Trace_Error(AND_02_B2)
            End If
            'AND02-OUT
            If (getTraceDataOUT(My.Settings.AND02Address) = "01") And (getTraceData2(My.Settings.AND01Address) = "01") Then
                Trace_ON(AND_01_B)
            ElseIf (getTraceDataOUT(My.Settings.AND02Address) = "10") And (getTraceData2(My.Settings.AND01Address) = "10") Then
                Trace_OFF(AND_01_B)
            Else
                Trace_Error(AND_01_B)
            End If
            'AND03
            Try
                Dim indexAND03 As Integer = Array.IndexOf(OW_Address, My.Settings.AND03Address)
                lblDataAND03.Text = OW_Data(indexAND03).ToString
            Catch
            End Try
            'AND03-A
            'AND03-B
            'AND03OUT
            If (getTraceDataOUT(My.Settings.AND03Address) = "01") Then
                Trace_ON(AND_03_OUT)
            ElseIf (getTraceDataOUT(My.Settings.AND03Address) = "10") Then
                Trace_OFF(AND_03_OUT)
            Else
                Trace_Error(AND_03_OUT)
            End If
            'AND04
            Try
                Dim indexAND04 As Integer = Array.IndexOf(OW_Address, My.Settings.AND04Address)
                lblDataAND04.Text = OW_Data(indexAND04).ToString
            Catch
            End Try
            'AND04-A
            If (getTraceData1(My.Settings.AND04Address) = "01") Then
                Trace_ON(AND_04_A)
            ElseIf (getTraceData1(My.Settings.AND04Address) = "10") Then
                Trace_OFF(AND_04_A)
            Else
                Trace_Error(AND_04_A)
            End If
            'AND04-B
            If (getTraceData2(My.Settings.AND04Address) = "01") And (getTraceData2(My.Settings.AND05Address) = "01") Then
                Trace_ON(AND_04_B1)
                Trace_ON(AND_04_B2)
            ElseIf (getTraceData2(My.Settings.AND04Address) = "10") And (getTraceData2(My.Settings.AND05Address) = "10") Then
                Trace_OFF(AND_04_B1)
                Trace_OFF(AND_04_B2)
            Else
                Trace_Error(AND_04_B1)
                Trace_Error(AND_04_B2)
            End If
            'AND04-OUT
            If (getTraceDataOUT(My.Settings.AND04Address) = "01") And (getTraceData2(My.Settings.AND03Address) = "01") Then
                Trace_ON(AND_03_B)
            ElseIf (getTraceDataOUT(My.Settings.AND04Address) = "10") And (getTraceData2(My.Settings.AND03Address) = "10") Then
                Trace_OFF(AND_03_B)
            Else
                Trace_Error(AND_03_B)
            End If
            'AND05
            Try
                Dim indexAND05 As Integer = Array.IndexOf(OW_Address, My.Settings.AND05Address)
                lblDataAND05.Text = OW_Data(indexAND05).ToString
            Catch
            End Try
            'AND05-OUT  
            If (getTraceDataOUT(My.Settings.AND05Address) = "01") And (getTraceData1(My.Settings.AND06Address) = "01") Then
                Trace_ON(AND_06_A)
            ElseIf (getTraceDataOUT(My.Settings.AND05Address) = "10") And (getTraceData1(My.Settings.AND06Address) = "10") Then
                Trace_OFF(AND_06_A)
            Else
                Trace_Error(AND_06_A)
            End If
            'AND06
            Try
                Dim indexAND06 As Integer = Array.IndexOf(OW_Address, My.Settings.AND06Address)
                lblDataAND06.Text = OW_Data(indexAND06).ToString
            Catch
            End Try
            'AND06-A
            'AND06-B
            If (getTraceData2(My.Settings.AND06Address) = "01") Then
                Trace_ON(AND_06_B)
            ElseIf (getTraceData2(My.Settings.AND06Address) = "10") Then
                Trace_OFF(AND_06_B)
            Else
                Trace_Error(AND_06_B)
            End If
            'AND06-OUT
            If (getTraceDataOUT(My.Settings.AND06Address) = "01") Then
                Trace_ON(AND_06_OUT)
            ElseIf (getTraceDataOUT(My.Settings.AND06Address) = "10") Then
                Trace_OFF(AND_06_OUT)
            Else
                Trace_Error(AND_06_OUT)
            End If
            'AND16
            Try
                Dim indexAND16 As Integer = Array.IndexOf(OW_Address, My.Settings.AND16Address)
                lblDataAND16.Text = OW_Data(indexAND16).ToString
            Catch
            End Try
            'AND16-A
            If (getTraceData1(My.Settings.AND16Address) = "01") And (getTraceData2(My.Settings.AND16Address) = "01") Then
                Trace_ON(AND_16_A1)
                Trace_ON(AND_16_A2)
            ElseIf (getTraceData1(My.Settings.AND16Address) = "10") And (getTraceData2(My.Settings.AND16Address) = "10") Then
                Trace_OFF(AND_16_A1)
                Trace_OFF(AND_16_A2)
            Else
                Trace_Error(AND_16_A1)
                Trace_Error(AND_16_A2)
            End If
            'AND16-B
            'AND16-OUT
            If (getTraceDataOUT(My.Settings.AND16Address) = "01") Then
                Trace_ON(AND_16_OUT)
            ElseIf (getTraceDataOUT(My.Settings.AND16Address) = "10") Then
                Trace_OFF(AND_16_OUT)
            Else
                Trace_Error(AND_16_OUT)
            End If
            'NC-01/NC-02
            Try
                Dim indexNC01 As Integer = Array.IndexOf(OW_Address, My.Settings.NC01Address)
                lblDataNC01.Text = OW_Data(indexNC01).ToString
                Dim indexNC02 As Integer = Array.IndexOf(OW_Address, My.Settings.NC02Address)
                lblDataNC02.Text = OW_Data(indexNC02).ToString
            Catch
            End Try
            'IN
            If (getTraceData1(My.Settings.NC01Address) = "01") And (getTraceData1(My.Settings.NC02Address) = "01") Then
                Trace_ON(NC_01_IN1)
            ElseIf (getTraceData1(My.Settings.NC01Address) = "10") And (getTraceData1(My.Settings.NC02Address) = "10") Then
                Trace_OFF(NC_01_IN1)
            Else
                Trace_Error(NC_01_IN1)
            End If
            'OUT
            If (getTraceDataOUT(My.Settings.NC01Address) = "01") And (getTraceDataOUT(My.Settings.NC02Address) = "01") Then
                Trace_ON(NC_01_OUT)
            ElseIf (getTraceDataOUT(My.Settings.NC01Address) = "10") And (getTraceDataOUT(My.Settings.NC02Address) = "10") Then
                Trace_OFF(NC_01_OUT)
            Else
                Trace_Error(NC_01_OUT)
            End If
            'NC-03/NC-04
            Try
                Dim indexNC03 As Integer = Array.IndexOf(OW_Address, My.Settings.NC03Address)
                lblDataNC03.Text = OW_Data(indexNC03).ToString
                Dim indexNC04 As Integer = Array.IndexOf(OW_Address, My.Settings.NC04Address)
                lblDataNC04.Text = OW_Data(indexNC04).ToString
            Catch
            End Try
            'IN
            If (getTraceData1(My.Settings.NC03Address) = "01") And (getTraceData1(My.Settings.NC04Address) = "01") Then
                Trace_ON(NC_03_IN1)
            ElseIf (getTraceData1(My.Settings.NC03Address) = "10") And (getTraceData1(My.Settings.NC04Address) = "10") Then
                Trace_OFF(NC_03_IN1)
            Else
                Trace_Error(NC_03_IN1)
            End If
            'OUT
            If (getTraceDataOUT(My.Settings.NC03Address) = "01") And (getTraceDataOUT(My.Settings.NC04Address) = "01") Then
                Trace_ON(NC_03_OUT)
            ElseIf (getTraceDataOUT(My.Settings.NC01Address) = "10") And (getTraceDataOUT(My.Settings.NC02Address) = "10") Then
                Trace_OFF(NC_03_OUT)
            Else
                Trace_Error(NC_03_OUT)
            End If
            'NC-05/NC-06
            Try
                Dim indexNC05 As Integer = Array.IndexOf(OW_Address, My.Settings.NC05Address)
                lblDataNC05.Text = OW_Data(indexNC05).ToString
                Dim indexNC06 As Integer = Array.IndexOf(OW_Address, My.Settings.NC06Address)
                lblDataNC06.Text = OW_Data(indexNC06).ToString
            Catch
            End Try
            'IN
            If (getTraceData1(My.Settings.NC05Address) = "01") And (getTraceData1(My.Settings.NC06Address) = "01") Then
                Trace_ON(NC_05_IN1)
            ElseIf (getTraceData1(My.Settings.NC05Address) = "10") And (getTraceData1(My.Settings.NC06Address) = "10") Then
                Trace_OFF(NC_05_IN1)
            Else
                Trace_Error(NC_05_IN1)
            End If
            'OUT
            If (getTraceDataOUT(My.Settings.NC05Address) = "01") And (getTraceDataOUT(My.Settings.NC06Address) = "01") Then
                Trace_ON(NC_05_OUT)
            ElseIf (getTraceDataOUT(My.Settings.NC05Address) = "10") And (getTraceDataOUT(My.Settings.NC06Address) = "10") Then
                Trace_OFF(NC_05_OUT)
            Else
                Trace_Error(NC_05_OUT)
            End If
        End If
    End Sub
    Public Sub loadThread()
        myThread3 = New System.Threading.Thread(AddressOf CheckOW)
        myThread3.Start()
    End Sub
    Public Sub CheckOW()

        Try
            Dim checkOWRequest As HttpWebRequest = DirectCast(WebRequest.Create("http://192.168.1.17"), HttpWebRequest)
            checkOWRequest.Timeout = 1000
            Array.Clear(OW_Data, 0, 150)
            Array.Clear(OW_Address, 0, 150)
            Dim checkOWResponse As HttpWebResponse
            checkOWResponse = DirectCast(checkOWRequest.GetResponse(), HttpWebResponse)
            Dim checkOWReader As New StreamReader(checkOWResponse.GetResponseStream())
            OW_String = checkOWReader.ReadToEnd.ToString.Split("-")
            For index As Integer = 0 To (OW_String.Length - 2)
                If OW_String(index).Length = 25 Then
                    OW_Data(index) = OW_String(index).Substring(16, 8)
                ElseIf OW_String(index).Length = 24 Then
                    OW_Data(index) = "0" + OW_String(index).Substring(16, 7)
                ElseIf OW_String(index).Length = 23 Then
                    OW_Data(index) = "00" + OW_String(index).Substring(16, 6)
                ElseIf OW_String(index).Length = 22 Then
                    OW_Data(index) = "000" + OW_String(index).Substring(16, 5)
                ElseIf OW_String(index).Length = 21 Then
                    OW_Data(index) = "0000" + OW_String(index).Substring(16, 4)
                ElseIf OW_String(index).Length = 20 Then
                    OW_Data(index) = "00000" + OW_String(index).Substring(16, 3)
                ElseIf OW_String(index).Length = 19 Then
                    OW_Data(index) = "000000" + OW_String(index).Substring(16, 2)
                ElseIf OW_String(index).Length = 18 Then
                    OW_Data(index) = "0000000" + OW_String(index).Substring(16, 1)
                End If
                OW_Address(index) = OW_String(index).Substring(0, 16)
                'RichTextBox1.Text += OW_Data(index) + Environment.NewLine
            Next
            checkStatusDone = True
            connectionPresent = True
        Catch ex As WebException
            checkStatusDone = False
            connectionPresent = False
            Timer1.Enabled = False
            Timer2.Enabled = False
            Dim result As DialogResult = MessageBox.Show("The program couldn't detect the OWTEN-Card." + Environment.NewLine +
                            "Please make sure that the OWTEN-Card is powered up and connected to the hub." + Environment.NewLine +
                            "Would you like to re-establish connection again?",
                            "Connection Error!", MessageBoxButtons.YesNo, MessageBoxIcon.Error)

            If (result = DialogResult.Yes) Then
                Timer1.Enabled = True
                Timer2.Enabled = True
            ElseIf (result = DialogResult.No) Then
                My.Forms.Form1.Close()
            End If
            myThread3.Abort()
        End Try
    End Sub

    'Get Trace Data
    Public Function getTraceData2(ByVal Address As String) As String
        Try
            Dim index As Integer = Array.IndexOf(OW_Address, Address)
            Dim Data_1 As String = OW_Data(index).Substring(4, 2)
            Return Data_1
        Catch
            Return Nothing
        End Try

    End Function
    Public Function getTraceData1(ByVal Address As String) As String
        Try
            Dim index As Integer = Array.IndexOf(OW_Address, Address)
            Dim Data_1 As String = OW_Data(index).Substring(6, 2)
            Return Data_1
        Catch
            Return Nothing
        End Try
    End Function
    Public Function getTraceDataOUT(ByVal Address As String) As String
        Try
            Dim index As Integer = Array.IndexOf(OW_Address, Address)
            Dim Data_1 As String = OW_Data(index).Substring(2, 2)
            Return Data_1
        Catch
            Return Nothing
        End Try
    End Function

    'Get Trace Data


    Private Sub DOOR_INPUTS_AND_ALIGNMENT_MODES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer2.Interval = My.Settings.refreshRate
        Timer1.Enabled = True 'CHECK OW
        Timer2.Enabled = True
        loadThread()
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Console.WriteLine("Connection Present: " + connectionPresent.ToString)
        If (myThread3.IsAlive = False) Then
            myThread3.Abort()
            loadThread()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If checkStatusDone = True Then
            updateSLPMapSheet1()
            checkStatusDone = False
        End If

        If (Form1.showDataStatus = True) Then
            lblDataAND01.Visible = True
            lblDataAND02.Visible = True
            lblDataAND03.Visible = True
            lblDataAND04.Visible = True
            lblDataAND05.Visible = True
            lblDataAND06.Visible = True
            lblDataAND16.Visible = True
            lblDataNC01.Visible = True
            lblDataNC02.Visible = True
            lblDataNC03.Visible = True
            lblDataNC04.Visible = True
            lblDataNC05.Visible = True
            lblDataNC06.Visible = True
        Else
            lblDataAND01.Visible = False
            lblDataAND02.Visible = False
            lblDataAND03.Visible = False
            lblDataAND04.Visible = False
            lblDataAND05.Visible = False
            lblDataAND06.Visible = False
            lblDataAND16.Visible = False
            lblDataNC01.Visible = False
            lblDataNC02.Visible = False
            lblDataNC03.Visible = False
            lblDataNC04.Visible = False
            lblDataNC05.Visible = False
            lblDataNC06.Visible = False
        End If

    End Sub
End Class