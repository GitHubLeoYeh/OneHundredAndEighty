﻿#region Usings

using System.Windows.Media.Imaging;
using OneHundredAndEightyCore.Common;

#endregion

namespace OneHundredAndEightyCore.Game
{
    public class Player
    {
        public int Id { get; }
        public string Name { get; }
        public string NickName { get; }
        public BitmapImage Avatar { get; }

        public Player(string name, string nickName, int id = -1, BitmapImage avatar = null)
        {
            Id = id;
            Name = name;
            NickName = nickName;
            Avatar = avatar ?? Converter.BitmapToBitmapImage(Resources.EmptyUserIcon);
        }

        public override string ToString()
        {
            return $"{Name} '{NickName}'";
        }
    }
}