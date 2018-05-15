using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EvilLyo.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        /// <summary>
        /// 数据库表名：picture，注意centos上core runtime表名大小写敏感
        /// </summary>
        public DbSet<Picture> picture { get; set; }

        /// <summary>
        /// 数据库表名：story，注意centos上core runtime表名大小写敏感
        /// </summary>
        public DbSet<Story> story { get; set; }

        /// <summary>
        /// 数据库表名：video，注意centos上core runtime表名大小写敏感
        /// </summary>
        public DbSet<Video> video { get; set; }
    }
}
