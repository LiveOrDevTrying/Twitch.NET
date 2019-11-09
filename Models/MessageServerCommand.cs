﻿using System;
using System.Collections.Generic;
using Twitch.NET.Enums;
using Twitch.NET.Models.DTOs.Interfaces;
using Twitch.NET.Models.Interfaces;
using TwitchLib.Client.Enums;
using TwitchLib.Client.Models.Extensions.NetCore;

namespace Twitch.NET.Models
{
    public struct MessageServerCommand : IMessageServerCommand
    {
        public Guid Id { get; set; }
        public IServer Server { get; set; }
        public string MessageText { get; set; }
        public IUserDTO User { get; set; }
        public IBot Bot { get; set; }
        public string ChatColor { get; set; }
        public DateTime Timestamp { get; set; }
        public MessageType MessageType { get; set; }
    }
}