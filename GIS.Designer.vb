<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GIS
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
        Dim More2Label As System.Windows.Forms.Label
        Dim TitleLabel As System.Windows.Forms.Label
        Dim ExplanationLabel As System.Windows.Forms.Label
        Dim CommentLabel As System.Windows.Forms.Label
        Dim TipsLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GIS))
        Me.Communication_skillsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.Communication_skillsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.College_stuffDataSet = New College_stuff.College_stuffDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Communication_skillsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Computer_ethicsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Communication_skillsTableAdapter = New College_stuff.College_stuffDataSetTableAdapters.Communication_skillsTableAdapter()
        Me.TableAdapterManager = New College_stuff.College_stuffDataSetTableAdapters.TableAdapterManager()
        Me.Computer_ethicsTableAdapter = New College_stuff.College_stuffDataSetTableAdapters.Computer_ethicsTableAdapter()
        Me.Cmsgb = New System.Windows.Forms.GroupBox()
        Me.HeadRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.Comment4RichTextBox = New System.Windows.Forms.RichTextBox()
        Me.Comment3RichTextBox = New System.Windows.Forms.RichTextBox()
        Me.DefinitionsRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PicturePictureBox = New System.Windows.Forms.PictureBox()
        Me.ExplanationRichTextBox1 = New System.Windows.Forms.RichTextBox()
        More2Label = New System.Windows.Forms.Label()
        TitleLabel = New System.Windows.Forms.Label()
        ExplanationLabel = New System.Windows.Forms.Label()
        CommentLabel = New System.Windows.Forms.Label()
        TipsLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        CType(Me.Communication_skillsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Communication_skillsBindingNavigator.SuspendLayout()
        CType(Me.Communication_skillsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.College_stuffDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.Computer_ethicsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Cmsgb.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PicturePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'More2Label
        '
        More2Label.AutoSize = True
        More2Label.Location = New System.Drawing.Point(456, 393)
        More2Label.Name = "More2Label"
        More2Label.Size = New System.Drawing.Size(73, 14)
        More2Label.TabIndex = 11
        More2Label.Text = "Definitions"
        '
        'TitleLabel
        '
        TitleLabel.AutoSize = True
        TitleLabel.Location = New System.Drawing.Point(623, 0)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New System.Drawing.Size(37, 14)
        TitleLabel.TabIndex = 2
        TitleLabel.Text = "Title:"
        '
        'ExplanationLabel
        '
        ExplanationLabel.AutoSize = True
        ExplanationLabel.Location = New System.Drawing.Point(3, 64)
        ExplanationLabel.Name = "ExplanationLabel"
        ExplanationLabel.Size = New System.Drawing.Size(83, 14)
        ExplanationLabel.TabIndex = 4
        ExplanationLabel.Text = "Explanation:"
        '
        'CommentLabel
        '
        CommentLabel.AutoSize = True
        CommentLabel.Location = New System.Drawing.Point(991, 114)
        CommentLabel.Name = "CommentLabel"
        CommentLabel.Size = New System.Drawing.Size(70, 14)
        CommentLabel.TabIndex = 6
        CommentLabel.Text = "Comment:"
        '
        'TipsLabel
        '
        TipsLabel.AutoSize = True
        TipsLabel.Location = New System.Drawing.Point(1045, 376)
        TipsLabel.Name = "TipsLabel"
        TipsLabel.Size = New System.Drawing.Size(35, 14)
        TipsLabel.TabIndex = 8
        TipsLabel.Text = "Tips:"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Location = New System.Drawing.Point(991, 61)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(40, 14)
        DateLabel.TabIndex = 10
        DateLabel.Text = "Date:"
        '
        'Communication_skillsBindingNavigator
        '
        Me.Communication_skillsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Communication_skillsBindingNavigator.BindingSource = Me.Communication_skillsBindingSource
        Me.Communication_skillsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Communication_skillsBindingNavigator.DeleteItem = Nothing
        Me.Communication_skillsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.Communication_skillsBindingNavigatorSaveItem, Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3})
        Me.Communication_skillsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Communication_skillsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Communication_skillsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Communication_skillsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Communication_skillsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Communication_skillsBindingNavigator.Name = "Communication_skillsBindingNavigator"
        Me.Communication_skillsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Communication_skillsBindingNavigator.Size = New System.Drawing.Size(1372, 25)
        Me.Communication_skillsBindingNavigator.TabIndex = 1
        Me.Communication_skillsBindingNavigator.Text = "BindingNavigator1"
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
        'Communication_skillsBindingSource
        '
        Me.Communication_skillsBindingSource.DataMember = "Communication skills"
        Me.Communication_skillsBindingSource.DataSource = Me.College_stuffDataSet
        '
        'College_stuffDataSet
        '
        Me.College_stuffDataSet.DataSetName = "College_stuffDataSet"
        Me.College_stuffDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'Communication_skillsBindingNavigatorSaveItem
        '
        Me.Communication_skillsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Communication_skillsBindingNavigatorSaveItem.Image = Global.College_stuff.My.Resources.Resources.save
        Me.Communication_skillsBindingNavigatorSaveItem.Name = "Communication_skillsBindingNavigatorSaveItem"
        Me.Communication_skillsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Communication_skillsBindingNavigatorSaveItem.Text = "Save Data(Ctrl+S)"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.College_stuff.My.Resources.Resources.Untitlted_16
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Back to previous page"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.College_stuff.My.Resources.Resources.Arabic
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        Me.ToolStripButton2.ToolTipText = "Arabic"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = Global.College_stuff.My.Resources.Resources.English
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "ToolStripButton3"
        Me.ToolStripButton3.ToolTipText = "English"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.College_stuff.My.Resources.Resources.Untitl88ed_3
        Me.PictureBox1.Location = New System.Drawing.Point(987, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 29)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox1, "Search for  a title")
        '
        'Button6
        '
        Me.Button6.BackgroundImage = Global.College_stuff.My.Resources.Resources.Untitled_199961
        Me.Button6.Location = New System.Drawing.Point(60, 0)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(50, 43)
        Me.Button6.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.Button6, "Zoom out")
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImage = Global.College_stuff.My.Resources.Resources.Untitled_15563
        Me.Button5.Location = New System.Drawing.Point(4, 0)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(50, 43)
        Me.Button5.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.Button5, "Zoom in")
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.College_stuff.My.Resources.Resources.Untitled_195
        Me.Button1.Location = New System.Drawing.Point(816, 122)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(51, 47)
        Me.Button1.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.Button1, "Add photo")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Navy
        Me.TextBox1.Location = New System.Drawing.Point(1034, 12)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(243, 29)
        Me.TextBox1.TabIndex = 5
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem, Me.CloseToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 25)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1372, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.NewToolStripMenuItem})
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.NewToolStripMenuItem.Text = "New "
        '
        'CloseToolStripMenuItem1
        '
        Me.CloseToolStripMenuItem1.Name = "CloseToolStripMenuItem1"
        Me.CloseToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.CloseToolStripMenuItem1.Size = New System.Drawing.Size(48, 20)
        Me.CloseToolStripMenuItem1.Text = "Close"
        '
        'Computer_ethicsBindingSource
        '
        Me.Computer_ethicsBindingSource.DataMember = "Computer ethics"
        Me.Computer_ethicsBindingSource.DataSource = Me.College_stuffDataSet
        '
        'Communication_skillsTableAdapter
        '
        Me.Communication_skillsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Communication_skillsTableAdapter = Me.Communication_skillsTableAdapter
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
        Me.TableAdapterManager.Statistics_NotesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = College_stuff.College_stuffDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Weekly_scheduleTableAdapter = Nothing
        '
        'Computer_ethicsTableAdapter
        '
        Me.Computer_ethicsTableAdapter.ClearBeforeFill = True
        '
        'Cmsgb
        '
        Me.Cmsgb.BackgroundImage = Global.College_stuff.My.Resources.Resources.Untitled_7
        Me.Cmsgb.Controls.Add(Me.HeadRichTextBox)
        Me.Cmsgb.Controls.Add(Me.Comment4RichTextBox)
        Me.Cmsgb.Controls.Add(Me.Comment3RichTextBox)
        Me.Cmsgb.Controls.Add(Me.DefinitionsRichTextBox)
        Me.Cmsgb.Controls.Add(Me.CheckBox1)
        Me.Cmsgb.Controls.Add(Me.Panel1)
        Me.Cmsgb.Controls.Add(Me.Button1)
        Me.Cmsgb.Controls.Add(More2Label)
        Me.Cmsgb.Controls.Add(Me.IDTextBox)
        Me.Cmsgb.Controls.Add(TitleLabel)
        Me.Cmsgb.Controls.Add(ExplanationLabel)
        Me.Cmsgb.Controls.Add(CommentLabel)
        Me.Cmsgb.Controls.Add(TipsLabel)
        Me.Cmsgb.Controls.Add(DateLabel)
        Me.Cmsgb.Controls.Add(Me.DateDateTimePicker)
        Me.Cmsgb.Controls.Add(Me.PicturePictureBox)
        Me.Cmsgb.Controls.Add(Me.ExplanationRichTextBox1)
        Me.Cmsgb.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmsgb.ForeColor = System.Drawing.Color.Purple
        Me.Cmsgb.Location = New System.Drawing.Point(2, 52)
        Me.Cmsgb.Name = "Cmsgb"
        Me.Cmsgb.Size = New System.Drawing.Size(1370, 689)
        Me.Cmsgb.TabIndex = 0
        Me.Cmsgb.TabStop = False
        '
        'HeadRichTextBox
        '
        Me.HeadRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Communication_skillsBindingSource, "Head", True))
        Me.HeadRichTextBox.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeadRichTextBox.ForeColor = System.Drawing.Color.Crimson
        Me.HeadRichTextBox.Location = New System.Drawing.Point(509, 17)
        Me.HeadRichTextBox.Name = "HeadRichTextBox"
        Me.HeadRichTextBox.Size = New System.Drawing.Size(297, 53)
        Me.HeadRichTextBox.TabIndex = 41
        Me.HeadRichTextBox.Text = ""
        '
        'Comment4RichTextBox
        '
        Me.Comment4RichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Communication_skillsBindingSource, "Comment4", True))
        Me.Comment4RichTextBox.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Comment4RichTextBox.ForeColor = System.Drawing.Color.Fuchsia
        Me.Comment4RichTextBox.Location = New System.Drawing.Point(1048, 393)
        Me.Comment4RichTextBox.Name = "Comment4RichTextBox"
        Me.Comment4RichTextBox.Size = New System.Drawing.Size(277, 194)
        Me.Comment4RichTextBox.TabIndex = 39
        Me.Comment4RichTextBox.Text = ""
        '
        'Comment3RichTextBox
        '
        Me.Comment3RichTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Comment3RichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Communication_skillsBindingSource, "Comment3", True))
        Me.Comment3RichTextBox.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Comment3RichTextBox.ForeColor = System.Drawing.Color.Black
        Me.Comment3RichTextBox.Location = New System.Drawing.Point(994, 134)
        Me.Comment3RichTextBox.Name = "Comment3RichTextBox"
        Me.Comment3RichTextBox.Size = New System.Drawing.Size(277, 239)
        Me.Comment3RichTextBox.TabIndex = 38
        Me.Comment3RichTextBox.Text = ""
        '
        'DefinitionsRichTextBox
        '
        Me.DefinitionsRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Communication_skillsBindingSource, "Definitions", True))
        Me.DefinitionsRichTextBox.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DefinitionsRichTextBox.ForeColor = System.Drawing.Color.DarkViolet
        Me.DefinitionsRichTextBox.Location = New System.Drawing.Point(444, 410)
        Me.DefinitionsRichTextBox.Name = "DefinitionsRichTextBox"
        Me.DefinitionsRichTextBox.Size = New System.Drawing.Size(550, 228)
        Me.DefinitionsRichTextBox.TabIndex = 37
        Me.DefinitionsRichTextBox.Text = ""
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CheckBox1.Location = New System.Drawing.Point(48, 10)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(133, 18)
        Me.CheckBox1.TabIndex = 32
        Me.CheckBox1.Text = "Show the picture"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Location = New System.Drawing.Point(6, 47)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(113, 47)
        Me.Panel1.TabIndex = 31
        Me.Panel1.Visible = False
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Communication_skillsBindingSource, "ID", True))
        Me.IDTextBox.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.IDTextBox.Location = New System.Drawing.Point(680, 183)
        Me.IDTextBox.Multiline = True
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(50, 36)
        Me.IDTextBox.TabIndex = 1
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Communication_skillsBindingSource, "Date", True))
        Me.DateDateTimePicker.Location = New System.Drawing.Point(1064, 57)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.DateDateTimePicker.TabIndex = 11
        '
        'PicturePictureBox
        '
        Me.PicturePictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.Communication_skillsBindingSource, "Image", True))
        Me.PicturePictureBox.Location = New System.Drawing.Point(6, 92)
        Me.PicturePictureBox.Name = "PicturePictureBox"
        Me.PicturePictureBox.Size = New System.Drawing.Size(217, 140)
        Me.PicturePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicturePictureBox.TabIndex = 16
        Me.PicturePictureBox.TabStop = False
        Me.PicturePictureBox.Visible = False
        '
        'ExplanationRichTextBox1
        '
        Me.ExplanationRichTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Communication_skillsBindingSource, "Explanation", True))
        Me.ExplanationRichTextBox1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExplanationRichTextBox1.ForeColor = System.Drawing.Color.Purple
        Me.ExplanationRichTextBox1.Location = New System.Drawing.Point(10, 100)
        Me.ExplanationRichTextBox1.Name = "ExplanationRichTextBox1"
        Me.ExplanationRichTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ExplanationRichTextBox1.Size = New System.Drawing.Size(428, 514)
        Me.ExplanationRichTextBox1.TabIndex = 35
        Me.ExplanationRichTextBox1.Text = ""
        '
        'GIS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Communication_skillsBindingNavigator)
        Me.Controls.Add(Me.Cmsgb)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GIS"
        Me.Text = "GIS"
        CType(Me.Communication_skillsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Communication_skillsBindingNavigator.ResumeLayout(False)
        Me.Communication_skillsBindingNavigator.PerformLayout()
        CType(Me.Communication_skillsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.College_stuffDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.Computer_ethicsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Cmsgb.ResumeLayout(False)
        Me.Cmsgb.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PicturePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cmsgb As System.Windows.Forms.GroupBox
    Friend WithEvents College_stuffDataSet As College_stuff.College_stuffDataSet
    Friend WithEvents Communication_skillsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Communication_skillsTableAdapter As College_stuff.College_stuffDataSetTableAdapters.Communication_skillsTableAdapter
    Friend WithEvents TableAdapterManager As College_stuff.College_stuffDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Communication_skillsBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Communication_skillsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Computer_ethicsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Computer_ethicsTableAdapter As College_stuff.College_stuffDataSetTableAdapters.Computer_ethicsTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PicturePictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExplanationRichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Comment4RichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents Comment3RichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents DefinitionsRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents HeadRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
End Class
