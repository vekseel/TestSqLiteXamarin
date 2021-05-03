using System;
using System.Collections.Generic;
using System.IO;
using SQLite;
using TestSqLiteApp.Entiyes;

namespace TestSqLiteApp.Repository
{
    public class FriendRepository
    {
        public const string DATABASE_NAME = "friends.db";
        SQLiteConnection database;
        public FriendRepository()
        {
            database = new SQLiteConnection(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
            database.CreateTable<Friend>();
        }
        public IEnumerable<Friend> GetItems()
        {
            return database.Table<Friend>().ToList();
        }
        public Friend GetItem(int id)
        {
            return database.Get<Friend>(id);
        }
        public int DeleteItem(int id)
        {
            return database.Delete<Friend>(id);
        }
        public int SaveItem(Friend item)
        {
            if (item.Id != 0)
            {
                database.Update(item);
                return item.Id;
            }
            else
            {
                return database.Insert(item);
            }
        }
    }
}