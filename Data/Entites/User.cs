﻿namespace FirstRelation.Data.Entites
{
    public class User
    {
        public int Id { get; set; }

        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public ICollection<Post> Posts { get; set; }

    }
}
