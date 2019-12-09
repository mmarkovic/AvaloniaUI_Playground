namespace AvaloniaMvvmAppUI.ViewModels
{
    using System;
    using ReactiveUI;

    public class SquareViewModel : ViewModelBase, IEquatable<SquareViewModel>
    {
        private bool isPredefinedValue;
        private bool? isValueCorrect;
        private byte? value;

        public bool IsPredefinedValue
        {
            get => this.isPredefinedValue;
            set => this.RaiseAndSetIfChanged(ref this.isPredefinedValue, value);
        }

        public bool? IsValueCorrect
        {
            get => this.isValueCorrect;
            set => this.RaiseAndSetIfChanged(ref this.isValueCorrect, value);
        }

        public byte? Value
        {
            get => this.value;
            set => this.RaiseAndSetIfChanged(ref this.value, value);
        }

        public static bool operator ==(SquareViewModel left, SquareViewModel right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SquareViewModel left, SquareViewModel right)
        {
            return !Equals(left, right);
        }

        public bool Equals(SquareViewModel other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return this.IsPredefinedValue == other.IsPredefinedValue
                && this.IsValueCorrect == other.IsValueCorrect
                && this.Value == other.Value;
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

            return obj.GetType() == this.GetType() && this.Equals((SquareViewModel)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = this.IsPredefinedValue.GetHashCode();
                hashCode = (hashCode * 397) ^ this.IsValueCorrect.GetHashCode();
                hashCode = (hashCode * 397) ^ this.Value.GetHashCode();
                return hashCode;
            }
        }
    }
}