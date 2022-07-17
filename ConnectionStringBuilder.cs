/******************************************************************************
**  Copyright(c) 2022 ignackoo. All rights reserved.
**
**  Licensed under the MIT license.
**  See LICENSE file in the project root for full license information.
**
**  This file is a part of the C# Library ConnectionStringBuilder.
** 
**  Create or parse ConnectionString using ConnectionStringBuilder
**
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.Common;


namespace Library
{
    public class ConnectionStringBuilder : DbConnectionStringBuilder
    {
        /// <summary>
        /// Initializes a new instance of the ConnectionStringBuilder class.
        /// </summary>
        public ConnectionStringBuilder() : base() { }

        /// <summary>
        /// Initializes a new instance of the ConnectionStringBuilder class, optionally using ODBC rules for quoting values.
        /// </summary>
        /// <param name="useOdbcRules">true to use {} to delimit fields; false to use quotation marks.</param>
        public ConnectionStringBuilder(bool useOdbcRules) : base(useOdbcRules) { }


        /// <summary>
        /// Gets or sets a value that indicates whether the ConnectionString property is visible in Visual Studio designers.
        /// </summary>
        [System.ComponentModel.Browsable(false)]
        public new bool BrowsableConnectionString 
        {
            get { return (base.BrowsableConnectionString); }
            set { base.BrowsableConnectionString = value; }
        }

        /// <summary>
        /// Gets or sets the connection string associated with the ConnectionStringBuilder.
        /// </summary>
        public new string ConnectionString 
        {
            get { return (base.ConnectionString); }
            set { base.ConnectionString = value; }
        }

        /// <summary>
        /// Gets the current number of keys that are contained within the ConnectionString property.
        /// </summary>
        [System.ComponentModel.Browsable(false)]
        public new virtual int Count 
        {
            get { return (base.Count); }
        }

        /// <summary>
        /// Gets a value that indicates whether the ConnectionStringBuilder has a fixed size.
        /// </summary>
        [System.ComponentModel.Browsable(false)]
        public new virtual bool IsFixedSize 
        {
            get { return (base.IsFixedSize); }
        }

        /// <summary>
        /// Gets a value that indicates whether the ConnectionStringBuilder is read-only.
        /// </summary>
        [System.ComponentModel.Browsable(false)]
        public new bool IsReadOnly 
        {
            get { return (base.IsReadOnly); }
        }

        /// <summary>
        /// Gets or sets the value associated with the specified key.
        /// </summary>
        /// <param name="keyword">The key of the item to get or set.</param>
        /// <returns>The value associated with the specified key. If the specified key is not found, trying to get it returns a null reference (Nothing in Visual Basic), and trying to set it creates a new element using the specified key.
        ///          Passing a null (Nothing in Visual Basic) key throws an ArgumentNullException. Assigning a null value removes the key/value pair.</returns>
        [System.ComponentModel.Browsable(false)]
        public new virtual object this[string keyword] 
        {
            get 
            {
                try
                {
                    return (base[keyword]);
                }
                catch (Exception)
                {
                    return "";
                }
            }
            set { base[keyword] = value; }
        }

        /// <summary>
        /// Gets an ICollection that contains the keys in the ConnectionStringBuilder.
        /// </summary>
        [System.ComponentModel.Browsable(false)]
        public new virtual System.Collections.ICollection Keys 
        {
            get { return (base.Keys); }
        }

        /// <summary>
        /// Gets an ICollection that contains the values in the ConnectionStringBuilder.
        /// </summary>
        [System.ComponentModel.Browsable(false)]
        public new virtual System.Collections.ICollection Values 
        {
            get { return (base.Values); }
        }


        /// <summary>
        /// Adds an entry with the specified key and value into the ConnectionStringBuilder.
        /// </summary>
        /// <param name="keyword">The key to add to the ConnectionStringBuilder.</param>
        /// <param name="value">The value for the specified key.</param>
        public new void Add(string keyword, object value)
        {
            base.Add(keyword, value);
        }

        /// <summary>
        /// Provides an efficient and safe way to append a key and value to an existing StringBuilder object.
        /// </summary>
        /// <param name="builder">The StringBuilder to which to add the key/value pair.</param>
        /// <param name="keyword">The key to be added.</param>
        /// <param name="value">The value for the supplied key.</param>
        public new static void AppendKeyValuePair(System.Text.StringBuilder builder, string keyword, string value)
        {
            DbConnectionStringBuilder.AppendKeyValuePair(builder, keyword, value);
            return;
        }

        /// <summary>
        /// Clears the contents of the ConnectionStringBuilder instance.
        /// </summary>
        public new virtual void Clear()
        {
            base.Clear();
        }

        /// <summary>
        /// Clears the collection of PropertyDescriptor objects on the associated ConnectionStringBuilder.
        /// </summary>
        protected new internal void ClearPropertyDescriptors()
        {
            base.ClearPropertyDescriptors();
        }

        /// <summary>
        /// Determines whether the ConnectionStringBuilder contains a specific key.
        /// </summary>
        /// <param name="keyword">The key to locate in the ConnectionStringBuilder.</param>
        /// <returns>true if the ConnectionStringBuilder contains an entry with the specified key; otherwise false.</returns>
        public new virtual bool ContainsKey(string keyword)
        {
            return (base.ContainsKey(keyword));
        }

        /// <summary>
        /// Compares the connection information in this ConnectionStringBuilder object with the connection information in the supplied object.
        /// </summary>
        /// <param name="connectionStringBuilder">The ConnectionStringBuilder to be compared with this ConnectionStringBuilder object.</param>
        /// <returns>Returns true if the connection information in both of the ConnectionStringBuilder objects causes an equivalent connection string; otherwise false.</returns>
        public virtual bool EquivalentTo(ConnectionStringBuilder connectionStringBuilder)
        {
            return (base.EquivalentTo((System.Data.Common.DbConnectionStringBuilder)connectionStringBuilder));
        }

        /// <summary>
        /// Fills a supplied Hashtable with information about all the properties of this ConnectionStringBuilder.
        /// </summary>
        /// <param name="propertyDescriptors">The Hashtable to be filled with information about this ConnectionStringBuilder.</param>
        protected new virtual void GetProperties(System.Collections.Hashtable propertyDescriptors)
        {
            base.GetProperties(propertyDescriptors);
        }

        /// <summary>
        /// Removes the entry with the specified key from the ConnectionStringBuilder instance.
        /// </summary>
        /// <param name="keyword">The key of the key/value pair to be removed from the connection string in this ConnectionStringBuilder.</param>
        /// <returns>true if the key existed within the connection string and was removed; false if the key did not exist.</returns>
        public new virtual bool Remove(string keyword)
        {
            return (base.Remove(keyword));
        }

        /// <summary>
        /// Indicates whether the specified key exists in this ConnectionStringBuilder instance.
        /// </summary>
        /// <param name="keyword">The key to locate in the ConnectionStringBuilder.</param>
        /// <returns>true if the ConnectionStringBuilder contains an entry with the specified key; otherwise false.</returns>
        public new virtual bool ShouldSerialize(string keyword)
        {
            return (base.ShouldSerialize(keyword));
        }

        /// <summary>
        /// Returns the connection string associated with this ConnectionStringBuilder.
        /// </summary>
        /// <returns>The current ConnectionString property.</returns>
        public override string ToString()
        {
            return (base.ToString());
        }

        /// <summary>
        /// Retrieves a value corresponding to the supplied key from this ConnectionStringBuilder.
        /// </summary>
        /// <param name="keyword">The key of the item to retrieve.</param>
        /// <param name="value">The value corresponding to the keyword.</param>
        /// <returns>true if keyword was found within the connection string, false otherwise.</returns>
        public new virtual bool TryGetValue(string keyword, out object value)
        {
            return (base.TryGetValue(keyword, out value));
        }
    }
}
