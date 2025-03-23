using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_103022300066
{
    class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            if (string.IsNullOrEmpty(title))
                Console.WriteLine("Judul video tidak boleh kosong");

            Random random = new Random();
            this.id = random.Next(12345, 67890);

            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            if (count < 0)
                Console.WriteLine("Play count tidak boleh negatif");

            this.playCount += count;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Play Count: {playCount}");
        }
    }
}
