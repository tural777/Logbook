namespace Logbook.Forms;

partial class MainForm
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

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
            this.pnl_header = new System.Windows.Forms.TableLayoutPanel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pnl_lessonContent = new System.Windows.Forms.Panel();
            this.tBox_Content = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_add_material = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.lbl_lesson_subject = new System.Windows.Forms.Label();
            this.lbl_lesson_title = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.rBtn_replace_teacher = new System.Windows.Forms.RadioButton();
            this.lbl_title = new System.Windows.Forms.Label();
            this.rBtn_main_teacher = new System.Windows.Forms.RadioButton();
            this.pnl_title = new System.Windows.Forms.TableLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbl_comment = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_diamond = new System.Windows.Forms.Button();
            this.lbl_CrystalCount = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_class_work = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_lab_work = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rBtn_cheched_all = new System.Windows.Forms.RadioButton();
            this.lbl_checked_all = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_fullname = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_last_login = new System.Windows.Forms.Label();
            this.pnl_students = new System.Windows.Forms.Panel();
            this.pnl_header.SuspendLayout();
            this.panel9.SuspendLayout();
            this.pnl_lessonContent.SuspendLayout();
            this.panel8.SuspendLayout();
            this.pnl_title.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_header.ColumnCount = 2;
            this.pnl_header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.2322F));
            this.pnl_header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.7678F));
            this.pnl_header.Controls.Add(this.panel9, 1, 0);
            this.pnl_header.Controls.Add(this.panel8, 0, 0);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(20, 20);
            this.pnl_header.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.RowCount = 1;
            this.pnl_header.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnl_header.Size = new System.Drawing.Size(1292, 115);
            this.pnl_header.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.pnl_lessonContent);
            this.panel9.Controls.Add(this.btn_add_material);
            this.panel9.Controls.Add(this.btn_edit);
            this.panel9.Controls.Add(this.lbl_lesson_subject);
            this.panel9.Controls.Add(this.lbl_lesson_title);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(649, 0);
            this.panel9.Margin = new System.Windows.Forms.Padding(0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(643, 115);
            this.panel9.TabIndex = 1;
            // 
            // pnl_lessonContent
            // 
            this.pnl_lessonContent.Controls.Add(this.tBox_Content);
            this.pnl_lessonContent.Controls.Add(this.btn_save);
            this.pnl_lessonContent.Controls.Add(this.btn_cancel);
            this.pnl_lessonContent.Location = new System.Drawing.Point(179, 8);
            this.pnl_lessonContent.Name = "pnl_lessonContent";
            this.pnl_lessonContent.Size = new System.Drawing.Size(0, 0);
            this.pnl_lessonContent.TabIndex = 3;
            this.pnl_lessonContent.Visible = false;
            // 
            // tBox_Content
            // 
            this.tBox_Content.AcceptsReturn = true;
            this.tBox_Content.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tBox_Content.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tBox_Content.Location = new System.Drawing.Point(-148, -38);
            this.tBox_Content.Multiline = true;
            this.tBox_Content.Name = "tBox_Content";
            this.tBox_Content.Size = new System.Drawing.Size(217, 77);
            this.tBox_Content.TabIndex = 2;
            // 
            // btn_save
            // 
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_save.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_save.Location = new System.Drawing.Point(73, -38);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(77, 39);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Saxla";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_cancel_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_cancel.Location = new System.Drawing.Point(73, 3);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(77, 39);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "İmtina";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_save_cancel_Click);
            // 
            // btn_add_material
            // 
            this.btn_add_material.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_material.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.btn_add_material.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_material.Enabled = false;
            this.btn_add_material.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_add_material.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_add_material.Location = new System.Drawing.Point(405, 65);
            this.btn_add_material.Name = "btn_add_material";
            this.btn_add_material.Size = new System.Drawing.Size(224, 39);
            this.btn_add_material.TabIndex = 1;
            this.btn_add_material.Text = "MATERİAL ƏLAVƏ ETMƏK";
            this.btn_add_material.UseVisualStyleBackColor = false;
            // 
            // btn_edit
            // 
            this.btn_edit.BackgroundImage = global::Logbook.Properties.Resources.edit;
            this.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit.Enabled = false;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Location = new System.Drawing.Point(171, 30);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(25, 25);
            this.btn_edit.TabIndex = 0;
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // lbl_lesson_subject
            // 
            this.lbl_lesson_subject.AutoSize = true;
            this.lbl_lesson_subject.BackColor = System.Drawing.Color.Transparent;
            this.lbl_lesson_subject.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl_lesson_subject.Location = new System.Drawing.Point(15, 58);
            this.lbl_lesson_subject.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_lesson_subject.MaximumSize = new System.Drawing.Size(360, 60);
            this.lbl_lesson_subject.Name = "lbl_lesson_subject";
            this.lbl_lesson_subject.Size = new System.Drawing.Size(0, 28);
            this.lbl_lesson_subject.TabIndex = 0;
            // 
            // lbl_lesson_title
            // 
            this.lbl_lesson_title.AutoSize = true;
            this.lbl_lesson_title.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_lesson_title.Location = new System.Drawing.Point(15, 28);
            this.lbl_lesson_title.Name = "lbl_lesson_title";
            this.lbl_lesson_title.Size = new System.Drawing.Size(158, 28);
            this.lbl_lesson_title.TabIndex = 0;
            this.lbl_lesson_title.Text = "Dərsin mövzusu";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.rBtn_replace_teacher);
            this.panel8.Controls.Add(this.lbl_title);
            this.panel8.Controls.Add(this.rBtn_main_teacher);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(649, 115);
            this.panel8.TabIndex = 0;
            // 
            // rBtn_replace_teacher
            // 
            this.rBtn_replace_teacher.AutoSize = true;
            this.rBtn_replace_teacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rBtn_replace_teacher.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rBtn_replace_teacher.Location = new System.Drawing.Point(150, 64);
            this.rBtn_replace_teacher.Name = "rBtn_replace_teacher";
            this.rBtn_replace_teacher.Size = new System.Drawing.Size(164, 24);
            this.rBtn_replace_teacher.TabIndex = 1;
            this.rBtn_replace_teacher.Text = "Müəllim əvəz olunur";
            this.rBtn_replace_teacher.UseVisualStyleBackColor = true;
            this.rBtn_replace_teacher.CheckedChanged += new System.EventHandler(this.rBtn_teacher_CheckedChanged);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.lbl_title.Location = new System.Drawing.Point(3, 12);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(541, 31);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "FBAS_2214_AZ    (Windows Forms and WPF (CT-3))";
            // 
            // rBtn_main_teacher
            // 
            this.rBtn_main_teacher.AutoSize = true;
            this.rBtn_main_teacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rBtn_main_teacher.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rBtn_main_teacher.Location = new System.Drawing.Point(25, 64);
            this.rBtn_main_teacher.Name = "rBtn_main_teacher";
            this.rBtn_main_teacher.Size = new System.Drawing.Size(119, 24);
            this.rBtn_main_teacher.TabIndex = 0;
            this.rBtn_main_teacher.Text = "Əsas müəllim";
            this.rBtn_main_teacher.UseVisualStyleBackColor = true;
            this.rBtn_main_teacher.CheckedChanged += new System.EventHandler(this.rBtn_teacher_CheckedChanged);
            // 
            // pnl_title
            // 
            this.pnl_title.ColumnCount = 7;
            this.pnl_title.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.22058F));
            this.pnl_title.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.70757F));
            this.pnl_title.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.58119F));
            this.pnl_title.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.42223F));
            this.pnl_title.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.42223F));
            this.pnl_title.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.42223F));
            this.pnl_title.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.22396F));
            this.pnl_title.Controls.Add(this.panel7, 6, 0);
            this.pnl_title.Controls.Add(this.panel6, 5, 0);
            this.pnl_title.Controls.Add(this.panel5, 4, 0);
            this.pnl_title.Controls.Add(this.panel4, 3, 0);
            this.pnl_title.Controls.Add(this.panel3, 2, 0);
            this.pnl_title.Controls.Add(this.panel1, 0, 0);
            this.pnl_title.Controls.Add(this.panel2, 1, 0);
            this.pnl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_title.Location = new System.Drawing.Point(20, 135);
            this.pnl_title.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_title.Name = "pnl_title";
            this.pnl_title.RowCount = 1;
            this.pnl_title.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnl_title.Size = new System.Drawing.Size(1292, 82);
            this.pnl_title.TabIndex = 35;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.panel7.Controls.Add(this.lbl_comment);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(1053, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(239, 82);
            this.panel7.TabIndex = 6;
            // 
            // lbl_comment
            // 
            this.lbl_comment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_comment.AutoSize = true;
            this.lbl_comment.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_comment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.lbl_comment.Location = new System.Drawing.Point(10, 31);
            this.lbl_comment.Name = "lbl_comment";
            this.lbl_comment.Size = new System.Drawing.Size(34, 20);
            this.lbl_comment.TabIndex = 27;
            this.lbl_comment.Text = "Rəy";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.panel6.Controls.Add(this.btn_diamond);
            this.panel6.Controls.Add(this.lbl_CrystalCount);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(919, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(134, 82);
            this.panel6.TabIndex = 5;
            // 
            // btn_diamond
            // 
            this.btn_diamond.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_diamond.BackgroundImage = global::Logbook.Properties.Resources.diamond_fill;
            this.btn_diamond.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_diamond.FlatAppearance.BorderSize = 0;
            this.btn_diamond.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_diamond.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_diamond.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_diamond.Location = new System.Drawing.Point(65, 31);
            this.btn_diamond.Name = "btn_diamond";
            this.btn_diamond.Size = new System.Drawing.Size(25, 25);
            this.btn_diamond.TabIndex = 0;
            this.btn_diamond.UseVisualStyleBackColor = true;
            // 
            // lbl_CrystalCount
            // 
            this.lbl_CrystalCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_CrystalCount.AutoSize = true;
            this.lbl_CrystalCount.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_CrystalCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.lbl_CrystalCount.Location = new System.Drawing.Point(41, 26);
            this.lbl_CrystalCount.Name = "lbl_CrystalCount";
            this.lbl_CrystalCount.Size = new System.Drawing.Size(27, 31);
            this.lbl_CrystalCount.TabIndex = 27;
            this.lbl_CrystalCount.Text = "5";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.panel5.Controls.Add(this.lbl_class_work);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(785, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(134, 82);
            this.panel5.TabIndex = 4;
            // 
            // lbl_class_work
            // 
            this.lbl_class_work.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_class_work.AutoSize = true;
            this.lbl_class_work.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_class_work.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.lbl_class_work.Location = new System.Drawing.Point(32, 31);
            this.lbl_class_work.Name = "lbl_class_work";
            this.lbl_class_work.Size = new System.Drawing.Size(70, 20);
            this.lbl_class_work.TabIndex = 27;
            this.lbl_class_work.Text = "Sinifdə iş";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.lbl_lab_work);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(651, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(134, 82);
            this.panel4.TabIndex = 3;
            // 
            // lbl_lab_work
            // 
            this.lbl_lab_work.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_lab_work.AutoSize = true;
            this.lbl_lab_work.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_lab_work.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.lbl_lab_work.Location = new System.Drawing.Point(18, 31);
            this.lbl_lab_work.Name = "lbl_lab_work";
            this.lbl_lab_work.Size = new System.Drawing.Size(99, 20);
            this.lbl_lab_work.TabIndex = 27;
            this.lbl_lab_work.Text = "Yoxlama işlər";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.rBtn_cheched_all);
            this.panel3.Controls.Add(this.lbl_checked_all);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(489, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(162, 82);
            this.panel3.TabIndex = 2;
            // 
            // rBtn_cheched_all
            // 
            this.rBtn_cheched_all.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rBtn_cheched_all.AutoSize = true;
            this.rBtn_cheched_all.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rBtn_cheched_all.Enabled = false;
            this.rBtn_cheched_all.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rBtn_cheched_all.ForeColor = System.Drawing.Color.Green;
            this.rBtn_cheched_all.Location = new System.Drawing.Point(73, 50);
            this.rBtn_cheched_all.Name = "rBtn_cheched_all";
            this.rBtn_cheched_all.Size = new System.Drawing.Size(16, 15);
            this.rBtn_cheched_all.TabIndex = 34;
            this.rBtn_cheched_all.TabStop = true;
            this.rBtn_cheched_all.UseVisualStyleBackColor = true;
            this.rBtn_cheched_all.CheckedChanged += new System.EventHandler(this.rBtn_checked_all_CheckedChanged);
            // 
            // lbl_checked_all
            // 
            this.lbl_checked_all.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_checked_all.AutoSize = true;
            this.lbl_checked_all.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_checked_all.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.lbl_checked_all.Location = new System.Drawing.Point(7, 18);
            this.lbl_checked_all.Name = "lbl_checked_all";
            this.lbl_checked_all.Size = new System.Drawing.Size(148, 20);
            this.lbl_checked_all.TabIndex = 27;
            this.lbl_checked_all.Text = "Hər kəsi qeyd etmək";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.lbl_fullname);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 82);
            this.panel1.TabIndex = 0;
            // 
            // lbl_fullname
            // 
            this.lbl_fullname.AutoSize = true;
            this.lbl_fullname.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_fullname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.lbl_fullname.Location = new System.Drawing.Point(94, 31);
            this.lbl_fullname.Name = "lbl_fullname";
            this.lbl_fullname.Size = new System.Drawing.Size(154, 20);
            this.lbl_fullname.TabIndex = 27;
            this.lbl_fullname.Text = "Adı / Soyadı / Ata adı";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.lbl_last_login);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(338, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(151, 82);
            this.panel2.TabIndex = 1;
            // 
            // lbl_last_login
            // 
            this.lbl_last_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_last_login.AutoSize = true;
            this.lbl_last_login.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_last_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.lbl_last_login.Location = new System.Drawing.Point(2, 31);
            this.lbl_last_login.Name = "lbl_last_login";
            this.lbl_last_login.Size = new System.Drawing.Size(147, 20);
            this.lbl_last_login.TabIndex = 27;
            this.lbl_last_login.Text = "MyStats\'a daxil olub";
            // 
            // pnl_students
            // 
            this.pnl_students.AutoSize = true;
            this.pnl_students.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_students.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_students.Location = new System.Drawing.Point(20, 217);
            this.pnl_students.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_students.Name = "pnl_students";
            this.pnl_students.Size = new System.Drawing.Size(1292, 505);
            this.pnl_students.TabIndex = 36;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(1300, 0);
            this.ClientSize = new System.Drawing.Size(1332, 742);
            this.Controls.Add(this.pnl_students);
            this.Controls.Add(this.pnl_title);
            this.Controls.Add(this.pnl_header);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logbook";
            this.Load += new System.EventHandler(this.Logbook_Load);
            this.pnl_header.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.pnl_lessonContent.ResumeLayout(false);
            this.pnl_lessonContent.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.pnl_title.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private TableLayoutPanel pnl_header;
    private TableLayoutPanel pnl_title;
    private Panel panel7;
    private Panel panel6;
    public Label lbl_CrystalCount;
    private Panel panel5;
    private Panel panel4;
    private Panel panel3;
    private Panel panel1;
    private Panel panel2;
    private Panel pnl_students;
    private Panel panel9;
    private Panel panel8;
    private RadioButton rBtn_replace_teacher;
    private RadioButton rBtn_main_teacher;
    private Label lbl_title;
    private Label lbl_lab_work;
    private Label lbl_checked_all;
    private Label lbl_fullname;
    private Label lbl_last_login;
    private RadioButton rBtn_cheched_all;
    private Label lbl_comment;
    private Label lbl_class_work;
    private Label lbl_lesson_title;
    private Button btn_diamond;
    private Button btn_edit;
    private Button btn_add_material;
    private Panel pnl_lessonContent;
    private TextBox tBox_Content;
    private Button btn_save;
    private Button btn_cancel;
    private Label lbl_lesson_subject;
}