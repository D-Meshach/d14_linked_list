using System;
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
                Console.WriteLine(temp.data + "->" + temp.next.data);
                int total = temp.next.data + temp.data;
                temp.added = total;
                Console.WriteLine(temp.added);
            }

           
    }
        
        public void display() {

            Node temp=this.head;
            Console.WriteLine("The data added sequentially are");
            while (temp!= null) {

                Console.WriteLine(" " + temp.data);
                
                temp = temp.next;

            }

        }
    }
    public class ListDetails {

        public ListDetails() {

            LinkedList ld = new LinkedList();
            ld.AddData(56);
            ld.AddData(30);
            ld.AddData(70);

            ld.display();
            Console.WriteLine("---------");
            /*addprevious ad = new addprevious();
            ad.AddData(23);
            ad.AddData(24);
            ad.AddData(25);
            ad.AddData(26);
            ad.display();*/

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

