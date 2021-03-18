using System;
using System.Collections.Generic;

namespace Maze
{
    public class MazeGrid
    {
        private static readonly int COMPLEXITY_DEFAULT = 5;
        private static readonly int COMPLEXITY_MIN = 3;
        private static readonly int COMPLEXITY_MAX = 61;
        private static readonly int MAX_ITERATIONS = 50000;
        private readonly int BRANCH_PERCENT = 10;
        private readonly char CH_WALL = 'X';
        private readonly char CH_SPACE = '-';

        private int complexity;
        private List<MazePath> paths;
        private List<MazePath> branches;
        private int rows;
        private int columns;
        private int wall_left = 0;
        private int wall_right = 0;
        private int wall_top;
        private int wall_bottom;
        private int while_control = 0;
        private GridPoint startPoint;
        private GridPoint exitPoint;
        private int startX;
        private int startY;
        private int exitX;
        private int exitY;

        public ColorRGB wallColor { get; set; }
        public ColorRGB spaceColor { get; set; }

        public MazeGrid(int complexity, ColorRGB wallColor, ColorRGB spaceColor)
        {
            this.complexity = complexity;
            this.wallColor = wallColor;
            this.spaceColor = spaceColor;

            rows = complexity * 3;
            columns = (complexity * 4) + 1;
            wall_right = columns - 1;
            wall_bottom = rows - 1;
        }

        public MazeGrid(int complexity) : this(complexity, new ColorRGB(100, 100, 100), new ColorRGB(200, 200, 200))
        {
        }

        public MazeGrid() : this(COMPLEXITY_DEFAULT, new ColorRGB(100, 100, 100), new ColorRGB(200, 200, 200))
        {
        }

    }
}