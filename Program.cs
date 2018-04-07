using System;
using System.Collections.Generic;
namespace AdminPageFinder
{
	class main
	{
		public static bool Check(string website, string page)
		{
			Console.Write("Checking "+page+" in "+website);
			try
			{
				string check = new System.Net.WebClient().DownloadString(website+page);
				return true;
			}
			catch
			{
				return false;
			}
		}
		public static bool CheckPrint(string website, string page)
		{
			Console.Write("Checking "+page+" in "+website);
			try
			{
				string check = new System.Net.WebClient().DownloadString(website+page);
				Console.ForegroundColor=ConsoleColor.Green;
				Console.WriteLine("");
				Console.WriteLine(check);
				Console.ForegroundColor=ConsoleColor.Red;
				return true;
			}
			catch
			{
				return false;
			}
		}
		public static void Main(string[] args)
		{
			Console.Title="AdminPageFinder by Kip";
			Console.ForegroundColor=ConsoleColor.Red;
			Console.WriteLine("AdminPageFinder by Kip");
			Console.Write("Website: "); string ws=Console.ReadLine();
			
			Console.WriteLine("Checking website...");
			if (!ws.Contains("http")) {Console.WriteLine("No protocol, adding http.");ws="http://"+ws;}
			if (!ws.Contains(".")) {Console.WriteLine("No dots. Adding \".com\".");ws=ws+".com/";}
			Console.WriteLine("Checking protection...");
			
			if (Check(ws, "a_page_that_does_not_exists"))
			{
				Console.WriteLine("");
				Console.WriteLine("!!!!!!!!!!!!!!!!!!! WEBSITE HAS PROTECTION !!!!!!!!!!!!!!!!!!!");
				while(true){}
			}
			else
			{
				Console.WriteLine("");
				Console.WriteLine("!!!!!!! No protection !!!!!!!");
			}
			
			if (Check(ws, "admins.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admin1.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admin1.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admin2.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admin2.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "yonetim.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "yonetim.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "yonetici.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "yonetici.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "adm/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admin/account.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admin/account.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admin/index.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admin/index.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admin/login.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admin/login.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admin/home.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admin/controlpanel.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admin/controlpanel.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admin.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admin.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admin/cp.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admin/cp.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "cp.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "cp.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "administrator/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "administrator/index.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "administrator/index.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "administrator/login.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "administrator/login.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "administrator/account.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "administrator/account.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "administrator.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "administrator.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "login.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "login.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "modelsearch/login.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "moderator.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "moderator.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "moderator/login.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "moderator/login.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "moderator/admin.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "moderator/admin.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "moderator/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "account.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "account.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "controlpanel/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "controlpanel.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "controlpanel.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admincontrol.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admincontrol.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "adminpanel.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "adminpanel.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admin1.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admin2.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "yonetim.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "yonetici.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admin/account.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admin/index.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admin/login.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admin/home.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admin/controlpanel.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admin.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admin/cp.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "cp.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "administrator/index.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "administrator/login.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "administrator/account.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "administrator.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "login.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "modelsearch/login.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "moderator.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "moderator/login.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "moderator/admin.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "account.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "controlpanel.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admincontrol.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "adminpanel.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "fileadmin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "fileadmin.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "fileadmin.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "fileadmin.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "administration/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "administration.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "administration.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "sysadmin.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "sysadmin.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "phpmyadmin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "myadmin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "sysadmin.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "sysadmin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "ur-admin.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "ur-admin.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "ur-admin.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "ur-admin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "Server.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "Server.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "Server.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "Server/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "wp-admin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "administr8.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "administr8.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "administr8/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "administr8.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "webadmin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "webadmin.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "webadmin.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "webadmin.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "administratie/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admins/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admins.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admins.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admins.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "administrivia/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "Database_Administration/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "WebAdmin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "useradmin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "sysadmins/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admin1/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "system-administration/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "administrators/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "pgadmin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "directadmin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "staradmin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "ServerAdministrator/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "SysAdmin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "administer/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "LiveUser_Admin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "sys-admin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "typo3/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "panel/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "cpanel/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "cPanel/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "cpanel_file/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "platz_login/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "rcLogin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "blogindex/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "formslogin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "autologin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "support_login/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "meta_login/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "manuallogin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "simpleLogin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "loginflat/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "utility_login/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "showlogin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "memlogin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "members/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "login-redirect/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "sub-login/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "wp-login/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "login1/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "dir-login/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "login_db/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "xlogin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "smblogin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "customer_login/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "UserLogin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "login-us/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "acct_login/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admin_area/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "bigadmin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "project-admins/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "phppgadmin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "pureadmin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "sql-admin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "radmind/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "openvpnadmin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "wizmysqladmin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "vadmind/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "ezsqliteadmin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "hpwebjetadmin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "newsadmin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "adminpro/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "Lotus_Domino_Admin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "bbadmin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "vmailadmin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "Indy_admin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "ccp14admin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "irc-macadmin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "banneradmin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "sshadmin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "phpldapadmin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "macadmin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "administratoraccounts/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admin4_account/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admin4_colon/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "radmind-1/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "Super-Admin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "AdminTools/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "cmsadmin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "SysAdmin2/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "globes_admin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "cadmins/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "phpSQLiteAdmin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "navSiteAdmin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "server_admin_small/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "logo_sysadmin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "server/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "database_administration/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "power_user/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "system_administration/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "ss_vms_admin_sm/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admeen/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admeen.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "login_here/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "login_here.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			Console.WriteLine("SEARCHING FOR ADMIN TEXT FILES");
			if (CheckPrint(ws, "admins.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admin1.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admin1.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admin2.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admin2.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "yonetim.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "yonetim.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "yonetici.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "yonetici.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "adm.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admin/account.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admin/account.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admin/index.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admin/index.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admin/login.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admin/login.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admin/home.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admin/controlpanel.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admin/controlpanel.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admin/cp.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admin/cp.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "cp.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "cp.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "administrator.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "administrator/index.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "administrator/index.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "administrator/login.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "administrator/login.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "administrator/account.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "administrator/account.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "administrator.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "administrator.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "login.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "login.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "modelsearch/login.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "moderator.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "moderator.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "moderator/login.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "moderator/login.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "moderator/admin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "moderator/admin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "moderator.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "account.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "account.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "controlpanel.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "controlpanel.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "controlpanel.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admincontrol.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admincontrol.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "adminpanel.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "adminpanel.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admin1.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admin2.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "yonetim.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "yonetici.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admin/account.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admin/index.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admin/login.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admin.txthome.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admin/controlpanel.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admin/cp.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "cp.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "administrator/index.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "administrator/login.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "administrator/account.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "administrator.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "login.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "modelsearch/login.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "moderator.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "moderator/login.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "moderator/admin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "account.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "controlpanel.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admincontrol.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "adminpanel.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "fileadmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "fileadmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "fileadmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "fileadmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "administration.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "administration.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "administration.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "sysadmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "sysadmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "phpmyadmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "myadmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "sysadmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "sysadmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "ur-admin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "ur-admin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "ur-admin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "ur-admin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "Server.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "Server.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "Server.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "Server.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "wp-admin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "administr8.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "administr8.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "administr8.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "administr8.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "webadmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "webadmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "webadmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "webadmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "administratie.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admins.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admins.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admins.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admins.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "administrivia.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "Database_Administration.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "WebAdmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "useradmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "sysadmins.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admin1.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "system-administration.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "administrators.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "pgadmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "directadmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "staradmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "ServerAdministrator.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "SysAdmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "administer.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "LiveUser_Admin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "sys-admin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "typo3.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "panel.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "cpanel.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "cPanel.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "cpanel_file.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "platz_login.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "rcLogin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "blogindex.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "formslogin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "autologin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "support_login.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "meta_login.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "manuallogin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "simpleLogin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "loginflat.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "utility_login.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "showlogin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "memlogin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "members.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "login-redirect.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "sub-login.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "wp-login.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "login1.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "dir-login.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "login_db.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "xlogin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "smblogin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "customer_login.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "UserLogin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "login-us.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "acct_login.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admin_area.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "bigadmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "project-admins.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "phppgadmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "pureadmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "sql-admin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "radmind.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "openvpnadmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "wizmysqladmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "vadmind.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "ezsqliteadmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "hpwebjetadmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "newsadmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "adminpro.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "Lotus_Domino_Admin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "bbadmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "vmailadmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "Indy_admin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "ccp14admin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "irc-macadmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "banneradmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "sshadmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "phpldapadmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "macadmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "administratoraccounts.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admin4_account.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admin4_colon.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "radmind-1.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "Super-Admin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "AdminTools.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "cmsadmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "SysAdmin2.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "globes_admin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "cadmins.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "phpSQLiteAdmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "navSiteAdmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "server_admin_small.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "logo_sysadmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "server.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "database_administration.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "power_user.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "system_administration.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "ss_vms_admin_sm.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admeen.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admeen.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "login_here.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "login_here.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "robots.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			Console.WriteLine("SEARCHING FOR BACKDIRS");
			ws=ws+"../../";
			if (Check(ws, "admins.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admin1.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admin1.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admin2.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admin2.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "yonetim.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "yonetim.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "yonetici.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "yonetici.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "adm/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admin/account.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admin/account.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admin/index.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admin/index.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admin/login.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admin/login.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admin/home.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admin/controlpanel.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admin/controlpanel.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admin.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admin.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admin/cp.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admin/cp.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "cp.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "cp.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "administrator/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "administrator/index.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "administrator/index.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "administrator/login.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "administrator/login.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "administrator/account.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "administrator/account.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "administrator.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "administrator.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "login.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "login.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "modelsearch/login.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "moderator.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "moderator.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "moderator/login.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "moderator/login.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "moderator/admin.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "moderator/admin.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "moderator/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "account.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "account.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "controlpanel/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "controlpanel.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "controlpanel.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admincontrol.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admincontrol.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "adminpanel.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "adminpanel.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admin1.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admin2.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "yonetim.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "yonetici.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admin/account.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admin/index.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admin/login.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admin/home.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admin/controlpanel.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admin.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admin/cp.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "cp.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "administrator/index.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "administrator/login.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "administrator/account.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "administrator.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "login.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "modelsearch/login.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "moderator.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "moderator/login.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "moderator/admin.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "account.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "controlpanel.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admincontrol.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "adminpanel.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "fileadmin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "fileadmin.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "fileadmin.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "fileadmin.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "administration/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "administration.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "administration.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "sysadmin.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "sysadmin.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "phpmyadmin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "myadmin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "sysadmin.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "sysadmin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "ur-admin.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "ur-admin.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "ur-admin.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "ur-admin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "Server.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "Server.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "Server.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "Server/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "wp-admin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "administr8.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "administr8.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "administr8/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "administr8.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "webadmin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "webadmin.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "webadmin.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "webadmin.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "administratie/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admins/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admins.php")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admins.asp")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admins.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "administrivia/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "Database_Administration/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "WebAdmin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "useradmin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "sysadmins/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admin1/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "system-administration/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "administrators/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "pgadmin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "directadmin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "staradmin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "ServerAdministrator/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "SysAdmin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "administer/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "LiveUser_Admin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "sys-admin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "typo3/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "panel/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "cpanel/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "cPanel/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "cpanel_file/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "platz_login/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "rcLogin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "blogindex/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "formslogin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "autologin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "support_login/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "meta_login/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "manuallogin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "simpleLogin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "loginflat/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "utility_login/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "showlogin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "memlogin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "members/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "login-redirect/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "sub-login/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "wp-login/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "login1/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "dir-login/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "login_db/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "xlogin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "smblogin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "customer_login/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "UserLogin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "login-us/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "acct_login/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admin_area/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "bigadmin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "project-admins/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "phppgadmin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "pureadmin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "sql-admin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "radmind/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "openvpnadmin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "wizmysqladmin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "vadmind/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "ezsqliteadmin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "hpwebjetadmin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "newsadmin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "adminpro/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "Lotus_Domino_Admin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "bbadmin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "vmailadmin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "Indy_admin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "ccp14admin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "irc-macadmin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "banneradmin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "sshadmin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "phpldapadmin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "macadmin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "administratoraccounts/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admin4_account/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admin4_colon/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "radmind-1/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "Super-Admin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "AdminTools/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "cmsadmin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "SysAdmin2/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "globes_admin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "cadmins/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "phpSQLiteAdmin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "navSiteAdmin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "server_admin_small/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "logo_sysadmin/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "server/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "database_administration/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "power_user/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "system_administration/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "ss_vms_admin_sm/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admeen/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "admeen.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "login_here/")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (Check(ws, "login_here.html")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			Console.WriteLine("SEARCHING FOR ADMIN TEXT FILES IN BACK DIRS");
			if (CheckPrint(ws, "admins.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admin1.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admin1.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admin2.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admin2.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "yonetim.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "yonetim.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "yonetici.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "yonetici.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "adm.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admin/account.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admin/account.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admin/index.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admin/index.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admin/login.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admin/login.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admin/home.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admin/controlpanel.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admin/controlpanel.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admin/cp.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admin/cp.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "cp.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "cp.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "administrator.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "administrator/index.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "administrator/index.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "administrator/login.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "administrator/login.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "administrator/account.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "administrator/account.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "administrator.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "administrator.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "login.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "login.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "modelsearch/login.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "moderator.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "moderator.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "moderator/login.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "moderator/login.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "moderator/admin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "moderator/admin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "moderator.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "account.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "account.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "controlpanel.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "controlpanel.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "controlpanel.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admincontrol.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admincontrol.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "adminpanel.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "adminpanel.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admin1.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admin2.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "yonetim.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "yonetici.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admin/account.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admin/index.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admin/login.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admin/home.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admin/controlpanel.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admin/cp.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "cp.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "administrator/index.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "administrator/login.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "administrator/account.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "administrator.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "login.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "modelsearch/login.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "moderator.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "moderator/login.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "moderator/admin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "account.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "controlpanel.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admincontrol.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "adminpanel.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "fileadmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "fileadmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "fileadmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "fileadmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "administration.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "administration.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "administration.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "sysadmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "sysadmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "phpmyadmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "myadmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "sysadmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "sysadmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "ur-admin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "ur-admin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "ur-admin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "ur-admin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "Server.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "Server.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "Server.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "Server.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "wp-admin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "administr8.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "administr8.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "administr8.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "administr8.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "webadmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "webadmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "webadmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "webadmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "administratie.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admins.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admins.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admins.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admins.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "administrivia.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "Database_Administration.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "WebAdmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "useradmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "sysadmins.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admin1.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "system-administration.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "administrators.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "pgadmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "directadmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "staradmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "ServerAdministrator.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "SysAdmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "administer.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "LiveUser_Admin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "sys-admin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "typo3.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "panel.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "cpanel.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "cPanel.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "cpanel_file.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "platz_login.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "rcLogin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "blogindex.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "formslogin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "autologin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "support_login.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "meta_login.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "manuallogin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "simpleLogin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "loginflat.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "utility_login.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "showlogin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "memlogin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "members.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "login-redirect.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "sub-login.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "wp-login.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "login1.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "dir-login.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "login_db.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "xlogin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "smblogin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "customer_login.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "UserLogin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "login-us.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "acct_login.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admin_area.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "bigadmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "project-admins.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "phppgadmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "pureadmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "sql-admin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "radmind.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "openvpnadmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "wizmysqladmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "vadmind.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "ezsqliteadmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "hpwebjetadmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "newsadmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "adminpro.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "Lotus_Domino_Admin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "bbadmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "vmailadmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "Indy_admin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "ccp14admin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "irc-macadmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "banneradmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "sshadmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "phpldapadmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "macadmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "administratoraccounts.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admin4_account.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admin4_colon.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "radmind-1.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "Super-Admin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "AdminTools.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "cmsadmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "SysAdmin2.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "globes_admin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "cadmins.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "phpSQLiteAdmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "navSiteAdmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "server_admin_small.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "logo_sysadmin.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "server.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "database_administration.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "power_user.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "system_administration.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "ss_vms_admin_sm.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admeen.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "admeen.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "login_here.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "login_here.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			if (CheckPrint(ws, "robots.txt")) {Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine(" -- FOUND * * * * * * * * * * *"); Console.ForegroundColor=ConsoleColor.Red;}
			else Console.WriteLine(" -- NOT FOUND");
			Console.WriteLine("Scan done! This tool is made by Kip");
			Console.WriteLine("Thanks for using it.");
			Console.ReadKey(true);
		}
	}
}
