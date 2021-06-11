using System;
using System.Collections.Generic;

namespace Proje2
{
    class Board{
        public static List<Kart> ToDo;
        public static List<Kart> InProgress;
        public static List<Kart> Done;

        
        public Board()
        {
            ToDo = DefaultToDo();
            InProgress = DefaultInProgress();

        }

        public static List<Kart> DefaultToDo()
        {
            return new List<Kart>(){
                new Kart("Başlık : 1","İçerik : 1",1,Buyukluk.L),
                new Kart("Başlık : 2","İçerik : 2",2,Buyukluk.S),

            };
        }

        public static List<Kart> DefaultInProgress()
        {
            return new List<Kart>(){
                new Kart("Başlık : 3","İçerik : 3",3,Buyukluk.XL)

            };
        }
    }
}