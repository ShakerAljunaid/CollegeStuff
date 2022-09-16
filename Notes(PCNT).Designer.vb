<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Notes_PCNT
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
        Dim TipLabel As System.Windows.Forms.Label
        Dim HintLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim TitleLabel As System.Windows.Forms.Label
        Dim CommentLabel As System.Windows.Forms.Label
        Dim NoteLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Notes_PCNT))
        Me.Logic_design_NotesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.Logic_design_NotesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.Logic_design_NotesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Logic_design_NotesTableAdapter = New College_stuff.College_stuffDataSetTableAdapters.Logic_design_NotesTableAdapter()
        Me.TableAdapterManager = New College_stuff.College_stuffDataSetTableAdapters.TableAdapterManager()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TipRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.PhotoPictureBox = New System.Windows.Forms.PictureBox()
        Me.HintRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TitleRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.CommentRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.NoteRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        TipLabel = New System.Windows.Forms.Label()
        HintLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        TitleLabel = New System.Windows.Forms.Label()
        CommentLabel = New System.Windows.Forms.Label()
        NoteLabel = New System.Windows.Forms.Label()
        CType(Me.Logic_design_NotesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Logic_design_NotesBindingNavigator.SuspendLayout()
        CType(Me.Logic_design_NotesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.College_stuffDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PhotoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TipLabel
        '
        TipLabel.AutoSize = True
        TipLabel.Location = New System.Drawing.Point(1112, 325)
        TipLabel.Name = "TipLabel"
        TipLabel.Size = New System.Drawing.Size(31, 16)
        TipLabel.TabIndex = 14
        TipLabel.Text = "Tip:"
        '
        'HintLabel
        '
        HintLabel.AutoSize = True
        HintLabel.Location = New System.Drawing.Point(765, 381)
        HintLabel.Name = "HintLabel"
        HintLabel.Size = New System.Drawing.Size(39, 16)
        HintLabel.TabIndex = 9
        HintLabel.Text = "Hint:"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Location = New System.Drawing.Point(1109, 68)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(44, 16)
        DateLabel.TabIndex = 7
        DateLabel.Text = "Date:"
        '
        'TitleLabel
        '
        TitleLabel.AutoSize = True
        TitleLabel.Location = New System.Drawing.Point(720, 0)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New System.Drawing.Size(40, 16)
        TitleLabel.TabIndex = 5
        TitleLabel.Text = "Title:"
        '
        'CommentLabel
        '
        CommentLabel.AutoSize = True
        CommentLabel.Location = New System.Drawing.Point(1112, 119)
        CommentLabel.Name = "CommentLabel"
        CommentLabel.Size = New System.Drawing.Size(73, 16)
        CommentLabel.TabIndex = 3
        CommentLabel.Text = "Comment:"
        '
        'NoteLabel
        '
        NoteLabel.AutoSize = True
        NoteLabel.Location = New System.Drawing.Point(12, 53)
        NoteLabel.Name = "NoteLabel"
        NoteLabel.Size = New System.Drawing.Size(43, 16)
        NoteLabel.TabIndex = 1
        NoteLabel.Text = "Note:"
        '
        'Logic_design_NotesBindingNavigator
        '
        Me.Logic_design_NotesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Logic_design_NotesBindingNavigator.BindingSource = Me.Logic_design_NotesBindingSource
        Me.Logic_design_NotesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Logic_design_NotesBindingNavigator.DeleteItem = Nothing
        Me.Logic_design_NotesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.Logic_design_NotesBindingNavigatorSaveItem, Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3})
        Me.Logic_design_NotesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Logic_design_NotesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Logic_design_NotesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Logic_design_NotesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Logic_design_NotesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Logic_design_NotesBindingNavigator.Name = "Logic_design_NotesBindingNavigator"
        Me.Logic_design_NotesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Logic_design_NotesBindingNavigator.Size = New System.Drawing.Size(1372, 25)
        Me.Logic_design_NotesBindingNavigator.TabIndex = 1
        Me.Logic_design_NotesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = Global.College_stuff.My.Resources.Resources.Untitled_610
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'Logic_design_NotesBindingSource
        '
        Me.Logic_design_NotesBindingSource.DataMember = "Logic design Notes"
        Me.Logic_design_NotesBindingSource.DataSource = Me.College_stuffDataSet
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
        'Logic_design_NotesBindingNavigatorSaveItem
        '
        Me.Logic_design_NotesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Logic_design_NotesBindingNavigatorSaveItem.Image = Global.College_stuff.My.Resources.Resources.Untitled_113
        Me.Logic_design_NotesBindingNavigatorSaveItem.Name = "Logic_design_NotesBindingNavigatorSaveItem"
        Me.Logic_design_NotesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Logic_design_NotesBindingNavigatorSaveItem.Text = "Save Data (Ctrl +S)"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.College_stuff.My.Resources.Resources.Untitlted_163
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Back to logic design"
        Me.ToolStripButton1.ToolTipText = "Back to logic design"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.College_stuff.My.Resources.Resources.Arabic4
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Arabic"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = Global.College_stuff.My.Resources.Resources.English3
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "English"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Green
        Me.TextBox1.Location = New System.Drawing.Point(1017, 24)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(273, 32)
        Me.TextBox1.TabIndex = 56
        '
        'Button6
        '
        Me.Button6.BackgroundImage = Global.College_stuff.My.Resources.Resources.Untitled_199965
        Me.Button6.Location = New System.Drawing.Point(63, 0)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(54, 42)
        Me.Button6.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.Button6, "Zoom out")
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImage = Global.College_stuff.My.Resources.Resources.Untitled_19955
        Me.Button5.Location = New System.Drawing.Point(3, 2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(54, 42)
        Me.Button5.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.Button5, "Zoom in")
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.College_stuff.My.Resources.Resources.Untitled_5
        Me.Button2.Location = New System.Drawing.Point(778, 101)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(52, 44)
        Me.Button2.TabIndex = 53
        Me.ToolTip1.SetToolTip(Me.Button2, "Add photo")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.College_stuff.My.Resources.Resources.Untitled_20
        Me.PictureBox1.Location = New System.Drawing.Point(964, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(47, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 57
        Me.PictureBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox1, "Search for a title")
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1372, 24)
        Me.MenuStrip1.TabIndex = 58
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.SaveToolStripMenuItem.Text = "Save"
        Me.SaveToolStripMenuItem.Visible = False
        '
        'Logic_design_NotesTableAdapter
        '
        Me.Logic_design_NotesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Communication_skillsTableAdapter = Nothing
        Me.TableAdapterManager.Computer_ethicsTableAdapter = Nothing
        Me.TableAdapterManager.Diverse_stuffTableAdapter = Nothing
        Me.TableAdapterManager.Logic_design_Assignment_TableAdapter = Nothing
        Me.TableAdapterManager.Logic_design_NotesTableAdapter = Me.Logic_design_NotesTableAdapter
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
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem, Me.CloseToolStripMenuItem1})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 25)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(1372, 24)
        Me.MenuStrip2.TabIndex = 61
        Me.MenuStrip2.Text = "MenuStrip2"
        Me.MenuStrip2.Visible = False
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.NewToolStripMenuItem})
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(141, 22)
        Me.ToolStripMenuItem1.Text = "Save"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'CloseToolStripMenuItem1
        '
        Me.CloseToolStripMenuItem1.Name = "CloseToolStripMenuItem1"
        Me.CloseToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.CloseToolStripMenuItem1.Size = New System.Drawing.Size(48, 20)
        Me.CloseToolStripMenuItem1.Text = "Close"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.College_stuff.My.Resources.Resources.Vision__150_
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(TipLabel)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.TipRichTextBox)
        Me.GroupBox1.Controls.Add(Me.PhotoPictureBox)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(HintLabel)
        Me.GroupBox1.Controls.Add(Me.HintRichTextBox)
        Me.GroupBox1.Controls.Add(DateLabel)
        Me.GroupBox1.Controls.Add(Me.DateDateTimePicker)
        Me.GroupBox1.Controls.Add(TitleLabel)
        Me.GroupBox1.Controls.Add(Me.TitleRichTextBox)
        Me.GroupBox1.Controls.Add(CommentLabel)
        Me.GroupBox1.Controls.Add(Me.CommentRichTextBox)
        Me.GroupBox1.Controls.Add(NoteLabel)
        Me.GroupBox1.Controls.Add(Me.NoteRichTextBox)
        Me.GroupBox1.Controls.Add(Me.IDTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(0, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1372, 686)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Location = New System.Drawing.Point(6, 26)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(121, 43)
        Me.Panel1.TabIndex = 55
        Me.Panel1.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.ForeColor = System.Drawing.Color.Olive
        Me.CheckBox1.Location = New System.Drawing.Point(183, 0)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(138, 20)
        Me.CheckBox1.TabIndex = 54
        Me.CheckBox1.Text = "Show the picture"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TipRichTextBox
        '
        Me.TipRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Logic_design_NotesBindingSource, "Tip", True))
        Me.TipRichTextBox.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipRichTextBox.ForeColor = System.Drawing.Color.DarkMagenta
        Me.TipRichTextBox.Location = New System.Drawing.Point(1112, 344)
        Me.TipRichTextBox.Name = "TipRichTextBox"
        Me.TipRichTextBox.Size = New System.Drawing.Size(217, 169)
        Me.TipRichTextBox.TabIndex = 15
        Me.TipRichTextBox.Text = ""
        '
        'PhotoPictureBox
        '
        Me.PhotoPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.Logic_design_NotesBindingSource, "Photo", True))
        Me.PhotoPictureBox.Location = New System.Drawing.Point(12, 68)
        Me.PhotoPictureBox.Name = "PhotoPictureBox"
        Me.PhotoPictureBox.Size = New System.Drawing.Size(217, 108)
        Me.PhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PhotoPictureBox.TabIndex = 14
        Me.PhotoPictureBox.TabStop = False
        Me.PhotoPictureBox.Visible = False
        '
        'HintRichTextBox
        '
        Me.HintRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Logic_design_NotesBindingSource, "Hint", True))
        Me.HintRichTextBox.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HintRichTextBox.ForeColor = System.Drawing.Color.Green
        Me.HintRichTextBox.Location = New System.Drawing.Point(589, 400)
        Me.HintRichTextBox.Name = "HintRichTextBox"
        Me.HintRichTextBox.Size = New System.Drawing.Size(406, 83)
        Me.HintRichTextBox.TabIndex = 10
        Me.HintRichTextBox.Text = ""
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Logic_design_NotesBindingSource, "Date", True))
        Me.DateDateTimePicker.Location = New System.Drawing.Point(1112, 87)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(200, 23)
        Me.DateDateTimePicker.TabIndex = 8
        '
        'TitleRichTextBox
        '
        Me.TitleRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Logic_design_NotesBindingSource, "Title", True))
        Me.TitleRichTextBox.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleRichTextBox.ForeColor = System.Drawing.Color.Navy
        Me.TitleRichTextBox.Location = New System.Drawing.Point(589, 19)
        Me.TitleRichTextBox.Name = "TitleRichTextBox"
        Me.TitleRichTextBox.Size = New System.Drawing.Size(306, 65)
        Me.TitleRichTextBox.TabIndex = 6
        Me.TitleRichTextBox.Text = ""
        '
        'CommentRichTextBox
        '
        Me.CommentRichTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CommentRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Logic_design_NotesBindingSource, "Comment", True))
        Me.CommentRichTextBox.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CommentRichTextBox.ForeColor = System.Drawing.Color.Red
        Me.CommentRichTextBox.Location = New System.Drawing.Point(1115, 138)
        Me.CommentRichTextBox.Name = "CommentRichTextBox"
        Me.CommentRichTextBox.Size = New System.Drawing.Size(217, 169)
        Me.CommentRichTextBox.TabIndex = 4
        Me.CommentRichTextBox.Text = ""
        '
        'NoteRichTextBox
        '
        Me.NoteRichTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NoteRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Logic_design_NotesBindingSource, "Note", True))
        Me.NoteRichTextBox.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoteRichTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.NoteRichTextBox.Location = New System.Drawing.Point(6, 72)
        Me.NoteRichTextBox.Name = "NoteRichTextBox"
        Me.NoteRichTextBox.Size = New System.Drawing.Size(554, 428)
        Me.NoteRichTextBox.TabIndex = 2
        Me.NoteRichTextBox.Text = ""
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Logic_design_NotesBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(778, 230)
        Me.IDTextBox.Multiline = True
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(52, 38)
        Me.IDTextBox.TabIndex = 1
        '
        'Notes_PCNT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.Logic_design_NotesBindingNavigator)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Notes_PCNT"
        Me.Text = "Notes(PCNT)"
        CType(Me.Logic_design_NotesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Logic_design_NotesBindingNavigator.ResumeLayout(False)
        Me.Logic_design_NotesBindingNavigator.PerformLayout()
        CType(Me.Logic_design_NotesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.College_stuffDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PhotoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents College_stuffDataSet As College_stuff.College_stuffDataSet
    Friend WithEvents Logic_design_NotesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Logic_design_NotesTableAdapter As College_stuff.College_stuffDataSetTableAdapters.Logic_design_NotesTableAdapter
    Friend WithEvents TableAdapterManager As College_stuff.College_stuffDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Logic_design_NotesBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Logic_design_NotesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TipRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents PhotoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents HintRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents TitleRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents CommentRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents NoteRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
End Class
