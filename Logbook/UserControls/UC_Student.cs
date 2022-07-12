using Logbook.CustomStyleControls;
using Logbook.Models;

namespace Logbook;



public partial class UC_Student : UserControl
{
    public Predicate<int> ChangeTotalScore { get; set; }



    public UC_Student(Student student, Predicate<int> changeTotalScore)
    {
        InitializeComponent();


        cbox_labWork.SelectedIndex = 0;
        cbox_lessonWork.SelectedIndex = 0;




        if (student != null)
        {
            InitializeStudent(student);
        }

        ChangeTotalScore = changeTotalScore;
    }

    private void InitializeStudent(Student student)
    {
        lbl_no.Text = student.Number.ToString();

        if (student.PictureUrl is not null)
            picture.Image = Image.FromFile($"../../../Resources/{student.PictureUrl}");



        lbl_fullName.Text = student.FullName();

        if (student.LastIn.HasValue)
            lbl_date.Text = student.LastIn.Value.ToString("MM/dd/yy");


        switch (student.Status)
        {
            case ParticipationStatus.Present:
                rBtn_present.Checked = true;
                break;
            case ParticipationStatus.Absent:
                rBtn_absent.Checked = true;
                break;
            case ParticipationStatus.Late:
                rBtn_late.Checked = true;
                break;
        }

    }



    private void diamond_Click(object sender, EventArgs e)
    {

        var btn = (sender as DiamondButton);

        if (btn is null)
            return;


        int score = 0;
        foreach (var control in pnl_sub_diamond.Controls)
            if (control is DiamondButton d)
                if (d.Checked)
                    score--;


        if (!ChangeTotalScore(score + btn.Score))
            return;



        foreach (var control in pnl_sub_diamond.Controls)
            if (control is DiamondButton d)
                if (d.Rank > btn.Rank)
                    d.Checked = false;
                else
                    d.Checked = true;
    }



    private void btn_clear_Click(object sender, EventArgs e)
    {
        int score = 0;

        foreach (var control in pnl_sub_diamond.Controls)
            if (control is DiamondButton d)
                if (d.Checked)
                {
                    score--;
                    d.Checked = false;
                }

        if (score < 0)
            ChangeTotalScore(score);
    }

    private void btn_comment_Click(object sender, EventArgs e)
    {
        ChangeVisibilty();
    }




    private void btn_save_cancel_Click(object sender, EventArgs e)
    {
        var btn = sender as Button;

        if (btn is null)
            return;

        if (btn.Tag?.ToString() == "Cancel" || txt_comment.Text.Length == 0)
        {
            ChangeVisibilty();
            return;
        }



        txt_comment.Text = $"{DateTime.Now.ToShortDateString()}: {txt_comment.Text}";

        var height = new Label
        {
            MaximumSize = new Size(300, 0),
            Text = txt_comment.Text
        }.PreferredHeight;



        if (height != 20)
        {
            Height += height;

            var form = (Parent.Parent as Form);

            if (form is not null)
            {
                var size = form.AutoScrollMinSize;
                form.AutoScrollMinSize = new Size(size.Width, size.Height + height);
            }
        }

        pnl_responsive_comment.Padding = new Padding(0, 17, 0, 0);



        txt_comment.Enabled = false;
        btn_save.Visible = false;
        btn_cancel.Visible = false;
    }



    private void ChangeVisibilty()
    {
        btn_comment.Visible = !btn_comment.Visible;
        btn_save.Visible = !btn_save.Visible;
        btn_cancel.Visible = !btn_cancel.Visible;
        txt_comment.Visible = !txt_comment.Visible;
    }
}