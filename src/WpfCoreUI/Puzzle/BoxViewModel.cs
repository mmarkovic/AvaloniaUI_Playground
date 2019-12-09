namespace WpfCoreUI.Puzzle
{
    using System;
    using System.ComponentModel;

    public class BoxViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        
        public  SquareViewModel Square1 { get; } = new SquareViewModel();

        public  SquareViewModel Square2 { get; } = new SquareViewModel();

        public  SquareViewModel Square3 { get; } = new SquareViewModel();

        public  SquareViewModel Square4 { get; } = new SquareViewModel();

        public  SquareViewModel Square5 { get; } = new SquareViewModel();

        public  SquareViewModel Square6 { get; } = new SquareViewModel();

        public  SquareViewModel Square7 { get; } = new SquareViewModel();

        public  SquareViewModel Square8 { get; } = new SquareViewModel();

        public  SquareViewModel Square9 { get; } = new SquareViewModel();

        public void SetPredefined(int squareNr, byte? value)
        {
            SquareViewModel squareView = this.GetSquare(squareNr);
            squareView.Value = value;
            squareView.IsPredefinedValue = value.HasValue;
            squareView.IsValueCorrect = null;
        }

        public SquareViewModel GetSquare(int squareNr)
        {
            switch (squareNr)
            {
                case 1:
                    return this.Square1;
                case 2:
                    return this.Square2;
                case 3:
                    return this.Square3;
                case 4:
                    return this.Square4;
                case 5:
                    return this.Square5;
                case 6:
                    return this.Square6;
                case 7:
                    return this.Square7;
                case 8:
                    return this.Square8;
                case 9:
                    return this.Square9;
                default:
                    throw new ArgumentException($"Invalid Square Number: {squareNr}");
            }
        }

        public void CheckInput(byte?[] expectedValues)
        {
            this.CheckInputForSquare(this.Square1, expectedValues[0]);
            this.CheckInputForSquare(this.Square2, expectedValues[1]);
            this.CheckInputForSquare(this.Square3, expectedValues[2]);
            this.CheckInputForSquare(this.Square4, expectedValues[3]);
            this.CheckInputForSquare(this.Square5, expectedValues[4]);
            this.CheckInputForSquare(this.Square6, expectedValues[5]);
            this.CheckInputForSquare(this.Square7, expectedValues[6]);
            this.CheckInputForSquare(this.Square8, expectedValues[7]);
            this.CheckInputForSquare(this.Square9, expectedValues[8]);
        }

        private void CheckInputForSquare(SquareViewModel square, byte? expectedValue)
        {
            if (!square.IsPredefinedValue && square.Value.HasValue)
            {
                square.IsValueCorrect = expectedValue.HasValue
                    ? expectedValue.Value == square.Value
                    : (bool?) null;
            }
        }
    }
}