using ReactiveUI;
using Sudoku.Core;

namespace AvaloniaMvvmAppUI.ViewModels
{
    public class PuzzleViewModel : ViewModelBase
    {
        private byte? _box1Square1;
        private byte? _box1Square2;
        private byte? _box1Square3;
        private byte? _box1Square4;
        private byte? _box1Square5;
        private byte? _box1Square6;
        private byte? _box1Square7;
        private byte? _box1Square8;
        private byte? _box1Square9;
        private byte? _box2Square1;
        private byte? _box2Square2;
        private byte? _box2Square3;
        private byte? _box2Square4;
        private byte? _box2Square5;
        private byte? _box2Square6;
        private byte? _box2Square7;
        private byte? _box2Square8;
        private byte? _box2Square9;
        private byte? _box3Square1;
        private byte? _box3Square2;
        private byte? _box3Square3;
        private byte? _box3Square4;
        private byte? _box3Square5;
        private byte? _box3Square6;
        private byte? _box3Square7;
        private byte? _box3Square8;
        private byte? _box3Square9;
        private byte? _box4Square1;
        private byte? _box4Square2;
        private byte? _box4Square3;
        private byte? _box4Square4;
        private byte? _box4Square5;
        private byte? _box4Square6;
        private byte? _box4Square7;
        private byte? _box4Square8;
        private byte? _box4Square9;
        private byte? _box5Square1;
        private byte? _box5Square2;
        private byte? _box5Square3;
        private byte? _box5Square4;
        private byte? _box5Square5;
        private byte? _box5Square6;
        private byte? _box5Square7;
        private byte? _box5Square8;
        private byte? _box5Square9;
        private byte? _box6Square1;
        private byte? _box6Square2;
        private byte? _box6Square3;
        private byte? _box6Square4;
        private byte? _box6Square5;
        private byte? _box6Square6;
        private byte? _box6Square7;
        private byte? _box6Square8;
        private byte? _box6Square9;
        private byte? _box7Square1;
        private byte? _box7Square2;
        private byte? _box7Square3;
        private byte? _box7Square4;
        private byte? _box7Square5;
        private byte? _box7Square6;
        private byte? _box7Square7;
        private byte? _box7Square8;
        private byte? _box7Square9;
        private byte? _box8Square1;
        private byte? _box8Square2;
        private byte? _box8Square3;
        private byte? _box8Square4;
        private byte? _box8Square5;
        private byte? _box8Square6;
        private byte? _box8Square7;
        private byte? _box8Square8;
        private byte? _box8Square9;
        private byte? _box9Square1;
        private byte? _box9Square2;
        private byte? _box9Square3;
        private byte? _box9Square4;
        private byte? _box9Square5;
        private byte? _box9Square6;
        private byte? _box9Square7;
        private byte? _box9Square8;
        private byte? _box9Square9;

        public byte? Box1Square1
        {
            get => _box1Square1;
            set => this.RaiseAndSetIfChanged(ref _box1Square1, value);
        }

        public byte? Box1Square2
        {
            get => _box1Square2;
            set => this.RaiseAndSetIfChanged(ref _box1Square2, value);
        }

        public byte? Box1Square3
        {
            get => _box1Square3;
            set => this.RaiseAndSetIfChanged(ref _box1Square3, value);
        }

        public byte? Box1Square4
        {
            get => _box1Square4;
            set => this.RaiseAndSetIfChanged(ref _box1Square4, value);
        }

        public byte? Box1Square5
        {
            get => _box1Square5;
            set => this.RaiseAndSetIfChanged(ref _box1Square5, value);
        }

        public byte? Box1Square6
        {
            get => _box1Square6;
            set => this.RaiseAndSetIfChanged(ref _box1Square6, value);
        }

        public byte? Box1Square7
        {
            get => _box1Square7;
            set => this.RaiseAndSetIfChanged(ref _box1Square7, value);
        }

