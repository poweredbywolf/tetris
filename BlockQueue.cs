using System;

namespace Tetris
{
    public class BlockQueue
    {
        // Instantiating an array containing block objects
        private readonly Block[] blocks = new Block[]
        //adding the different block shapes to the array
        {
            new IBlock(),
            new JBlock(),
            new LBlock(),
            new OBlock(),
            new SBlock(),
            new TBlock(),


        };

        private readonly Random random = new Random();

        //property for the next block in the queue 
        public Block NextBlock { get; private set;}


//in the constructor we 
    public BlockQueue()
      {
            NextBlock = RandomBlock();
        }

//method to return block
        private Block RandomBlock()
        {
            return blocks[random.Next(blocks.Length)];
        }

        public Block GetAndUpdate()
        {
            Block block = NextBlock;

            do
            {
                NextBlock = RandomBlock();
            }
            while (block.Id == NextBlock.Id);
            return block;
        }
}
}