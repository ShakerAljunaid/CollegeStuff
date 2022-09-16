<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Notes_IS
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
        Dim CommentLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim TipLabel As System.Windows.Forms.Label
        Dim HintLabel As System.Windows.Forms.Label
        Dim TitleLabel As System.Windows.Forms.Label
        Dim NoteLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Notes_IS))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Statistics_NotesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.College_stuffDataSet = New College_stuff.College_stuffDataSet()
        Me.Statistics_NotesTableAdapter = New College_stuff.College_stuffDataSetTableAdapters.Statistics_NotesTableAdapter()
        Me.TableAdapterManager = New College_stuff.College_stuffDataSetTableAdapters.TableAdapterManager()
        Me.Statistics_NotesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Statistics_NotesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CommentRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PhotoPictureBox = New System.Windows.Forms.PictureBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TipRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.HintRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.TitleRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.NoteRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        CommentLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        TipLabel = New System.Windows.Forms.Label()
        HintLabel = New System.Windows.Forms.Label()
        TitleLabel = New System.Windows.Forms.Label()
        NoteLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Statistics_NotesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.College_stuffDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Statistics_NotesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Statistics_NotesBindingNavigator.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PhotoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CommentLabel
        '
        CommentLabel.AutoSize = True
        CommentLabel.Location = New System.Drawing.Point(1095, 113)
        CommentLabel.Name = "CommentLabel"
        CommentLabel.Size = New System.Drawing.Size(73, 16)
        CommentLabel.TabIndex = 12
        CommentLabel.Text = "Comment:"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Location = New System.Drawing.Point(1116, 62)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(44, 16)
        DateLabel.TabIndex = 9
        DateLabel.Text = "Date:"
        '
        'TipLabel
        '
        TipLabel.AutoSize = True
        TipLabel.Location = New System.Drawing.Point(1095, 341)
        TipLabel.Name = "TipLabel"
        TipLabel.Size = New System.Drawing.Size(31, 16)
        TipLabel.TabIndex = 7
        TipLabel.Text = "Tip:"
        '
        'HintLabel
        '
        HintLabel.AutoSize = True
        HintLabel.Location = New System.Drawing.Point(737, 316)
        HintLabel.Name = "HintLabel"
        HintLabel.Size = New System.Drawing.Size(39, 16)
        HintLabel.TabIndex = 5
        HintLabel.Text = "Hint:"
        '
        'TitleLabel
        '
        TitleLabel.AutoSize = True
        TitleLabel.Location = New System.Drawing.Point(669, 0)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New System.Drawing.Size(40, 16)
        TitleLabel.TabIndex = 3
        TitleLabel.Text = "Title:"
        '
        'NoteLabel
        '
        NoteLabel.AutoSize = True
        NoteLabel.Location = New System.Drawing.Point(9, 88)
        NoteLabel.Name = "NoteLabel"
        NoteLabel.Size = New System.Drawing.Size(43, 16)
        NoteLabel.TabIndex = 1
        NoteLabel.Text = "Note:"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.College_stuff.My.Resources.Resources.Untitled_51
        Me.Button1.Location = New System.Drawing.Point(684, 156)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(47, 47)
        Me.Button1.TabIndex = 53
        Me.ToolTip1.SetToolTip(Me.Button1, "Add photo")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.BackgroundImage = Global.College_stuff.My.Resources.Resources.Untitled_199964
        Me.Button6.Location = New System.Drawing.Point(59, -2)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(50, 39)
        Me.Button6.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.Button6, "Zoom out")
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImage = Global.College_stuff.My.Resources.Resources.Untitled_19954
        Me.Button5.Location = New System.Drawing.Point(3, -1)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(50, 47)
        Me.Button5.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.Button5, "Zoom in")
        Me.Button5.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.College_stuff.My.Resources.Resources.Untitled_314
        Me.PictureBox1.Location = New System.Drawing.Point(988, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(47, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 56
        Me.PictureBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox1, "Search for a title")
        '
        'Statistics_NotesBindingSource
        '
        Me.Statistics_NotesBindingSource.DataMember = "Statistics Notes"
        Me.Statistics_NotesBindingSource.DataSource = Me.College_stuffDataSet
        '
        'College_stuffDataSet
        '
        Me.College_stuffDataSet.DataSetName = "College_stuffDataSet"
        Me.College_stuffDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Statistics_NotesTableAdapter
        '
        Me.Statistics_NotesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Communication_skillsTableAdapter = Nothing
        Me.TableAdapterManager.Computer_ethicsTableAdapter = Nothing
        Me.TableAdapterManager.Diverse_stuffTableAdapter = Nothing
        Me.TableAdapterManager.Logic_design_Assignment_TableAdapter = Nothing
        Me.TableAdapterManager.Logic_design_NotesTableAdapter = Nothing
        Me.TableAdapterManager.Logic_design_Practical_TableAdapter = Nothing
        Me.TableAdapterManager.Logic_design_theorical_TableAdapter = Nothing
        Me.TableAdapterManager.Math_assignment_TableAdapter = Nothing
        Me.TableAdapterManager.Math_NotesTableAdapter = Nothing
        Me.TableAdapterManager.MathTableAdapter = Nothing
        Me.TableAdapterManager.NotesTableAdapter = Nothing
        Me.TableAdapterManager.PlansTableAdapter = Nothing
        Me.TableAdapterManager.Programming_assignment_TableAdapter = Nothing
        Me.TableAdapterManager.Programming_In_the_classl_TableAdapter = Nothing
        Me.TableAdapterManager.Programming_NotesTableAdapter = Nothing
        Me.TableAdapterManager.Programming_practical_TableAdapter = Nothing
        Me.TableAdapterManager.Programming_theorical_TableAdapter = Nothing
        Me.TableAdapterManager.Programming_trialsl_TableAdapter = Nothing
        Me.TableAdapterManager.statistic_and_possibilities_Assignment_TableAdapter = Nothing
        Me.TableAdapterManager.statistic_and_possibilitiesTableAdapter = Nothing
        Me.TableAdapterManager.Statistics_NotesTableAdapter = Me.Statistics_NotesTableAdapter
        Me.TableAdapterManager.UpdateOrder = College_stuff.College_stuffDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Weekly_scheduleTableAdapter = Nothing
        '
        'Statistics_NotesBindingNavigator
        '
        Me.Statistics_NotesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Statistics_NotesBindingNavigator.BindingSource = Me.Statistics_NotesBindingSource
        Me.Statistics_NotesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Statistics_NotesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Statistics_NotesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Statistics_NotesBindingNavigatorSaveItem, Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3})
        Me.Statistics_NotesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Statistics_NotesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Statistics_NotesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Statistics_NotesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Statistics_NotesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Statistics_NotesBindingNavigator.Name = "Statistics_NotesBindingNavigator"
        Me.Statistics_NotesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Statistics_NotesBindingNavigator.Size = New System.Drawing.Size(1382, 25)
        Me.Statistics_NotesBindingNavigator.TabIndex = 1
        Me.Statistics_NotesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = Global.College_stuff.My.Resources.Resources.Untitled_4310
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Statistics_NotesBindingNavigatorSaveItem
        '
        Me.Statistics_NotesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Statistics_NotesBindingNavigatorSaveItem.Image = Global.College_stuff.My.Resources.Resources.Untitled_491
        Me.Statistics_NotesBindingNavigatorSaveItem.Name = "Statistics_NotesBindingNavigatorSaveItem"
        Me.Statistics_NotesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Statistics_NotesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.College_stuff.My.Resources.Resources.Untitlted_162
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Back to statistics"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.College_stuff.My.Resources.Resources.Arabic10
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Arabic"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = Global.College_stuff.My.Resources.Resources.English10
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "English"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Green
        Me.TextBox1.Location = New System.Drawing.Point(1041, 28)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(273, 32)
        Me.TextBox1.TabIndex = 55
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem3})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 25)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(1382, 24)
        Me.MenuStrip2.TabIndex = 73
        Me.MenuStrip2.Text = "MenuStrip2"
        Me.MenuStrip2.Visible = False
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.NewToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(48, 20)
        Me.ToolStripMenuItem1.Text = "Close"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(141, 22)
        Me.ToolStripMenuItem2.Text = "Save"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(48, 20)
        Me.ToolStripMenuItem3.Text = "Close"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.College_stuff.My.Resources.Resources.Untitled_1111
        Me.GroupBox1.Controls.Add(CommentLabel)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.CommentRichTextBox)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.PhotoPictureBox)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(DateLabel)
        Me.GroupBox1.Controls.Add(Me.DateDateTimePicker)
        Me.GroupBox1.Controls.Add(TipLabel)
        Me.GroupBox1.Controls.Add(Me.TipRichTextBox)
        Me.GroupBox1.Controls.Add(HintLabel)
        Me.GroupBox1.Controls.Add(Me.HintRichTextBox)
        Me.GroupBox1.Controls.Add(TitleLabel)
        Me.GroupBox1.Controls.Add(Me.TitleRichTextBox)
        Me.GroupBox1.Controls.Add(NoteLabel)
        Me.GroupBox1.Controls.Add(Me.NoteRichTextBox)
        Me.GroupBox1.Controls.Add(Me.IDTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1382, 682)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'CommentRichTextBox
        '
        Me.CommentRichTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CommentRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Statistics_NotesBindingSource, "Comment", True))
        Me.CommentRichTextBox.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CommentRichTextBox.ForeColor = System.Drawing.Color.DeepPink
        Me.CommentRichTextBox.Location = New System.Drawing.Point(1098, 132)
        Me.CommentRichTextBox.Name = "CommentRichTextBox"
        Me.CommentRichTextBox.Size = New System.Drawing.Size(216, 200)
        Me.CommentRichTextBox.TabIndex = 13
        Me.CommentRichTextBox.Text = ""
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Location = New System.Drawing.Point(5, 70)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(112, 36)
        Me.Panel1.TabIndex = 52
        Me.Panel1.Visible = False
        '
        'PhotoPictureBox
        '
        Me.PhotoPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.Statistics_NotesBindingSource, "Photo", True))
        Me.PhotoPictureBox.Location = New System.Drawing.Point(5, 107)
        Me.PhotoPictureBox.Name = "PhotoPictureBox"
        Me.PhotoPictureBox.Size = New System.Drawing.Size(167, 96)
        Me.PhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PhotoPictureBox.TabIndex = 12
        Me.PhotoPictureBox.TabStop = False
        Me.PhotoPictureBox.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.ForeColor = System.Drawing.Color.Olive
        Me.CheckBox1.Location = New System.Drawing.Point(249, 45)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(138, 20)
        Me.CheckBox1.TabIndex = 51
        Me.CheckBox1.Text = "Show the picture"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Statistics_NotesBindingSource, "Date", True))
        Me.DateDateTimePicker.Location = New System.Drawing.Point(1132, 81)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(200, 23)
        Me.DateDateTimePicker.TabIndex = 10
        '
        'TipRichTextBox
        '
        Me.TipRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Statistics_NotesBindingSource, "Tip", True))
        Me.TipRichTextBox.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipRichTextBox.ForeColor = System.Drawing.Color.DarkMagenta
        Me.TipRichTextBox.Location = New System.Drawing.Point(1098, 360)
        Me.TipRichTextBox.Name = "TipRichTextBox"
        Me.TipRichTextBox.Size = New System.Drawing.Size(216, 199)
        Me.TipRichTextBox.TabIndex = 8
        Me.TipRichTextBox.Text = ""
        '
        'HintRichTextBox
        '
        Me.HintRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Statistics_NotesBindingSource, "Hint", True))
        Me.HintRichTextBox.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HintRichTextBox.ForeColor = System.Drawing.Color.Crimson
        Me.HintRichTextBox.Location = New System.Drawing.Point(579, 335)
        Me.HintRichTextBox.Name = "HintRichTextBox"
        Me.HintRichTextBox.Size = New System.Drawing.Size(371, 68)
        Me.HintRichTextBox.TabIndex = 6
        Me.HintRichTextBox.Text = ""
        '
        'TitleRichTextBox
        '
        Me.TitleRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Statistics_NotesBindingSource, "Title", True))
        Me.TitleRichTextBox.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleRichTextBox.ForeColor = System.Drawing.Color.Fuchsia
        Me.TitleRichTextBox.Location = New System.Drawing.Point(516, 22)
        Me.TitleRichTextBox.Name = "TitleRichTextBox"
        Me.TitleRichTextBox.Size = New System.Drawing.Size(349, 64)
        Me.TitleRichTextBox.TabIndex = 4
        Me.TitleRichTextBox.Text = ""
        '
        'NoteRichTextBox
        '
        Me.NoteRichTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.NoteRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Statistics_NotesBindingSource, "Note", True))
        Me.NoteRichTextBox.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoteRichTextBox.ForeColor = System.Drawing.Color.Black
        Me.NoteRichTextBox.Location = New System.Drawing.Point(12, 107)
        Me.NoteRichTextBox.Name = "NoteRichTextBox"
        Me.NoteRichTextBox.Size = New System.Drawing.Size(511, 366)
        Me.NoteRichTextBox.TabIndex = 2
        Me.NoteRichTextBox.Text = ""
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Statistics_NotesBindingSource, "ID", True))
        Me.IDTextBox.ForeColor = System.Drawing.Color.Maroon
        Me.IDTextBox.Location = New System.Drawing.Point(740, 240)
        Me.IDTextBox.Multiline = True
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(48, 35)
        Me.IDTextBox.TabIndex = 1
        '
        'Notes_IS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.Statistics_NotesBindingNavigator)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Notes_IS"
        Me.Text = "Notes(IS)"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Statistics_NotesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.College_stuffDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Statistics_NotesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Statistics_NotesBindingNavigator.ResumeLayout(False)
        Me.Statistics_NotesBindingNavigator.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PhotoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents College_stuffDataSet As College_stuff.College_stuffDataSet
    Friend WithEvents Statistics_NotesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Statistics_NotesTableAdapter As College_stuff.College_stuffDataSetTableAdapters.Statistics_NotesTableAdapter
    Friend WithEvents TableAdapterManager As College_stuff.College_stuffDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Statistics_NotesBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Statistics_NotesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PhotoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents TipRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents HintRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents TitleRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents NoteRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CommentRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
End Class
