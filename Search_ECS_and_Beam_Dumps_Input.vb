Imports System.Net
Imports System.IO
Class Search_ECS_and_Beam_Dumps_Input
    Dim OW_String() As String
    Public OW_Address(150) As String
    Dim OW_Data(150) As String
    Dim connectionPresent As Boolean = False

    Public updateComplete As Boolean = False
    Public checkStatusDone As Boolean = False
    Dim myThread2 As System.Threading.Thread
    Public Sub LoadThread()
        myThread2 = New System.Threading.Thread(AddressOf CheckOW)
        myThread2.Start()
    End Sub
    'coordinates
    'AND15 Polyline Coordinates
    Dim AND_15_A() As Point = {New Point(1036, 270), New Point(1094, 270), New Point(1094, 325.5), New Point(1101, 325.5)}
    Dim AND_15_B() As Point = {New Point(1052, 406.5), New Point(1094, 406.5), New Point(1094, 342.5), New Point(1101, 342.5)}
    Dim AND_15_OUT() As Point = {New Point(1155, 334), New Point(1171, 334)}
    'AND12 Polyline Coordinates
    Dim AND_12_B1() As Point = {New Point(305, 802), New Point(299, 802), New Point(299, 827.5), New Point(625, 827.5), New Point(625, 802), New Point(631, 802)}
    Dim AND_12_B2() As Point = {New Point(174, 827.5), New Point(299, 827.5)}
    'AND11 Polyline Coordinates
    Dim AND_11_A1() As Point = {New Point(174, 656.5), New Point(394, 656.5), New Point(394, 682), New Point(400, 682)}
    Dim AND_11_A2() As Point = {New Point(394, 656.5), New Point(625, 656.5), New Point(625, 785), New Point(631, 785)}
    'AND10 Polyline Coordinates
    Dim AND_10_A1() As Point = {New Point(174, 554), New Point(299, 554), New Point(299, 599), New Point(305, 599)}
    Dim AND_10_A2() As Point = {New Point(237.5, 554), New Point(237.5, 760), New Point(299, 760), New Point(299, 785), New Point(305, 785)}
    Dim AND_10_B1() As Point = {New Point(305, 616), New Point(299, 616), New Point(299, 726), New Point(174, 726)}
    Dim AND_10_B2() As Point = {New Point(299, 726), New Point(394, 726), New Point(394, 699), New Point(400, 699)}
    'AND09 Polyline Coordinates
    Dim AND_09_A() As Point = {New Point(504, 169.5), New Point(850.5, 169.5), New Point(850.5, 203), New Point(857, 203)}
    Dim AND_09_B() As Point = {New Point(857, 220.5), New Point(850.5, 220.5), New Point(850.5, 793.5), New Point(687, 793.5)}
    'AND08 Polyline Coordinates
    Dim AND_08_A() As Point = {New Point(174, 112.5), New Point(443, 112.5), New Point(443, 161), New Point(449, 161)}
    Dim AND_08_B1() As Point = {New Point(449, 178), New Point(443, 178), New Point(443, 227), New Point(455, 227)}
    Dim AND_08_B2() As Point = {New Point(360, 227), New Point(443, 227)}
    'AND07 Polyline Coordinates
    Dim AND_07_A() As Point = {New Point(174, 198.5), New Point(299, 198.5), New Point(299, 218.5), New Point(305, 218.5)}
    Dim AND_07_B1() As Point = {New Point(174, 270), New Point(299, 270), New Point(299, 236), New Point(305, 236)}
    Dim AND_07_B2() As Point = {New Point(299, 270), New Point(299, 388), New Point(308, 388)}
    Dim AND_07_B3() As Point = {New Point(299, 309.5), New Point(385, 309.5)}
    Dim AND_07_B4() As Point = {New Point(299, 351), New Point(385, 351)}
    'AND14 Polyline Coordinates
    Dim AND_14_A() As Point = {New Point(359, 396.5), New Point(764, 396.5), New Point(764, 476), New Point(770, 476)}
    Dim AND_14_B() As Point = {New Point(770, 493.5), New Point(764, 493.5), New Point(764, 688.5), New Point(723, 688.5)}
    'OR01 Polyline Coordinates
    Dim OR_01_B() As Point = {New Point(174, 467), New Point(299, 467), New Point(299, 405), New Point(308, 405)}
    'OR02 Polyline Coordinates
    Dim OR_02_A() As Point = {New Point(455, 690.5), New Point(504, 690.5), New Point(504, 734), New Point(513, 734)}
    Dim OR_02_B() As Point = {New Point(513, 752), New Point(504, 752), New Point(504, 793.5), New Point(360, 793.5)}
    'OR03 Polyline Coordinates
    Dim OR_03_A() As Point = {New Point(360, 607.5), New Point(662.5, 607.5), New Point(662.5, 679.5), New Point(672, 679.5)}
    Dim OR_03_B() As Point = {New Point(564, 743), New Point(662.5, 743), New Point(662.5, 697), New Point(672, 697)}
    'OR04 Polyline Coordinates
    Dim OR_04_A1() As Point = {New Point(912, 212), New Point(1022, 212), New Point(1022, 76), New Point(1047, 76)}
    Dim OR_04_A2() As Point = {New Point(976, 212), New Point(976, 261), New Point(985, 261)}
    Dim OR_04_A3() As Point = {New Point(1022, 136), New Point(1047, 136)}
    Dim OR_04_B() As Point = {New Point(985, 278.5), New Point(976, 278.5), New Point(976, 484.5), New Point(825, 484.5)}
    'NO01 Polyline Coordinates
    Dim NO_01_OUT() As Point = {New Point(549, 227), New Point(586, 227)}
    'NO02 Polyline Coordinates
    Dim NO_02_OUT() As Point = {New Point(478, 309.5), New Point(577, 309.5)}
    'NO03 Polyline Coordinates
    Dim NO_03_OUT() As Point = {New Point(478, 351), New Point(577, 351)}
    'NO04 Polyline Coordintes
    Dim NO_04_OUT() As Point = {New Point(1141, 76), New Point(1164, 76)}
    'NO05 Polyline Coordinates
    Dim NO_05_OUT() As Point = {New Point(1141, 136), New Point(1164, 136)}
    'coordinates

    'getTrace and Trace State Functions
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
    Public Sub Trace_ON(ByVal Trace() As Point)
        Try
            Dim LoadLines As Graphics = CreateGraphics()
            Dim LoadPen As Pen = New Pen(Color.Green, 4)
            LoadLines.DrawLines(LoadPen, Trace)
        Catch
        End Try
    End Sub
    Public Sub Trace_OFF(ByVal Trace() As Point)
        Try
            Dim LoadLines As Graphics = CreateGraphics()
            Dim LoadPen As Pen = New Pen(Color.Red, 4)
            LoadLines.DrawLines(LoadPen, Trace)
        Catch
        End Try
    End Sub
    Public Sub Trace_Error(ByVal Trace() As Point)
        Try
            Dim LoadLines As Graphics = CreateGraphics()
            Dim LoadPen As Pen = New Pen(My.Settings.traceErrorColor, 4)
            LoadLines.DrawLines(LoadPen, Trace)
        Catch
        End Try
    End Sub
    'getTrace and Trace State Function
    Public Sub updateSLPMapSheet2()
        If connectionPresent = True Then
            Try
                'AND07
                Dim indexAND07 As Integer = Array.IndexOf(OW_Address, My.Settings.AND07Address)
                lblDataAND07.Text = OW_Data(indexAND07).ToString
                'AND07-A
                If (getTraceData1(My.Settings.AND07Address) = "01") Then
                    Trace_ON(AND_07_A)
                ElseIf (getTraceData1(My.Settings.AND07Address) = "10") Then
                    Trace_OFF(AND_07_A)
                Else
                    Trace_Error(AND_07_A)
                End If
                'AND07-B
                If (getTraceData2(My.Settings.AND07Address) = "01") And (getTraceData1(My.Settings.OR01Address) = "01") And
               (getTraceData1(My.Settings.NO02Address) = "01") And (getTraceData1(My.Settings.NO03Address) = "01") Then
                    Trace_ON(AND_07_B1)
                    Trace_ON(AND_07_B2)
                    Trace_ON(AND_07_B3)
                    Trace_ON(AND_07_B4)
                ElseIf (getTraceData2(My.Settings.AND07Address) = "10") And (getTraceData1(My.Settings.OR01Address) = "10") And
                   (getTraceData1(My.Settings.NO02Address) = "10") And (getTraceData1(My.Settings.NO03Address) = "10") Then
                    Trace_OFF(AND_07_B1)
                    Trace_OFF(AND_07_B2)
                    Trace_OFF(AND_07_B3)
                    Trace_OFF(AND_07_B4)
                Else
                    Trace_Error(AND_07_B1)
                    Trace_Error(AND_07_B2)
                    Trace_Error(AND_07_B3)
                    Trace_Error(AND_07_B4)
                End If
            Catch
            End Try

            Try
                'AND08
                Dim indexAND08 As Integer = Array.IndexOf(OW_Address, My.Settings.AND08Address)
                lblDataAND08.Text = OW_Data(indexAND08).ToString
                'AND08-A
                If (getTraceData1(My.Settings.AND08Address) = "01") Then
                    Trace_ON(AND_08_A)
                ElseIf (getTraceData1(My.Settings.AND08Address) = "10") Then
                    Trace_OFF(AND_08_A)
                Else
                    Trace_Error(AND_08_A)
                End If
                'AND08-B
                If (getTraceDataOUT(My.Settings.AND07Address) = "01") And
                (getTraceData1(My.Settings.NO01Address) = "01") And
                (getTraceData2(My.Settings.AND08Address) = "01") Then
                    Trace_ON(AND_08_B1)
                    Trace_ON(AND_08_B2)
                ElseIf (getTraceDataOUT(My.Settings.AND07Address) = "10") And
                (getTraceData1(My.Settings.NO01Address) = "10") And
                (getTraceData2(My.Settings.AND08Address) = "10") Then
                    Trace_OFF(AND_08_B1)
                    Trace_OFF(AND_08_B2)
                Else
                    Trace_Error(AND_08_B1)
                    Trace_Error(AND_08_B2)
                End If
                'AND08-OUT
                If (getTraceDataOUT(My.Settings.AND08Address) = "01") And (getTraceData1(My.Settings.AND09Address) = "01") Then
                    Trace_ON(AND_09_A)
                ElseIf (getTraceDataOUT(My.Settings.AND08Address) = "10") And (getTraceData1(My.Settings.AND09Address) = "10") Then
                    Trace_OFF(AND_09_A)
                Else
                    Trace_Error(AND_09_A)
                End If
            Catch
            End Try

            Try
                'AND09
                Dim indexAND09 As Integer = Array.IndexOf(OW_Address, My.Settings.AND09Address)
                lblDataAND09.Text = OW_Data(indexAND09).ToString
                'AND09-A
                'AND09-B
                'AND09-OUT
                If (getTraceDataOUT(My.Settings.AND09Address) = "01") And (getTraceData1(My.Settings.OR04Address) = "01") And
               (getTraceData1(My.Settings.NO04Address) = "01") And (getTraceData1(My.Settings.NO05Address) = "01") Then
                    Trace_ON(OR_04_A1)
                    Trace_ON(OR_04_A2)
                    Trace_ON(OR_04_A3)
                ElseIf (getTraceDataOUT(My.Settings.AND09Address) = "10") And (getTraceData1(My.Settings.OR04Address) = "10") And
               (getTraceData1(My.Settings.NO04Address) = "10") And (getTraceData1(My.Settings.NO05Address) = "10") Then
                    Trace_OFF(OR_04_A1)
                    Trace_OFF(OR_04_A2)
                    Trace_OFF(OR_04_A3)
                Else
                    Trace_Error(OR_04_A1)
                    Trace_Error(OR_04_A2)
                    Trace_Error(OR_04_A3)
                End If
            Catch
            End Try

            Try
                'AND10
                Dim indexAND10 As Integer = Array.IndexOf(OW_Address, My.Settings.AND10Address)
                lblDataAND10.Text = OW_Data(indexAND10).ToString
                'AND10-A
                If (getTraceData1(My.Settings.AND10Address) = "01") And (getTraceData1(My.Settings.AND12Address) = "01") Then
                    Trace_ON(AND_10_A1)
                    Trace_ON(AND_10_A2)
                ElseIf (getTraceData1(My.Settings.AND10Address) = "10") And (getTraceData1(My.Settings.AND12Address) = "10") Then
                    Trace_OFF(AND_10_A1)
                    Trace_OFF(AND_10_A2)
                Else
                    Trace_Error(AND_10_A1)
                    Trace_Error(AND_10_A2)
                End If
                'AND10-B
                If (getTraceData2(My.Settings.AND10Address) = "01") And (getTraceData2(My.Settings.AND11Address) = "01") Then
                    Trace_ON(AND_10_B1)
                    Trace_ON(AND_10_B2)
                ElseIf (getTraceData2(My.Settings.AND10Address) = "10") And (getTraceData2(My.Settings.AND11Address) = "10") Then
                    Trace_OFF(AND_10_B1)
                    Trace_OFF(AND_10_B2)
                Else
                    Trace_Error(AND_10_B1)
                    Trace_Error(AND_10_B2)
                End If
                'AND10-OUT
                If (getTraceDataOUT(My.Settings.AND10Address) = "01") And (getTraceData1(My.Settings.OR03Address) = "01") Then
                    Trace_ON(OR_03_A)
                ElseIf (getTraceDataOUT(My.Settings.AND10Address) = "10") And (getTraceData1(My.Settings.OR03Address) = "10") Then
                    Trace_OFF(OR_03_A)
                Else
                    Trace_Error(OR_03_A)
                End If
            Catch
            End Try

            Try
                'AND11
                Dim indexAND11 As Integer = Array.IndexOf(OW_Address, My.Settings.AND11Address)
                lblDataAND11.Text = OW_Data(indexAND11).ToString
                'AND11-A
                If (getTraceData1(My.Settings.AND11Address) = "01") And (getTraceData1(My.Settings.AND13Address) = "01") Then
                    Trace_ON(AND_11_A1)
                    Trace_ON(AND_11_A2)
                ElseIf (getTraceData1(My.Settings.AND11Address) = "10") And (getTraceData1(My.Settings.AND13Address) = "10") Then
                    Trace_OFF(AND_11_A1)
                    Trace_OFF(AND_11_A2)
                Else
                    Trace_Error(AND_11_A1)
                    Trace_Error(AND_11_A2)
                End If
                'AND11-B
                'AND11-OUT
                If (getTraceDataOUT(My.Settings.AND11Address) = "01") And (getTraceData1(My.Settings.OR02Address) = "01") Then
                    Trace_ON(OR_02_A)
                ElseIf (getTraceDataOUT(My.Settings.AND11Address) = "10") And (getTraceData1(My.Settings.OR02Address) = "10") Then
                    Trace_OFF(OR_02_A)
                Else
                    Trace_Error(OR_02_A)
                End If
            Catch
            End Try

            Try
                'AND12
                Dim indexAND12 As Integer = Array.IndexOf(OW_Address, My.Settings.AND12Address)
                lblDataAND12.Text = OW_Data(indexAND12).ToString
                'AND12-A
                'AND12-B
                If (getTraceData2(My.Settings.AND12Address) = "01") And (getTraceData2(My.Settings.AND13Address) = "01") Then
                    Trace_ON(AND_12_B1)
                    Trace_ON(AND_12_B2)
                ElseIf (getTraceData2(My.Settings.AND12Address) = "10") And (getTraceData2(My.Settings.AND13Address) = "10") Then
                    Trace_OFF(AND_12_B1)
                    Trace_OFF(AND_12_B2)
                Else
                    Trace_Error(AND_12_B1)
                    Trace_Error(AND_12_B2)
                End If
                'AND12-OUT
                If (getTraceDataOUT(My.Settings.AND12Address) = "01") And (getTraceData2(My.Settings.OR02Address) = "01") Then
                    Trace_ON(OR_02_B)
                ElseIf (getTraceDataOUT(My.Settings.AND12Address) = "10") And (getTraceData2(My.Settings.OR02Address) = "10") Then
                    Trace_OFF(OR_02_B)
                Else
                    Trace_Error(OR_02_B)
                End If
            Catch
            End Try

            Try
                'AND13
                Dim indexAND13 As Integer = Array.IndexOf(OW_Address, My.Settings.AND13Address)
                lblDataAND13.Text = OW_Data(indexAND13).ToString
                'AND13-A
                'AND13-B
                'AND13-OUT
                If (getTraceDataOUT(My.Settings.AND13Address) = "01") And (getTraceData2(My.Settings.AND09Address) = "01") Then
                    Trace_ON(AND_09_B)
                ElseIf (getTraceDataOUT(My.Settings.AND13Address) = "10") And (getTraceData2(My.Settings.AND09Address) = "10") Then
                    Trace_OFF(AND_09_B)
                Else
                    Trace_Error(AND_09_B)
                End If
            Catch
            End Try

            Try
                'AND14
                Dim indexAND14 As Integer = Array.IndexOf(OW_Address, My.Settings.AND14Address)
                lblDataAND14.Text = OW_Data(indexAND14).ToString
                'AND14-A
                'AND14-B
                'AND14-OUT
                If (getTraceDataOUT(My.Settings.AND14Address) = "01") And (getTraceData2(My.Settings.OR04Address) = "01") Then
                    Trace_ON(OR_04_B)
                ElseIf (getTraceDataOUT(My.Settings.AND14Address) = "10") And (getTraceData2(My.Settings.OR04Address) = "10") Then
                    Trace_OFF(OR_04_B)
                Else
                    Trace_Error(OR_04_B)
                End If
            Catch
            End Try

            Try
                'AND15
                Dim indexAND15 As Integer = Array.IndexOf(OW_Address, My.Settings.AND15Address)
                lblDataAND15.Text = OW_Data(indexAND15).ToString
                'AND15-A
                'AND15-B
                If (getTraceDataOUT(My.Settings.AND06Address) = "01") And (getTraceData2(My.Settings.AND15Address) = "01") Then
                    Trace_ON(AND_15_B)
                ElseIf (getTraceDataOUT(My.Settings.AND06Address) = "10") And (getTraceData2(My.Settings.AND15Address) = "10") Then
                    Trace_OFF(AND_15_B)
                Else
                    Trace_Error(AND_15_B)
                End If
                'AND15-OUT
                If (getTraceDataOUT(My.Settings.AND15Address) = "01") Then
                    Trace_ON(AND_15_OUT)
                ElseIf (getTraceDataOUT(My.Settings.AND15Address) = "10") Then
                    Trace_OFF(AND_15_OUT)
                Else
                    Trace_Error(AND_15_OUT)
                End If
            Catch
            End Try

            Try
                'OR01
                Dim indexOR01 As Integer = Array.IndexOf(OW_Address, My.Settings.OR01Address)
                lblDataOR01.Text = OW_Data(indexOR01).ToString
                'OR01-A
                'OR01-B
                If (getTraceData2(My.Settings.OR01Address) = "01") Then
                    Trace_ON(OR_01_B)
                ElseIf (getTraceData2(My.Settings.OR01Address) = "10") Then
                    Trace_OFF(OR_01_B)
                Else
                    Trace_Error(OR_01_B)
                End If
                'OR01-OUT
                If (getTraceDataOUT(My.Settings.OR01Address) = "01") And (getTraceData1(My.Settings.AND14Address) = "01") Then
                    Trace_ON(AND_14_A)
                ElseIf (getTraceDataOUT(My.Settings.OR01Address) = "10") And (getTraceData1(My.Settings.AND14Address) = "10") Then
                    Trace_OFF(AND_14_A)
                Else
                    Trace_Error(AND_14_A)
                End If
            Catch
            End Try

            Try
                'OR02
                Dim indexOR02 As Integer = Array.IndexOf(OW_Address, My.Settings.OR02Address)
                lblDataOR02.Text = OW_Data(indexOR02).ToString
                'OR02-A
                'OR02-B
                'OR02-OUT
                If (getTraceDataOUT(My.Settings.OR02Address) = "01") And (getTraceData2(My.Settings.OR03Address) = "01") Then
                    Trace_ON(OR_03_B)
                ElseIf (getTraceDataOUT(My.Settings.OR02Address) = "10") And (getTraceData2(My.Settings.OR03Address) = "10") Then
                    Trace_OFF(OR_03_B)
                Else
                    Trace_Error(OR_03_B)
                End If
            Catch
            End Try

            Try
                'OR03
                Dim indexOR03 As Integer = Array.IndexOf(OW_Address, My.Settings.OR03Address)
                lblDataOR03.Text = OW_Data(indexOR03).ToString
                'OR03-A
                'OR03-B
                'OR03-OUT
                If (getTraceDataOUT(My.Settings.OR03Address) = "01") And (getTraceData2(My.Settings.AND14Address) = "01") Then
                    Trace_ON(AND_14_B)
                ElseIf (getTraceDataOUT(My.Settings.OR03Address) = "10") And (getTraceData2(My.Settings.AND14Address) = "10") Then
                    Trace_OFF(AND_14_B)
                Else
                    Trace_Error(AND_14_B)
                End If
            Catch
            End Try

            Try
                'OR04
                Dim indexOR04 As Integer = Array.IndexOf(OW_Address, My.Settings.OR04Address)
                lblDataOR04.Text = OW_Data(indexOR04).ToString
                'OR04-A
                'OR04-B
                'OR04-OUT
                If (getTraceDataOUT(My.Settings.OR04Address) = "01") And (getTraceData1(My.Settings.AND15Address) = "01") Then
                    Trace_ON(AND_15_A)
                ElseIf (getTraceDataOUT(My.Settings.OR04Address) = "10") And (getTraceData1(My.Settings.AND15Address) = "10") Then
                    Trace_OFF(AND_15_A)
                Else
                    Trace_Error(AND_15_A)
                End If
            Catch
            End Try
            Try
                'NO01
                Dim indexNO01 As Integer = Array.IndexOf(OW_Address, My.Settings.NO01Address)
                lblDataNO01.Text = OW_Data(indexNO01).ToString
                'NO01-A
                'NO01-OUT
                If (getTraceDataOUT(My.Settings.NO01Address) = "01") Then
                    Trace_ON(NO_01_OUT)
                ElseIf (getTraceDataOUT(My.Settings.NO01Address) = "10") Then
                    Trace_OFF(NO_01_OUT)
                Else
                    Trace_Error(NO_01_OUT)
                End If
            Catch
            End Try
            Try
                'NO02
                Dim indexNO02 As Integer = Array.IndexOf(OW_Address, My.Settings.NO02Address)
                lblDataNO02.Text = OW_Data(indexNO02).ToString
                'NO02-A
                'NO02-OUT
                If (getTraceDataOUT(My.Settings.NO02Address) = "01") Then
                    Trace_ON(NO_02_OUT)
                ElseIf (getTraceDataOUT(My.Settings.NO02Address) = "10") Then
                    Trace_OFF(NO_02_OUT)
                Else
                    Trace_Error(NO_02_OUT)
                End If
            Catch
            End Try

            Try
                'NO03
                Dim indexNO03 As Integer = Array.IndexOf(OW_Address, My.Settings.NO03Address)
                lblDataNO03.Text = OW_Data(indexNO03).ToString
                'NO03-A
                'NO03-OUT
                If (getTraceDataOUT(My.Settings.NO02Address) = "01") Then
                    Trace_ON(NO_03_OUT)
                ElseIf (getTraceDataOUT(My.Settings.NO02Address) = "10") Then
                    Trace_OFF(NO_03_OUT)
                Else
                    Trace_Error(NO_03_OUT)
                End If
            Catch
            End Try

            Try
                'NO04
                Dim indexNO04 As Integer = Array.IndexOf(OW_Address, My.Settings.NO04Address)
                lblDataNO04.Text = OW_Data(indexNO04).ToString
                'NO04-A
                'NO04-OUT
                If (getTraceDataOUT(My.Settings.NO04Address) = "01") Then
                    Trace_ON(NO_04_OUT)
                ElseIf (getTraceDataOUT(My.Settings.NO04Address) = "10") Then
                    Trace_OFF(NO_04_OUT)
                Else
                    Trace_Error(NO_04_OUT)
                End If
            Catch
            End Try

            Try
                'NO05
                Dim indexNO05 As Integer = Array.IndexOf(OW_Address, My.Settings.NO05Address)
                lblDataNO05.Text = OW_Data(indexNO05).ToString
                'NO05-A
                'NO05-OUT
                If (getTraceDataOUT(My.Settings.NO05Address) = "01") Then
                    Trace_ON(NO_05_OUT)
                ElseIf (getTraceDataOUT(My.Settings.NO05Address) = "10") Then
                    Trace_OFF(NO_05_OUT)
                Else
                    Trace_Error(NO_05_OUT)
                End If
            Catch
            End Try
            updateComplete = True 'SLP Conditions
        End If
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
            Dim result As DialogResult = MessageBox.Show("The program couldn't detect the OWTEN-Card." + Environment.NewLine +
                            "Please make sure that the OWTEN-Card is powered up and connected to the hub." + Environment.NewLine +
                            "Would you like to re-establish connection again?",
                            "Connection Error!", MessageBoxButtons.YesNo, MessageBoxIcon.Error)

            If (result = DialogResult.Yes) Then
                Timer1.Enabled = True
            ElseIf (result = DialogResult.No) Then
                My.Forms.Form1.Close()
            End If
            myThread2.Abort()
        End Try
    End Sub

    Private Sub Search_ECS_and_Beam_Dumps_Input_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timerUpdateUI.Interval = My.Settings.refreshRate
        Timer1.Enabled = True
        timerUpdateUI.Enabled = True
        LoadThread()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (myThread2.IsAlive = False) Then
            LoadThread()
        End If
    End Sub

    Private Sub timerUpdateUI_Tick(sender As Object, e As EventArgs) Handles timerUpdateUI.Tick
        If checkStatusDone = True Then
            updateSLPMapSheet2()
            checkStatusDone = False
        End If

        If (Form1.showDataStatus = True) Then
            lblDataAND07.Visible = True
            lblDataAND08.Visible = True
            lblDataAND09.Visible = True
            lblDataAND10.Visible = True
            lblDataAND11.Visible = True
            lblDataAND12.Visible = True
            lblDataAND13.Visible = True
            lblDataAND14.Visible = True
            lblDataAND15.Visible = True

            lblDataNO01.Visible = True
            lblDataNO02.Visible = True
            lblDataNO03.Visible = True
            lblDataNO04.Visible = True
            lblDataNO05.Visible = True

            lblDataOR01.Visible = True
            lblDataOR02.Visible = True
            lblDataOR03.Visible = True
            lblDataOR04.Visible = True
        Else
            lblDataAND07.Visible = False
            lblDataAND08.Visible = False
            lblDataAND09.Visible = False
            lblDataAND10.Visible = False
            lblDataAND11.Visible = False
            lblDataAND12.Visible = False
            lblDataAND13.Visible = False
            lblDataAND14.Visible = False
            lblDataAND15.Visible = False

            lblDataNO01.Visible = False
            lblDataNO02.Visible = False
            lblDataNO03.Visible = False
            lblDataNO04.Visible = False
            lblDataNO05.Visible = False

            lblDataOR01.Visible = False
            lblDataOR02.Visible = False
            lblDataOR03.Visible = False
            lblDataOR04.Visible = False 'Data textbox visibility toggle.
        End If
    End Sub
End Class