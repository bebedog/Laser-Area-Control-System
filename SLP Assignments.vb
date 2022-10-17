Imports System.IO
Imports System.Net
Imports System.Text

Public Class SLP_Assignments
    Public SLP_Gates(150)
    Public OW_ImportedAddress(150)
    Dim OW_String() As String
    Public OW_Address(150) As String
    Dim OW_Data(150) As String
    Dim connectionPresent As Boolean = False
    Public Sub resumeOperation()
        My.Forms.Form1.Timer1.Enabled = True
        My.Forms.Form1.Enabled = True
        My.Forms.Form1.Show()
    End Sub
    Public Sub ListUpdate()

        addressList.Items.Remove(tbAND01.Text)
        addressList.Items.Remove(tbAND02.Text)
        addressList.Items.Remove(tbAND03.Text)
        addressList.Items.Remove(tbAND04.Text)
        addressList.Items.Remove(tbAND05.Text)
        addressList.Items.Remove(tbAND06.Text)
        addressList.Items.Remove(tbAND07.Text)
        addressList.Items.Remove(tbAND08.Text)
        addressList.Items.Remove(tbAND09.Text)
        addressList.Items.Remove(tbAND10.Text)
        addressList.Items.Remove(tbAND11.Text)
        addressList.Items.Remove(tbAND11.Text)
        addressList.Items.Remove(tbAND12.Text)
        addressList.Items.Remove(tbAND13.Text)
        addressList.Items.Remove(tbAND14.Text)
        addressList.Items.Remove(tbAND15.Text)
        addressList.Items.Remove(tbAND16.Text)

        addressList.Items.Remove(tbOR01.Text)
        addressList.Items.Remove(tbOR02.Text)
        addressList.Items.Remove(tbOR03.Text)
        addressList.Items.Remove(tbOR04.Text)

        addressList.Items.Remove(tbNC01.Text)
        addressList.Items.Remove(tbNC02.Text)
        addressList.Items.Remove(tbNC03.Text)
        addressList.Items.Remove(tbNC04.Text)
        addressList.Items.Remove(tbNC05.Text)
        addressList.Items.Remove(tbNC06.Text)

        addressList.Items.Remove(tbNO01.Text)
        addressList.Items.Remove(tbNO02.Text)
        addressList.Items.Remove(tbNO03.Text)
        addressList.Items.Remove(tbNO04.Text)
        addressList.Items.Remove(tbNO05.Text)

    End Sub
    Public Sub loadAllSettings()
        tbAND01.Text = My.Settings.AND01Address
        tbAND02.Text = My.Settings.AND02Address
        tbAND03.Text = My.Settings.AND03Address
        tbAND04.Text = My.Settings.AND04Address
        tbAND05.Text = My.Settings.AND05Address
        tbAND06.Text = My.Settings.AND06Address
        tbAND07.Text = My.Settings.AND07Address
        tbAND08.Text = My.Settings.AND08Address
        tbAND09.Text = My.Settings.AND09Address
        tbAND10.Text = My.Settings.AND10Address
        tbAND11.Text = My.Settings.AND11Address
        tbAND12.Text = My.Settings.AND12Address
        tbAND13.Text = My.Settings.AND13Address
        tbAND14.Text = My.Settings.AND14Address
        tbAND15.Text = My.Settings.AND15Address
        tbAND16.Text = My.Settings.AND16Address

        tbOR01.Text = My.Settings.OR01Address
        tbOR02.Text = My.Settings.OR02Address
        tbOR03.Text = My.Settings.OR03Address
        tbOR04.Text = My.Settings.OR04Address

        tbNC01.Text = My.Settings.NC01Address
        tbNC02.Text = My.Settings.NC02Address
        tbNC03.Text = My.Settings.NC03Address
        tbNC04.Text = My.Settings.NC04Address
        tbNC05.Text = My.Settings.NC05Address
        tbNC06.Text = My.Settings.NC06Address

        tbNO01.Text = My.Settings.NO01Address
        tbNO02.Text = My.Settings.NO02Address
        tbNO03.Text = My.Settings.NO03Address
        tbNO04.Text = My.Settings.NO04Address
        tbNO05.Text = My.Settings.NO05Address

    End Sub

    Public Sub SaveAddresses()
        My.Settings.AND01Address = tbAND01.Text
        My.Settings.AND02Address = tbAND02.Text
        My.Settings.AND03Address = tbAND03.Text
        My.Settings.AND04Address = tbAND04.Text
        My.Settings.AND05Address = tbAND05.Text
        My.Settings.AND06Address = tbAND06.Text
        My.Settings.AND07Address = tbAND07.Text
        My.Settings.AND08Address = tbAND08.Text
        My.Settings.AND09Address = tbAND09.Text
        My.Settings.AND10Address = tbAND10.Text
        My.Settings.AND11Address = tbAND11.Text
        My.Settings.AND12Address = tbAND12.Text
        My.Settings.AND13Address = tbAND13.Text
        My.Settings.AND14Address = tbAND14.Text
        My.Settings.AND15Address = tbAND15.Text
        My.Settings.AND16Address = tbAND16.Text

        My.Settings.OR01Address = tbOR01.Text
        My.Settings.OR02Address = tbOR02.Text
        My.Settings.OR03Address = tbOR03.Text
        My.Settings.OR04Address = tbOR04.Text

        My.Settings.NC01Address = tbNC01.Text
        My.Settings.NC02Address = tbNC02.Text
        My.Settings.NC03Address = tbNC03.Text
        My.Settings.NC04Address = tbNC04.Text
        My.Settings.NC05Address = tbNC05.Text
        My.Settings.NC06Address = tbNC06.Text

        My.Settings.NO01Address = tbNO01.Text
        My.Settings.NO02Address = tbNO02.Text
        My.Settings.NO03Address = tbNO03.Text
        My.Settings.NO04Address = tbNO04.Text
        My.Settings.NO05Address = tbNO05.Text

        MessageBox.Show("Changes Saved.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        My.Settings.Save()
    End Sub

    Public Sub checkDatabasewithCurrentStream()
        'AND01 Compare to database

        If (OW_Address.ToList.IndexOf(tbAND01.Text) = -1) Then
            statusAND01.Text = "X"
            statusAND01.ForeColor = Color.Red
        Else
            statusAND01.Text = "OK"
            statusAND01.ForeColor = Color.Green
        End If

        'AND02 Compare to database

        If (OW_Address.ToList.IndexOf(tbAND02.Text) = -1) Then
            statusAND02.Text = "X"
            statusAND02.ForeColor = Color.Red
        Else
            statusAND02.Text = "OK"
            statusAND02.ForeColor = Color.Green
        End If

        'AND03 Compare to database

        If (OW_Address.ToList.IndexOf(tbAND03.Text) = -1) Then
            statusAND03.Text = "X"
            statusAND03.ForeColor = Color.Red
        Else
            statusAND03.Text = "OK"
            statusAND03.ForeColor = Color.Green
        End If

        'AND04 Compare to database

        If (OW_Address.ToList.IndexOf(tbAND04.Text) = -1) Then
            statusAND04.Text = "X"
            statusAND04.ForeColor = Color.Red
        Else
            statusAND04.Text = "OK"
            statusAND04.ForeColor = Color.Green
        End If

        'AND05 Compare to database

        If (OW_Address.ToList.IndexOf(tbAND05.Text) = -1) Then
            statusAND05.Text = "X"
            statusAND05.ForeColor = Color.Red
        Else
            statusAND05.Text = "OK"
            statusAND05.ForeColor = Color.Green
        End If

        'AND06 Compare to database

        If (OW_Address.ToList.IndexOf(tbAND06.Text) = -1) Then
            statusAND06.Text = "X"
            statusAND06.ForeColor = Color.Red
        Else
            statusAND06.Text = "OK"
            statusAND06.ForeColor = Color.Green
        End If

        'AND07 Compare to database

        If (OW_Address.ToList.IndexOf(tbAND07.Text) = -1) Then
            statusAND07.Text = "X"
            statusAND07.ForeColor = Color.Red
        Else
            statusAND07.Text = "OK"
            statusAND07.ForeColor = Color.Green
        End If

        'AND08 Compare to database

        If (OW_Address.ToList.IndexOf(tbAND08.Text) = -1) Then
            statusAND08.Text = "X"
            statusAND08.ForeColor = Color.Red
        Else
            statusAND08.Text = "OK"
            statusAND08.ForeColor = Color.Green
        End If

        'AND09 Compare to database

        If (OW_Address.ToList.IndexOf(tbAND09.Text) = -1) Then
            statusAND09.Text = "X"
            statusAND09.ForeColor = Color.Red
        Else
            statusAND09.Text = "OK"
            statusAND09.ForeColor = Color.Green
        End If

        'AND10 Compare to database

        If (OW_Address.ToList.IndexOf(tbAND10.Text) = -1) Then
            statusAND10.Text = "X"
            statusAND10.ForeColor = Color.Red
        Else
            statusAND10.Text = "OK"
            statusAND10.ForeColor = Color.Green
        End If

        'AND11 Compare to database

        If (OW_Address.ToList.IndexOf(tbAND11.Text) = -1) Then
            statusAND11.Text = "X"
            statusAND11.ForeColor = Color.Red
        Else
            statusAND11.Text = "OK"
            statusAND11.ForeColor = Color.Green
        End If

        'AND12 Compare to database

        If (OW_Address.ToList.IndexOf(tbAND12.Text) = -1) Then
            statusAND12.Text = "X"
            statusAND12.ForeColor = Color.Red
        Else
            statusAND12.Text = "OK"
            statusAND12.ForeColor = Color.Green
        End If

        'AND13 Compare to database

        If (OW_Address.ToList.IndexOf(tbAND13.Text) = -1) Then
            statusAND13.Text = "X"
            statusAND13.ForeColor = Color.Red
        Else
            statusAND13.Text = "OK"
            statusAND13.ForeColor = Color.Green
        End If

        'AND14 Compare to database

        If (OW_Address.ToList.IndexOf(tbAND14.Text) = -1) Then
            statusAND14.Text = "X"
            statusAND14.ForeColor = Color.Red
        Else
            statusAND14.Text = "OK"
            statusAND14.ForeColor = Color.Green
        End If

        'AND15 Compare to database

        If (OW_Address.ToList.IndexOf(tbAND15.Text) = -1) Then
            statusAND15.Text = "X"
            statusAND15.ForeColor = Color.Red
        Else
            statusAND15.Text = "OK"
            statusAND15.ForeColor = Color.Green
        End If

        'AND16 Compare to database

        If (OW_Address.ToList.IndexOf(tbAND16.Text) = -1) Then
            statusAND16.Text = "X"
            statusAND16.ForeColor = Color.Red
        Else
            statusAND16.Text = "OK"
            statusAND16.ForeColor = Color.Green
        End If

        'OR01 Compare to database

        If (OW_Address.ToList.IndexOf(tbOR01.Text) = -1) Then
            statusOR01.Text = "X"
            statusOR01.ForeColor = Color.Red
        Else
            statusOR01.Text = "OK"
            statusOR01.ForeColor = Color.Green
        End If

        'OR02 Compare to database

        If (OW_Address.ToList.IndexOf(tbOR02.Text) = -1) Then
            statusOR02.Text = "X"
            statusOR02.ForeColor = Color.Red
        Else
            statusOR02.Text = "OK"
            statusOR02.ForeColor = Color.Green
        End If

        'OR03 Compare to database

        If (OW_Address.ToList.IndexOf(tbOR03.Text) = -1) Then
            statusOR03.Text = "X"
            statusOR03.ForeColor = Color.Red
        Else
            statusOR03.Text = "OK"
            statusOR03.ForeColor = Color.Green
        End If

        'OR04 Compare to database

        If (OW_Address.ToList.IndexOf(tbOR04.Text) = -1) Then
            statusOR04.Text = "X"
            statusOR04.ForeColor = Color.Red
        Else
            statusOR04.Text = "OK"
            statusOR04.ForeColor = Color.Green
        End If

        'NC01 Compare to database

        If (OW_Address.ToList.IndexOf(tbNC01.Text) = -1) Then
            statusNC01.Text = "X"
            statusNC01.ForeColor = Color.Red
        Else
            statusNC01.Text = "OK"
            statusNC01.ForeColor = Color.Green
        End If

        'NC02 Compare to database

        If (OW_Address.ToList.IndexOf(tbNC02.Text) = -1) Then
            statusNC02.Text = "X"
            statusNC02.ForeColor = Color.Red
        Else
            statusNC02.Text = "OK"
            statusNC02.ForeColor = Color.Green
        End If

        'NC03 Compare to database

        If (OW_Address.ToList.IndexOf(tbNC03.Text) = -1) Then
            statusNC03.Text = "X"
            statusNC03.ForeColor = Color.Red
        Else
            statusNC03.Text = "OK"
            statusNC03.ForeColor = Color.Green
        End If

        'NC04 Compare to database

        If (OW_Address.ToList.IndexOf(tbNC04.Text) = -1) Then
            statusNC04.Text = "X"
            statusNC04.ForeColor = Color.Red
        Else
            statusNC04.Text = "OK"
            statusNC04.ForeColor = Color.Green
        End If

        'NC05 Compare to database

        If (OW_Address.ToList.IndexOf(tbNC05.Text) = -1) Then
            statusNC05.Text = "X"
            statusNC05.ForeColor = Color.Red
        Else
            statusNC05.Text = "OK"
            statusNC05.ForeColor = Color.Green
        End If

        'NC06 Compare to database

        If (OW_Address.ToList.IndexOf(tbNC06.Text) = -1) Then
            statusNC06.Text = "X"
            statusNC06.ForeColor = Color.Red
        Else
            statusNC06.Text = "OK"
            statusNC06.ForeColor = Color.Green
        End If

        'NO01 Compare to database

        If (OW_Address.ToList.IndexOf(tbNO01.Text) = -1) Then
            statusNO01.Text = "X"
            statusNO01.ForeColor = Color.Red
        Else
            statusNO01.Text = "OK"
            statusNO01.ForeColor = Color.Green
        End If

        'NO02 Compare to database

        If (OW_Address.ToList.IndexOf(tbNO02.Text) = -1) Then
            statusNO02.Text = "X"
            statusNO02.ForeColor = Color.Red
        Else
            statusNO02.Text = "OK"
            statusNO02.ForeColor = Color.Green
        End If

        'NO03 Compare to database

        If (OW_Address.ToList.IndexOf(tbNO03.Text) = -1) Then
            statusNO03.Text = "X"
            statusNO03.ForeColor = Color.Red
        Else
            statusNO03.Text = "OK"
            statusNO03.ForeColor = Color.Green
        End If

        'NO03 Compare to database

        If (OW_Address.ToList.IndexOf(tbNO04.Text) = -1) Then
            statusNO04.Text = "X"
            statusNO04.ForeColor = Color.Red
        Else
            statusNO04.Text = "OK"
            statusNO04.ForeColor = Color.Green
        End If

        'NO05 Compare to database

        If (OW_Address.ToList.IndexOf(tbNO05.Text) = -1) Then
            statusNO05.Text = "X"
            statusNO05.ForeColor = Color.Red
        Else
            statusNO05.Text = "OK"
            statusNO05.ForeColor = Color.Green
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
            MessageBox.Show("There are " + (OW_String.Length - 1).ToString + " devices found.", "Scan Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
            For index As Integer = 0 To (OW_String.Length - 2)
                If OW_String(index).Length = 23 Then
                    OW_Data(index) = OW_String(index).Substring(16, 6)
                ElseIf OW_String(index).Length = 22 Then
                    OW_Data(index) = "0" + OW_String(index).Substring(16, 5)
                ElseIf OW_String(index).Length = 21 Then
                    OW_Data(index) = "00" + OW_String(index).Substring(16, 4)
                ElseIf OW_String(index).Length = 20 Then
                    OW_Data(index) = "000" + OW_String(index).Substring(16, 3)
                ElseIf OW_String(index).Length = 19 Then
                    OW_Data(index) = "0000" + OW_String(index).Substring(16, 2)
                ElseIf OW_String(index).Length = 18 Then
                    OW_Data(index) = "00000" + OW_String(index).Substring(16, 1)
                End If
                OW_Address(index) = OW_String(index).Substring(0, 16)
                addressList.Items.Add(OW_Address(index))
            Next

            connectionPresent = True
        Catch ex As WebException
            connectionPresent = False
            Dim result As DialogResult = MessageBox.Show("The program couldn't detect the OWTEN-Card." + Environment.NewLine +
                            "Please make sure that the OWTEN-Card is powered up and connected to the hub." + Environment.NewLine +
                            "Would you like to re-establish connection again?",
                            "Connection Error!", MessageBoxButtons.YesNo, MessageBoxIcon.Error)

            If (result = DialogResult.Yes) Then

            ElseIf (result = DialogResult.No) Then

            End If

        End Try
    End Sub


    Private Sub SLP_Assignments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        BrowseAddressList.FileName = Nothing
        Me.TopMost = True
        loadAllSettings()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        resumeOperation()
        Me.Close()
    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        addressList.Items.Clear()
        CheckOW()
        If connectionPresent = True Then
            checkDatabasewithCurrentStream()
            ListUpdate()
            SaveAddresses()
        End If
    End Sub

    Private Sub addressList_MouseClick(sender As Object, e As MouseEventArgs) Handles addressList.MouseClick
        If addressList.SelectedItems.Count > 0 Then
            Clipboard.SetText(addressList.SelectedItems(0))
            MessageBox.Show("Item selected copied to textbox." + Environment.NewLine + addressList.SelectedItems(0))
        End If

    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        BrowseAddressList.DefaultExt = ".csv"
        BrowseAddressList.Filter = "DWBAddressList (.csv)| *.csv*"
        If BrowseAddressList.ShowDialog() <> DialogResult.Cancel Then
            If (BrowseAddressList.FileName = "") Then
                'address is empty
                MessageBox.Show("Address list not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                'address isn't empty
                Try
                    Dim fileName As String = BrowseAddressList.FileName
                    Using reader As New StreamReader(fileName, Encoding.Default)
                        Dim sline As String = ""
                        Dim colsexpected As Integer = 2
                        Dim words() As String
                        Dim r As Integer = 0
                        Dim n As Integer = 0
                        sline = reader.ReadLine
                        Do
                            sline = reader.ReadLine
                            If sline Is Nothing Then Exit Do
                            words = sline.Split(",")
                            OW_ImportedAddress(n) = words(1)
                            n += 1
                        Loop
                        If (n = 31) Then
                            'program detects 31 addresses.
                            MessageBox.Show("Import is successful. Data list is updated.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            PlaceImportedAddressToTextBoxes()
                        ElseIf (n > 31) Then
                            'program detects a extra  addresses.
                            MessageBox.Show("Import unsuccessful. Program detects over 31 address.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            MessageBox.Show("Import unsuccessful. Program detects lack of address.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error! You need to close the csv tab you opened before you can access it here.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub 'Browse For Address

    Public Sub PlaceImportedAddressToTextBoxes()
        tbAND01.Text = OW_ImportedAddress(0)
        tbAND02.Text = OW_ImportedAddress(1)
        tbAND03.Text = OW_ImportedAddress(2)
        tbAND04.Text = OW_ImportedAddress(3)
        tbAND05.Text = OW_ImportedAddress(4)
        tbAND06.Text = OW_ImportedAddress(5)
        tbAND07.Text = OW_ImportedAddress(6)
        tbAND08.Text = OW_ImportedAddress(7)
        tbAND09.Text = OW_ImportedAddress(8)
        tbAND10.Text = OW_ImportedAddress(9)
        tbAND11.Text = OW_ImportedAddress(10)
        tbAND12.Text = OW_ImportedAddress(11)
        tbAND13.Text = OW_ImportedAddress(12)
        tbAND14.Text = OW_ImportedAddress(13)
        tbAND15.Text = OW_ImportedAddress(14)
        tbAND16.Text = OW_ImportedAddress(15)

        tbOR01.Text = OW_ImportedAddress(16)
        tbOR02.Text = OW_ImportedAddress(17)
        tbOR03.Text = OW_ImportedAddress(18)
        tbOR04.Text = OW_ImportedAddress(19)

        tbNC01.Text = OW_ImportedAddress(20)
        tbNC02.Text = OW_ImportedAddress(21)
        tbNC03.Text = OW_ImportedAddress(22)
        tbNC04.Text = OW_ImportedAddress(23)
        tbNC05.Text = OW_ImportedAddress(24)
        tbNC06.Text = OW_ImportedAddress(25)

        tbNO01.Text = OW_ImportedAddress(26)
        tbNO02.Text = OW_ImportedAddress(27)
        tbNO03.Text = OW_ImportedAddress(28)
        tbNO04.Text = OW_ImportedAddress(29)
        tbNO05.Text = OW_ImportedAddress(30)

    End Sub 'Imported values to textbox

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        If SaveFileDialog1.ShowDialog() <> DialogResult.Cancel Then
            SaveFileDialog1.DefaultExt = ".csv"
            SaveFileDialog1.Filter = "DWBAddressList (.csv)|*.csv*"
            Try
                File.Delete(SaveFileDialog1.FileName) 'deletes the previous file.

                WriteToFile("SLP Gate", "Address")
                WriteToFile("AND-01", tbAND01.Text)
                WriteToFile("AND-02", tbAND02.Text)
                WriteToFile("AND-03", tbAND03.Text)
                WriteToFile("AND-04", tbAND04.Text)
                WriteToFile("AND-05", tbAND05.Text)
                WriteToFile("AND-06", tbAND06.Text)
                WriteToFile("AND-07", tbAND07.Text)
                WriteToFile("AND-08", tbAND08.Text)
                WriteToFile("AND-09", tbAND09.Text)
                WriteToFile("AND-10", tbAND10.Text)
                WriteToFile("AND-11", tbAND11.Text)
                WriteToFile("AND-12", tbAND12.Text)
                WriteToFile("AND-13", tbAND13.Text)
                WriteToFile("AND-14", tbAND14.Text)
                WriteToFile("AND-15", tbAND15.Text)
                WriteToFile("AND-16", tbAND16.Text)

                WriteToFile("OR-01", tbOR01.Text)
                WriteToFile("OR-02", tbOR02.Text)
                WriteToFile("OR-03", tbOR03.Text)
                WriteToFile("OR-04", tbOR04.Text)

                WriteToFile("NC-01", tbNC01.Text)
                WriteToFile("NC-02", tbNC02.Text)
                WriteToFile("NC-03", tbNC03.Text)
                WriteToFile("NC-04", tbNC04.Text)
                WriteToFile("NC-05", tbNC05.Text)
                WriteToFile("NC-06", tbNC06.Text)

                WriteToFile("NO-01", tbNO01.Text)
                WriteToFile("NO-02", tbNO02.Text)
                WriteToFile("NC-03", tbNO03.Text)
                WriteToFile("NC-04", tbNO04.Text)
                WriteToFile("NC-05", tbNO05.Text)

                MessageBox.Show("The file is succesfully exported to:" + Environment.NewLine + SaveFileDialog1.FileName, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("File was not saved. Please check the following error: " + Environment.NewLine + ex.ToString, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If

    End Sub

    Public Sub WriteToFile(ByVal fieldOne As String, ByVal fieldTwo As String)
        Try
            Dim record As String = fieldOne + "," + fieldTwo
            Using fileWriter As New System.IO.StreamWriter(SaveFileDialog1.FileName, True)
                fileWriter.WriteLine(record)
            End Using
        Catch ex As Exception
            MessageBox.Show("File can't be exported." + Environment.NewLine + ex.ToString, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Class