        public byte? Box1Square8
        {
            get => _box1Square8;
            set => this.RaiseAndSetIfChanged(ref _box1Square8, value);
        }

        public byte? Box1Square9
        {
            get => _box1Square9;
            set => this.RaiseAndSetIfChanged(ref _box1Square9, value);
        }

        public byte? Box2Square1
        {
            get => _box2Square1;
            set => this.RaiseAndSetIfChanged(ref _box2Square1, value);
        }

        public byte? Box2Square2
        {
            get => _box2Square2;
            set => this.RaiseAndSetIfChanged(ref _box2Square2, value);
        }

        public byte? Box2Square3
        {
            get => _box2Square3;
            set => this.RaiseAndSetIfChanged(ref _box2Square3, value);
        }

        public byte? Box2Square4
        {
            get => _box2Square4;
            set => this.RaiseAndSetIfChanged(ref _box2Square4, value);
        }

        public byte? Box2Square5
        {
            get => _box2Square5;
            set => this.RaiseAndSetIfChanged(ref _box2Square5, value);
        }

        public byte? Box2Square6
        {
            get => _box2Square6;
            set => this.RaiseAndSetIfChanged(ref _box2Square6, value);
        }

        public byte? Box2Square7
        {
            get => _box2Square7;
            set => this.RaiseAndSetIfChanged(ref _box2Square7, value);
        }

        public byte? Box2Square8
        {
            get => _box2Square8;
            set => this.RaiseAndSetIfChanged(ref _box2Square8, value);
        }

        public byte? Box2Square9
        {
            get => _box2Square9;
            set => this.RaiseAndSetIfChanged(ref _box2Square9, value);
        }

        public byte? Box3Square1
        {
            get => _box3Square1;
            set => this.RaiseAndSetIfChanged(ref _box3Square1, value);
        }

        public byte? Box3Square2
        {
            get => _box3Square2;
            set => this.RaiseAndSetIfChanged(ref _box3Square2, value);
        }

        public byte? Box3Square3
        {
            get => _box3Square3;
            set => this.RaiseAndSetIfChanged(ref _box3Square3, value);
        }

        public byte? Box3Square4
        {
            get => _box3Square4;
            set => this.RaiseAndSetIfChanged(ref _box3Square4, value);
        }

        public byte? Box3Square5
        {
            get => _box3Square5;
            set => this.RaiseAndSetIfChanged(ref _box3Square5, value);
        }

        public byte? Box3Square6
        {
            get => _box3Square6;
            set => this.RaiseAndSetIfChanged(ref _box3Square6, value);
        }

        public byte? Box3Square7
        {
            get => _box3Square7;
            set => this.RaiseAndSetIfChanged(ref _box3Square7, value);
        }

        public byte? Box3Square8
        {
            get => _box3Square8;
            set => this.RaiseAndSetIfChanged(ref _box3Square8, value);
        }

        public byte? Box3Square9
        {
            get => _box3Square9;
            set => this.RaiseAndSetIfChanged(ref _box3Square9, value);
        }

        public byte? Box4Square1
        {
            get => _box4Square1;
            set => this.RaiseAndSetIfChanged(ref _box4Square1, value);
        }

        public byte? Box4Square2
        {
            get => _box4Square2;
            set => this.RaiseAndSetIfChanged(ref _box4Square2, value);
        }

        public byte? Box4Square3
        {
            get => _box4Square3;
            set => this.RaiseAndSetIfChanged(ref _box4Square3, value);
        }

        public byte? Box4Square4
        {
            get => _box4Square4;
            set => this.RaiseAndSetIfChanged(ref _box4Square4, value);
        }

        public byte? Box4Square5
        {
            get => _box4Square5;
            set => this.RaiseAndSetIfChanged(ref _box4Square5, value);
        }

        public byte? Box4Square6
        {
            get => _box4Square6;
            set => this.RaiseAndSetIfChanged(ref _box4Square6, value);
        }

