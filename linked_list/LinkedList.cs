﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace linked_list
{
    public class LinkedList
    {
        public Node head;
        public void AddData(int data)
        {
            
            Node node = new Node(data);
            if (this.head == null)
            {

                this.head = node;
               // Console.WriteLine("head is" + this.head.data);
            }
            else {
               // Console.WriteLine("Head is " + this.head.data);
                Node temp=head;
                while (temp.next != null)
                {

                    temp = temp.next;

                   // Console.WriteLine("Temp.next is" + temp.data);



                }
                temp.next = node;
                ////
            }

           
    }
        
        public void display() {

            Node temp=this.head;
            while (temp!= null) {

                Console.WriteLine("The data are" + temp.data);
                temp = temp.next;

            }

        }
    }

  /*  public class addprevious
    {

        public Nodeprev tail;
        public Nodeprev temp2;

        public void AddData(int data)
        {
            Console.WriteLine("add previous");
            Nodeprev node = new Nodeprev(data);

            if (this.tail == null)
            {

                this.tail = node;
                // Console.WriteLine("head is" + this.head.data);
            }
            else
            {



                Nodeprev temp =null;
                temp.previous = tail;


                while (temp != null)
                {
                    temp = temp.previous;
                    Console.WriteLine("temp=" + temp.data + "temp.prev=" + temp.previous.data);

                }
                this.temp2 = temp;


            }




            //int total = temp.next.data + temp.data;
            //Console.WriteLine(total);
        }






        public void display()
        {

            Nodeprev temp = this.tail;
            while (temp != null)
            {

                Console.WriteLine("The data are" + temp.data);
                temp = temp.previous;

            }

        }

    }*/
}

