using MongoDB.Bson;
using MongoDB.Driver;
using mongodb_project.App.models;
using System;

namespace myPro.App
{
    class Program
    {

        //主程序入口
        static void Main(string[] args)
        {
            AccountInfo info = new AccountInfo()
            {
                Name = "二哈",
                FullName  = "Siberian Husky",
                NickName = "哈士奇",
            };

            //实例化一个mongoDB
            var dbClass = new DB();
               
            //获取到tabase表的user集合
            var collection = dbClass.GetOrCreateCollection<AccountInfo>(dbClass.GetOrCreateDatabase(dbClass.GetOrCreateDBClinet(), "tabase"), "userinfo");

            //集合里插入数据
            collection.InsertOne(info);

            
            //查询集合里的所有数据
            var t = collection.Find(o=>o.Name=="二哈").ToList();
            //所有的数据输出到控制台
            t.ForEach(o=>Console.WriteLine($"id:{o.Id}  fullname:{o.Name}  nickname:{o.NickName}"));
        }
    }
}
