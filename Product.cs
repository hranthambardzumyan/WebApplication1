﻿namespace WebApplication1
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int FileId { get; set; }
        public File File { get; set; }
    }
}