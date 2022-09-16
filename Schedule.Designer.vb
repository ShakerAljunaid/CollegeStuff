<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Schedule
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Schedule))
        Me.College_stuffDataSet = New College_stuff.College_stuffDataSet()
        Me.Weekly_scheduleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Weekly_scheduleTableAdapter = New College_stuff.College_stuffDataSetTableAdapters.Weekly_scheduleTableAdapter()
        Me.TableAdapterManager = New College_stuff.College_stuffDataSetTableAdapters.TableAdapterManager()
        Me.Weekly_scheduleBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.Weekly_scheduleBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CLOSEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me._7TextBox = New System.Windows.Forms.TextBox()
        Me._11TextBox = New System.Windows.Forms.TextBox()
        Me._10TextBox = New System.Windows.Forms.TextBox()
        Me._8TextBox = New System.Windows.Forms.TextBox()
        Me._17TextBox = New System.Windows.Forms.TextBox()
        Me._9TextBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me._13TextBox = New System.Windows.Forms.TextBox()
        Me._14TextBox = New System.Windows.Forms.TextBox()
        Me._12TextBox = New System.Windows.Forms.TextBox()
        Me._2TextBox = New System.Windows.Forms.TextBox()
        Me._15TextBox = New System.Windows.Forms.TextBox()
        Me._18TextBox = New System.Windows.Forms.TextBox()
        Me._3TextBox = New System.Windows.Forms.TextBox()
        Me._16TextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me._5TextBox = New System.Windows.Forms.TextBox()
        Me._1TextBox = New System.Windows.Forms.TextBox()
        Me._4TextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me._6TextBox = New System.Windows.Forms.TextBox()
        Me.Splitter2 = New System.Windows.Forms.Splitter()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        CType(Me.College_stuffDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Weekly_scheduleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Weekly_scheduleBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Weekly_scheduleBindingNavigator.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'College_stuffDataSet
        '
        Me.College_stuffDataSet.DataSetName = "College_stuffDataSet"
        Me.College_stuffDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Weekly_scheduleBindingSource
        '
        Me.Weekly_scheduleBindingSource.DataMember = "Weekly schedule"
        Me.Weekly_scheduleBindingSource.DataSource = Me.College_stuffDataSet
        '
        'Weekly_scheduleTableAdapter
        '
        Me.Weekly_scheduleTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Communication_skillsTableAdapter = Nothing
        Me.TableAdapterManager.Computer_ethicsTableAdapter = Nothing
        Me.TableAdapterManager.Diverse_stuffTableAdapter = Nothing
        Me.TableAdapterManager.Logic_design_Assignment_TableAdapter = Nothing
        Me.TableAdapterManager.Logic_design_Practical_TableAdapter = Nothing
        Me.TableAdapterManager.Logic_design_theorical_TableAdapter = Nothing
        Me.TableAdapterManager.Math_assignment_TableAdapter = Nothing
        Me.TableAdapterManager.MathTableAdapter = Nothing
        Me.TableAdapterManager.PlansTableAdapter = Nothing
        Me.TableAdapterManager.Programming_assignment_TableAdapter = Nothing
        Me.TableAdapterManager.Programming_practical_TableAdapter = Nothing
        Me.TableAdapterManager.Programming_theorical_TableAdapter = Nothing
        Me.TableAdapterManager.statistic_and_possibilities_Assignment_TableAdapter = Nothing
        Me.TableAdapterManager.statistic_and_possibilitiesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = College_stuff.College_stuffDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Weekly_scheduleTableAdapter = Me.Weekly_scheduleTableAdapter
        '
        'Weekly_scheduleBindingNavigator
        '
        Me.Weekly_scheduleBindingNavigator.AddNewItem = Nothing
        Me.Weekly_scheduleBindingNavigator.BindingSource = Me.Weekly_scheduleBindingSource
        Me.Weekly_scheduleBindingNavigator.CountItem = Nothing
        Me.Weekly_scheduleBindingNavigator.DeleteItem = Nothing
        Me.Weekly_scheduleBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorSeparator, Me.Weekly_scheduleBindingNavigatorSaveItem})
        Me.Weekly_scheduleBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Weekly_scheduleBindingNavigator.MoveFirstItem = Nothing
        Me.Weekly_scheduleBindingNavigator.MoveLastItem = Nothing
        Me.Weekly_scheduleBindingNavigator.MoveNextItem = Nothing
        Me.Weekly_scheduleBindingNavigator.MovePreviousItem = Nothing
        Me.Weekly_scheduleBindingNavigator.Name = "Weekly_scheduleBindingNavigator"
        Me.Weekly_scheduleBindingNavigator.PositionItem = Nothing
        Me.Weekly_scheduleBindingNavigator.Size = New System.Drawing.Size(1385, 25)
        Me.Weekly_scheduleBindingNavigator.TabIndex = 1
        Me.Weekly_scheduleBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'Weekly_scheduleBindingNavigatorSaveItem
        '
        Me.Weekly_scheduleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Weekly_scheduleBindingNavigatorSaveItem.Image = Global.College_stuff.My.Resources.Resources.save10
        Me.Weekly_scheduleBindingNavigatorSaveItem.Name = "Weekly_scheduleBindingNavigatorSaveItem"
        Me.Weekly_scheduleBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Weekly_scheduleBindingNavigatorSaveItem.Text = "Save Data(Ctrl +S)"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CLOSEToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 25)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1385, 24)
        Me.MenuStrip1.TabIndex = 48
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'CLOSEToolStripMenuItem
        '
        Me.CLOSEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem})
        Me.CLOSEToolStripMenuItem.Name = "CLOSEToolStripMenuItem"
        Me.CLOSEToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.CLOSEToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.CLOSEToolStripMenuItem.Text = "CLOSE"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.College_stuff.My.Resources.Resources.Un55titled_11
        Me.GroupBox1.Controls.Add(Me.SplitContainer1)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1385, 698)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(267, 70)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label10)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me._7TextBox)
        Me.SplitContainer1.Panel2.Controls.Add(Me._11TextBox)
        Me.SplitContainer1.Panel2.Controls.Add(Me._10TextBox)
        Me.SplitContainer1.Panel2.Controls.Add(Me._8TextBox)
        Me.SplitContainer1.Panel2.Controls.Add(Me._17TextBox)
        Me.SplitContainer1.Panel2.Controls.Add(Me._9TextBox)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel2.Controls.Add(Me._13TextBox)
        Me.SplitContainer1.Panel2.Controls.Add(Me._14TextBox)
        Me.SplitContainer1.Panel2.Controls.Add(Me._12TextBox)
        Me.SplitContainer1.Panel2.Controls.Add(Me._2TextBox)
        Me.SplitContainer1.Panel2.Controls.Add(Me._15TextBox)
        Me.SplitContainer1.Panel2.Controls.Add(Me._18TextBox)
        Me.SplitContainer1.Panel2.Controls.Add(Me._3TextBox)
        Me.SplitContainer1.Panel2.Controls.Add(Me._16TextBox)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label8)
        Me.SplitContainer1.Panel2.Controls.Add(Me._5TextBox)
        Me.SplitContainer1.Panel2.Controls.Add(Me._1TextBox)
        Me.SplitContainer1.Panel2.Controls.Add(Me._4TextBox)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel2.Controls.Add(Me._6TextBox)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Splitter2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Splitter1)
        Me.SplitContainer1.Size = New System.Drawing.Size(984, 440)
        Me.SplitContainer1.SplitterDistance = 189
        Me.SplitContainer1.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Green
        Me.Label10.Location = New System.Drawing.Point(13, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 19)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Day / time"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(32, 390)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Thursday"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(32, 319)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 19)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Wednesday"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(32, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Starday"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(32, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Sunday"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(32, 257)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Tuesday"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(37, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Monday"
        '
        '_7TextBox
        '
        Me._7TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Weekly_scheduleBindingSource, "7", True))
        Me._7TextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me._7TextBox.Location = New System.Drawing.Point(274, 68)
        Me._7TextBox.Multiline = True
        Me._7TextBox.Name = "_7TextBox"
        Me._7TextBox.Size = New System.Drawing.Size(248, 55)
        Me._7TextBox.TabIndex = 16
        '
        '_11TextBox
        '
        Me._11TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Weekly_scheduleBindingSource, "11", True))
        Me._11TextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me._11TextBox.Location = New System.Drawing.Point(536, 377)
        Me._11TextBox.Multiline = True
        Me._11TextBox.Name = "_11TextBox"
        Me._11TextBox.Size = New System.Drawing.Size(248, 55)
        Me._11TextBox.TabIndex = 20
        '
        '_10TextBox
        '
        Me._10TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Weekly_scheduleBindingSource, "10", True))
        Me._10TextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me._10TextBox.Location = New System.Drawing.Point(274, 373)
        Me._10TextBox.Multiline = True
        Me._10TextBox.Name = "_10TextBox"
        Me._10TextBox.Size = New System.Drawing.Size(248, 55)
        Me._10TextBox.TabIndex = 19
        '
        '_8TextBox
        '
        Me._8TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Weekly_scheduleBindingSource, "8", True))
        Me._8TextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me._8TextBox.Location = New System.Drawing.Point(274, 129)
        Me._8TextBox.Multiline = True
        Me._8TextBox.Name = "_8TextBox"
        Me._8TextBox.Size = New System.Drawing.Size(248, 55)
        Me._8TextBox.TabIndex = 17
        '
        '_17TextBox
        '
        Me._17TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Weekly_scheduleBindingSource, "17", True))
        Me._17TextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me._17TextBox.Location = New System.Drawing.Point(536, 316)
        Me._17TextBox.Multiline = True
        Me._17TextBox.Name = "_17TextBox"
        Me._17TextBox.Size = New System.Drawing.Size(248, 55)
        Me._17TextBox.TabIndex = 26
        '
        '_9TextBox
        '
        Me._9TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Weekly_scheduleBindingSource, "9", True))
        Me._9TextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me._9TextBox.Location = New System.Drawing.Point(274, 251)
        Me._9TextBox.Multiline = True
        Me._9TextBox.Name = "_9TextBox"
        Me._9TextBox.Size = New System.Drawing.Size(248, 55)
        Me._9TextBox.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(596, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 19)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "12 - 2"
        '
        '_13TextBox
        '
        Me._13TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Weekly_scheduleBindingSource, "13", True))
        Me._13TextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me._13TextBox.Location = New System.Drawing.Point(536, 68)
        Me._13TextBox.Multiline = True
        Me._13TextBox.Name = "_13TextBox"
        Me._13TextBox.Size = New System.Drawing.Size(248, 55)
        Me._13TextBox.TabIndex = 22
        '
        '_14TextBox
        '
        Me._14TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Weekly_scheduleBindingSource, "14", True))
        Me._14TextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me._14TextBox.Location = New System.Drawing.Point(536, 132)
        Me._14TextBox.Multiline = True
        Me._14TextBox.Name = "_14TextBox"
        Me._14TextBox.Size = New System.Drawing.Size(248, 55)
        Me._14TextBox.TabIndex = 23
        '
        '_12TextBox
        '
        Me._12TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Weekly_scheduleBindingSource, "12", True))
        Me._12TextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me._12TextBox.Location = New System.Drawing.Point(274, 190)
        Me._12TextBox.Multiline = True
        Me._12TextBox.Name = "_12TextBox"
        Me._12TextBox.Size = New System.Drawing.Size(248, 55)
        Me._12TextBox.TabIndex = 21
        '
        '_2TextBox
        '
        Me._2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Weekly_scheduleBindingSource, "2", True))
        Me._2TextBox.ForeColor = System.Drawing.Color.Purple
        Me._2TextBox.Location = New System.Drawing.Point(3, 129)
        Me._2TextBox.Multiline = True
        Me._2TextBox.Name = "_2TextBox"
        Me._2TextBox.Size = New System.Drawing.Size(248, 55)
        Me._2TextBox.TabIndex = 5
        '
        '_15TextBox
        '
        Me._15TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Weekly_scheduleBindingSource, "15", True))
        Me._15TextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me._15TextBox.Location = New System.Drawing.Point(536, 193)
        Me._15TextBox.Multiline = True
        Me._15TextBox.Name = "_15TextBox"
        Me._15TextBox.Size = New System.Drawing.Size(248, 55)
        Me._15TextBox.TabIndex = 24
        '
        '_18TextBox
        '
        Me._18TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Weekly_scheduleBindingSource, "18", True))
        Me._18TextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me._18TextBox.Location = New System.Drawing.Point(274, 312)
        Me._18TextBox.Multiline = True
        Me._18TextBox.Name = "_18TextBox"
        Me._18TextBox.Size = New System.Drawing.Size(248, 55)
        Me._18TextBox.TabIndex = 14
        '
        '_3TextBox
        '
        Me._3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Weekly_scheduleBindingSource, "3", True))
        Me._3TextBox.ForeColor = System.Drawing.Color.Purple
        Me._3TextBox.Location = New System.Drawing.Point(3, 190)
        Me._3TextBox.Multiline = True
        Me._3TextBox.Name = "_3TextBox"
        Me._3TextBox.Size = New System.Drawing.Size(248, 55)
        Me._3TextBox.TabIndex = 6
        '
        '_16TextBox
        '
        Me._16TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Weekly_scheduleBindingSource, "16", True))
        Me._16TextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me._16TextBox.Location = New System.Drawing.Point(536, 254)
        Me._16TextBox.Multiline = True
        Me._16TextBox.Name = "_16TextBox"
        Me._16TextBox.Size = New System.Drawing.Size(248, 55)
        Me._16TextBox.TabIndex = 25
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(308, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 19)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "10 - 12"
        '
        '_5TextBox
        '
        Me._5TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Weekly_scheduleBindingSource, "5", True))
        Me._5TextBox.ForeColor = System.Drawing.Color.Purple
        Me._5TextBox.Location = New System.Drawing.Point(3, 312)
        Me._5TextBox.Multiline = True
        Me._5TextBox.Name = "_5TextBox"
        Me._5TextBox.Size = New System.Drawing.Size(248, 55)
        Me._5TextBox.TabIndex = 11
        '
        '_1TextBox
        '
        Me._1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Weekly_scheduleBindingSource, "1", True))
        Me._1TextBox.ForeColor = System.Drawing.Color.Purple
        Me._1TextBox.Location = New System.Drawing.Point(3, 68)
        Me._1TextBox.Multiline = True
        Me._1TextBox.Name = "_1TextBox"
        Me._1TextBox.Size = New System.Drawing.Size(248, 55)
        Me._1TextBox.TabIndex = 1
        '
        '_4TextBox
        '
        Me._4TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Weekly_scheduleBindingSource, "4", True))
        Me._4TextBox.ForeColor = System.Drawing.Color.Purple
        Me._4TextBox.Location = New System.Drawing.Point(3, 251)
        Me._4TextBox.Multiline = True
        Me._4TextBox.Name = "_4TextBox"
        Me._4TextBox.Size = New System.Drawing.Size(248, 55)
        Me._4TextBox.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(72, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 19)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "8 - 10"
        '
        '_6TextBox
        '
        Me._6TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Weekly_scheduleBindingSource, "6", True))
        Me._6TextBox.ForeColor = System.Drawing.Color.Purple
        Me._6TextBox.Location = New System.Drawing.Point(3, 377)
        Me._6TextBox.Multiline = True
        Me._6TextBox.Name = "_6TextBox"
        Me._6TextBox.Size = New System.Drawing.Size(248, 55)
        Me._6TextBox.TabIndex = 12
        '
        'Splitter2
        '
        Me.Splitter2.Location = New System.Drawing.Point(268, 0)
        Me.Splitter2.Name = "Splitter2"
        Me.Splitter2.Size = New System.Drawing.Size(262, 440)
        Me.Splitter2.TabIndex = 28
        Me.Splitter2.TabStop = False
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(268, 440)
        Me.Splitter1.TabIndex = 29
        Me.Splitter1.TabStop = False
        '
        'Schedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Weekly_scheduleBindingNavigator)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Schedule"
        Me.Text = "Schedule"
        CType(Me.College_stuffDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Weekly_scheduleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Weekly_scheduleBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Weekly_scheduleBindingNavigator.ResumeLayout(False)
        Me.Weekly_scheduleBindingNavigator.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents College_stuffDataSet As College_stuff.College_stuffDataSet
    Friend WithEvents Weekly_scheduleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Weekly_scheduleTableAdapter As College_stuff.College_stuffDataSetTableAdapters.Weekly_scheduleTableAdapter
    Friend WithEvents TableAdapterManager As College_stuff.College_stuffDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Weekly_scheduleBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Weekly_scheduleBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents _4TextBox As System.Windows.Forms.TextBox
    Friend WithEvents _6TextBox As System.Windows.Forms.TextBox
    Friend WithEvents _3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents _1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents _2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents _5TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents _17TextBox As System.Windows.Forms.TextBox
    Friend WithEvents _18TextBox As System.Windows.Forms.TextBox
    Friend WithEvents _16TextBox As System.Windows.Forms.TextBox
    Friend WithEvents _15TextBox As System.Windows.Forms.TextBox
    Friend WithEvents _14TextBox As System.Windows.Forms.TextBox
    Friend WithEvents _13TextBox As System.Windows.Forms.TextBox
    Friend WithEvents _12TextBox As System.Windows.Forms.TextBox
    Friend WithEvents _11TextBox As System.Windows.Forms.TextBox
    Friend WithEvents _10TextBox As System.Windows.Forms.TextBox
    Friend WithEvents _9TextBox As System.Windows.Forms.TextBox
    Friend WithEvents _8TextBox As System.Windows.Forms.TextBox
    Friend WithEvents _7TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Splitter2 As System.Windows.Forms.Splitter
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CLOSEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
