namespace AvaloniaMvvmAppUI.ViewModels
{
    using System;

    public class BoxViewModel : ViewModelBase, IEquatable<BoxViewModel>
    {
        public  SquareViewModel Square1 { get; } = new SquareViewModel();

        public  SquareViewModel Square2 { get; } = new SquareViewModel();

        public  SquareViewModel Square3 { get; } = new SquareViewModel();

        public  SquareViewModel Square4 { get; } = new SquareViewModel();

        public  SquareViewModel Square5 { get; } = new SquareViewModel();

        public  SquareViewModel Square6 { get; } = new SquareViewModel();

        public  SquareViewModel Square7 { get; } = new SquareViewModel();

        public  SquareViewModel Square8 { get; } = new SquareViewModel();

        public  SquareViewModel Square9 { get; } = new SquareViewModel();

        public static bool operator ==(BoxViewModel left, BoxViewModel right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BoxViewModel left, BoxViewModel right)
        {
            return !Equals(left, right);
        }

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

        public bool Equals(BoxViewModel other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return this.Square1 == other.Square1 &&
                this.Square2 == other.Square2 &&
                this.Square3 == other.Square3 &&
                this.Square4 == other.Square4 &&
                this.Square5 == other.Square5 &&
                this.Square6 == other.Square6 &&
                this.Square7 == other.Square7 &&
                this.Square8 == other.Square8 &&
                this.Square9 == other.Square9;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            return obj.GetType() == this.GetType() && Equals((BoxViewModel)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = this.Square1.GetHashCode();
                hashCode = (hashCode * 397) ^ this.Square2.GetHashCode();
                hashCode = (hashCode * 397) ^ this.Square3.GetHashCode();
                hashCode = (hashCode * 397) ^ this.Square4.GetHashCode();
                hashCode = (hashCode * 397) ^ this.Square5.GetHashCode();
                hashCode = (hashCode * 397) ^ this.Square6.GetHashCode();
                hashCode = (hashCode * 397) ^ this.Square7.GetHashCode();
                hashCode = (hashCode * 397) ^ this.Square8.GetHashCode();
                hashCode = (hashCode * 397) ^ this.Square9.GetHashCode();
                return hashCode;
            }
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
