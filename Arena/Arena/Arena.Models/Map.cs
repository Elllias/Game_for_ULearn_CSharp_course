﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

namespace Arena.Models
{
    public class Map
    {
        public static int[,] map = new int[MapWidth, MapHeight];
        public const int MapWidth = 40;
        public const int MapHeight = 24;
        public static int CellSize = 31;
        public static Image MapSprite;
        public static List<Thing> MapThings;

        public static void Init()
        {
            map = GetMap();
            MapSprite = new Bitmap(Path.Combine(new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName.ToString(), "Sprites\\Backgrounds\\background.png"));
            MapThings = new List<Thing>();
        }

        public static int[,] GetMap()
        {
            return new int[,]
            {
                { 9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9},
                { 9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9},
                { 9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9},
                { 9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9},
                { 1,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,2},
                { 5,20,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,20,0,0,7},
                { 5,20,0,0,0,0,0,20,0,0,0,0,0,0,0,0,0,0,0,0,0,0,20,0,0,0,0,0,0,0,0,0,0,0,0,0,20,0,0,7},
                { 5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,20,0,0,0,0,0,0,7},
                { 5,20,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,20,0,0,7},
                { 5,0,0,0,0,0,0,0,0,0,0,0,20,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,7},
                { 5,20,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,20,0,0,7},
                { 5,0,0,0,0,0,20,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,7},
                { 5,20,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,20,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,20,0,0,7},
                { 5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,20,0,0,0,0,0,0,0,0,0,0,0,7},
                { 5,20,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,20,0,0,7},
                { 5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,7},
                { 5,20,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,20,0,0,7},
                { 5,0,0,0,0,0,0,0,0,20,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,7},
                { 5,20,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,20,0,0,7},
                { 5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,20,0,0,0,0,0,0,0,0,20,0,0,0,0,0,0,0,0,0,0,0,0,0,7},
                { 5,20,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,20,0,0,7},
                { 5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,7},
                { 5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,7},
                { 3,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,4},
            };
        }

        public static bool IsCollide(Player player, Point dir)
        {
            if (player.PosX + dir.X <= -5 || player.PosX + dir.X >= Map.CellSize * (Map.MapWidth - 1.65) || player.PosY + dir.Y <= 110 || player.PosY + dir.Y >= Map.CellSize * (Map.MapHeight - 1.85))
                return true;

            for (int i = 0; i < Map.MapThings.Count; i++)
            {
                var curObject = Map.MapThings[i];
                PointF delta = FindDelta(player, curObject);
                if (Math.Abs(delta.X) <= (player.Size / 2 + curObject.Size.Width / 2)/1.3)
                {
                    if (Math.Abs(delta.Y) <= (player.Size / 2 + curObject.Size.Height / 2)/1.15)
                    {
                        if (delta.X < 0 && dir.X == player.Speed 
                            && player.PosY + player.Size / 2 > curObject.Position.Y 
                            && player.PosY + player.Size / 2 < curObject.Position.Y + curObject.Size.Height)
                        {
                            return true;
                        }
                        if (delta.X > 0 && dir.X == -player.Speed 
                            && player.PosY + player.Size / 2 > curObject.Position.Y 
                            && player.PosY + player.Size / 2 < curObject.Position.Y + curObject.Size.Height)
                        {
                            return true;
                        }
                        if (delta.Y < 0 && dir.Y == player.Speed 
                            && player.PosX + player.Size / 2 > curObject.Position.X 
                            && player.PosX + player.Size / 2 < curObject.Position.X + curObject.Size.Width)
                        {
                            return true;
                        }
                        if (delta.Y > 0 && dir.Y == -player.Speed 
                            && player.PosX + player.Size / 2 > curObject.Position.X 
                            && player.PosX + player.Size / 2 < curObject.Position.X + curObject.Size.Width)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private static PointF FindDelta(Player player, Thing curObject)
        {
            var delta = new PointF
            {
                X = (player.PosX + player.Size / 2) - (curObject.Position.X + curObject.Size.Width / 2),
                Y = (player.PosY + player.Size / 2) - (curObject.Position.Y + curObject.Size.Height / 2)
            };
            return delta;
        }
    }
}