        public byte? Box4Square7
        {
            get => _box4Square7;
            set => this.RaiseAndSetIfChanged(ref _box4Square7, value);
        }

        public byte? Box4Square8
        {
            get => _box4Square8;
            set => this.RaiseAndSetIfChanged(ref _box4Square8, value);
        }

        public byte? Box4Square9
        {
            get => _box4Square9;
            set => this.RaiseAndSetIfChanged(ref _box4Square9, value);
        }
        public byte? Box5Square1
        {
            get => _box5Square1;
            set => this.RaiseAndSetIfChanged(ref _box5Square1, value);
        }

        public byte? Box5Square2
        {
            get => _box5Square2;
            set => this.RaiseAndSetIfChanged(ref _box5Square2, value);
        }

        public byte? Box5Square3
        {
            get => _box5Square3;
            set => this.RaiseAndSetIfChanged(ref _box5Square3, value);
        }

        public byte? Box5Square4
        {
            get => _box5Square4;
            set => this.RaiseAndSetIfChanged(ref _box5Square4, value);
        }

        public byte? Box5Square5
        {
            get => _box5Square5;
            set => this.RaiseAndSetIfChanged(ref _box5Square5, value);
        }

        public byte? Box5Square6
        {
            get => _box5Square6;
            set => this.RaiseAndSetIfChanged(ref _box5Square6, value);
        }

        public byte? Box5Square7
        {
            get => _box5Square7;
            set => this.RaiseAndSetIfChanged(ref _box5Square7, value);
        }

        public byte? Box5Square8
        {
            get => _box5Square8;
            set => this.RaiseAndSetIfChanged(ref _box5Square8, value);
        }

        public byte? Box5Square9
        {
            get => _box5Square9;
            set => this.RaiseAndSetIfChanged(ref _box5Square9, value);
        }
        public byte? Box6Square1
        {
            get => _box6Square1;
            set => this.RaiseAndSetIfChanged(ref _box6Square1, value);
        }

        public byte? Box6Square2
        {
            get => _box6Square2;
            set => this.RaiseAndSetIfChanged(ref _box6Square2, value);
        }

        public byte? Box6Square3
        {
            get => _box6Square3;
            set => this.RaiseAndSetIfChanged(ref _box6Square3, value);
        }

        public byte? Box6Square4
        {
            get => _box6Square4;
            set => this.RaiseAndSetIfChanged(ref _box6Square4, value);
        }

        public byte? Box6Square5
        {
            get => _box6Square5;
            set => this.RaiseAndSetIfChanged(ref _box6Square5, value);
        }

        public byte? Box6Square6
        {
            get => _box6Square6;
            set => this.RaiseAndSetIfChanged(ref _box6Square6, value);
        }

        public byte? Box6Square7
        {
            get => _box6Square7;
            set => this.RaiseAndSetIfChanged(ref _box6Square7, value);
        }

        public byte? Box6Square8
        {
            get => _box6Square8;
            set => this.RaiseAndSetIfChanged(ref _box6Square8, value);
        }

        public byte? Box6Square9
        {
            get => _box6Square9;
            set => this.RaiseAndSetIfChanged(ref _box6Square9, value);
        }
        public byte? Box7Square1
        {
            get => _box7Square1;
            set => this.RaiseAndSetIfChanged(ref _box7Square1, value);
        }

        public byte? Box7Square2
        {
            get => _box7Square2;
            set => this.RaiseAndSetIfChanged(ref _box7Square2, value);
        }

        public byte? Box7Square3
        {
            get => _box7Square3;
            set => this.RaiseAndSetIfChanged(ref _box7Square3, value);
        }

        public byte? Box7Square4
        {
            get => _box7Square4;
            set => this.RaiseAndSetIfChanged(ref _box7Square4, value);
        }

        public byte? Box7Square5
        {
            get => _box7Square5;
            set => this.RaiseAndSetIfChanged(ref _box7Square5, value);
        }

