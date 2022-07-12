using Logbook.Ropository;

namespace Logbook.Forms;

public partial class MainForm : Form
{
    public Predicate<int> ChangeTotalScore { get; set; }


    public MainForm()
    {
        InitializeComponent();



        ChangeTotalScore += (score) =>
        {
            int totalScore = int.Parse(lbl_CrystalCount.Text);

            if (totalScore - score < 0)
                return false;

            totalScore -= score;
            lbl_CrystalCount.Text = totalScore.ToString();

            return true;
        };
    }




    private void btn_edit_Click(object sender, EventArgs e)
    {
        pnl_lessonContent.Size = new Size(305, 83);

        ChangeVisibilty();
    }






    private bool _firstTimeEditAndSaveButton = true;
    private void btn_save_cancel_Click(object sender, EventArgs e)
    {
        var btn = sender as Button;

        ChangeVisibilty();

        pnl_lessonContent.Size = new Size(0, 0);


        if (btn?.Text == "İmtina" || tBox_Content.Text.Length == 0)
            return;





        lbl_lesson_subject.Text = tBox_Content.Text;


        if (_firstTimeEditAndSaveButton)
        {
            _firstTimeEditAndSaveButton = false;
            rBtn_cheched_all.Enabled = true;
            btn_add_material.Enabled = true;


            foreach (var control in pnl_students.Controls)
                if (control is UC_Student s)
                {
                    s.pnl_participation_status.Enabled = true;
                    s.pnl_labWork.Enabled = true;
                    s.pnl_lessonWork.Enabled = true;
                    s.pnl_diamond.Enabled = true;
                    s.pnl_comment.Enabled = true;
                }
        }

    }


    private void ChangeVisibilty()
    {
        pnl_lessonContent.Visible = !pnl_lessonContent.Visible;
        lbl_lesson_subject.Visible = !lbl_lesson_subject.Visible;
        btn_edit.Visible = !btn_edit.Visible;
        btn_add_material.Visible = !btn_add_material.Visible;
    }


    private void Logbook_Load(object sender, EventArgs e)
    {
        for (int i = FakeRepository.Students.Count - 1; i >= 0; i--)
        {
            var userControl = new UC_Student(FakeRepository.Students[i], ChangeTotalScore);
            userControl.Dock = DockStyle.Top;
            pnl_students.Controls.Add(userControl);
        }


        AutoScrollMinSize = new Size(1300, 220 + pnl_students.PreferredSize.Height);
    }

    private void rBtn_checked_all_CheckedChanged(object sender, EventArgs e)
    {
        foreach (var control in pnl_students.Controls)
            if (control is UC_Student s)
                s.rBtn_present.Checked = true;
    }


    private void rBtn_teacher_CheckedChanged(object sender, EventArgs e)
        => btn_edit.Enabled = true;
}
