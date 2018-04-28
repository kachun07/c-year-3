using System.Collections.Generic;
using System.Linq;
using System.Web;

using Microsoft.WindowsAzure.StorageClient;
using System.Data.Services;
using System.Data.Services.Client;
using System;

namespace WebRole1
{
    public class Album : TableServiceEntity
    {
        public Album(string partitionKey, string rowKey)
            : base(partitionKey, rowKey)
        {
        }
        public Album()
            : base()
        {
            PartitionKey = Guid.NewGuid().ToString();
            RowKey = String.Empty;
        }
        public int id
        {
            get;
            set;
        }
        public string name
        {
            get;
            set;
        }
        public string artist
        {
            get;
            set;
        }
        public int year
        {
            get;
            set;
        }
        public string seller
        {
            get;
            set;
        }
        public int startPrice
        {
            get;
            set;
        }
        public int bid
        {
            get;
            set;
        }
        public string bidder
        {
            get;
            set;
        }
        public string genre
        {
            get;
            set;
        }
        public string formatType
        {
            get;
            set;
        }
        public string status
        {
            get;
            set;
        }
    }
    class ProductDataServiceContext : TableServiceContext
    {
        internal ProductDataServiceContext(string baseAddress,
                          Microsoft.WindowsAzure.StorageCredentials credentials)
            : base(baseAddress, credentials)
        {
        }
        internal const string ProductTableName = "ProductTable2";
        public IQueryable<Album> Albums
        {
            get
            {
                return this.CreateQuery<Album>(ProductTableName);
            }
        }
    }

}
