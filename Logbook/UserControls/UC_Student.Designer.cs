namespace Logbook;

partial class UC_Student
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Component Designer generated code

    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Student));
            this.btn_comment = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.rBtn_absent = new System.Windows.Forms.RadioButton();
            this.rBtn_late = new System.Windows.Forms.RadioButton();
            this.rBtn_present = new System.Windows.Forms.RadioButton();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_fullName = new System.Windows.Forms.Label();
            this.lbl_bottom_line = new System.Windows.Forms.Label();
            this.lbl_top_line = new System.Windows.Forms.Label();
            this.lbl_no = new System.Windows.Forms.Label();
            this.pnl_sub_diamond = new System.Windows.Forms.Panel();
            this.diamond_3 = new Logbook.CustomStyleControls.DiamondButton();
            this.diamond_2 = new Logbook.CustomStyleControls.DiamondButton();
            this.diamond_1 = new Logbook.CustomStyleControls.DiamondButton();
            this.cbox_lessonWork = new Logbook.CustomStyleControls.FlatCombo();
            this.cbox_labWork = new Logbook.CustomStyleControls.FlatCombo();
            this.picture = new Logbook.CustomControls.OvalPictureBox();
            this.pabel = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_comment = new System.Windows.Forms.Panel();
            this.pnl_responsive_comment = new System.Windows.Forms.Panel();
            this.txt_comment = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.pnl_diamond = new System.Windows.Forms.Panel();
            this.pnl_lessonWork = new System.Windows.Forms.Panel();
            this.pnl_labWork = new System.Windows.Forms.Panel();
            this.pnl_participation_status = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnl_sub_diamond.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.pabel.SuspendLayout();
            this.pnl_comment.SuspendLayout();
            this.pnl_responsive_comment.SuspendLayout();
            this.pnl_diamond.SuspendLayout();
            this.pnl_lessonWork.SuspendLayout();
            this.pnl_labWork.SuspendLayout();
            this.pnl_participation_status.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_comment
            // 
            this.btn_comment.BackColor = System.Drawing.Color.Transparent;
            this.btn_comment.BackgroundImage = global::Logbook.Properties.Resources.comment;
            this.btn_comment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_comment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_comment.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_comment.FlatAppearance.BorderSize = 0;
            this.btn_comment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_comment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_comment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_comment.Location = new System.Drawing.Point(10, 10);
            this.btn_comment.Margin = new System.Windows.Forms.Padding(20);
            this.btn_comment.Name = "btn_comment";
            this.btn_comment.Size = new System.Drawing.Size(30, 62);
            this.btn_comment.TabIndex = 40;
            this.btn_comment.UseVisualStyleBackColor = false;
            this.btn_comment.Click += new System.EventHandler(this.btn_comment_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_clear.BackColor = System.Drawing.Color.Transparent;
            this.btn_clear.BackgroundImage = global::Logbook.Properties.Resources.diamond_clear;
            this.btn_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Location = new System.Drawing.Point(93, 26);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(30, 30);
            this.btn_clear.TabIndex = 39;
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // rBtn_absent
            // 
            this.rBtn_absent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rBtn_absent.AutoSize = true;
            this.rBtn_absent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rBtn_absent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rBtn_absent.FlatAppearance.BorderSize = 5;
            this.rBtn_absent.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.rBtn_absent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.rBtn_absent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.rBtn_absent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rBtn_absent.ForeColor = System.Drawing.Color.Red;
            this.rBtn_absent.Location = new System.Drawing.Point(113, 34);
            this.rBtn_absent.Name = "rBtn_absent";
            this.rBtn_absent.Size = new System.Drawing.Size(16, 15);
            this.rBtn_absent.TabIndex = 29;
            this.rBtn_absent.UseVisualStyleBackColor = false;
            // 
            // rBtn_late
            // 
            this.rBtn_late.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rBtn_late.AutoSize = true;
            this.rBtn_late.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rBtn_late.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rBtn_late.ForeColor = System.Drawing.Color.Khaki;
            this.rBtn_late.Location = new System.Drawing.Point(75, 34);
            this.rBtn_late.Name = "rBtn_late";
            this.rBtn_late.Size = new System.Drawing.Size(16, 15);
            this.rBtn_late.TabIndex = 30;
            this.rBtn_late.UseVisualStyleBackColor = false;
            // 
            // rBtn_present
            // 
            this.rBtn_present.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rBtn_present.AutoSize = true;
            this.rBtn_present.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rBtn_present.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rBtn_present.ForeColor = System.Drawing.Color.Green;
            this.rBtn_present.Location = new System.Drawing.Point(37, 34);
            this.rBtn_present.Name = "rBtn_present";
            this.rBtn_present.Size = new System.Drawing.Size(16, 15);
            this.rBtn_present.TabIndex = 31;
            this.rBtn_present.UseVisualStyleBackColor = false;
            // 
            // lbl_date
            // 
            this.lbl_date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_date.Location = new System.Drawing.Point(39, 30);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(78, 23);
            this.lbl_date.TabIndex = 27;
            this.lbl_date.Text = "00.00.00";
            // 
            // lbl_fullName
            // 
            this.lbl_fullName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_fullName.AutoSize = true;
            this.lbl_fullName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_fullName.Location = new System.Drawing.Point(104, 30);
            this.lbl_fullName.Name = "lbl_fullName";
            this.lbl_fullName.Size = new System.Drawing.Size(186, 23);
            this.lbl_fullName.TabIndex = 26;
            this.lbl_fullName.Text = "Name Surname Father";
            // 
            // lbl_bottom_line
            // 
            this.lbl_bottom_line.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lbl_bottom_line.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_bottom_line.Location = new System.Drawing.Point(0, 0);
            this.lbl_bottom_line.Name = "lbl_bottom_line";
            this.lbl_bottom_line.Size = new System.Drawing.Size(1334, 1);
            this.lbl_bottom_line.TabIndex = 42;
            // 
            // lbl_top_line
            // 
            this.lbl_top_line.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lbl_top_line.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_top_line.Location = new System.Drawing.Point(0, 83);
            this.lbl_top_line.Name = "lbl_top_line";
            this.lbl_top_line.Size = new System.Drawing.Size(1334, 1);
            this.lbl_top_line.TabIndex = 42;
            // 
            // lbl_no
            // 
            this.lbl_no.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_no.AutoSize = true;
            this.lbl_no.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_no.Location = new System.Drawing.Point(5, 30);
            this.lbl_no.Name = "lbl_no";
            this.lbl_no.Size = new System.Drawing.Size(33, 23);
            this.lbl_no.TabIndex = 43;
            this.lbl_no.Text = "No";
            // 
            // pnl_sub_diamond
            // 
            this.pnl_sub_diamond.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_sub_diamond.BackColor = System.Drawing.Color.Transparent;
            this.pnl_sub_diamond.Controls.Add(this.diamond_3);
            this.pnl_sub_diamond.Controls.Add(this.diamond_2);
            this.pnl_sub_diamond.Controls.Add(this.diamond_1);
            this.pnl_sub_diamond.Location = new System.Drawing.Point(15, 17);
            this.pnl_sub_diamond.Name = "pnl_sub_diamond";
            this.pnl_sub_diamond.Size = new System.Drawing.Size(78, 49);
            this.pnl_sub_diamond.TabIndex = 44;
            // 
            // diamond_3
            // 
            this.diamond_3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.diamond_3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("diamond_3.BackgroundImage")));
            this.diamond_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.diamond_3.Checked = false;
            this.diamond_3.FlatAppearance.BorderSize = 0;
            this.diamond_3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.diamond_3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.diamond_3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.diamond_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.diamond_3.Location = new System.Drawing.Point(51, 12);
            this.diamond_3.Name = "diamond_3";
            this.diamond_3.Rank = ((byte)(3));
            this.diamond_3.Score = 3;
            this.diamond_3.Size = new System.Drawing.Size(25, 25);
            this.diamond_3.TabIndex = 0;
            this.diamond_3.UseVisualStyleBackColor = true;
            this.diamond_3.Click += new System.EventHandler(this.diamond_Click);
            // 
            // diamond_2
            // 
            this.diamond_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.diamond_2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("diamond_2.BackgroundImage")));
            this.diamond_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.diamond_2.Checked = false;
            this.diamond_2.FlatAppearance.BorderSize = 0;
            this.diamond_2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.diamond_2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.diamond_2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.diamond_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.diamond_2.Location = new System.Drawing.Point(26, 12);
            this.diamond_2.Name = "diamond_2";
            this.diamond_2.Rank = ((byte)(2));
            this.diamond_2.Score = 2;
            this.diamond_2.Size = new System.Drawing.Size(25, 25);
            this.diamond_2.TabIndex = 0;
            this.diamond_2.UseVisualStyleBackColor = true;
            this.diamond_2.Click += new System.EventHandler(this.diamond_Click);
            // 
            // diamond_1
            // 
            this.diamond_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.diamond_1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("diamond_1.BackgroundImage")));
            this.diamond_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.diamond_1.Checked = false;
            this.diamond_1.FlatAppearance.BorderSize = 0;
            this.diamond_1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.diamond_1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.diamond_1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.diamond_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.diamond_1.Location = new System.Drawing.Point(1, 12);
            this.diamond_1.Name = "diamond_1";
            this.diamond_1.Rank = ((byte)(1));
            this.diamond_1.Score = 1;
            this.diamond_1.Size = new System.Drawing.Size(25, 25);
            this.diamond_1.TabIndex = 0;
            this.diamond_1.UseVisualStyleBackColor = true;
            this.diamond_1.Click += new System.EventHandler(this.diamond_Click);
            // 
            // cbox_lessonWork
            // 
            this.cbox_lessonWork.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbox_lessonWork.BorderColor = System.Drawing.Color.Green;
            this.cbox_lessonWork.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbox_lessonWork.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_lessonWork.FormattingEnabled = true;
            this.cbox_lessonWork.Items.AddRange(new object[] {
            "     -",
            "     1",
            "     2",
            "     3",
            "     4",
            "     5",
            "     6",
            "     7",
            "     8",
            "     9",
            "     10",
            "     11",
            "     12"});
            this.cbox_lessonWork.Location = new System.Drawing.Point(33, 27);
            this.cbox_lessonWork.Name = "cbox_lessonWork";
            this.cbox_lessonWork.Size = new System.Drawing.Size(72, 28);
            this.cbox_lessonWork.TabIndex = 45;
            // 
            // cbox_labWork
            // 
            this.cbox_labWork.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbox_labWork.BorderColor = System.Drawing.Color.DarkViolet;
            this.cbox_labWork.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbox_labWork.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_labWork.FormattingEnabled = true;
            this.cbox_labWork.Items.AddRange(new object[] {
            "     -",
            "     1",
            "     2",
            "     3",
            "     4",
            "     5",
            "     6",
            "     7",
            "     8",
            "     9",
            "     10",
            "     11",
            "     12"});
            this.cbox_labWork.Location = new System.Drawing.Point(33, 27);
            this.cbox_labWork.Name = "cbox_labWork";
            this.cbox_labWork.Size = new System.Drawing.Size(72, 28);
            this.cbox_labWork.TabIndex = 45;
            // 
            // picture
            // 
            this.picture.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picture.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picture.BackgroundImage = global::Logbook.Properties.Resources.avatar;
            this.picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picture.Location = new System.Drawing.Point(25, 9);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(65, 65);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 46;
            this.picture.TabStop = false;
            // 
            // pabel
            // 
            this.pabel.ColumnCount = 7;
            this.pabel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.22055F));
            this.pabel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.7071F));
            this.pabel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.58119F));
            this.pabel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.42125F));
            this.pabel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.42125F));
            this.pabel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.42125F));
            this.pabel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.2274F));
            this.pabel.Controls.Add(this.pnl_comment, 6, 0);
            this.pabel.Controls.Add(this.pnl_diamond, 5, 0);
            this.pabel.Controls.Add(this.pnl_lessonWork, 4, 0);
            this.pabel.Controls.Add(this.pnl_labWork, 3, 0);
            this.pabel.Controls.Add(this.pnl_participation_status, 2, 0);
            this.pabel.Controls.Add(this.panel1, 0, 0);
            this.pabel.Controls.Add(this.panel2, 1, 0);
            this.pabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pabel.Location = new System.Drawing.Point(0, 1);
            this.pabel.Margin = new System.Windows.Forms.Padding(0);
            this.pabel.Name = "pabel";
            this.pabel.RowCount = 1;
            this.pabel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pabel.Size = new System.Drawing.Size(1334, 82);
            this.pabel.TabIndex = 47;
            // 
            // pnl_comment
            // 
            this.pnl_comment.Controls.Add(this.pnl_responsive_comment);
            this.pnl_comment.Controls.Add(this.btn_cancel);
            this.pnl_comment.Controls.Add(this.btn_comment);
            this.pnl_comment.Controls.Add(this.btn_save);
            this.pnl_comment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_comment.Enabled = false;
            this.pnl_comment.Location = new System.Drawing.Point(1089, 0);
            this.pnl_comment.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_comment.Name = "pnl_comment";
            this.pnl_comment.Padding = new System.Windows.Forms.Padding(10);
            this.pnl_comment.Size = new System.Drawing.Size(245, 82);
            this.pnl_comment.TabIndex = 6;
            // 
            // pnl_responsive_comment
            // 
            this.pnl_responsive_comment.Controls.Add(this.txt_comment);
            this.pnl_responsive_comment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_responsive_comment.Location = new System.Drawing.Point(40, 10);
            this.pnl_responsive_comment.Name = "pnl_responsive_comment";
            this.pnl_responsive_comment.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.pnl_responsive_comment.Size = new System.Drawing.Size(139, 62);
            this.pnl_responsive_comment.TabIndex = 45;
            // 
            // txt_comment
            // 
            this.txt_comment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_comment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_comment.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_comment.Location = new System.Drawing.Point(5, 0);
            this.txt_comment.Margin = new System.Windows.Forms.Padding(0);
            this.txt_comment.Multiline = true;
            this.txt_comment.Name = "txt_comment";
            this.txt_comment.Size = new System.Drawing.Size(129, 62);
            this.txt_comment.TabIndex = 45;
            this.txt_comment.Visible = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackgroundImage = global::Logbook.Properties.Resources.cancel;
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Location = new System.Drawing.Point(179, 10);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(0);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(28, 62);
            this.btn_cancel.TabIndex = 42;
            this.btn_cancel.Tag = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Visible = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_save_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackgroundImage = global::Logbook.Properties.Resources.save;
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Location = new System.Drawing.Point(207, 10);
            this.btn_save.Margin = new System.Windows.Forms.Padding(0);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(28, 62);
            this.btn_save.TabIndex = 43;
            this.btn_save.Tag = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Visible = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_cancel_Click);
            // 
            // pnl_diamond
            // 
            this.pnl_diamond.BackColor = System.Drawing.Color.Transparent;
            this.pnl_diamond.Controls.Add(this.pnl_sub_diamond);
            this.pnl_diamond.Controls.Add(this.btn_clear);
            this.pnl_diamond.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_diamond.Enabled = false;
            this.pnl_diamond.Location = new System.Drawing.Point(950, 0);
            this.pnl_diamond.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_diamond.Name = "pnl_diamond";
            this.pnl_diamond.Size = new System.Drawing.Size(139, 82);
            this.pnl_diamond.TabIndex = 5;
            // 
            // pnl_lessonWork
            // 
            this.pnl_lessonWork.BackColor = System.Drawing.Color.Transparent;
            this.pnl_lessonWork.Controls.Add(this.cbox_lessonWork);
            this.pnl_lessonWork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_lessonWork.Enabled = false;
            this.pnl_lessonWork.Location = new System.Drawing.Point(811, 0);
            this.pnl_lessonWork.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_lessonWork.Name = "pnl_lessonWork";
            this.pnl_lessonWork.Size = new System.Drawing.Size(139, 82);
            this.pnl_lessonWork.TabIndex = 4;
            // 
            // pnl_labWork
            // 
            this.pnl_labWork.BackColor = System.Drawing.Color.Transparent;
            this.pnl_labWork.Controls.Add(this.cbox_labWork);
            this.pnl_labWork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_labWork.Enabled = false;
            this.pnl_labWork.Location = new System.Drawing.Point(672, 0);
            this.pnl_labWork.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_labWork.Name = "pnl_labWork";
            this.pnl_labWork.Size = new System.Drawing.Size(139, 82);
            this.pnl_labWork.TabIndex = 3;
            // 
            // pnl_participation_status
            // 
            this.pnl_participation_status.BackColor = System.Drawing.Color.Transparent;
            this.pnl_participation_status.Controls.Add(this.rBtn_absent);
            this.pnl_participation_status.Controls.Add(this.rBtn_present);
            this.pnl_participation_status.Controls.Add(this.rBtn_late);
            this.pnl_participation_status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_participation_status.Enabled = false;
            this.pnl_participation_status.Location = new System.Drawing.Point(505, 0);
            this.pnl_participation_status.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_participation_status.Name = "pnl_participation_status";
            this.pnl_participation_status.Size = new System.Drawing.Size(167, 82);
            this.pnl_participation_status.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lbl_fullName);
            this.panel1.Controls.Add(this.lbl_no);
            this.panel1.Controls.Add(this.picture);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(349, 82);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lbl_date);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(349, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(156, 82);
            this.panel2.TabIndex = 1;
            // 
            // UC_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pabel);
            this.Controls.Add(this.lbl_top_line);
            this.Controls.Add(this.lbl_bottom_line);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "UC_Student";
            this.Size = new System.Drawing.Size(1334, 84);
            this.pnl_sub_diamond.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.pabel.ResumeLayout(false);
            this.pnl_comment.ResumeLayout(false);
            this.pnl_responsive_comment.ResumeLayout(false);
            this.pnl_responsive_comment.PerformLayout();
            this.pnl_diamond.ResumeLayout(false);
            this.pnl_lessonWork.ResumeLayout(false);
            this.pnl_labWork.ResumeLayout(false);
            this.pnl_participation_status.ResumeLayout(false);
            this.pnl_participation_status.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion
    public Button btn_clear;
    public RadioButton rBtn_present;
    private Label lbl_bottom_line;
    private Label lbl_no;
    private Panel pnl_sub_diamond;
    private CustomStyleControls.DiamondButton diamond_3;
    private CustomStyleControls.DiamondButton diamond_2;
    private CustomStyleControls.DiamondButton diamond_1;
    private CustomStyleControls.FlatCombo cbox_lessonWork;
    private CustomStyleControls.FlatCombo cbox_labWork;
    private CustomControls.OvalPictureBox picture;
    private TableLayoutPanel pabel;
    private Panel panel1;
    private Label lbl_top_line;
    private Panel panel2;
    private Button btn_comment;
    private RadioButton rBtn_absent;
    private RadioButton rBtn_late;
    private Label lbl_date;
    private Label lbl_fullName;
    public Panel pnl_comment;
    public Panel pnl_diamond;
    public Panel pnl_lessonWork;
    public Panel pnl_labWork;
    public Panel pnl_participation_status;
    private Button btn_cancel;
    private Button btn_save;
    private TextBox txt_comment;
    private Panel pnl_responsive_comment;
}
