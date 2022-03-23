using Microsoft.Extensions.Options;
using uas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using uas.Models;

namespace uas.Services
{
    public class EmailService
    {
        private readonly IOptions<Email> _dj; // => Dari Json
        public EmailService(IOptions<Email> dariJson)
        {
            _dj = dariJson;
        }

        public bool KirimEmail(string tujuan, string judulEmail, string isiEmail)
        {
            try
            {
                // dapatkan data dari appsetting.json
                // tampung di variable
                Email e = new Email();
                e.NamaClientnya = _dj.Value.NamaClientnya;
                e.Portnya = _dj.Value.Portnya;
                e.EmailKita = _dj.Value.EmailKita;
                e.PasswordEmailKita = _dj.Value.PasswordEmailKita;

                // atur email
                MailMessage m = new MailMessage();
                m.From = new MailAddress(e.EmailKita);
                m.Subject = judulEmail;
                m.Body = isiEmail;
                m.IsBodyHtml = true;
                m.To.Add(tujuan);

                // atur server
                SmtpClient s = new SmtpClient(e.NamaClientnya);
                s.Port = e.Portnya;
                s.Credentials = new System.Net.NetworkCredential(e.EmailKita, e.PasswordEmailKita);
                s.EnableSsl = true;
                s.Send(m);

                // kalo berhasil
                return true;
            }
            catch
            {
                // kalo gagal
                return false;
            }
        }
    }
}
