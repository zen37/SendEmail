// See https://aka.ms/new-console-template for more information
//using System.IO;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;

Console.WriteLine("Salut, Monde!");

Random ran = new Random();

int num = ran.Next(100000);


Console.WriteLine(num);

var email = new MimeMessage();
email.From.Add(MailboxAddress.Parse("...."));
email.To.Add(MailboxAddress.Parse("..."));
email.Subject = "email sent by C# console application";
email.Body = new TextPart(TextFormat.Html) { Text = "random number is: " + num };

using var smtp = new SmtpClient();
smtp.Connect("smtp.ethereal.email", 587, SecureSocketOptions.StartTls);
smtp.Authenticate("ozella15@ethereal.email", "CmXzdg8Yzv6qgXYwN8");
smtp.Send(email);
smtp.Disconnect(true);

//string to = "toaddress@gmail.com"; //To address    
//string from = "fromaddress@gmail.com"; //From address    
//MailMessage message = new MailMessage(from, to);

//string mailbody = "In this article you will learn how to send a email using Asp.Net & C#";
//message.Subject = "Sending Email Using Asp.Net & C#";
//message.Body = mailbody;
//message.BodyEncoding = Encoding.UTF8;
//message.IsBodyHtml = true;
//// SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Gmail smtp
//SmtpClient client = new SmtpClient("\tsmtp.live.com", 587); //	Outlook
//System.Net.NetworkCredential basicCredential1 = new
//System.Net.NetworkCredential("yourmail id", "Password");
//client.EnableSsl = true;
//client.UseDefaultCredentials = false;
//client.Credentials = basicCredential1;
//try
//{
//    client.Send(message);
//}

//catch (Exception ex)
//{
//    //    throw ex;
//    Console.WriteLine(ex);
//}

Console.WriteLine("Hello, World!");