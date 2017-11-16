using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;

namespace Algorithms.Algorithms2017
{
    public class MatrixLayerRotation
    {
        public MatrixLayerRotation()
        {}

        public int[][] CalcSecondMaxNumber(int m, int n, int r, int[][] inputArray)
        {
            if (inputArray == null || inputArray.Length < 2 || inputArray.Length > 300 || inputArray[0].Length < 2 || inputArray[0].Length > 300
                || r < 1 || r > 1000000000)
                throw new Exception("Length of input parameters is not correct.");

            if (Math.Min(m, n) % 2 != 0)
                throw new Exception("Math.Min(m, n) % 2 != 0");

            var result = new int[inputArray.Length][];

            var requiredNumberOfDisplacements = GetRequiredNumberOfDisplacements(m, n, r);
            if (requiredNumberOfDisplacements == 0)
                return inputArray;

            var frameList = new List<Frame>();
            var countOfFrames = Math.Min(m, n) / 2;

            // create all frames frameList from mattrix:
            for (int i = 1; i <= countOfFrames; i++)
            {
                //We go diagonally and if we have not yet exhausted the frames, than we create the frame:
                if (i < m && i < n)
                {
                    var frWidth = n - i + 1;
                    var frLength = m - i + 1;
                    var frame = new Frame() {M = frLength, N = frWidth, FrameNum = i,
                        RequiredNumberOfDisplacements = GetRequiredNumberOfDisplacements(frLength, frWidth, r) };
                    frameList.Add(frame); 
                }
            }

            foreach (var frame in frameList)
            {
                var points = new List<Point>();
                // go along the left vertical side of the frame:
                for (var y = frame.FrameNum; y <= frame.M + 1; y++)
                {
                    var point = new Point() {X = frame.FrameNum, Y = y, Value = inputArray[frame.FrameNum][y] };
                    //if (y == frame.FrameNum)
                    //{
                    //    points.Add(point);
                    //}
                    //else
                    points.Add(point);
                }

                // go along the bottom horizontal side of the frame:
                for (var x = frame.FrameNum + 1; x <= frame.N + 1; x++)
                {
                    var y = frame.FrameNum + frame.M - 1;
                    var point = new Point() { X = x, Y = y, Value = inputArray[x][y] };
                    points.Add(point);
                }

                // go along the right vertical side of the frame:
                for (var y = frame.FrameNum + frame.M - 1; y >= frame.M; y--)
                {
                    var x = frame.FrameNum + frame.N - 1;
                    var point = new Point() { X = x, Y = y, Value = inputArray[x][y] };
                    points.Add(point);
                }

                // go along the upper horizontal side of the frame:
                for (var x = frame.FrameNum + frame.N - 1; x >= frame.N; x--)
                {
                    var y = frame.FrameNum;
                    var point = new Point() { X = x, Y = y, Value = inputArray[x][y] };
                    points.Add(point);
                }
            }

            // move the elements in the frames to requiredNumberOfDisplacements places:
            foreach (var frame in frameList)
            {
                var displacedPoints = new Point[frame.Points.Count];
                for(var i = 0; i < frame.Points.Count; i++)
                {
                    if (i + frame.RequiredNumberOfDisplacements < frame.Points.Count)
                    {
                        var newPositIndex = i + frame.RequiredNumberOfDisplacements;
                        displacedPoints[newPositIndex] =
                            new Point() {
                                X = frame.Points[newPositIndex].X,
                                Y = frame.Points[newPositIndex].Y,
                                Value = frame.Points[i].Value };
                    }
                    else
                    {
                        var newPositIndex = i + frame.RequiredNumberOfDisplacements - frame.Points.Count;
                        displacedPoints[newPositIndex] =
                            new Point()
                            {
                                X = frame.Points[newPositIndex].X,
                                Y = frame.Points[newPositIndex].Y,
                                Value = frame.Points[i].Value };
                    }
                }

                frame.Points = displacedPoints.ToList();
            }
            // fill out the output array and frames:
            foreach (var frame in frameList)
            {
                foreach (var point in frame.Points)
                {
                    result[point.X][point.Y] = point.Value;
                }
            }
            return result;
        }

        private int GetRequiredNumberOfDisplacements(int m, int n, int r)
        {
            var requiredNumberOfDisplacements = 0;
            var numberOfStepsForOneFullPass = (m + n) * 2 - 4;

            if (r < numberOfStepsForOneFullPass)
                requiredNumberOfDisplacements = r;
            else
            {
                requiredNumberOfDisplacements = r % numberOfStepsForOneFullPass;
            }
            return requiredNumberOfDisplacements;
        }

        public class Frame
        {
            public int FrameNum { get; set; }
            public int M { get; set; }
            public int N { get; set; }
            public int RequiredNumberOfDisplacements { get; set; }

            public List<Point> Points { get; set; }
            //public LinkedList<Point> LinkedPoints { get; set; }
        }

        public struct Point
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int Value { get; set; }
        }
    }
}

