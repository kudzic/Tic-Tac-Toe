   M S B A M L   `   `   `  ????D  @TicTacToe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:TicTacToe	TicTacToe  5   	       TicTacToe.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:TicTacToe     5   	     ? Title$  
MainWindow??5   	   $	??500??6   $	??400??6)   .??5	      ? 
???   ?.+?5
   
   ?? $??29(?6   $??Center=?6   
???????.??6N   Tic Tac Toe6[   ? 5   
   $??50q?6    ? ColumnDefinitions 5      ?? 5      $??1* ?6#   ?? 5      $??1* ?6#   ?? 5      $??1* ?6#    ? RowDefinitions 5      ?? 5      $??1* ?6    ?? 5      $??1* ?6    ?? 5      $??1* ?6    ?? 5      $??1* ?6    ?? 5      $??1* ?6    .+?5      ?? -   5         ??Name$	 lb1??5      
???????$??5q?65   $??3q?6@   
???????$??40(?6?   $??Center=?6?   $??Center=?6?   ?? 5       -   5        $	 lb2??5       
???????$??5q?65   $??3q?6@   $??1??6T   $??0??6d   
???????$??40(?6?   $??Center=?6?   $??Center=?6?   ?? 5!      -   5        $	 lb3??5!      
???????$??5q?65   $??3q?6@   $??2??6T   $??0??6d   
???????$??40(?6?   $??Center=?6?   $??Center=?6?   ?? 5"      -   5        $	 lb4??5"      
???????$??5q?65   $??3q?6@   $??0??6T   $??1??6d   
???????$??40(?6?   $??Center=?6?   $??Center=?6?   ?? 5#      -   5        $	 lb5??5#      
???????$??5q?65   $??3q?6@   $??1??6T   $??1??6d   
???????$??40(?6?   $??Center=?6?   $??Center=?6?   ?? 5$      -   5        $	 lb6??5$      
???????$??5q?65   $??3q?6@   $??2??6T   $??1??6d   
???????$??40(?6?   $??Center=?6?   $??Center=?6?   ?? 5%      -   5        $	 lb7??5%      
???????$??5q?65   $??3q?6@   $??0??6T   $??2??6d   
???????$??40(?6?   $??Center=?6?   $??Center=?6?   ?? 5&      -   5        $	 lb8??5&      
???????$??5q?65   $??3q?6@   $??1??6T   $??2??6d   
???????$??40(?6?   $??Center=?6?   $??Center=?6?   ?? 5'      -	   5        $	 lb9??5'      
???????$??5q?65   $??3q?6@   $??2??6T   $??2??6d   
???????$??40(?6?   $??Center=?6?   $??Center=?6?   ?? 5(      -
   5        $??Reset??5(      $??3??6%   $??30(?62   6@   ?? 5)      $??Restart??6   $??3??6'   $??1??64   $??30(?6D   ?? 5*      -   5        $
??Quit??5*      $??3??6$   $??2??61   $??30(?6A   6O   ?? 5+      $??	Player X:??6   
???????$??20(?6;   $??4??6I   6X   ?? 5,      -   5        $ PlayerX??5,   !   $??0??6   
???????$??4??6F   $??Bottom=?6S   $??Center=?6u   $??20(?6?   6?   ?? 5-      $??Draw:??6   
???????$??20(?67   $??4??6E   $??1??6R   6d   ?? 5.      -   5        $ Draw1??5.       $??0??6   
???????$??4??6C   $??1??6P   $??Bottom=?6`   $??Center=?6?   $??20(?6?   6?   ?? 5/      $??	Player O:??6   
???????$??20(?6;   $??4??6I   $??2??6V   6h   ?? 50      -   5        $ PlayerO??50       $??0??6   
???????$??4??6E   $??2??6R   $??Bottom=?6b   $??Center=?6?   $??20(?6?   6?   52      54      55      