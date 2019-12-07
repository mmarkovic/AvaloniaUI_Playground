namespace AvaloniaAppUI.Puzzle
{
    using Sudoku.Core;
    
    public class PuzzleViewModel
    {
        public byte? Box1Square1 { get; set; }
        public byte? Box1Square2 { get; set; }
        public byte? Box1Square3 { get; set; }
        public byte? Box1Square4 { get; set; }
        public byte? Box1Square5 { get; set; }
        public byte? Box1Square6 { get; set; }
        public byte? Box1Square7 { get; set; }
        public byte? Box1Square8 { get; set; }
        public byte? Box1Square9 { get; set; }
        public byte? Box2Square1 { get; set; }
        public byte? Box2Square2 { get; set; }
        public byte? Box2Square3 { get; set; }
        public byte? Box2Square4 { get; set; }
        public byte? Box2Square5 { get; set; }
        public byte? Box2Square6 { get; set; }
        public byte? Box2Square7 { get; set; }
        public byte? Box2Square8 { get; set; }
        public byte? Box2Square9 { get; set; }
        public byte? Box3Square1 { get; set; }
        public byte? Box3Square2 { get; set; }
        public byte? Box3Square3 { get; set; }
        public byte? Box3Square4 { get; set; }
        public byte? Box3Square5 { get; set; }
        public byte? Box3Square6 { get; set; }
        public byte? Box3Square7 { get; set; }
        public byte? Box3Square8 { get; set; }
        public byte? Box3Square9 { get; set; }
        public byte? Box4Square1 { get; set; }
        public byte? Box4Square2 { get; set; }
        public byte? Box4Square3 { get; set; }
        public byte? Box4Square4 { get; set; }
        public byte? Box4Square5 { get; set; }
        public byte? Box4Square6 { get; set; }
        public byte? Box4Square7 { get; set; }
        public byte? Box4Square8 { get; set; }
        public byte? Box4Square9 { get; set; }
        public byte? Box5Square1 { get; set; }
        public byte? Box5Square2 { get; set; }
        public byte? Box5Square3 { get; set; }
        public byte? Box5Square4 { get; set; }
        public byte? Box5Square5 { get; set; }
        public byte? Box5Square6 { get; set; }
        public byte? Box5Square7 { get; set; }
        public byte? Box5Square8 { get; set; }
        public byte? Box5Square9 { get; set; }
        public byte? Box6Square1 { get; set; }
        public byte? Box6Square2 { get; set; }
        public byte? Box6Square3 { get; set; }
        public byte? Box6Square4 { get; set; }
        public byte? Box6Square5 { get; set; }
        public byte? Box6Square6 { get; set; }
        public byte? Box6Square7 { get; set; }
        public byte? Box6Square8 { get; set; }
        public byte? Box6Square9 { get; set; }
        public byte? Box7Square1 { get; set; }
        public byte? Box7Square2 { get; set; }
        public byte? Box7Square3 { get; set; }
        public byte? Box7Square4 { get; set; }
        public byte? Box7Square5 { get; set; }
        public byte? Box7Square6 { get; set; }
        public byte? Box7Square7 { get; set; }
        public byte? Box7Square8 { get; set; }
        public byte? Box7Square9 { get; set; }
        public byte? Box8Square1 { get; set; }
        public byte? Box8Square2 { get; set; }
        public byte? Box8Square3 { get; set; }
        public byte? Box8Square4 { get; set; }
        public byte? Box8Square5 { get; set; }
        public byte? Box8Square6 { get; set; }
        public byte? Box8Square7 { get; set; }
        public byte? Box8Square8 { get; set; }
        public byte? Box8Square9 { get; set; }
        public byte? Box9Square1 { get; set; }
        public byte? Box9Square2 { get; set; }
        public byte? Box9Square3 { get; set; }
        public byte? Box9Square4 { get; set; }
        public byte? Box9Square5 { get; set; }
        public byte? Box9Square6 { get; set; }
        public byte? Box9Square7 { get; set; }
        public byte? Box9Square8 { get; set; }
        public byte? Box9Square9 { get; set; }

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
