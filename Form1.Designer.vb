<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblTA24ShutterStatus = New System.Windows.Forms.Label()
        Me.lblTA23ShutterStatus = New System.Windows.Forms.Label()
        Me.lblTA22ShutterStatus = New System.Windows.Forms.Label()
        Me.lblTA21ShutterStatus = New System.Windows.Forms.Label()
        Me.lblTA13ShutterStatus = New System.Windows.Forms.Label()
        Me.lblTA12ShutterStatus = New System.Windows.Forms.Label()
        Me.lblTA11ShutterStatus = New System.Windows.Forms.Label()
        Me.btnTA24Cls = New System.Windows.Forms.Button()
        Me.btnTA24Opn = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnTA23Cls = New System.Windows.Forms.Button()
        Me.btnTA23Opn = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnTA22Cls = New System.Windows.Forms.Button()
        Me.btnTA22Opn = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnTA21Cls = New System.Windows.Forms.Button()
        Me.btnTA21Opn = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnTA13Cls = New System.Windows.Forms.Button()
        Me.btnTA13Opn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnTA12Cls = New System.Windows.Forms.Button()
        Me.btnTA12Opn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnTA11Cls = New System.Windows.Forms.Button()
        Me.btnTA11Opn = New System.Windows.Forms.Button()
        Me.panelSheetViewer = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.DebugToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlwaysOnTopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SLPAddressAssignmentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SLPTraceErrorColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GrayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripDropDownButton3 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.AboutUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cbSheets = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel1.Size = New System.Drawing.Size(1920, 41)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(11, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(394, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lasermet - Laser Area Control and Monitor v1.1.2"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Target Area 1/1"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.AutoSize = True
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblTA24ShutterStatus)
        Me.Panel2.Controls.Add(Me.lblTA23ShutterStatus)
        Me.Panel2.Controls.Add(Me.lblTA22ShutterStatus)
        Me.Panel2.Controls.Add(Me.lblTA21ShutterStatus)
        Me.Panel2.Controls.Add(Me.lblTA13ShutterStatus)
        Me.Panel2.Controls.Add(Me.lblTA12ShutterStatus)
        Me.Panel2.Controls.Add(Me.lblTA11ShutterStatus)
        Me.Panel2.Controls.Add(Me.btnTA24Cls)
        Me.Panel2.Controls.Add(Me.btnTA24Opn)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.btnTA23Cls)
        Me.Panel2.Controls.Add(Me.btnTA23Opn)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.btnTA22Cls)
        Me.Panel2.Controls.Add(Me.btnTA22Opn)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.btnTA21Cls)
        Me.Panel2.Controls.Add(Me.btnTA21Opn)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.btnTA13Cls)
        Me.Panel2.Controls.Add(Me.btnTA13Opn)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.btnTA12Cls)
        Me.Panel2.Controls.Add(Me.btnTA12Opn)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.btnTA11Cls)
        Me.Panel2.Controls.Add(Me.btnTA11Opn)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(24, 90)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(15)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel2.Size = New System.Drawing.Size(488, 971)
        Me.Panel2.TabIndex = 1
        '
        'lblTA24ShutterStatus
        '
        Me.lblTA24ShutterStatus.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblTA24ShutterStatus.Location = New System.Drawing.Point(170, 384)
        Me.lblTA24ShutterStatus.Name = "lblTA24ShutterStatus"
        Me.lblTA24ShutterStatus.Size = New System.Drawing.Size(289, 41)
        Me.lblTA24ShutterStatus.TabIndex = 26
        Me.lblTA24ShutterStatus.Text = "Loading Status.."
        Me.lblTA24ShutterStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTA23ShutterStatus
        '
        Me.lblTA23ShutterStatus.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblTA23ShutterStatus.Location = New System.Drawing.Point(170, 323)
        Me.lblTA23ShutterStatus.Name = "lblTA23ShutterStatus"
        Me.lblTA23ShutterStatus.Size = New System.Drawing.Size(289, 41)
        Me.lblTA23ShutterStatus.TabIndex = 25
        Me.lblTA23ShutterStatus.Text = "Loading Status.."
        Me.lblTA23ShutterStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTA22ShutterStatus
        '
        Me.lblTA22ShutterStatus.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblTA22ShutterStatus.Location = New System.Drawing.Point(170, 262)
        Me.lblTA22ShutterStatus.Name = "lblTA22ShutterStatus"
        Me.lblTA22ShutterStatus.Size = New System.Drawing.Size(289, 41)
        Me.lblTA22ShutterStatus.TabIndex = 24
        Me.lblTA22ShutterStatus.Text = "Loading Status.."
        Me.lblTA22ShutterStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTA21ShutterStatus
        '
        Me.lblTA21ShutterStatus.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblTA21ShutterStatus.Location = New System.Drawing.Point(170, 201)
        Me.lblTA21ShutterStatus.Name = "lblTA21ShutterStatus"
        Me.lblTA21ShutterStatus.Size = New System.Drawing.Size(289, 41)
        Me.lblTA21ShutterStatus.TabIndex = 23
        Me.lblTA21ShutterStatus.Text = "Loading Status.."
        Me.lblTA21ShutterStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTA13ShutterStatus
        '
        Me.lblTA13ShutterStatus.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblTA13ShutterStatus.Location = New System.Drawing.Point(170, 140)
        Me.lblTA13ShutterStatus.Name = "lblTA13ShutterStatus"
        Me.lblTA13ShutterStatus.Size = New System.Drawing.Size(289, 41)
        Me.lblTA13ShutterStatus.TabIndex = 22
        Me.lblTA13ShutterStatus.Text = "Loading Status.."
        Me.lblTA13ShutterStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTA12ShutterStatus
        '
        Me.lblTA12ShutterStatus.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblTA12ShutterStatus.Location = New System.Drawing.Point(170, 79)
        Me.lblTA12ShutterStatus.Name = "lblTA12ShutterStatus"
        Me.lblTA12ShutterStatus.Size = New System.Drawing.Size(289, 41)
        Me.lblTA12ShutterStatus.TabIndex = 21
        Me.lblTA12ShutterStatus.Text = "Loading Status.."
        Me.lblTA12ShutterStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTA11ShutterStatus
        '
        Me.lblTA11ShutterStatus.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblTA11ShutterStatus.Location = New System.Drawing.Point(170, 18)
        Me.lblTA11ShutterStatus.Name = "lblTA11ShutterStatus"
        Me.lblTA11ShutterStatus.Size = New System.Drawing.Size(289, 41)
        Me.lblTA11ShutterStatus.TabIndex = 11
        Me.lblTA11ShutterStatus.Text = "Loading Status.."
        Me.lblTA11ShutterStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnTA24Cls
        '
        Me.btnTA24Cls.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTA24Cls.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnTA24Cls.Location = New System.Drawing.Point(323, 384)
        Me.btnTA24Cls.Name = "btnTA24Cls"
        Me.btnTA24Cls.Size = New System.Drawing.Size(136, 41)
        Me.btnTA24Cls.TabIndex = 20
        Me.btnTA24Cls.Text = "Close"
        Me.btnTA24Cls.UseVisualStyleBackColor = True
        '
        'btnTA24Opn
        '
        Me.btnTA24Opn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTA24Opn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnTA24Opn.Location = New System.Drawing.Point(174, 384)
        Me.btnTA24Opn.Margin = New System.Windows.Forms.Padding(10)
        Me.btnTA24Opn.Name = "btnTA24Opn"
        Me.btnTA24Opn.Size = New System.Drawing.Size(136, 41)
        Me.btnTA24Opn.TabIndex = 19
        Me.btnTA24Opn.Text = "Open"
        Me.btnTA24Opn.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(12, 395)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(126, 21)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Target Area 2/4"
        '
        'btnTA23Cls
        '
        Me.btnTA23Cls.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTA23Cls.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnTA23Cls.Location = New System.Drawing.Point(323, 323)
        Me.btnTA23Cls.Name = "btnTA23Cls"
        Me.btnTA23Cls.Size = New System.Drawing.Size(136, 41)
        Me.btnTA23Cls.TabIndex = 17
        Me.btnTA23Cls.Text = "Close"
        Me.btnTA23Cls.UseVisualStyleBackColor = True
        '
        'btnTA23Opn
        '
        Me.btnTA23Opn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTA23Opn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnTA23Opn.Location = New System.Drawing.Point(174, 323)
        Me.btnTA23Opn.Margin = New System.Windows.Forms.Padding(10)
        Me.btnTA23Opn.Name = "btnTA23Opn"
        Me.btnTA23Opn.Size = New System.Drawing.Size(136, 41)
        Me.btnTA23Opn.TabIndex = 16
        Me.btnTA23Opn.Text = "Open"
        Me.btnTA23Opn.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(12, 334)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 21)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Target Area 2/3"
        '
        'btnTA22Cls
        '
        Me.btnTA22Cls.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTA22Cls.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnTA22Cls.Location = New System.Drawing.Point(323, 262)
        Me.btnTA22Cls.Name = "btnTA22Cls"
        Me.btnTA22Cls.Size = New System.Drawing.Size(136, 41)
        Me.btnTA22Cls.TabIndex = 14
        Me.btnTA22Cls.Text = "Close"
        Me.btnTA22Cls.UseVisualStyleBackColor = True
        '
        'btnTA22Opn
        '
        Me.btnTA22Opn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTA22Opn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnTA22Opn.Location = New System.Drawing.Point(174, 262)
        Me.btnTA22Opn.Margin = New System.Windows.Forms.Padding(10)
        Me.btnTA22Opn.Name = "btnTA22Opn"
        Me.btnTA22Opn.Size = New System.Drawing.Size(136, 41)
        Me.btnTA22Opn.TabIndex = 13
        Me.btnTA22Opn.Text = "Open"
        Me.btnTA22Opn.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(12, 273)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 21)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Target Area 2/2"
        '
        'btnTA21Cls
        '
        Me.btnTA21Cls.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTA21Cls.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnTA21Cls.Location = New System.Drawing.Point(323, 201)
        Me.btnTA21Cls.Name = "btnTA21Cls"
        Me.btnTA21Cls.Size = New System.Drawing.Size(136, 41)
        Me.btnTA21Cls.TabIndex = 11
        Me.btnTA21Cls.Text = "Close"
        Me.btnTA21Cls.UseVisualStyleBackColor = True
        '
        'btnTA21Opn
        '
        Me.btnTA21Opn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTA21Opn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnTA21Opn.Location = New System.Drawing.Point(174, 201)
        Me.btnTA21Opn.Margin = New System.Windows.Forms.Padding(10)
        Me.btnTA21Opn.Name = "btnTA21Opn"
        Me.btnTA21Opn.Size = New System.Drawing.Size(136, 41)
        Me.btnTA21Opn.TabIndex = 10
        Me.btnTA21Opn.Text = "Open"
        Me.btnTA21Opn.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(12, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 21)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Target Area 2/1"
        '
        'btnTA13Cls
        '
        Me.btnTA13Cls.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTA13Cls.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnTA13Cls.Location = New System.Drawing.Point(323, 140)
        Me.btnTA13Cls.Name = "btnTA13Cls"
        Me.btnTA13Cls.Size = New System.Drawing.Size(136, 41)
        Me.btnTA13Cls.TabIndex = 8
        Me.btnTA13Cls.Text = "Close"
        Me.btnTA13Cls.UseVisualStyleBackColor = True
        '
        'btnTA13Opn
        '
        Me.btnTA13Opn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTA13Opn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnTA13Opn.Location = New System.Drawing.Point(174, 140)
        Me.btnTA13Opn.Margin = New System.Windows.Forms.Padding(10)
        Me.btnTA13Opn.Name = "btnTA13Opn"
        Me.btnTA13Opn.Size = New System.Drawing.Size(136, 41)
        Me.btnTA13Opn.TabIndex = 7
        Me.btnTA13Opn.Text = "Open"
        Me.btnTA13Opn.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(12, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 21)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Target Area 1/3"
        '
        'btnTA12Cls
        '
        Me.btnTA12Cls.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTA12Cls.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnTA12Cls.Location = New System.Drawing.Point(323, 79)
        Me.btnTA12Cls.Name = "btnTA12Cls"
        Me.btnTA12Cls.Size = New System.Drawing.Size(136, 41)
        Me.btnTA12Cls.TabIndex = 5
        Me.btnTA12Cls.Text = "Close"
        Me.btnTA12Cls.UseVisualStyleBackColor = True
        '
        'btnTA12Opn
        '
        Me.btnTA12Opn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTA12Opn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnTA12Opn.Location = New System.Drawing.Point(174, 79)
        Me.btnTA12Opn.Margin = New System.Windows.Forms.Padding(10)
        Me.btnTA12Opn.Name = "btnTA12Opn"
        Me.btnTA12Opn.Size = New System.Drawing.Size(136, 41)
        Me.btnTA12Opn.TabIndex = 4
        Me.btnTA12Opn.Text = "Open"
        Me.btnTA12Opn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(12, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 21)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Target Area 1/2"
        '
        'btnTA11Cls
        '
        Me.btnTA11Cls.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTA11Cls.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnTA11Cls.Location = New System.Drawing.Point(323, 18)
        Me.btnTA11Cls.Name = "btnTA11Cls"
        Me.btnTA11Cls.Size = New System.Drawing.Size(136, 41)
        Me.btnTA11Cls.TabIndex = 2
        Me.btnTA11Cls.Text = "Close"
        Me.btnTA11Cls.UseVisualStyleBackColor = True
        '
        'btnTA11Opn
        '
        Me.btnTA11Opn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTA11Opn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnTA11Opn.Location = New System.Drawing.Point(174, 18)
        Me.btnTA11Opn.Margin = New System.Windows.Forms.Padding(10)
        Me.btnTA11Opn.Name = "btnTA11Opn"
        Me.btnTA11Opn.Size = New System.Drawing.Size(136, 41)
        Me.btnTA11Opn.TabIndex = 1
        Me.btnTA11Opn.Text = "Open"
        Me.btnTA11Opn.UseVisualStyleBackColor = True
        '
        'panelSheetViewer
        '
        Me.panelSheetViewer.BackColor = System.Drawing.Color.White
        Me.panelSheetViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelSheetViewer.Location = New System.Drawing.Point(523, 90)
        Me.panelSheetViewer.Margin = New System.Windows.Forms.Padding(10)
        Me.panelSheetViewer.Name = "panelSheetViewer"
        Me.panelSheetViewer.Padding = New System.Windows.Forms.Padding(10)
        Me.panelSheetViewer.Size = New System.Drawing.Size(1378, 971)
        Me.panelSheetViewer.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.ToolStrip1)
        Me.Panel4.Location = New System.Drawing.Point(24, 50)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(162, 33)
        Me.Panel4.TabIndex = 7
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1, Me.ToolStripSeparator1, Me.ToolStripDropDownButton2, Me.ToolStripSeparator2, Me.ToolStripDropDownButton3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(162, 33)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(38, 30)
        Me.ToolStripDropDownButton1.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 33)
        '
        'ToolStripDropDownButton2
        '
        Me.ToolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DebugToolStripMenuItem, Me.AlwaysOnTopToolStripMenuItem, Me.SLPAddressAssignmentsToolStripMenuItem, Me.SLPTraceErrorColorToolStripMenuItem, Me.ShowDataToolStripMenuItem})
        Me.ToolStripDropDownButton2.Image = CType(resources.GetObject("ToolStripDropDownButton2.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton2.Name = "ToolStripDropDownButton2"
        Me.ToolStripDropDownButton2.Size = New System.Drawing.Size(62, 30)
        Me.ToolStripDropDownButton2.Text = "Settings"
        '
        'DebugToolStripMenuItem
        '
        Me.DebugToolStripMenuItem.Name = "DebugToolStripMenuItem"
        Me.DebugToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.DebugToolStripMenuItem.Text = "Time Variables"
        '
        'AlwaysOnTopToolStripMenuItem
        '
        Me.AlwaysOnTopToolStripMenuItem.Name = "AlwaysOnTopToolStripMenuItem"
        Me.AlwaysOnTopToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.AlwaysOnTopToolStripMenuItem.Text = "Disable Always On Top"
        '
        'SLPAddressAssignmentsToolStripMenuItem
        '
        Me.SLPAddressAssignmentsToolStripMenuItem.Name = "SLPAddressAssignmentsToolStripMenuItem"
        Me.SLPAddressAssignmentsToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.SLPAddressAssignmentsToolStripMenuItem.Text = "SLP Address Assignments"
        '
        'SLPTraceErrorColorToolStripMenuItem
        '
        Me.SLPTraceErrorColorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GrayToolStripMenuItem, Me.OrangeToolStripMenuItem})
        Me.SLPTraceErrorColorToolStripMenuItem.Name = "SLPTraceErrorColorToolStripMenuItem"
        Me.SLPTraceErrorColorToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.SLPTraceErrorColorToolStripMenuItem.Text = "SLP Trace Error Color"
        '
        'GrayToolStripMenuItem
        '
        Me.GrayToolStripMenuItem.Name = "GrayToolStripMenuItem"
        Me.GrayToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.GrayToolStripMenuItem.Text = "Gray"
        '
        'OrangeToolStripMenuItem
        '
        Me.OrangeToolStripMenuItem.Name = "OrangeToolStripMenuItem"
        Me.OrangeToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.OrangeToolStripMenuItem.Text = "Orange"
        '
        'ShowDataToolStripMenuItem
        '
        Me.ShowDataToolStripMenuItem.Name = "ShowDataToolStripMenuItem"
        Me.ShowDataToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.ShowDataToolStripMenuItem.Text = "Show data"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 33)
        '
        'ToolStripDropDownButton3
        '
        Me.ToolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutUsToolStripMenuItem})
        Me.ToolStripDropDownButton3.Image = CType(resources.GetObject("ToolStripDropDownButton3.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton3.Name = "ToolStripDropDownButton3"
        Me.ToolStripDropDownButton3.Size = New System.Drawing.Size(45, 30)
        Me.ToolStripDropDownButton3.Text = "Help"
        '
        'AboutUsToolStripMenuItem
        '
        Me.AboutUsToolStripMenuItem.Name = "AboutUsToolStripMenuItem"
        Me.AboutUsToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.AboutUsToolStripMenuItem.Text = "About Us"
        '
        'cbSheets
        '
        Me.cbSheets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSheets.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cbSheets.FormattingEnabled = True
        Me.cbSheets.Location = New System.Drawing.Point(639, 50)
        Me.cbSheets.Name = "cbSheets"
        Me.cbSheets.Size = New System.Drawing.Size(143, 29)
        Me.cbSheets.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label10.Location = New System.Drawing.Point(519, 53)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(114, 23)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Browse Sheets: "
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Timer1
        '
        Me.Timer1.Interval = 200
        '
        'Timer2
        '
        Me.Timer2.Interval = 500
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cbSheets)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.panelSheetViewer)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DWB Control Switch"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnTA24Cls As Button
    Friend WithEvents btnTA24Opn As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents btnTA23Cls As Button
    Friend WithEvents btnTA23Opn As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents btnTA22Cls As Button
    Friend WithEvents btnTA22Opn As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents btnTA21Cls As Button
    Friend WithEvents btnTA21Opn As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents btnTA13Cls As Button
    Friend WithEvents btnTA13Opn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btnTA12Cls As Button
    Friend WithEvents btnTA12Opn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnTA11Cls As Button
    Friend WithEvents btnTA11Opn As Button
    Friend WithEvents panelSheetViewer As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripDropDownButton2 As ToolStripDropDownButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripDropDownButton3 As ToolStripDropDownButton
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DebugToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutUsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlwaysOnTopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cbSheets As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblTA11ShutterStatus As Label
    Friend WithEvents lblTA12ShutterStatus As Label
    Friend WithEvents lblTA13ShutterStatus As Label
    Friend WithEvents lblTA21ShutterStatus As Label
    Friend WithEvents lblTA22ShutterStatus As Label
    Friend WithEvents lblTA23ShutterStatus As Label
    Friend WithEvents lblTA24ShutterStatus As Label
    Friend WithEvents SLPAddressAssignmentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SLPTraceErrorColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GrayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrangeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer2 As Timer
End Class
