﻿namespace Jewellery.Domain.DBModels
{
    public class AppToken
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Token { get; set; }
    }
}
