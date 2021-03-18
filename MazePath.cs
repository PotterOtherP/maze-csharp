using System;
using System.Collections.Generic;

namespace Maze
{
public class MazePath
{
    public Direction direction {get; set; }
    public bool active { get; set; }
    public List<GridPoint> points;
    public Random rand;

    public MazePath(int startX, int startY, Direction dir)
    {
        points.Add(new GridPoint(startX, startY));
        direction = dir;
        rand = new Random();
    }

    public MazePath Branch()
    {
        if (points.Count < 3)
            return null;

        var index = rand.Next(points.Count - 2) + 1;

        var nx = points[index].x;
        var ny = points[index].y;

        return null;
    }

    public bool ChangeDirection()
    {
        if (GetX() % 2 == 1 || GetY() % 2 == 1)
            return false;

        var roll = rand.Next(2);

        switch(direction)
        {
            case Direction.UP:
            case Direction.DOWN:
            {
                direction = (roll == 0 ? Direction.LEFT : Direction.RIGHT);
            } break;

            case Direction.LEFT:
            case Direction.RIGHT:
            {
                direction = (roll == 0 ? Direction.UP : Direction.DOWN);
            } break;

            default: {} break;
        }

        return true;
    }

    public GridPoint? GetBranchCheckpoint()
    {
        GridPoint? result = null;
        var checkX = this.points[0].x;
        var checkY = this.points[0].y;

        switch (this.direction)
        {
            case Direction.UP:
            {
                result = new GridPoint(checkX, checkY - 1);
            } break;

            case Direction.DOWN:
            {
                result = new GridPoint(checkX, checkY + 1);
            } break;

            case Direction.LEFT:
            {
                result = new GridPoint(checkX - 1, checkY);
            } break;

            case Direction.RIGHT:
            {
                result = new GridPoint(checkX + 1, checkY);
            } break;

            default: {} break;
        }

        return result;
    }

    public GridPoint? GetCheckpoint()
    {
        GridPoint? result = null;
        var checkX = points[0].x;
        var checkY = points[0].y;

        switch (direction)
        {
            case Direction.UP:
            {
                result = new GridPoint(checkX, checkY - 2);
            } break;

            case Direction.DOWN:
            {
                result = new GridPoint(checkX, checkY + 2);
            } break;

            case Direction.LEFT:
            {
                result = new GridPoint(checkX - 2, checkY);
            } break;

            case Direction.RIGHT:
            {
                result = new GridPoint(checkX + 2, checkY);
            } break;

            default: {} break;
        }

        return result;
    }

    public int GetX()
    {
        return points[points.Count - 1].x;
    }

    public int GetY()
    {
        return points[points.Count - 1].y;
    }

    public void Grow()
    {
        var newX = GetX();
        var newY = GetY();

        switch (direction)
        {
            case Direction.UP:
            {
                --newY;
            } break;

            case Direction.DOWN:
            {
                ++newY;
            } break;

            case Direction.LEFT:
            {
                --newX;
            } break;

            case Direction.RIGHT:
            {
                ++newX;
            } break;

            default: return;
        }

        points.Add(new GridPoint(newX, newY));
    }
}

}