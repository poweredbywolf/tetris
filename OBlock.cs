namespace Tetris

{
    public class OBlock : Block
    {
        //declaring a tiles array from the Position Class which takes 
        // row and column values
        private readonly Position[][] tiles = new Position[][]
        {
            new Position[]{ new{0,0}, new(0,1), new(0,1), new(1,1) }
        }

        public override int Id => 4;
        protected override Position StartOffset => new Position(0, 4);

        protected override Position[][] Tiles => tiles;
    }
}