using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities
{
    internal class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post()
        {
        }

        public Post (DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        //Mesmo não tendo sido especificado no diagrama por padrão cria-se as funções de add e remove (somente em caso de regras de negócio essas funções não serão criadas).
        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }
        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        //Implementação da classe StringBuilder para melhor performace na criação de um ToString.
        public override string ToString()
        {
            //Criação e inicialização de um objeto do tipo StringBuilder.
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            //Formatando com uma máscara de formatação o DateTime.
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments: ");
            foreach(Comment c in Comments)
            {
                sb.AppendLine(c.Text);
            }
            return sb.ToString();
        }
    }
}
