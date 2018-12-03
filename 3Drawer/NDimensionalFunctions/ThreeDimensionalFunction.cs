using _3Drawer.NDimensionalPoints;
using _3Drawer.ThreeDimensionalExpression;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Drawer.NDimensionalFunctions
{
    class ThreeDimensionalFunction
    {
        private ThreeDimensionalPoint[,] points;
        private ThreeDimensionalFunctionEvaluator zEvaluator;
        private double dx;
        private TwoDimensionalPoint startingPoint;
        public ThreeDimensionalFunction(int pointCount, double dx, ThreeDimensionalFunctionEvaluator zEvaluator)
        {
            this.dx = dx;
            this.zEvaluator = zEvaluator;
            points = new ThreeDimensionalPoint[pointCount, pointCount];
            UpdateStartingPoint(dx, pointCount);
            EvaluatePoints();
        }
        public void SetDx(double dx)
        {
            this.dx = dx;
            UpdateStartingPoint(dx, points.GetLength(0));
            EvaluatePoints();
        }
        public void UpdatePointCount(int pointCount)
        {
            points = new ThreeDimensionalPoint[pointCount, pointCount];
            UpdateStartingPoint(dx, pointCount);
            EvaluatePoints();
        }
        public void UpdateZEvaluator(ThreeDimensionalFunctionEvaluator zEvaluator)
        {
            this.zEvaluator = zEvaluator;
            EvaluatePoints();
        }
        public void EvaluatePoints()
        {
            for (int x = 0; x < points.GetLength(0); x++)
            {
                for (int y = 0; y < points.GetLength(0); y++)
                {
                    try
                    {
                        var xVal = startingPoint.X + x * dx;
                        var yVal = startingPoint.Y + y * dx;
                        var zVal = zEvaluator.Evaluate(xVal, yVal);
                        points[x, y] = new ThreeDimensionalPoint(xVal, yVal, zVal);
                    }
                    catch {
                        // point is mathematically undefined.
                        points[x, y] = null;
                    }
                }
            }
        }

        public void RotateAbout(Axis axis, int angle)
        {
            for (int x = 0; x < points.GetLength(0); x++)
            {
                for (int y = 0; y < points.GetLength(1); y++)
                {
                    try
                    {
                        points[x, y].RotateAbout(axis, angle);
                    }
                    catch
                    {
                        // point is mathematically undefined.
                        points[x, y] = null;
                    }
                }
            }
        }
    
        public void Shift(Axis axis, int value)
        {
            for (int x = 0; x < points.GetLength(0); x++)
            {
                for (int y = 0; y < points.GetLength(0); y++)
                {
                    try
                    {
                        points[x, y].Shift(axis, value);
                    }
                    catch
                    {
                        // point is mathematically undefined.
                        points[x, y] = null;
                    }
                }
            }
        }
        public ThreeDimensionalPoint[,] GetPoints()
        {
            return this.points;
        }

        private void UpdateStartingPoint(double dx, int pointCount)
        {
            startingPoint = new TwoDimensionalPoint(-(pointCount / 2) * dx, -(pointCount / 2) * dx);
        }
    }

    public enum Axis
    {
        X,
        Y,
        Z,
    }
}
