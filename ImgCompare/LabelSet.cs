namespace ImgCompare
{
    internal class LabelSet(Label name, Label width, Label height, Label hash)
    {
        public Label name = name;
        public Label width = width;
        public Label height = height;
        public Label hash = hash;

        public void SetEqual()
        {
            width.BackColor = Color.Gold;
            height.BackColor = Color.Gold;
        }

        public void SetGreater()
        {
            width.BackColor = Color.Chartreuse;
            height.BackColor = Color.Chartreuse;
        }

        public void ResetColor()
        {
            width.BackColor = Color.Empty;
            height.BackColor = Color.Empty;
        }
    }
}
