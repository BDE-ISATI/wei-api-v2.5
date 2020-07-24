﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsatiWei.Api.Models
{
    public class Challenge
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        [BsonIgnore]
        public string Base64Image { get; set; } // This is only use to pass image over http
        public byte[] Image { get; set; }
        public int Value { get; set; }
        public int NumberOfRepetitions { get; set; }

        public bool IsForTeam { get; set; }
        public bool IsVisible { get; set; }
    }
}