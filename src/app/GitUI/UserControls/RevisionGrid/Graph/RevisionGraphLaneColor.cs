namespace GitUI.UserControls.RevisionGrid.Graph
{
    public static class RevisionGraphLaneColor
    {
        internal static readonly IReadOnlyList<Color> PresetGraphColors = new[]
        {
            Color.FromArgb(240, 100, 160), // pink
            Color.FromArgb(120, 180, 230), // light blue
            Color.FromArgb(36, 194, 33), // green
            Color.FromArgb(230, 36, 107), // red-pink
            Color.FromArgb(142, 108, 193), // light violet
            Color.FromArgb(221, 76, 60), // red
            Color.FromArgb(60, 120, 220), // dark blue
            Color.FromArgb(26, 198, 166), // cyan-green
            Color.FromArgb(231, 176, 15) // orange
        };

        public static int GetColorForLane(int seed)
        {
            return Math.Abs(seed) % PresetGraphBrushes.Length;
        }

        public static Color NonRelativeColor { get; } = Color.LightGray;

        internal static Brush NonRelativeBrush { get; }

        internal static readonly Brush[] PresetGraphBrushes;

        static RevisionGraphLaneColor()
        {
            PresetGraphBrushes = PresetGraphColors
                .Select(color => (Brush)new SolidBrush(color))
                .ToArray();

            NonRelativeBrush = new SolidBrush(NonRelativeColor);
        }

        public static Brush GetBrushForLane(int laneColor)
        {
            return PresetGraphBrushes[laneColor];
        }
    }
}