        public byte? Box7Square6
        {
            get => _box7Square6;
            set => this.RaiseAndSetIfChanged(ref _box7Square6, value);
        }

        public byte? Box7Square7
        {
            get => _box7Square7;
            set => this.RaiseAndSetIfChanged(ref _box7Square7, value);
        }

        public byte? Box7Square8
        {
            get => _box7Square8;
            set => this.RaiseAndSetIfChanged(ref _box7Square8, value);
        }

        public byte? Box7Square9
        {
            get => _box7Square9;
            set => this.RaiseAndSetIfChanged(ref _box7Square9, value);
        }
        public byte? Box8Square1
        {
            get => _box8Square1;
            set => this.RaiseAndSetIfChanged(ref _box8Square1, value);
        }

        public byte? Box8Square2
        {
            get => _box8Square2;
            set => this.RaiseAndSetIfChanged(ref _box8Square2, value);
        }

        public byte? Box8Square3
        {
            get => _box8Square3;
            set => this.RaiseAndSetIfChanged(ref _box8Square3, value);
        }

        public byte? Box8Square4
        {
            get => _box8Square4;
            set => this.RaiseAndSetIfChanged(ref _box8Square4, value);
        }

        public byte? Box8Square5
        {
            get => _box8Square5;
            set => this.RaiseAndSetIfChanged(ref _box8Square5, value);
        }

        public byte? Box8Square6
        {
            get => _box8Square6;
            set => this.RaiseAndSetIfChanged(ref _box8Square6, value);
        }

        public byte? Box8Square7
        {
            get => _box8Square7;
            set => this.RaiseAndSetIfChanged(ref _box8Square7, value);
        }

        public byte? Box8Square8
        {
            get => _box8Square8;
            set => this.RaiseAndSetIfChanged(ref _box8Square8, value);
        }

        public byte? Box8Square9
        {
            get => _box8Square9;
            set => this.RaiseAndSetIfChanged(ref _box8Square9, value);
        }
        public byte? Box9Square1
        {
            get => _box9Square1;
            set => this.RaiseAndSetIfChanged(ref _box9Square1, value);
        }

        public byte? Box9Square2
        {
            get => _box9Square2;
            set => this.RaiseAndSetIfChanged(ref _box9Square2, value);
        }

        public byte? Box9Square3
        {
            get => _box9Square3;
            set => this.RaiseAndSetIfChanged(ref _box9Square3, value);
        }

        public byte? Box9Square4
        {
            get => _box9Square4;
            set => this.RaiseAndSetIfChanged(ref _box9Square4, value);
        }

        public byte? Box9Square5
        {
            get => _box9Square5;
            set => this.RaiseAndSetIfChanged(ref _box9Square5, value);
        }

        public byte? Box9Square6
        {
            get => _box9Square6;
            set => this.RaiseAndSetIfChanged(ref _box9Square6, value);
        }

        public byte? Box9Square7
        {
            get => _box9Square7;
            set => this.RaiseAndSetIfChanged(ref _box9Square7, value);
        }

        public byte? Box9Square8
        {
            get => _box9Square8;
            set => this.RaiseAndSetIfChanged(ref _box9Square8, value);
        }

        public byte? Box9Square9
        {
            get => _box9Square9;
            set => this.RaiseAndSetIfChanged(ref _box9Square9, value);
        }

