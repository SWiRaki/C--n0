using System;

namespace matrix
{
    public struct Matrix
    {
        private double[,] _matrix;
        private uint _dim1length;
        private uint _dim2length;

        public void Create(uint pDimension1, uint pDimension2)
        {
            this._matrix = new double[pDimension1, pDimension2];
            this._dim1length = pDimension1;
            this._dim2length = pDimension2;
        }

        public void CreateRandom(uint pDimension1, uint pDimension2)
        {
            Create(pDimension1, pDimension2);
            Random random = new Random();
            for (int i = 0; i < this._dim1length; i++)
            {
                for (int j = 0; j < this._dim2length; j++)
                {
                    this._matrix[i, j] = random.NextDouble();
                }
            }
        }

        public void Transpose()
        {
            Matrix copy = new Matrix();
            copy.Create(this._dim1length, this._dim2length);
            for (int i = 0; i < this._dim1length; i++)
            {
                for (int j = 0; j < this._dim2length; j++)
                {
                    copy._matrix[i, j] = this._matrix[j, i];
                }
            }
        }
    }
}
