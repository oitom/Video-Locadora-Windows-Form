using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace video_locadora
{
    public class Usuario
    {
        private string Login;
        private string Senha;
    
        public Usuario(string LOGIN, string SENHA)
        {
            Login = LOGIN;
            Senha = SENHA;
        }        

        public string CriptoSenha(string Senha)
        {
            //Gerando criptografia da senha
            MD5 md5 = MD5.Create();


            byte[] vetorByte = System.Text.Encoding.ASCII.GetBytes(Senha);
            byte[] hash = md5.ComputeHash(vetorByte);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString());
            }

            return sb.ToString();
        }
    }
}
