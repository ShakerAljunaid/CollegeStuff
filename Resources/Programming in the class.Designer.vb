<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Programming_in_the_class
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Programming_in_the_class))
        Dim NotesLabel As System.Windows.Forms.Label
        Dim MoreInfoLabel As System.Windows.Forms.Label
        Dim AdditionalLabel As System.Windows.Forms.Label
        Dim CommentsLabel As System.Windows.Forms.Label
        Dim CodeLabel As System.Windows.Forms.Label
        Dim TitleLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim DateLabel1 As System.Windows.Forms.Label
        Me.College_stuffDataSet = New College_stuff.College_stuffDataSet()
        Me.Programming_In_the_classl_BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Programming_In_the_classl_TableAdapter = New College_stuff.College_stuffDataSetTableAdapters.Programming_In_the_classl_TableAdapter()
        Me.TableAdapterManager = New College_stuff.College_stuffDataSetTableAdapters.TableAdapterManager()
        Me.Programming_In_the_classl_BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.Programming_In_the_classl_BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.IDTextBox1 = New System.Windows.Forms.TextBox()
        Me.More5RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.PicturePictureBox = New System.Windows.Forms.PictureBox()
        Me.CodeRichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.NotesRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.CommentsTextBox1 = New System.Windows.Forms.TextBox()
        Me.AdditionalTextBox1 = New System.Windows.Forms.TextBox()
        Me.MoreInfoTextBox1 = New System.Windows.Forms.TextBox()
        Me.DateDateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ASSIGB = New System.Windows.Forms.GroupBox()
        Me.TitleTextBox1 = New System.Windows.Forms.TextBox()
        NotesLabel = New System.Windows.Forms.Label()
        MoreInfoLabel = New System.Windows.Forms.Label()
        AdditionalLabel = New System.Windows.Forms.Label()
        CommentsLabel = New System.Windows.Forms.Label()
        CodeLabel = New System.Windows.Forms.Label()
        TitleLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        DateLabel1 = New System.Windows.Forms.Label()
        CType(Me.College_stuffDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Programming_In_the_classl_BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Programming_In_the_classl_BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Programming_In_the_classl_BindingNavigator.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PicturePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ASSIGB.SuspendLayout()
        Me.SuspendLayout()
        '
        'College_stuffDataSet
        '
        Me.College_stuffDataSet.DataSetName = "College_stuffDataSet"
        Me.College_stuffDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Programming_In_the_classl_BindingSource
        '
        Me.Programming_In_the_classl_BindingSource.DataMember = "Programming(In the classl)"
        Me.Programming_In_the_classl_BindingSource.DataSource = Me.College_stuffDataSet
        '
        'Programming_In_the_classl_TableAdapter
        '
        Me.Programming_In_the_classl_TableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.Programming_In_the_classl_TableAdapter = Me.Programming_In_the_classl_TableAdapter
        Me.TableAdapterManager.Programming_practical_TableAdapter = Nothing
        Me.TableAdapterManager.Programming_theorical_TableAdapter = Nothing
        Me.TableAdapterManager.statistic_and_possibilities_Assignment_TableAdapter = Nothing
        Me.TableAdapterManager.statistic_and_possibilitiesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = College_stuff.College_stuffDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Weekly_scheduleTableAdapter = Nothing
        '
        'Programming_In_the_classl_BindingNavigator
        '
        Me.Programming_In_the_classl_BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Programming_In_the_classl_BindingNavigator.BindingSource = Me.Programming_In_the_classl_BindingSource
        Me.Programming_In_the_classl_BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Programming_In_the_classl_BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Programming_In_the_classl_BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Programming_In_the_classl_BindingNavigatorSaveItem})
        Me.Programming_In_the_classl_BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Programming_In_the_classl_BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Programming_In_the_classl_BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Programming_In_the_classl_BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Programming_In_the_classl_BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Programming_In_the_classl_BindingNavigator.Name = "Programming_In_the_classl_BindingNavigator"
        Me.Programming_In_the_classl_BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Programming_In_the_classl_BindingNavigator.Size = New System.Drawing.Size(1370, 25)
        Me.Programming_In_the_classl_BindingNavigator.TabIndex = 2
        Me.Programming_In_the_classl_BindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'Programming_In_the_classl_BindingNavigatorSaveItem
        '
        Me.Programming_In_the_classl_BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Programming_In_the_classl_BindingNavigatorSaveItem.Image = CType(resources.GetObject("Programming_In_the_classl_BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Programming_In_the_classl_BindingNavigatorSaveItem.Name = "Programming_In_the_classl_BindingNavigatorSaveItem"
        Me.Programming_In_the_classl_BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Programming_In_the_classl_BindingNavigatorSaveItem.Text = "Save Data"
        '
        'NotesLabel
        '
        NotesLabel.AutoSize = True
        NotesLabel.Location = New System.Drawing.Point(583, 487)
        NotesLabel.Name = "NotesLabel"
        NotesLabel.Size = New System.Drawing.Size(50, 16)
        NotesLabel.TabIndex = 14
        NotesLabel.Text = "Notes:"
        '
        'MoreInfoLabel
        '
        MoreInfoLabel.AutoSize = True
        MoreInfoLabel.Location = New System.Drawing.Point(849, 374)
        MoreInfoLabel.Name = "MoreInfoLabel"
        MoreInfoLabel.Size = New System.Drawing.Size(76, 16)
        MoreInfoLabel.TabIndex = 10
        MoreInfoLabel.Text = "More Info:"
        '
        'AdditionalLabel
        '
        AdditionalLabel.AutoSize = True
        AdditionalLabel.Location = New System.Drawing.Point(861, 230)
        AdditionalLabel.Name = "AdditionalLabel"
        AdditionalLabel.Size = New System.Drawing.Size(78, 16)
        AdditionalLabel.TabIndex = 8
        AdditionalLabel.Text = "Additional:"
        '
        'CommentsLabel
        '
        CommentsLabel.AutoSize = True
        CommentsLabel.Location = New System.Drawing.Point(849, 75)
        CommentsLabel.Name = "CommentsLabel"
        CommentsLabel.Size = New System.Drawing.Size(80, 16)
        CommentsLabel.TabIndex = 6
        CommentsLabel.Text = "Comments:"
        '
        'CodeLabel
        '
        CodeLabel.AutoSize = True
        CodeLabel.Location = New System.Drawing.Point(8, 227)
        CodeLabel.Name = "CodeLabel"
        CodeLabel.Size = New System.Drawing.Size(45, 16)
        CodeLabel.TabIndex = 4
        CodeLabel.Text = "Code:"
        '
        'TitleLabel
        '
        TitleLabel.AutoSize = True
        TitleLabel.Location = New System.Drawing.Point(571, 0)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New System.Drawing.Size(40, 16)
        TitleLabel.TabIndex = 2
        TitleLabel.Text = "Title:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(6, 75)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(65, 16)
        Label1.TabIndex = 17
        Label1.Text = "Example:"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.College_stuff.My.Resources.Resources.Untitled_1956
        Me.Button1.Location = New System.Drawing.Point(654, 99)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 44)
        Me.Button1.TabIndex = 32
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.ForeColor = System.Drawing.Color.Olive
        Me.CheckBox1.Location = New System.Drawing.Point(277, 24)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(138, 20)
        Me.CheckBox1.TabIndex = 33
        Me.CheckBox1.Text = "Show the picture"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.College_stuff.My.Resources.Resources.Untitled_435
        Me.Button3.Location = New System.Drawing.Point(720, 96)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(61, 56)
        Me.Button3.TabIndex = 35
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Location = New System.Drawing.Point(6, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(104, 48)
        Me.Panel1.TabIndex = 34
        Me.Panel1.Visible = False
        '
        'Button5
        '
        Me.Button5.BackgroundImage = Global.College_stuff.My.Resources.Resources.Untitled_199511
        Me.Button5.Location = New System.Drawing.Point(3, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(52, 44)
        Me.Button5.TabIndex = 0
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.BackgroundImage = Global.College_stuff.My.Resources.Resources.Untitled_1999612
        Me.Button6.Location = New System.Drawing.Point(56, 5)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(48, 43)
        Me.Button6.TabIndex = 1
        Me.Button6.UseVisualStyleBackColor = True
        '
        'IDTextBox1
        '
        Me.IDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Programming_In_the_classl_BindingSource, "ID", True))
        Me.IDTextBox1.ForeColor = System.Drawing.Color.Red
        Me.IDTextBox1.Location = New System.Drawing.Point(725, 374)
        Me.IDTextBox1.Multiline = True
        Me.IDTextBox1.Name = "IDTextBox1"
        Me.IDTextBox1.Size = New System.Drawing.Size(56, 28)
        Me.IDTextBox1.TabIndex = 36
        '
        'More5RichTextBox1
        '
        Me.More5RichTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Programming_In_the_classl_BindingSource, "Title", True))
        Me.More5RichTextBox1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.More5RichTextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.More5RichTextBox1.Location = New System.Drawing.Point(0, 98)
        Me.More5RichTextBox1.Name = "More5RichTextBox1"
        Me.More5RichTextBox1.Size = New System.Drawing.Size(553, 126)
        Me.More5RichTextBox1.TabIndex = 37
        Me.More5RichTextBox1.Text = ""
        '
        'PicturePictureBox
        '
        Me.PicturePictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.Programming_In_the_classl_BindingSource, "picture", True))
        Me.PicturePictureBox.Location = New System.Drawing.Point(0, 94)
        Me.PicturePictureBox.Name = "PicturePictureBox"
        Me.PicturePictureBox.Size = New System.Drawing.Size(161, 128)
        Me.PicturePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicturePictureBox.TabIndex = 38
        Me.PicturePictureBox.TabStop = False
        Me.PicturePictureBox.Visible = False
        '
        'CodeRichTextBox1
        '
        Me.CodeRichTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Programming_In_the_classl_BindingSource, "Code", True))
        Me.CodeRichTextBox1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodeRichTextBox1.ForeColor = System.Drawing.Color.Purple
        Me.CodeRichTextBox1.Location = New System.Drawing.Point(6, 253)
        Me.CodeRichTextBox1.Name = "CodeRichTextBox1"
        Me.CodeRichTextBox1.Size = New System.Drawing.Size(554, 386)
        Me.CodeRichTextBox1.TabIndex = 39
        Me.CodeRichTextBox1.Text = ""
        '
        'NotesRichTextBox
        '
        Me.NotesRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Programming_In_the_classl_BindingSource, "Notes", True))
        Me.NotesRichTextBox.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotesRichTextBox.ForeColor = System.Drawing.Color.Green
        Me.NotesRichTextBox.Location = New System.Drawing.Point(574, 514)
        Me.NotesRichTextBox.Name = "NotesRichTextBox"
        Me.NotesRichTextBox.Size = New System.Drawing.Size(554, 122)
        Me.NotesRichTextBox.TabIndex = 40
        Me.NotesRichTextBox.Text = ""
        '
        'CommentsTextBox1
        '
        Me.CommentsTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Programming_In_the_classl_BindingSource, "Comments", True))
        Me.CommentsTextBox1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CommentsTextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CommentsTextBox1.Location = New System.Drawing.Point(937, 75)
        Me.CommentsTextBox1.Multiline = True
        Me.CommentsTextBox1.Name = "CommentsTextBox1"
        Me.CommentsTextBox1.Size = New System.Drawing.Size(263, 147)
        Me.CommentsTextBox1.TabIndex = 41
        '
        'AdditionalTextBox1
        '
        Me.AdditionalTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Programming_In_the_classl_BindingSource, "Additional", True))
        Me.AdditionalTextBox1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdditionalTextBox1.ForeColor = System.Drawing.Color.HotPink
        Me.AdditionalTextBox1.Location = New System.Drawing.Point(940, 228)
        Me.AdditionalTextBox1.Multiline = True
        Me.AdditionalTextBox1.Name = "AdditionalTextBox1"
        Me.AdditionalTextBox1.Size = New System.Drawing.Size(258, 137)
        Me.AdditionalTextBox1.TabIndex = 42
        '
        'MoreInfoTextBox1
        '
        Me.MoreInfoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Programming_In_the_classl_BindingSource, "MoreInfo", True))
        Me.MoreInfoTextBox1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MoreInfoTextBox1.ForeColor = System.Drawing.Color.Fuchsia
        Me.MoreInfoTextBox1.Location = New System.Drawing.Point(940, 368)
        Me.MoreInfoTextBox1.Multiline = True
        Me.MoreInfoTextBox1.Name = "MoreInfoTextBox1"
        Me.MoreInfoTextBox1.Size = New System.Drawing.Size(263, 140)
        Me.MoreInfoTextBox1.TabIndex = 43
        '
        'DateDateTimePicker1
        '
        Me.DateDateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Programming_In_the_classl_BindingSource, "Date", True))
        Me.DateDateTimePicker1.Location = New System.Drawing.Point(945, 36)
        Me.DateDateTimePicker1.Name = "DateDateTimePicker1"
        Me.DateDateTimePicker1.Size = New System.Drawing.Size(200, 23)
        Me.DateDateTimePicker1.TabIndex = 44
        '
        'DateLabel1
        '
        DateLabel1.AutoSize = True
        DateLabel1.Location = New System.Drawing.Point(895, 36)
        DateLabel1.Name = "DateLabel1"
        DateLabel1.Size = New System.Drawing.Size(44, 16)
        DateLabel1.TabIndex = 43
        DateLabel1.Text = "Date:"
        '
        'ASSIGB
        '
        Me.ASSIGB.BackgroundImage = Global.College_stuff.My.Resources.Resources.Untitled_101
        Me.ASSIGB.Controls.Add(Me.TitleTextBox1)
        Me.ASSIGB.Controls.Add(DateLabel1)
        Me.ASSIGB.Controls.Add(Me.DateDateTimePicker1)
        Me.ASSIGB.Controls.Add(Me.MoreInfoTextBox1)
        Me.ASSIGB.Controls.Add(Me.AdditionalTextBox1)
        Me.ASSIGB.Controls.Add(Me.CommentsTextBox1)
        Me.ASSIGB.Controls.Add(Me.NotesRichTextBox)
        Me.ASSIGB.Controls.Add(Me.CodeRichTextBox1)
        Me.ASSIGB.Controls.Add(Me.PicturePictureBox)
        Me.ASSIGB.Controls.Add(Me.More5RichTextBox1)
        Me.ASSIGB.Controls.Add(Me.IDTextBox1)
        Me.ASSIGB.Controls.Add(Me.Panel1)
        Me.ASSIGB.Controls.Add(Me.Button3)
        Me.ASSIGB.Controls.Add(Me.CheckBox1)
        Me.ASSIGB.Controls.Add(Me.Button1)
        Me.ASSIGB.Controls.Add(Label1)
        Me.ASSIGB.Controls.Add(TitleLabel)
        Me.ASSIGB.Controls.Add(CodeLabel)
        Me.ASSIGB.Controls.Add(CommentsLabel)
        Me.ASSIGB.Controls.Add(AdditionalLabel)
        Me.ASSIGB.Controls.Add(MoreInfoLabel)
        Me.ASSIGB.Controls.Add(NotesLabel)
        Me.ASSIGB.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ASSIGB.ForeColor = System.Drawing.Color.DarkBlue
        Me.ASSIGB.Location = New System.Drawing.Point(3, 51)
        Me.ASSIGB.Name = "ASSIGB"
        Me.ASSIGB.Size = New System.Drawing.Size(1365, 659)
        Me.ASSIGB.TabIndex = 1
        Me.ASSIGB.TabStop = False
        '
        'TitleTextBox1
        '
        Me.TitleTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Programming_In_the_classl_BindingSource, "Title", True))
        Me.TitleTextBox1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleTextBox1.ForeColor = System.Drawing.Color.DarkMagenta
        Me.TitleTextBox1.Location = New System.Drawing.Point(450, 19)
        Me.TitleTextBox1.Multiline = True
        Me.TitleTextBox1.Name = "TitleTextBox1"
        Me.TitleTextBox1.Size = New System.Drawing.Size(377, 50)
        Me.TitleTextBox1.TabIndex = 45
        '
        'Programming_in_the_class
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Programming_In_the_classl_BindingNavigator)
        Me.Controls.Add(Me.ASSIGB)
        Me.Name = "Programming_in_the_class"
        Me.Text = "Programming_in_the_class"
        CType(Me.College_stuffDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Programming_In_the_classl_BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Programming_In_the_classl_BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Programming_In_the_classl_BindingNavigator.ResumeLayout(False)
        Me.Programming_In_the_classl_BindingNavigator.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PicturePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ASSIGB.ResumeLayout(False)
        Me.ASSIGB.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents College_stuffDataSet As College_stuff.College_stuffDataSet
    Friend WithEvents Programming_In_the_classl_BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Programming_In_the_classl_TableAdapter As College_stuff.College_stuffDataSetTableAdapters.Programming_In_the_classl_TableAdapter
    Friend WithEvents TableAdapterManager As College_stuff.College_stuffDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Programming_In_the_classl_BindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Programming_In_the_classl_BindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents IDTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents More5RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents PicturePictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents CodeRichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents NotesRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents CommentsTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents AdditionalTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents MoreInfoTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DateDateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ASSIGB As System.Windows.Forms.GroupBox
    Friend WithEvents TitleTextBox1 As System.Windows.Forms.TextBox
End Class
