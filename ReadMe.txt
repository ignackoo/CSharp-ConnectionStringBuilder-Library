ConnectionStringBuilder wrapper class implementation

Allow build or parse connection strings

Examples of use

Example 1 ...

	Library.ConnectionStringBuilder csb = new Library.ConnectionStringBuilder();
	csb.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\mydatabase.mdb;User Id=admin;Password=;";

	Console.WriteLine("Provider {0}", csb["Provider"]);
	Console.WriteLine("Data Source {0}", csb["Data Source"]);
	Console.WriteLine("User Id {0}", csb["User Id"]);
	Console.WriteLine("Password {0}", csb["Password"]);
	Console.WriteLine();

Example 2 ...

    	Library.ConnectionStringBuilder csb2 = new Library.ConnectionStringBuilder();
    	csb2["One"] = "1";
    	csb2["Two"] = "2";
    	csb2["Three"] = "3";
    	csb2.Add("Four", 4);
    	csb2.Remove("Four");

    	Console.WriteLine("Connection String {0}", csb2.ConnectionString);
	Console.WriteLine();

please give me some star if you will see that the library is useful, thank you
