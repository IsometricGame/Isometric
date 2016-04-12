using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace Altharius_Game_Engine
{
    public class TileMap
    {

        //A test map. Load this data in a more elegant way later
        int[,] testMap = {
                             {0, 1, 0, 0, 1},
                             {0, 0, 1, 0, 0},
                             {0, 0, 1, 0, 0},
                             {0, 1, 0, 1, 0},
                             {0, 0, 0, 0, 1}
                         };

        public TileMap()
        {

        }

        public Tile[,] TranslateToTiles(int[,] mapFile)
        {
            //Set width and height based on the mapFile dimensions
            int width = mapFile.GetLength(0);
            int height = mapFile.GetLength(1);

            Tile[,] tileMap = new Tile[width, height];

            //Iterate through the map file
            for (int y = 0; y < mapFile.GetLength(1); y++)
            {
                for (int x = 0; x < mapFile.GetLength(0); x++)
                {
                    tileMap[y,x] = new Tile(mapFile[y,x]); //Add the correct tile to the tile map
                }
            }

            return tileMap;
        }

        /*
        //Create int array holding tile data
        int[] TextMap = {0, 1, 0, 1, 0, 0,
                         0, 1, 0, 1, 0, 0,
                         0, 1, 0, 1, 0, 0,
                         0, 1, 0, 1, 0, 0,
                         0, 0, 0, 0, 0, 0};
        
        //Set render distance for X and Y
        public int RenderDistanceX = 5;
        public int RenderDistanceY = 5;

        //Create a list of MapRows
        public List<MapRow> Rows = new List<MapRow>();

        //Set map dimensions
        public Vector2 MapDimensions = new Vector2(50,50);

        public TileMap()
        {
            for (int y = 0; y < MapDimensions.Y; y++)
            {
                MapRow thisRow = new MapRow();
                for (int x = 0; x < MapDimensions.X; x++)
                {
                    thisRow.Columns.Add(new MapCell(0));
                }
                Rows.Add(thisRow);
            }

            Rows[0].Columns[0].TileID = 5;
            Rows[1].Columns[1].TileID = 2;
            Rows[0].Columns[3].TileID = 3;

        }
        public void DrawMap(SpriteBatch sb)
        {
            for (int y = 0; y < RenderDistanceY; y++)
            {
                for (int x = 0; x < RenderDistanceX; x++)
                {
                    sb.Draw(Tile.TileSetTexture, new Rectangle((x * 32), (y * 32), 32, 32), Tile.GetSourceRectangle(Rows[y].Columns[x].TileID), Color.White);
                }
            }
        }

    }

    public class MapRow
    {
        public List<MapCell> Columns = new List<MapCell>();
    }
         */
    }
}
