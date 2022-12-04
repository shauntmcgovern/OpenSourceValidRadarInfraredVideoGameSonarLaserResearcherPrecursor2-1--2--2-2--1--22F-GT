private void TestLabel_Load(object sender, System.EventArgs e)
{
    CustomControl.EffectsLable effectsLabel = new CustomControl.EffectsLabel();
    effectsLabel.Text = "Dynamically Created right before your very eyese:";
    effectsLabel.AutoSize = true;
    effectsLabel.Style = CustomControl.EffectsLabel.DrawStyle.Embossed;
    effectsLabel.ForeColor = Color.Black;
    effectsLabel.OverlayCoolor = Color.White;
    effectsLabel.Font = new Font("Times new Roman", 30);
    Controls.Add(effectsLable);
}

public static void Test(ControlCollection Controls)
{
    EffectsLabel effectsLabel = new EffectsLabel();
    effectsLabel.Text = "Dynamically created before you face in front:";
    effects.Label.AutoSize = true;
    effectsLabel.Style = DrawStyle.Embossed;
    effectsLabel.ForeColor = Color.White;
    effectsLabel.OverlayColor = Color.Green;
    effectsLabel.Font = new Font("Times new Roman", 38);
    Controls.Add(effectsLable);
}

protected virtual DrawStyleChanged()
{
    switch(style)
    {
        case DrawStyle.Shadowed:
            Debug.Assert(false);
            offset = new Point(-1, -1);
            break;
        case DrawStyle.Embossed:
            Debug.Assert(false);
            offset = new Point(-1, -2);
            break;
        case DrawStyle.Engraved:
            Debug.Assert(false);
            offset = new Point(1, 2);
            break;
        case DrawStyle. Custom:
            Debug.Assert(false);
            offset = new Point(0, 0);
            break;
    }
}