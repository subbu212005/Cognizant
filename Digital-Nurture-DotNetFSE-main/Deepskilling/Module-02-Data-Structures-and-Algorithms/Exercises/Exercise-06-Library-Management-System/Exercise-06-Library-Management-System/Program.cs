using LibraryManagementSystem;
Book[] books={new(1,"Algorithms","Cormen"),new(2,"C Programming","Dennis Ritchie"),new(3,"Data Structures","Seymour Lipschutz"),new(4,"Operating Systems","Galvin")};
Book? Linear(Book[] a,string t){foreach(var b in a) if(b.Title.Equals(t,StringComparison.OrdinalIgnoreCase)) return b; return null;}
Book? Binary(Book[] a,string t){int l=0,h=a.Length-1;while(l<=h){int m=(l+h)/2;int c=string.Compare(a[m].Title,t,true);if(c==0)return a[m];if(c<0)l=m+1;else h=m-1;}return null;}
Array.Sort(books,(x,y)=>string.Compare(x.Title,y.Title,true));
Console.WriteLine("Linear Search:");Console.WriteLine(Linear(books,"Data Structures"));
Console.WriteLine("\nBinary Search:");Console.WriteLine(Binary(books,"Operating Systems"));