        public void Load(SudokuPuzzle puzzle)
        {
            this.Box1Square1 = puzzle[1, 1];
            this.Box1Square2 = puzzle[1, 2];
            this.Box1Square3 = puzzle[1, 3];
            this.Box2Square1 = puzzle[1, 4];
            this.Box2Square2 = puzzle[1, 5];
            this.Box2Square3 = puzzle[1, 6];
            this.Box3Square1 = puzzle[1, 7];
            this.Box3Square2 = puzzle[1, 8];
            this.Box3Square3 = puzzle[1, 9];

            this.Box1Square4 = puzzle[2, 1];
            this.Box1Square5 = puzzle[2, 2];
            this.Box1Square6 = puzzle[2, 3];
            this.Box2Square4 = puzzle[2, 4];
            this.Box2Square5 = puzzle[2, 5];
            this.Box2Square6 = puzzle[2, 6];
            this.Box3Square4 = puzzle[2, 7];
            this.Box3Square5 = puzzle[2, 8];
            this.Box3Square6 = puzzle[2, 9];

            this.Box1Square7 = puzzle[3, 1];
            this.Box1Square8 = puzzle[3, 2];
            this.Box1Square9 = puzzle[3, 3];
            this.Box2Square7 = puzzle[3, 4];
            this.Box2Square8 = puzzle[3, 5];
            this.Box2Square9 = puzzle[3, 6];
            this.Box3Square7 = puzzle[3, 7];
            this.Box3Square8 = puzzle[3, 8];
            this.Box3Square9 = puzzle[3, 9];

            this.Box4Square1 = puzzle[4, 1];
            this.Box4Square2 = puzzle[4, 2];
            this.Box4Square3 = puzzle[4, 3];
            this.Box5Square1 = puzzle[4, 4];
            this.Box5Square2 = puzzle[4, 5];
            this.Box5Square3 = puzzle[4, 6];
            this.Box6Square1 = puzzle[4, 7];
            this.Box6Square2 = puzzle[4, 8];
            this.Box6Square3 = puzzle[4, 9];

            this.Box4Square4 = puzzle[5, 1];
            this.Box4Square5 = puzzle[5, 2];
            this.Box4Square6 = puzzle[5, 3];
            this.Box5Square4 = puzzle[5, 4];
            this.Box5Square5 = puzzle[5, 5];
            this.Box5Square6 = puzzle[5, 6];
            this.Box6Square4 = puzzle[5, 7];
            this.Box6Square5 = puzzle[5, 8];
            this.Box6Square6 = puzzle[5, 9];

            this.Box4Square7 = puzzle[6, 1];
            this.Box4Square8 = puzzle[6, 2];
            this.Box4Square9 = puzzle[6, 3];
            this.Box5Square7 = puzzle[6, 4];
            this.Box5Square8 = puzzle[6, 5];
            this.Box5Square9 = puzzle[6, 6];
            this.Box6Square7 = puzzle[6, 7];
            this.Box6Square8 = puzzle[6, 8];
            this.Box6Square9 = puzzle[6, 9];

            this.Box7Square1 = puzzle[7, 1];
            this.Box7Square2 = puzzle[7, 2];
            this.Box7Square3 = puzzle[7, 3];
            this.Box8Square1 = puzzle[7, 4];
            this.Box8Square2 = puzzle[7, 5];
            this.Box8Square3 = puzzle[7, 6];
            this.Box9Square1 = puzzle[7, 7];
            this.Box9Square2 = puzzle[7, 8];
            this.Box9Square3 = puzzle[7, 9];

            this.Box7Square4 = puzzle[8, 1];
            this.Box7Square5 = puzzle[8, 2];
            this.Box7Square6 = puzzle[8, 3];
            this.Box8Square4 = puzzle[8, 4];
            this.Box8Square5 = puzzle[8, 5];
            this.Box8Square6 = puzzle[8, 6];
            this.Box9Square4 = puzzle[8, 7];
            this.Box9Square5 = puzzle[8, 8];
            this.Box9Square6 = puzzle[8, 9];

            this.Box7Square7 = puzzle[9, 1];
            this.Box7Square8 = puzzle[9, 2];
            this.Box7Square9 = puzzle[9, 3];
            this.Box8Square7 = puzzle[9, 4];
            this.Box8Square8 = puzzle[9, 5];
            this.Box8Square9 = puzzle[9, 6];
            this.Box9Square7 = puzzle[9, 7];
            this.Box9Square8 = puzzle[9, 8];
            this.Box9Square9 = puzzle[9, 9];
        }
    }
}
