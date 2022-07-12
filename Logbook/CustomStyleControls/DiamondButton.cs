namespace Logbook.CustomStyleControls;

public class DiamondButton : Button
{
    public byte Rank { get; set; }
    public int Score { get; set; }


    private bool _checked;
    public bool Checked
    {
        get { return _checked; }
        set
        {
            _checked = value;

            BackgroundImage = value
             ? Properties.Resources.diamond_fill
             : Properties.Resources.diamond_empty;
        }
    }


    public DiamondButton()
    {
        BackgroundImage = Properties.Resources.diamond_empty;
        BackgroundImageLayout = ImageLayout.Zoom;

        FlatStyle = FlatStyle.Flat;

        FlatAppearance.CheckedBackColor = Color.Transparent;
        FlatAppearance.MouseOverBackColor = Color.Transparent;
        FlatAppearance.MouseDownBackColor = Color.Transparent;
        FlatAppearance.BorderSize = 0;

        Cursor = Cursors.Hand;
    }
}
